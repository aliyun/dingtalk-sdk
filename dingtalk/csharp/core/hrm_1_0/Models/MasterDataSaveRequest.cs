// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDataSaveRequest : TeaModel {
        /// <summary>
        /// 主数据
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<MasterDataSaveRequestBody> Body { get; set; }
        public class MasterDataSaveRequestBody : TeaModel {
            /// <summary>
            /// 员工id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 数据流水唯一标识，如流水号，用以唯一确认一条写入数据
            /// </summary>
            [NameInMap("bizUk")]
            [Validation(Required=false)]
            public string BizUk { get; set; }

            /// <summary>
            /// 数据变更时间戳，用以保证更新操作的顺序性
            /// </summary>
            [NameInMap("bizTime")]
            [Validation(Required=false)]
            public long? BizTime { get; set; }

            /// <summary>
            /// 业务域描述，系统分配
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public MasterDataSaveRequestBodyScope Scope { get; set; }
            public class MasterDataSaveRequestBodyScope : TeaModel {
                [NameInMap("scopeCode")]
                [Validation(Required=false)]
                public string ScopeCode { get; set; }
                [NameInMap("version")]
                [Validation(Required=false)]
                public int? Version { get; set; }
            };

            /// <summary>
            /// 业务域下的细分领域实体
            /// </summary>
            [NameInMap("entityCode")]
            [Validation(Required=false)]
            public string EntityCode { get; set; }

            /// <summary>
            /// 数据字段列表
            /// </summary>
            [NameInMap("fieldList")]
            [Validation(Required=false)]
            public List<MasterDataSaveRequestBodyFieldList> FieldList { get; set; }
            public class MasterDataSaveRequestBodyFieldList : TeaModel {
                /// <summary>
                /// 字段名
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 字段string值
                /// </summary>
                [NameInMap("valueStr")]
                [Validation(Required=false)]
                public string ValueStr { get; set; }

            }

        }

        /// <summary>
        /// 租户id
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}
