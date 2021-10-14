/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmanufacturing_1_0.Models
{
    public class IndustrializeManufactureJobBookRequest : TeaModel {
        /// <summary>
        /// 钉钉组织id
        /// </summary>
        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        /// <summary>
        /// 扩展字段，用于增加自定义字段
        /// </summary>
        [NameInMap("extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// 工单编号
        /// </summary>
        [NameInMap("instNo")]
        [Validation(Required=false)]
        public string InstNo { get; set; }

        /// <summary>
        /// 是否是批量报工(取值[n,y])
        /// </summary>
        [NameInMap("isBatchJob")]
        [Validation(Required=false)]
        public string IsBatchJob { get; set; }

        /// <summary>
        /// 生产日期时间(到时分秒)
        /// </summary>
        [NameInMap("manufactureDate")]
        [Validation(Required=false)]
        public string ManufactureDate { get; set; }

        /// <summary>
        /// mes 系统唯一标识
        /// </summary>
        [NameInMap("mesAppKey")]
        [Validation(Required=false)]
        public string MesAppKey { get; set; }

        /// <summary>
        /// 制程英文名称
        /// </summary>
        [NameInMap("processEnName")]
        [Validation(Required=false)]
        public string ProcessEnName { get; set; }

        /// <summary>
        /// 制程名称
        /// </summary>
        [NameInMap("processName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// 产品唯一标识
        /// </summary>
        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品英文名称
        /// </summary>
        [NameInMap("productEnName")]
        [Validation(Required=false)]
        public string ProductEnName { get; set; }

        /// <summary>
        /// 产品名称，例如"双头螺柱001"
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
        /// 合格数量
        /// </summary>
        [NameInMap("qualifiedQuantity")]
        [Validation(Required=false)]
        public string QualifiedQuantity { get; set; }

        /// <summary>
        /// 可重工数量
        /// </summary>
        [NameInMap("reworkableQuantity")]
        [Validation(Required=false)]
        public string ReworkableQuantity { get; set; }

        /// <summary>
        /// 报废数量
        /// </summary>
        [NameInMap("scrappedQuantity")]
        [Validation(Required=false)]
        public string ScrappedQuantity { get; set; }

        /// <summary>
        /// 计件单价，单位：分
        /// </summary>
        [NameInMap("unitPrice")]
        [Validation(Required=false)]
        public string UnitPrice { get; set; }

        /// <summary>
        /// 批量报工时多个工人userId以英文逗号分隔
        /// </summary>
        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public string UserIdList { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// 批量报工时多个人名以英文逗号分隔
        /// </summary>
        [NameInMap("userNameList")]
        [Validation(Required=false)]
        public string UserNameList { get; set; }

        /// <summary>
        /// 随机串，唯一标识(用于幂等及更新)
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
