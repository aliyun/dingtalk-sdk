// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class RobotReplyEmotionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("emotionName")]
        [Validation(Required=false)]
        public string EmotionName { get; set; }

        [NameInMap("emotionType")]
        [Validation(Required=false)]
        public int? EmotionType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cidxxx</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>msgxxxx</para>
        /// </summary>
        [NameInMap("openMsgId")]
        [Validation(Required=false)]
        public string OpenMsgId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>213123</para>
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        [NameInMap("textEmotion")]
        [Validation(Required=false)]
        public RobotReplyEmotionRequestTextEmotion TextEmotion { get; set; }
        public class RobotReplyEmotionRequestTextEmotion : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>im_bg_1</para>
            /// </summary>
            [NameInMap("backgroundId")]
            [Validation(Required=false)]
            public string BackgroundId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("emotionId")]
            [Validation(Required=false)]
            public string EmotionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("emotionName")]
            [Validation(Required=false)]
            public string EmotionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

    }

}
