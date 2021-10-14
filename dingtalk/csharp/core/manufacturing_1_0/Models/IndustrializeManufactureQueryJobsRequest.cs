// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmanufacturing_1_0.Models
{
    public class IndustrializeManufactureQueryJobsRequest : TeaModel {
        /// <summary>
        /// 当前页序号(从1开始)
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// 工单编号
        /// </summary>
        [NameInMap("instNo")]
        [Validation(Required=false)]
        public string InstNo { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        [NameInMap("manufactureDay")]
        [Validation(Required=false)]
        public string ManufactureDay { get; set; }

        /// <summary>
        /// MES系统唯一标识
        /// </summary>
        [NameInMap("mesAppKey")]
        [Validation(Required=false)]
        public string MesAppKey { get; set; }

        /// <summary>
        /// 每页显示记录条数
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 产品唯一标识
        /// </summary>
        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品中文名称
        /// </summary>
        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// 产品规格
        /// </summary>
        [NameInMap("productSpecification")]
        [Validation(Required=false)]
        public string ProductSpecification { get; set; }

        /// <summary>
        /// 报工合格数量
        /// </summary>
        [NameInMap("qualifiedQuantity")]
        [Validation(Required=false)]
        public string QualifiedQuantity { get; set; }

        /// <summary>
        /// 计件单价，单位：分
        /// </summary>
        [NameInMap("unitPrice")]
        [Validation(Required=false)]
        public string UnitPrice { get; set; }

        /// <summary>
        /// 员工钉钉userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// 报工记录的唯一标识
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
