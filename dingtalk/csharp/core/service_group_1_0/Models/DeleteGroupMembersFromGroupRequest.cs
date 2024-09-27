// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class DeleteGroupMembersFromGroupRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GROUP：从群中删除；GROUP_SET：从群组中删除</para>
        /// </summary>
        [NameInMap("deleteGroupType")]
        [Validation(Required=false)]
        public string DeleteGroupType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8888</para>
        /// </summary>
        [NameInMap("memberUnionId")]
        [Validation(Required=false)]
        public string MemberUnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cid**</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8888</para>
        /// </summary>
        [NameInMap("openGroupSetId")]
        [Validation(Required=false)]
        public string OpenGroupSetId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8888</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

    }

}
