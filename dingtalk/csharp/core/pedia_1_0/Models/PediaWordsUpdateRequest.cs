// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0.Models
{
    public class PediaWordsUpdateRequest : TeaModel {
        [NameInMap("appLink")]
        [Validation(Required=false)]
        public List<PediaWordsUpdateRequestAppLink> AppLink { get; set; }
        public class PediaWordsUpdateRequestAppLink : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>应用名称</para>
            /// </summary>
            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://123243435.com">https://123243435.com</a></para>
            /// </summary>
            [NameInMap("iconLink")]
            [Validation(Required=false)]
            public string IconLink { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://213435.com">http://213435.com</a></para>
            /// </summary>
            [NameInMap("pcLink")]
            [Validation(Required=false)]
            public string PcLink { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>htttps://12345.com</para>
            /// </summary>
            [NameInMap("phoneLink")]
            [Validation(Required=false)]
            public string PhoneLink { get; set; }

        }

        [NameInMap("contactList")]
        [Validation(Required=false)]
        public List<PediaWordsUpdateRequestContactList> ContactList { get; set; }
        public class PediaWordsUpdateRequestContactList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>@12312312</para>
            /// </summary>
            [NameInMap("avatarMediaId")]
            [Validation(Required=false)]
            public string AvatarMediaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>名称</para>
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12131312</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("highLightWordAlias")]
        [Validation(Required=false)]
        public List<string> HighLightWordAlias { get; set; }

        [NameInMap("picList")]
        [Validation(Required=false)]
        public List<PediaWordsUpdateRequestPicList> PicList { get; set; }
        public class PediaWordsUpdateRequestPicList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://1234554.com">https://1234554.com</a></para>
            /// </summary>
            [NameInMap("mediaIdUrl")]
            [Validation(Required=false)]
            public string MediaIdUrl { get; set; }

        }

        [NameInMap("relatedDoc")]
        [Validation(Required=false)]
        public List<PediaWordsUpdateRequestRelatedDoc> RelatedDoc { get; set; }
        public class PediaWordsUpdateRequestRelatedDoc : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://213567.com">https://213567.com</a></para>
            /// </summary>
            [NameInMap("link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>相关文档</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>adoc</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("relatedLink")]
        [Validation(Required=false)]
        public List<PediaWordsUpdateRequestRelatedLink> RelatedLink { get; set; }
        public class PediaWordsUpdateRequestRelatedLink : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://123466.com">https://123466.com</a></para>
            /// </summary>
            [NameInMap("link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>相关链接</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>312123213</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2131321</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public long? Uuid { get; set; }

        [NameInMap("wordAlias")]
        [Validation(Required=false)]
        public List<string> WordAlias { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>词条名称</para>
        /// </summary>
        [NameInMap("wordName")]
        [Validation(Required=false)]
        public string WordName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>释义</para>
        /// </summary>
        [NameInMap("wordParaphrase")]
        [Validation(Required=false)]
        public string WordParaphrase { get; set; }

    }

}
