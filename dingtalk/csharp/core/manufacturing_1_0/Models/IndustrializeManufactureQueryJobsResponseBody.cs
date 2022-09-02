// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmanufacturing_1_0.Models
{
    public class IndustrializeManufactureQueryJobsResponseBody : TeaModel {
        /// <summary>
        /// 查询的数据结果
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public IndustrializeManufactureQueryJobsResponseBodyContent Content { get; set; }
        public class IndustrializeManufactureQueryJobsResponseBodyContent : TeaModel {
            /// <summary>
            /// 组织id
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// 数据库id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 工单id
            /// </summary>
            [NameInMap("instNo")]
            [Validation(Required=false)]
            public string InstNo { get; set; }

            /// <summary>
            /// 是否是批量报工，即一次报工由多个工人一起分担，取值[n,y],y表示是批量，批量时多个人名以英文逗号分隔
            /// </summary>
            [NameInMap("isBatchJob")]
            [Validation(Required=false)]
            public string IsBatchJob { get; set; }

            /// <summary>
            /// 生产日期时间(到时分秒),格式:2021-07-05 08:00:21
            /// </summary>
            [NameInMap("manufactureDate")]
            [Validation(Required=false)]
            public string ManufactureDate { get; set; }

            /// <summary>
            /// 生产日期(到天)
            /// </summary>
            [NameInMap("manufactureDay")]
            [Validation(Required=false)]
            public string ManufactureDay { get; set; }

            /// <summary>
            /// 分配给mes系统的appkey
            /// </summary>
            [NameInMap("mesAppKey")]
            [Validation(Required=false)]
            public string MesAppKey { get; set; }

            /// <summary>
            /// 工序名称
            /// </summary>
            [NameInMap("processName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// 合格数
            /// </summary>
            [NameInMap("qualifiedQuantity")]
            [Validation(Required=false)]
            public string QualifiedQuantity { get; set; }

            /// <summary>
            /// 不合格数
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
            /// 工人工号(isBatchJob=='n'时)
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 批量报工时多个人钉钉工号以英文逗号分隔
            /// </summary>
            [NameInMap("userIdList")]
            [Validation(Required=false)]
            public string UserIdList { get; set; }

            /// <summary>
            /// 批量报工时多个人名以英文逗号分隔
            /// </summary>
            [NameInMap("userNameList")]
            [Validation(Required=false)]
            public string UserNameList { get; set; }

            /// <summary>
            /// 报工记录的唯一标识
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// httpCode
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

    }

}
