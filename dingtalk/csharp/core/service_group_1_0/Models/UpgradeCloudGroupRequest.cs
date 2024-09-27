// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class UpgradeCloudGroupRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sdfdfser</para>
        /// </summary>
        [NameInMap("ccsInstanceId")]
        [Validation(Required=false)]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cidrQnTVXH/X+ERaVqGaH+asw==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oPnDlfVYYIUia</para>
        /// </summary>
        [NameInMap("openGroupSetId")]
        [Validation(Required=false)]
        public string OpenGroupSetId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>btkoYsadwyQiE</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
