// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class UpdateRoleRequest : TeaModel {
        [NameInMap("flowType")]
        [Validation(Required=false)]
        public string FlowType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("roleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("subRoles")]
        [Validation(Required=false)]
        public List<UpdateRoleRequestSubRoles> SubRoles { get; set; }
        public class UpdateRoleRequestSubRoles : TeaModel {
            [NameInMap("authLevel")]
            [Validation(Required=false)]
            public int? AuthLevel { get; set; }

            [NameInMap("bizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

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
