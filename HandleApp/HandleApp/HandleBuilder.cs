using Kompas6API5;
using Kompas6Constants3D;

namespace HandleApp
{
    public class HandleBuilder
    {
        private KompasObject _kompas;

        public HandleBuilder(KompasObject kompas)
        {
            this._kompas = kompas;
        }

        public void CreateDetail(HandleParameters parameters)
        {
            //СОЗДАНИЕ НОВОЙ ДЕТАЛИ
            if (_kompas != null)
            {
                var document3D = (ksDocument3D)_kompas.Document3D(); //получение указателя на интерфейс документа 3D модели

                document3D.Create(false, true); //создание детали, где false - значит видимое редактирование документа true - деталь а не сборка
            }

            //ПАРАМЕТРЫ
            var backRadius = parameters.BackDiameter * 5;
            var backLenght = parameters.BackLenght * 10;
            var frontLenght = parameters.FrontLenght * 10;
            var holeRadius = parameters.HoleDiameter / 0.2;
            var notchCount = parameters.NotchCount;

            //СОЗДАНИЕ САМОЙ РУЧКИ
            var doc3D = (ksDocument3D)_kompas.ActiveDocument3D(); //получение указателя на интерфейс ТЕКУЩЕГО документа 3D модели

            var part = (ksPart)doc3D.GetPart((short)Part_Type.pTop_Part); //интерфейс детали

            //эскиз стандарт. плоскостиZOY 
            var entitySketch = (ksEntity)part.NewEntity((short)Obj3dType.o3d_sketch); //интерфейс элемнта детали - эскиз

            var sketchDefinition = (ksSketchDefinition)entitySketch.GetDefinition(); //интерфейс параметров эскиза

            var plane = (ksEntity)part.GetDefaultEntity((short)Obj3dType.o3d_planeYOZ); //выбираем плоскость ZOY

            sketchDefinition.SetPlane(plane);   // установим выбранную плоскость для эскиза
            entitySketch.Create(); // создаем эскиз

            var sketchEdit = (ksDocument2D)sketchDefinition.BeginEdit(); //интерфейс редактора эскиза

            sketchEdit.ksLineSeg(-backLenght + 3, -holeRadius, -backLenght, -holeRadius - 4, 1);
            sketchEdit.ksLineSeg(-backLenght, -holeRadius - 4, -backLenght, -backRadius, 1);
            sketchEdit.ksLineSeg(-backLenght, -backRadius, 0, -backRadius, 1);
            sketchEdit.ksLineSeg(0, -backRadius, 0, -20, 1); //25
            sketchEdit.ksLineSeg(0, -20, 6.5, -30, 1);//25
            sketchEdit.ksLineSeg(6.5, -30, frontLenght - 6.5, -30, 1);
            sketchEdit.ksLineSeg(frontLenght - 6.5, -30, frontLenght, -20, 1);
            sketchEdit.ksLineSeg(frontLenght, -20, frontLenght, -holeRadius - 4, 1);
            sketchEdit.ksLineSeg(frontLenght, -holeRadius - 4, frontLenght - 3, -holeRadius, 1);
            sketchEdit.ksLineSeg(frontLenght - 3, -holeRadius, -backLenght + 3, -holeRadius, 1);
            sketchEdit.ksLineSeg(-45, 0, 45, 0, 3); //осевая линия
            sketchDefinition.EndEdit();	// завершение редактирования эскиза

            //выдавливание вращением
            var entityRotated = (ksEntity)part.NewEntity((short)Obj3dType.o3d_baseRotated);
            var entityRotatedDefinition = (ksBaseRotatedDefinition)entityRotated.GetDefinition();

            entityRotatedDefinition.directionType = 0;
            entityRotatedDefinition.SetSideParam(true, 360);
            entityRotatedDefinition.SetSketch(entitySketch);
            entityRotated.Create();

            //плоскостьXOY для вырезов
            entitySketch = (ksEntity)part.NewEntity((short)Obj3dType.o3d_sketch);
            plane = (ksEntity)part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY); //выбираем плоскость XOY

            sketchDefinition = (ksSketchDefinition)entitySketch.GetDefinition();
            sketchDefinition.SetPlane(plane);
            entitySketch.Create();

            sketchEdit = (ksDocument2D)sketchDefinition.BeginEdit(); //интерфейс редактора эскиза
            sketchEdit.ksCircle(0, 40, 19, 1);
            sketchDefinition.EndEdit(); // завершение редактирования эскиза

            //выдавливание выреза
            var entityCutExtrusion = (ksEntity)part.NewEntity((short)Obj3dType.o3d_cutExtrusion); //интерфейс элемнта детали - вращение

            var cutExtrusionDefinition = (ksCutExtrusionDefinition)entityCutExtrusion.GetDefinition(); //интерфейс параметров вращения

            cutExtrusionDefinition.cut = true;
            cutExtrusionDefinition.directionType = (short)Direction_Type.dtNormal;
            cutExtrusionDefinition.SetSideParam(true, 0, frontLenght + backLenght);
            cutExtrusionDefinition.SetSketch(entitySketch);
            entityCutExtrusion.Create();

            //концентрическая сетка
            var entityCircularCopy = (ksEntity)part.NewEntity((short)Obj3dType.o3d_circularCopy);

            var circCopyDefinition = (ksCircularCopyDefinition)entityCircularCopy.GetDefinition();

            var baseAxisOZ = (ksEntity)part.GetDefaultEntity((short)Obj3dType.o3d_axisOZ);

            var entityCollectionCircle = (ksEntityCollection)circCopyDefinition.GetOperationArray();

            circCopyDefinition.SetCopyParamAlongDir(notchCount, 360, true, false);
            circCopyDefinition.SetAxis(baseAxisOZ); //Устанавливаем ось OZ
            entityCollectionCircle.Add(cutExtrusionDefinition);
            entityCircularCopy.Create();
        }
    }
}
