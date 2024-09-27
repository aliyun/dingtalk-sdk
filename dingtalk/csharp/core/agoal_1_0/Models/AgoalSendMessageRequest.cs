// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class AgoalSendMessageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://agoal.dingtalk.com">https://agoal.dingtalk.com</a></para>
        /// </summary>
        [NameInMap("mobileUrl")]
        [Validation(Required=false)]
        public string MobileUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;A&quot;:&quot;a&quot;, &quot;B&quot;:&quot;b&quot;}</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://agoal.dingtalk.com">https://agoal.dingtalk.com</a></para>
        /// </summary>
        [NameInMap("pcUrl")]
        [Validation(Required=false)]
        public string PcUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>211042291978xxxx</para>
        /// </summary>
        [NameInMap("sourceDingUserId")]
        [Validation(Required=false)]
        public string SourceDingUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("targetDingUserIds")]
        [Validation(Required=false)]
        public List<string> TargetDingUserIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d01a14febc7482ca3b6e1d30cf5xxxx</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
