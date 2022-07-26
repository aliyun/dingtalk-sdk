// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesProductionPlanRequest : TeaModel {
        /// <summary>
        /// 本次操作的行为
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// actualEndTime
        /// </summary>
        [NameInMap("actualEndTime")]
        [Validation(Required=false)]
        public string ActualEndTime { get; set; }

        /// <summary>
        /// actualStartTime
        /// </summary>
        [NameInMap("actualStartTime")]
        [Validation(Required=false)]
        public string ActualStartTime { get; set; }

        /// <summary>
        /// 生态唯一标识,枚举:opsoft， 需要注册
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// 主数据名称
        /// </summary>
        [NameInMap("baseDataName")]
        [Validation(Required=false)]
        public string BaseDataName { get; set; }

        /// <summary>
        /// BOM业务唯一标识
        /// </summary>
        [NameInMap("bomUuid")]
        [Validation(Required=false)]
        public string BomUuid { get; set; }

        /// <summary>
        /// 事件列表
        /// </summary>
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [NameInMap("extendData")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesProductionPlanRequestExtendData> ExtendData { get; set; }
        public class IndustryManufactureMesProductionPlanRequestExtendData : TeaModel {
            /// <summary>
            /// 字段唯一标识(英文)
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 字段中文描述
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 当时取值(活的)
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// 字段类型
            /// </summary>
            [NameInMap("valueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        /// <summary>
        /// 工单编号(生产订单号)
        /// </summary>
        [NameInMap("no")]
        [Validation(Required=false)]
        public string No { get; set; }

        /// <summary>
        /// 任务逾期
        /// </summary>
        [NameInMap("overdue")]
        [Validation(Required=false)]
        public string Overdue { get; set; }

        /// <summary>
        /// 计划结束时间
        /// </summary>
        [NameInMap("planEndTime")]
        [Validation(Required=false)]
        public string PlanEndTime { get; set; }

        /// <summary>
        /// 工单计划数
        /// </summary>
        [NameInMap("planQuantity")]
        [Validation(Required=false)]
        public string PlanQuantity { get; set; }

        /// <summary>
        /// 计划开始时间
        /// </summary>
        [NameInMap("planStartTime")]
        [Validation(Required=false)]
        public string PlanStartTime { get; set; }

        /// <summary>
        /// 工序列表(有序) 主体
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
        /// 最后一道工序完成数量
        /// </summary>
        [NameInMap("qualifiedQuantity")]
        [Validation(Required=false)]
        public string QualifiedQuantity { get; set; }

        /// <summary>
        /// 销售订单
        /// </summary>
        [NameInMap("sellOrderNo")]
        [Validation(Required=false)]
        public string SellOrderNo { get; set; }

        /// <summary>
        /// 工单状态
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 班组信息(有序)
        /// </summary>
        [NameInMap("teamList")]
        [Validation(Required=false)]
        public string TeamList { get; set; }

        /// <summary>
        /// 工单标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 工单类型,["NORMAL"(普通),"返工","样品"],默认"NORMAL"
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

        /// <summary>
        /// 工单实例的唯一Id
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
