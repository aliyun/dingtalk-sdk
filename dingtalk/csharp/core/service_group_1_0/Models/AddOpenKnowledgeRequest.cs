// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class AddOpenKnowledgeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("attachments")]
        [Validation(Required=false)]
        public List<AddOpenKnowledgeRequestAttachments> Attachments { get; set; }
        public class AddOpenKnowledgeRequestAttachments : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>PDF</para>
            /// </summary>
            [NameInMap("mimeType")]
            [Validation(Required=false)]
            public string MimeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://dtapp-pub.dingtalk.com/dingtalkdesktop/test.pdf">https://dtapp-pub.dingtalk.com/dingtalkdesktop/test.pdf</a></para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>444556</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public double? Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("suffix")]
            [Validation(Required=false)]
            public string Suffix { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>这是一个附件文档</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44555</para>
        /// </summary>
        [NameInMap("categoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是服务群的介绍</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2100-01-01 23:59:59</para>
        /// </summary>
        [NameInMap("effectTimeend")]
        [Validation(Required=false)]
        public string EffectTimeend { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1980-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("effectTimestart")]
        [Validation(Required=false)]
        public string EffectTimestart { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是问法1,这是问法2</para>
        /// </summary>
        [NameInMap("extTitle")]
        [Validation(Required=false)]
        public string ExtTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>服务群,智能场景群</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public long? LibraryId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jxi12wo3qxoa</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XMD</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>服务群,智能场景群</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>服务群是什么</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXTERNAL</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0159003451667222</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>钉三多</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
