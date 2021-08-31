// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class GetResidentUserInfoResponseBody : TeaModel {
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
        public List<GetResidentUserInfoResponseBodyRoles> Roles { get; set; }
        public class GetResidentUserInfoResponseBodyRoles : TeaModel {
            /// <summary>
            /// 标签id
            /// </summary>
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            /// <summary>
            /// 标签名称
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

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
