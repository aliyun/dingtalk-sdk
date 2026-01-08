// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class RebuildRoleMembersRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("defaultRoleDTO")]
        [Validation(Required=false)]
        public RebuildRoleMembersRequestDefaultRoleDTO DefaultRoleDTO { get; set; }
        public class RebuildRoleMembersRequestDefaultRoleDTO : TeaModel {
            [NameInMap("mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            [NameInMap("roleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("toRoleMemberDTOMap")]
        [Validation(Required=false)]
        public Dictionary<string, List<ToRoleMemberDTOMapValue>> ToRoleMemberDTOMap { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
