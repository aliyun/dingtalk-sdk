// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesOutPlanRequest : TeaModel {
        /// <summary>
        /// 审批状态
        /// </summary>
        [NameInMap("approvalStatus")]
        [Validation(Required=false)]
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// 审批人
        /// </summary>
        [NameInMap("approver")]
        [Validation(Required=false)]
        public string Approver { get; set; }

        /// <summary>
        /// 主数据名称
        /// </summary>
        [NameInMap("baseDataName")]
        [Validation(Required=false)]
        public string BaseDataName { get; set; }

        /// <summary>
        /// 委外计划单号
        /// </summary>
        [NameInMap("outSourceProjectCode")]
        [Validation(Required=false)]
        public string OutSourceProjectCode { get; set; }

        /// <summary>
        /// 委外群
        /// </summary>
        [NameInMap("outSourceTeamId")]
        [Validation(Required=false)]
        public string OutSourceTeamId { get; set; }

        /// <summary>
        /// 单价（元）
        /// </summary>
        [NameInMap("price")]
        [Validation(Required=false)]
        public string Price { get; set; }

        /// <summary>
        /// 工序识别码
        /// </summary>
        [NameInMap("processIdentificationCode")]
        [Validation(Required=false)]
        public string ProcessIdentificationCode { get; set; }

        /// <summary>
        /// 委外的工序列表(多个)
        /// </summary>
        [NameInMap("processUuids")]
        [Validation(Required=false)]
        public string ProcessUuids { get; set; }

        /// <summary>
        /// 产品代码(物料编号)
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
        /// 规格型号
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
        /// 工单(生产计划单)ID
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 委外计划数
        /// </summary>
        [NameInMap("sendPlanQuantity")]
        [Validation(Required=false)]
        public string SendPlanQuantity { get; set; }

        /// <summary>
        /// 供应商代码
        /// </summary>
        [NameInMap("supplierCode")]
        [Validation(Required=false)]
        public string SupplierCode { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        [NameInMap("supplierName")]
        [Validation(Required=false)]
        public string SupplierName { get; set; }

        /// <summary>
        /// 金额（元）
        /// </summary>
        [NameInMap("totalWage")]
        [Validation(Required=false)]
        public string TotalWage { get; set; }

        /// <summary>
        /// 记录唯一标识
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
