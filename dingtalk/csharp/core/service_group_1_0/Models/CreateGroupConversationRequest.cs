// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class CreateGroupConversationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dingadc88253b4d581bd35c2f4657eb6378f</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fsfsfadfasfdasdfsaf</para>
        /// </summary>
        [NameInMap("dingGroupId")]
        [Validation(Required=false)]
        public string DingGroupId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>57675657</para>
        /// </summary>
        [NameInMap("dingUserId")]
        [Validation(Required=false)]
        public string DingUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("dingUserName")]
        [Validation(Required=false)]
        public string DingUserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;isServerInitiative&quot;:&quot;true&quot;}</para>
        /// </summary>
        [NameInMap("extValues")]
        [Validation(Required=false)]
        public string ExtValues { get; set; }

        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3434</para>
        /// </summary>
        [NameInMap("serverGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

    }

}
