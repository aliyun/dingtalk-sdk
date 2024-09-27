// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class AddContactMemberToGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>不裂变：STANDARD；裂变：FISSION</para>
        /// </summary>
        [NameInMap("fissionType")]
        [Validation(Required=false)]
        public string FissionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>888</para>
        /// </summary>
        [NameInMap("memberUnionId")]
        [Validation(Required=false)]
        public string MemberUnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("memberUserId")]
        [Validation(Required=false)]
        public string MemberUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cid***</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>888</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

    }

}
