using System.Collections.Generic;
using Kompas6API5;
using Kompas6Constants;

namespace HandleApp
{
    /// <summary>
    /// Класс создания спецификации
    /// </summary>
    public class SpecificationCreator
    {
        /// <summary>
        /// Указатель на интерфейс API Компас
        /// </summary>
        private KompasObject _kompas;

        /// <summary>
        /// Указатель интерфейса штампа спецификации
        /// </summary>
        private ksStamp _stamp;

        /// <summary>
        /// Указатель на интерфейс параметров
        /// </summary>
        private ksTextItemParam _textItemParam;

        private ksSpcDocument _documentSpc;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="kompas">Указатель на интерфейс Компас</param>
        public SpecificationCreator(KompasObject kompas)
        {
            _kompas = kompas;
        }

        /// <summary>
        /// Главный метод создания спецификации
        /// </summary>
        /// <param name="specParameters">Параметры спецификации</param>
        public void CreateSpec
            (List<string> specParameters)
        {
            SetSpecification(specParameters[0], specParameters[1], specParameters[2],
                specParameters[3], specParameters[4], specParameters[5]);
            SetStamp(specParameters[6], specParameters[7], specParameters[8], specParameters[9]);
        }

        /// <summary>
        /// Метод заполнения документации
        /// </summary>
        /// <param name="docDesignation">Обозначение документа</param>
        /// <param name="docName">Название документа</param>
        /// <param name="detailDesignation">Обозначение детали</param>
        /// <param name="detailName">Название детали</param>
        /// <param name="detailCount">Количество деталей</param>
        /// <param name="gostNumber">Номер госта</param>
        private void SetSpecification(string docDesignation, 
            string docName, string detailDesignation, string detailName, 
            string detailCount, string gostNumber)
        {
            _documentSpc = (ksSpcDocument)_kompas.SpcDocument();
            var documentParam = (ksDocumentParam)_kompas.GetParamStruct
                ((short)StructType2DEnum.ko_DocumentParam);
            documentParam.type = 4;
            var sheetParam = (ksSheetPar)documentParam.GetLayoutParam();
            sheetParam.Init();
            _documentSpc.ksCreateDocument(documentParam);
            var spec = (ksSpecification)_documentSpc.GetSpecification();

            spec.ksSpcObjectCreate("GRAPHIC.LYT", 1, 5, 0, 0, 0);
            spec.ksSetSpcObjectColumnText(4, 1, 0, docDesignation); 
            spec.ksSetSpcObjectColumnText(5, 1, 0, docName); 
            spec.ksSpcObjectEnd();

            spec.ksSpcObjectCreate("GRAPHIC.LYT", 1, 20, 0, 0, 1);
            spec.ksSetSpcObjectColumnText(4, 1, 0, detailDesignation); 
            spec.ksSetSpcObjectColumnText(5, 1, 0, detailName); 
            spec.ksSetSpcObjectColumnText(6, 1, 0, detailCount); 
            spec.ksSpcObjectEnd();

            spec.ksSpcObjectCreate("GRAPHIC.LYT", 1, 20, 0, 0, 1);
            spec.ksSetSpcObjectColumnText(5, 1, 0, "ГОСТ " + gostNumber); 
            spec.ksSpcObjectEnd();
        }

        /// <summary>
        /// Метод заполнения штампа
        /// </summary>
        /// <param name="stampName">Название штампа</param>
        /// <param name="stampDesignation">Обозначение штампа</param>
        /// <param name="developer">Разработчик</param>
        /// <param name="teacher">Преподаватель</param>
        private void SetStamp(string stampName, 
            string stampDesignation, string developer, string teacher)
        {
            _stamp = (ksStamp)_documentSpc.GetStamp();
            _textItemParam =
                (ksTextItemParam)_kompas.GetParamStruct
                    ((short)StructType2DEnum.ko_TextItemParam);

            _stamp.ksOpenStamp();
            SetStampCell(1, stampName);
            SetStampCell(2, stampDesignation);
            SetStampCell(110, developer);
            SetStampCell(111, teacher);
            _stamp.ksCloseStamp();
        }

        /// <summary>
        /// Метод заполнения отдельной ячейки
        /// </summary>
        /// <param name="cellId">ID ячейки</param>
        /// <param name="cellValue">Значение ячейки</param>
        public void SetStampCell(int cellId, string cellValue)
        {
            _stamp.ksColumnNumber(cellId);
            _textItemParam.s = cellValue;
            _stamp.ksTextLine(_textItemParam);
        }
    }
}
