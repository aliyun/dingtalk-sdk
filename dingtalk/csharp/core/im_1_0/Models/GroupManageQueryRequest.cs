// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GroupManageQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1652183395772</para>
        /// </summary>
        [NameInMap("createdAfter")]
        [Validation(Required=false)]
        public long? CreatedAfter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>53364321</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("groupMemberSamples")]
        [Validation(Required=false)]
        public List<string> GroupMemberSamples { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4122134</para>
        /// </summary>
        [NameInMap("groupOwner")]
        [Validation(Required=false)]
        public string GroupOwner { get; set; }

        [NameInMap("groupTitleKeywords")]
        [Validation(Required=false)]
        public List<string> GroupTitleKeywords { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://h5.dingtalk.com/circle/healthCheckin.html?dtaction=os&corpId=ding91766asjkldhfkjklasdjkfjkhajksdjkfhjkla811&5fd5e=db2ed&cbdbhh=qwertyuiop">https://h5.dingtalk.com/circle/healthCheckin.html?dtaction=os&amp;corpId=ding91766asjkldhfkjklasdjkfjkhajksdjkfhjkla811&amp;5fd5e=db2ed&amp;cbdbhh=qwertyuiop</a></para>
        /// </summary>
        [NameInMap("groupUrl")]
        [Validation(Required=false)]
        public string GroupUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("membersOver")]
        [Validation(Required=false)]
        public int? MembersOver { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cidnvcxzklxv23jhkg412hj==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

    }

}
