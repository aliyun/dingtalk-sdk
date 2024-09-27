// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class PushDingMessageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>消息内容</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CARD</para>
        /// </summary>
        [NameInMap("messageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
        /// </summary>
        [NameInMap("messageUrl")]
        [Validation(Required=false)]
        public string MessageUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://pic.616pic.com/ys_b_img/00/27/71/Uu8E6C2Edn.jpg">http://pic.616pic.com/ys_b_img/00/27/71/Uu8E6C2Edn.jpg</a></para>
        /// </summary>
        [NameInMap("pictureUrl")]
        [Validation(Required=false)]
        public string PictureUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>转跳链接</para>
        /// </summary>
        [NameInMap("singleTitle")]
        [Validation(Required=false)]
        public string SingleTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
        /// </summary>
        [NameInMap("singleUrl")]
        [Validation(Required=false)]
        public string SingleUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>消息title</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

    }

}
