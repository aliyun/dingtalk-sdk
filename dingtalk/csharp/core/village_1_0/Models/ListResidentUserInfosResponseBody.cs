// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListResidentUserInfosResponseBody : TeaModel {
        /// <summary>
        /// result
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListResidentUserInfosResponseBodyResult> Result { get; set; }
        public class ListResidentUserInfosResponseBodyResult : TeaModel {
            /// <summary>
            /// 员工id
            /// </summary>
            [NameInMap("userid")]
            [Validation(Required=false)]
            public string Userid { get; set; }

            /// <summary>
            /// 员工名字
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 标签列表
            /// </summary>
            [NameInMap("roles")]
            [Validation(Required=false)]
            public List<ListResidentUserInfosResponseBodyResultRoles> Roles { get; set; }
            public class ListResidentUserInfosResponseBodyResultRoles : TeaModel {
                /// <summary>
                /// 标签id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// 标签名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 标签名称 tagCode
                /// </summary>
                [NameInMap("tagCode")]
                [Validation(Required=false)]
                public string TagCode { get; set; }

            }

            /// <summary>
            /// 员工特征
            /// </summary>
            [NameInMap("feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }

            /// <summary>
            /// 钉钉唯一标识
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

    }

}
