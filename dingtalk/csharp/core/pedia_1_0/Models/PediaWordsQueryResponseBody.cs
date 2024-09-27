// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0.Models
{
    public class PediaWordsQueryResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public PediaWordsQueryResponseBodyData Data { get; set; }
        public class PediaWordsQueryResponseBodyData : TeaModel {
            [NameInMap("appLink")]
            [Validation(Required=false)]
            public List<PediaWordsQueryResponseBodyDataAppLink> AppLink { get; set; }
            public class PediaWordsQueryResponseBodyDataAppLink : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>相关应用</para>
                /// </summary>
                [NameInMap("appName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>htttps://1234567</para>
                /// </summary>
                [NameInMap("iconLink")]
                [Validation(Required=false)]
                public string IconLink { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://123344.com">http://123344.com</a></para>
                /// </summary>
                [NameInMap("pcLink")]
                [Validation(Required=false)]
                public string PcLink { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://12334.com">https://12334.com</a></para>
                /// </summary>
                [NameInMap("phoneLink")]
                [Validation(Required=false)]
                public string PhoneLink { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>审核者</para>
            /// </summary>
            [NameInMap("approveName")]
            [Validation(Required=false)]
            public string ApproveName { get; set; }

            [NameInMap("contactList")]
            [Validation(Required=false)]
            public List<PediaWordsQueryResponseBodyDataContactList> ContactList { get; set; }
            public class PediaWordsQueryResponseBodyDataContactList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>@dasdasd</para>
                /// </summary>
                [NameInMap("avatarMediaId")]
                [Validation(Required=false)]
                public string AvatarMediaId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>相关联系人</para>
                /// </summary>
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12321231</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("contacts")]
            [Validation(Required=false)]
            public List<string> Contacts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>创建者</para>
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>31312312</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>321312312</para>
            /// </summary>
            [NameInMap("gmtModify")]
            [Validation(Required=false)]
            public long? GmtModify { get; set; }

            [NameInMap("highLightWordAlias")]
            [Validation(Required=false)]
            public List<string> HighLightWordAlias { get; set; }

            [NameInMap("imHighLight")]
            [Validation(Required=false)]
            public bool? ImHighLight { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345678</para>
            /// </summary>
            [NameInMap("parentUuid")]
            [Validation(Required=false)]
            public long? ParentUuid { get; set; }

            [NameInMap("picList")]
            [Validation(Required=false)]
            public List<PediaWordsQueryResponseBodyDataPicList> PicList { get; set; }
            public class PediaWordsQueryResponseBodyDataPicList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://123455.com">http://123455.com</a></para>
                /// </summary>
                [NameInMap("mediaIdUrl")]
                [Validation(Required=false)]
                public string MediaIdUrl { get; set; }

            }

            [NameInMap("relatedDoc")]
            [Validation(Required=false)]
            public List<PediaWordsQueryResponseBodyDataRelatedDoc> RelatedDoc { get; set; }
            public class PediaWordsQueryResponseBodyDataRelatedDoc : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://123456.com">http://123456.com</a></para>
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
            public List<PediaWordsQueryResponseBodyDataRelatedLink> RelatedLink { get; set; }
            public class PediaWordsQueryResponseBodyDataRelatedLink : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://123343.com">http://123343.com</a></para>
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

            [NameInMap("simHighLight")]
            [Validation(Required=false)]
            public bool? SimHighLight { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>剔除富文本释义</para>
            /// </summary>
            [NameInMap("simpleWordParaphrase")]
            [Validation(Required=false)]
            public string SimpleWordParaphrase { get; set; }

            [NameInMap("tagsList")]
            [Validation(Required=false)]
            public List<string> TagsList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>更新者</para>
            /// </summary>
            [NameInMap("updaterName")]
            [Validation(Required=false)]
            public string UpdaterName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>213123123</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123123121</para>
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public long? Uuid { get; set; }

            [NameInMap("wordAlias")]
            [Validation(Required=false)]
            public List<string> WordAlias { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>词条名称</para>
            /// </summary>
            [NameInMap("wordName")]
            [Validation(Required=false)]
            public string WordName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>释义</para>
            /// </summary>
            [NameInMap("wordParaphrase")]
            [Validation(Required=false)]
            public string WordParaphrase { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
