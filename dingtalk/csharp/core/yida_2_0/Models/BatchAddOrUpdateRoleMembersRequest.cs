// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0.Models
{
    public class BatchAddOrUpdateRoleMembersRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingxxxx</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;memberId&quot;:&quot;5014533041684xx&quot;,&quot;manageScopes&quot;:&quot;8360866xx,430181xx,429821xx&quot;},{&quot;memberId&quot;:&quot;014329103xx&quot;,&quot;manageScopes&quot;:&quot;all&quot;}]</para>
        /// </summary>
        [NameInMap("membersInfo")]
        [Validation(Required=false)]
        public string MembersInfo { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ROLE-71dc7859-17df-490d-a93d-eb5506e31f42</para>
        /// </summary>
        [NameInMap("roleUuid")]
        [Validation(Required=false)]
        public string RoleUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>501453</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
