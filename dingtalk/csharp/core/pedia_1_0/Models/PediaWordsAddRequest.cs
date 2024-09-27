// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0.Models
{
    public class PediaWordsAddRequest : TeaModel {
        [NameInMap("contactList")]
        [Validation(Required=false)]
        public List<PediaWordsAddRequestContactList> ContactList { get; set; }
        public class PediaWordsAddRequestContactList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>@123243</para>
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
            /// <para>1231243213</para>
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
        public List<PediaWordsAddRequestPicList> PicList { get; set; }
        public class PediaWordsAddRequestPicList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://23987874.com">https://23987874.com</a></para>
            /// </summary>
            [NameInMap("mediaIdUrl")]
            [Validation(Required=false)]
            public string MediaIdUrl { get; set; }

        }

        [NameInMap("relatedDoc")]
        [Validation(Required=false)]
        public List<PediaWordsAddRequestRelatedDoc> RelatedDoc { get; set; }
        public class PediaWordsAddRequestRelatedDoc : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://123456.com">https://123456.com</a></para>
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
        public List<PediaWordsAddRequestRelatedLink> RelatedLink { get; set; }
        public class PediaWordsAddRequestRelatedLink : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://1233435.com">http://1233435.com</a></para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23231231123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

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
