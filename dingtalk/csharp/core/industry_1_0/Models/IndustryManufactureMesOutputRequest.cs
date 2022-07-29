// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesOutputRequest : TeaModel {
        /// <summary>
        /// 本次操作的行为
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// 生态唯一标识, 需要注册
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// 审批状态
        /// </summary>
        [NameInMap("approveStatus")]
        [Validation(Required=false)]
        public string ApproveStatus { get; set; }

        /// <summary>
        /// 主数据名称
        /// </summary>
        [NameInMap("baseDataName")]
        [Validation(Required=false)]
        public string BaseDataName { get; set; }

        /// <summary>
        /// 不良品总数(多次报工)
        /// </summary>
        [NameInMap("defectsAmount")]
        [Validation(Required=false)]
        public string DefectsAmount { get; set; }

        /// <summary>
        /// 不良品原因
        /// </summary>
        [NameInMap("defectsReason")]
        [Validation(Required=false)]
        public string DefectsReason { get; set; }

        /// <summary>
        /// 良品总数(多次报工)
        /// </summary>
        [NameInMap("fineAmount")]
        [Validation(Required=false)]
        public string FineAmount { get; set; }

        /// <summary>
        /// 是否已质检
        /// </summary>
        [NameInMap("hasQualityTest")]
        [Validation(Required=false)]
        public string HasQualityTest { get; set; }

        /// <summary>
        /// 任务逾期
        /// </summary>
        [NameInMap("overdue")]
        [Validation(Required=false)]
        public int? Overdue { get; set; }

        /// <summary>
        /// 派工(总)数
        /// </summary>
        [NameInMap("planQuantity")]
        [Validation(Required=false)]
        public long? PlanQuantity { get; set; }

        /// <summary>
        /// 是否加急
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// 工序名称
        /// </summary>
        [NameInMap("processName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// 工序业务唯一标识
        /// </summary>
        [NameInMap("processUuid")]
        [Validation(Required=false)]
        public string ProcessUuid { get; set; }

        /// <summary>
        /// 产品编号(物料编号)
        /// </summary>
        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// 产品(物料)规格
        /// </summary>
        [NameInMap("productSpecification")]
        [Validation(Required=false)]
        public string ProductSpecification { get; set; }

        /// <summary>
        /// 工单编号(生产任务单)
        /// </summary>
        [NameInMap("projectCode")]
        [Validation(Required=false)]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 工单(生产计划单)
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 工单状态
        /// </summary>
        [NameInMap("projectStatus")]
        [Validation(Required=false)]
        public string ProjectStatus { get; set; }

        /// <summary>
        /// 检验状态
        /// </summary>
        [NameInMap("qualityTestStatus")]
        [Validation(Required=false)]
        public string QualityTestStatus { get; set; }

        /// <summary>
        /// 任务计划结束(完成)时间
        /// </summary>
        [NameInMap("taskPlanEndTime")]
        [Validation(Required=false)]
        public string TaskPlanEndTime { get; set; }

        /// <summary>
        /// 任务计划开始时间
        /// </summary>
        [NameInMap("taskPlanStartTime")]
        [Validation(Required=false)]
        public string TaskPlanStartTime { get; set; }

        /// <summary>
        /// 派工任务状态
        /// </summary>
        [NameInMap("taskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 报工类型(正常,委外)
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// 派工任务唯一标识
        /// </summary>
        [NameInMap("taskUuid")]
        [Validation(Required=false)]
        public string TaskUuid { get; set; }

        /// <summary>
        /// 负责班组id
        /// </summary>
        [NameInMap("teamId")]
        [Validation(Required=false)]
        public string TeamId { get; set; }

        /// <summary>
        /// 报工人staffNo(生产人员)
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 派工人名称
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// 本次记录唯一标识
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
