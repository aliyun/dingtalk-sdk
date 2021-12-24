// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class JoinGroupSetRequest : TeaModel {
        /// <summary>
        /// 关系模型数据。
        /// </summary>
        [NameInMap("bizDataList")]
        [Validation(Required=false)]
        public List<JoinGroupSetRequestBizDataList> BizDataList { get; set; }
        public class JoinGroupSetRequestBizDataList : TeaModel {
            /// <summary>
            /// 关系模型数据字段扩展值。
            /// </summary>
            [NameInMap("extendValue")]
            [Validation(Required=false)]
            public string ExtendValue { get; set; }

            /// <summary>
            /// 关系模型数据字段名。
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// 关系模型数据字段值。
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// 群组openGroupSetId。
        /// </summary>
        [NameInMap("openGroupSetId")]
        [Validation(Required=false)]
        public string OpenGroupSetId { get; set; }

        /// <summary>
        /// unionId。
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
