// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesProductionPlanRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("actualEndTime")]
        [Validation(Required=false)]
        public string ActualEndTime { get; set; }

        [NameInMap("actualStartTime")]
        [Validation(Required=false)]
        public string ActualStartTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("baseDataName")]
        [Validation(Required=false)]
        public string BaseDataName { get; set; }

        [NameInMap("bomUuid")]
        [Validation(Required=false)]
        public string BomUuid { get; set; }

        [NameInMap("events")]
        [Validation(Required=false)]
        public List<string> Events { get; set; }

        [NameInMap("extendData")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesProductionPlanRequestExtendData> ExtendData { get; set; }
        public class IndustryManufactureMesProductionPlanRequestExtendData : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("valueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        [NameInMap("no")]
        [Validation(Required=false)]
        public string No { get; set; }

        [NameInMap("overdue")]
        [Validation(Required=false)]
        public string Overdue { get; set; }

        [NameInMap("planEndTime")]
        [Validation(Required=false)]
        public string PlanEndTime { get; set; }

        [NameInMap("planQuantity")]
        [Validation(Required=false)]
        public string PlanQuantity { get; set; }

        [NameInMap("planStartTime")]
        [Validation(Required=false)]
        public string PlanStartTime { get; set; }

        [NameInMap("processUuids")]
        [Validation(Required=false)]
        public string ProcessUuids { get; set; }

        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("productSpecification")]
        [Validation(Required=false)]
        public string ProductSpecification { get; set; }

        [NameInMap("qualifiedQuantity")]
        [Validation(Required=false)]
        public string QualifiedQuantity { get; set; }

        [NameInMap("sellOrderNo")]
        [Validation(Required=false)]
        public string SellOrderNo { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("teamList")]
        [Validation(Required=false)]
        public string TeamList { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
