using Kompas6API5;
using Kompas6Constants3D;

namespace HandleApp
{
    /// <summary>
    /// Класс построения детали Ручка
    /// </summary>
    public class HandleBuilder
    {
        /// <summary>
        /// Указатель на интерфейс API Компас
        /// </summary>
        private KompasObject _kompas;

        /// <summary>
        /// Указатель на интерфейс документа-модели
        /// </summary>
        private ksDocument3D _doc3D;

        /// <summary>
        /// Указатель на интерфейс компонента
        /// </summary>
        private ksPart _part;

        /// <summary>
        /// Указатель на интерфейс сущности
        /// </summary>
        private ksEntity _entitySketch;

        /// <summary>
        /// Указатель на интерфейс параметров плоскости
        /// </summary>
        private ksSketchDefinition _sketchDefinition;

        /// <summary>
        /// Указатель на интерфейс графического документа
        /// </summary>
        private ksDocument2D _sketchEdit;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="kompas">Интерфейс API КОМПАС</param>
        public HandleBuilder(KompasObject kompas)
        {
            _kompas = kompas;
        }

        /// <summary>
        /// Главнй метод построения детали
        /// </summary>
        /// <param name="parameters">Входные параметры детали</param>
        public void CreateDetail(HandleParameters parameters)
        {
            if (_kompas != null)
            {
                _doc3D = (ksDocument3D)_kompas.Document3D();
                _doc3D.Create(false, true); 
            }

            var backRadius = parameters.BackDiameter * 5;
            var backLenght = parameters.BackLenght * 10;
            var frontLenght = parameters.FrontLenght * 10;
            var holeRadius = parameters.HoleDiameter * 5;
            var notchCount = parameters.NotchCount;

            _doc3D = (ksDocument3D)_kompas.ActiveDocument3D(); 
            _part = (ksPart)_doc3D.GetPart((short)Part_Type.pTop_Part);

            CreateMainSketch(backRadius, backLenght, frontLenght, holeRadius);

            RotateSketch();

            CreateNotchSketch();

            ExtrudeSketch(frontLenght, backLenght, notchCount);
        }

        /// <summary>
        /// Метод, создающий осовной эскиз самой ручки
        /// </summary>
        /// <param name="backRadius">Радиус задней части руки</param>
        /// <param name="backLenght">Длина задней части ручки</param>
        /// <param name="frontLenght">Длина передней части ручки</param>
        /// <param name="holeRadius">Радиус тверстия ручки</param>
        private void CreateMainSketch
            (double backRadius, double backLenght, double frontLenght, double holeRadius)
        {
            CreateEntitySketch((short)Obj3dType.o3d_planeYOZ);

            _sketchEdit = (ksDocument2D)_sketchDefinition.BeginEdit(); 

            _sketchEdit.ksLineSeg
                (-backLenght + 3, -holeRadius, -backLenght, -holeRadius - 4, 1);
            _sketchEdit.ksLineSeg
                (-backLenght, -holeRadius - 4, -backLenght, -backRadius, 1);
            _sketchEdit.ksLineSeg
                (-backLenght, -backRadius, 0, -backRadius, 1);
            _sketchEdit.ksLineSeg
                (0, -backRadius, 0, -20, 1); 
            _sketchEdit.ksLineSeg
                (0, -20, 6.5, -30, 1);
            _sketchEdit.ksLineSeg
                (6.5, -30, frontLenght - 6.5, -30, 1);
            _sketchEdit.ksLineSeg
                (frontLenght - 6.5, -30, frontLenght, -20, 1);
            _sketchEdit.ksLineSeg
                (frontLenght, -20, frontLenght, -holeRadius - 4, 1);
            _sketchEdit.ksLineSeg
                (frontLenght, -holeRadius - 4, frontLenght - 3, -holeRadius, 1);
            _sketchEdit.ksLineSeg
                (frontLenght - 3, -holeRadius, -backLenght + 3, -holeRadius, 1);
            _sketchEdit.ksLineSeg
                (-45, 0, 45, 0, 3); 
            _sketchDefinition.EndEdit();	
        }

        /// <summary>
        /// Метод для выдавливания вращением осовного эскиза
        /// </summary>
        private void RotateSketch()
        {
            var entityRotated = 
                (ksEntity)_part.NewEntity((short)Obj3dType.o3d_baseRotated);
            var entityRotatedDefinition = 
                (ksBaseRotatedDefinition)entityRotated.GetDefinition();

            entityRotatedDefinition.directionType = 0;
            entityRotatedDefinition.SetSideParam(true, 360);
            entityRotatedDefinition.SetSketch(_entitySketch);
            entityRotated.Create();
        }

        /// <summary>
        /// Метод, создающий эскиз вырезов на передней части ручки
        /// </summary>
        private void CreateNotchSketch()
        {
            CreateEntitySketch((short)Obj3dType.o3d_planeXOY);

            _sketchEdit = (ksDocument2D)_sketchDefinition.BeginEdit();
            _sketchEdit.ksCircle(0, 40, 19, 1);
            _sketchDefinition.EndEdit(); 
        }

        /// <summary>
        /// Метод, выдавливающий эскизы вырезов
        /// </summary>
        /// <param name="frontLenght">Длина передней части ручки</param>
        /// <param name="backLenght">Длина задней части ручки</param>
        /// <param name="notchCount">Количество вырезов на ручке</param>
        private void ExtrudeSketch
            (double frontLenght, double backLenght, int notchCount)
        {
            var entityCutExtrusion = 
                (ksEntity)_part.NewEntity((short)Obj3dType.o3d_cutExtrusion); 

            var cutExtrusionDefinition = 
                (ksCutExtrusionDefinition)entityCutExtrusion.GetDefinition(); 

            cutExtrusionDefinition.cut = true;
            cutExtrusionDefinition.directionType = (short)Direction_Type.dtNormal;
            cutExtrusionDefinition.SetSideParam(true, 0, frontLenght + backLenght);
            cutExtrusionDefinition.SetSketch(_entitySketch);
            entityCutExtrusion.Create();

            var entityCircularCopy = 
                (ksEntity)_part.NewEntity((short)Obj3dType.o3d_circularCopy);

            var circCopyDefinition = 
                (ksCircularCopyDefinition)entityCircularCopy.GetDefinition();

            var baseAxisOZ = 
                (ksEntity)_part.GetDefaultEntity((short)Obj3dType.o3d_axisOZ);

            var entityCollectionCircle = 
                (ksEntityCollection)circCopyDefinition.GetOperationArray();

            circCopyDefinition.SetCopyParamAlongDir(notchCount, 360, true, false);
            circCopyDefinition.SetAxis(baseAxisOZ); 
            entityCollectionCircle.Add(cutExtrusionDefinition);
            entityCircularCopy.Create();
        }

        /// <summary>
        /// Второстепенный метод, создающий новый эскиз
        /// </summary>
        /// <param name="plane">Плоскость, выбраная в качестве эскиза</param>
        private void CreateEntitySketch(short plane)
        {
            var currentPlane = (ksEntity)_part.GetDefaultEntity(plane); 

            _entitySketch = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_sketch); 
            _sketchDefinition = (ksSketchDefinition)_entitySketch.GetDefinition(); 
            _sketchDefinition.SetPlane(currentPlane);   
            _entitySketch.Create(); 
        }
    }
}
