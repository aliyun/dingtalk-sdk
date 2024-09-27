// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class SendRobotMessageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("atAll")]
        [Validation(Required=false)]
        public bool? AtAll { get; set; }

        [NameInMap("atAppUids")]
        [Validation(Required=false)]
        public List<string> AtAppUids { get; set; }

        [NameInMap("atMobiles")]
        [Validation(Required=false)]
        public List<string> AtMobiles { get; set; }

        [NameInMap("atUnionIds")]
        [Validation(Required=false)]
        public List<string> AtUnionIds { get; set; }

        [NameInMap("atUsers")]
        [Validation(Required=false)]
        public List<string> AtUsers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;pic1&quot;:&quot;@123&quot;,&quot;pic2&quot;:&quot;@456&quot;}</para>
        /// </summary>
        [NameInMap("msgMediaIdParamMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> MsgMediaIdParamMap { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;text1&quot;:&quot;hello&quot;,&quot;text2&quot;:&quot;world&quot;}</para>
        /// </summary>
        [NameInMap("msgParamMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> MsgParamMap { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("msgTemplateId")]
        [Validation(Required=false)]
        public string MsgTemplateId { get; set; }

        [NameInMap("receiverAppUids")]
        [Validation(Required=false)]
        public List<string> ReceiverAppUids { get; set; }

        [NameInMap("receiverMobiles")]
        [Validation(Required=false)]
        public List<string> ReceiverMobiles { get; set; }

        [NameInMap("receiverUnionIds")]
        [Validation(Required=false)]
        public List<string> ReceiverUnionIds { get; set; }

        [NameInMap("receiverUserIds")]
        [Validation(Required=false)]
        public List<string> ReceiverUserIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("targetOpenConversationId")]
        [Validation(Required=false)]
        public string TargetOpenConversationId { get; set; }

    }

}
