// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesOutputRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("approveStatus")]
        [Validation(Required=false)]
        public string ApproveStatus { get; set; }

        [NameInMap("baseDataName")]
        [Validation(Required=false)]
        public string BaseDataName { get; set; }

        [NameInMap("defectsAmount")]
        [Validation(Required=false)]
        public string DefectsAmount { get; set; }

        [NameInMap("defectsReason")]
        [Validation(Required=false)]
        public string DefectsReason { get; set; }

        [NameInMap("fineAmount")]
        [Validation(Required=false)]
        public string FineAmount { get; set; }

        [NameInMap("hasQualityTest")]
        [Validation(Required=false)]
        public string HasQualityTest { get; set; }

        [NameInMap("overdue")]
        [Validation(Required=false)]
        public int? Overdue { get; set; }

        [NameInMap("planQuantity")]
        [Validation(Required=false)]
        public long? PlanQuantity { get; set; }

        [NameInMap("priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("processName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        [NameInMap("processUuid")]
        [Validation(Required=false)]
        public string ProcessUuid { get; set; }

        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("productSpecification")]
        [Validation(Required=false)]
        public string ProductSpecification { get; set; }

        [NameInMap("projectCode")]
        [Validation(Required=false)]
        public string ProjectCode { get; set; }

        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("projectStatus")]
        [Validation(Required=false)]
        public string ProjectStatus { get; set; }

        [NameInMap("qualityTestStatus")]
        [Validation(Required=false)]
        public string QualityTestStatus { get; set; }

        [NameInMap("taskPlanEndTime")]
        [Validation(Required=false)]
        public string TaskPlanEndTime { get; set; }

        [NameInMap("taskPlanStartTime")]
        [Validation(Required=false)]
        public string TaskPlanStartTime { get; set; }

        [NameInMap("taskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("taskUuid")]
        [Validation(Required=false)]
        public string TaskUuid { get; set; }

        [NameInMap("teamId")]
        [Validation(Required=false)]
        public string TeamId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
