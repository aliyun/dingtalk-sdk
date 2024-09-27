// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class AddKnowledgeRequest : TeaModel {
        [NameInMap("attachmentList")]
        [Validation(Required=false)]
        public List<AddKnowledgeRequestAttachmentList> AttachmentList { get; set; }
        public class AddKnowledgeRequestAttachmentList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>doc</para>
            /// </summary>
            [NameInMap("mime_type")]
            [Validation(Required=false)]
            public string MimeType { get; set; }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>655</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("suffix")]
            [Validation(Required=false)]
            public string Suffix { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试附件</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试内容</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("effectTimeend")]
        [Validation(Required=false)]
        public long? EffectTimeend { get; set; }

        [NameInMap("effectTimestart")]
        [Validation(Required=false)]
        public long? EffectTimestart { get; set; }

        [NameInMap("extTitle")]
        [Validation(Required=false)]
        public string ExtTitle { get; set; }

        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xuvw1245</para>
        /// </summary>
        [NameInMap("libraryKey")]
        [Validation(Required=false)]
        public string LibraryKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://www.test.com/xxxxx">http://www.test.com/xxxxx</a></para>
        /// </summary>
        [NameInMap("linkUrl")]
        [Validation(Required=false)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Jxi12wo3qxoa</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        [NameInMap("questionIds")]
        [Validation(Required=false)]
        public List<long?> QuestionIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CCM</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CCM-123</para>
        /// </summary>
        [NameInMap("sourcePrimaryKey")]
        [Validation(Required=false)]
        public string SourcePrimaryKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CONDITION</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>V0193859102</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
