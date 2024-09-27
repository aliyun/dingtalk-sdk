// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0.Models
{
    public class PediaWordsSearchResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<PediaWordsSearchResponseBodyData> Data { get; set; }
        public class PediaWordsSearchResponseBodyData : TeaModel {
            [NameInMap("appLink")]
            [Validation(Required=false)]
            public List<PediaWordsSearchResponseBodyDataAppLink> AppLink { get; set; }
            public class PediaWordsSearchResponseBodyDataAppLink : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>应用名</para>
                /// </summary>
                [NameInMap("appName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://123434.com">https://123434.com</a></para>
                /// </summary>
                [NameInMap("iconLink")]
                [Validation(Required=false)]
                public string IconLink { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://123.com">http://123.com</a></para>
                /// </summary>
                [NameInMap("pcLink")]
                [Validation(Required=false)]
                public string PcLink { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://1244.com">http://1244.com</a></para>
                /// </summary>
                [NameInMap("phoneLink")]
                [Validation(Required=false)]
                public string PhoneLink { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>审核人钉钉名称</para>
            /// </summary>
            [NameInMap("approveName")]
            [Validation(Required=false)]
            public string ApproveName { get; set; }

            [NameInMap("contactList")]
            [Validation(Required=false)]
            public List<PediaWordsSearchResponseBodyDataContactList> ContactList { get; set; }
            public class PediaWordsSearchResponseBodyDataContactList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>@12321312ds</para>
                /// </summary>
                [NameInMap("avatarMediaId")]
                [Validation(Required=false)]
                public string AvatarMediaId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>员工名称</para>
                /// </summary>
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1232343</para>
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

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModify")]
            [Validation(Required=false)]
            public long? GmtModify { get; set; }

            [NameInMap("highLightWordAlias")]
            [Validation(Required=false)]
            public List<string> HighLightWordAlias { get; set; }

            [NameInMap("imHighLight")]
            [Validation(Required=false)]
            public bool? ImHighLight { get; set; }

            [NameInMap("parentUuid")]
            [Validation(Required=false)]
            public long? ParentUuid { get; set; }

            [NameInMap("picList")]
            [Validation(Required=false)]
            public List<PediaWordsSearchResponseBodyDataPicList> PicList { get; set; }
            public class PediaWordsSearchResponseBodyDataPicList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://1234.com">https://1234.com</a></para>
                /// </summary>
                [NameInMap("mediaIdUrl")]
                [Validation(Required=false)]
                public string MediaIdUrl { get; set; }

            }

            [NameInMap("relatedDoc")]
            [Validation(Required=false)]
            public List<PediaWordsSearchResponseBodyDataRelatedDoc> RelatedDoc { get; set; }
            public class PediaWordsSearchResponseBodyDataRelatedDoc : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://12324.com">https://12324.com</a></para>
                /// </summary>
                [NameInMap("link")]
                [Validation(Required=false)]
                public string Link { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>文档名</para>
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
            public List<PediaWordsSearchResponseBodyDataRelatedLink> RelatedLink { get; set; }
            public class PediaWordsSearchResponseBodyDataRelatedLink : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://123112.com">https://123112.com</a></para>
                /// </summary>
                [NameInMap("link")]
                [Validation(Required=false)]
                public string Link { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>文档名字</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>空值</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("simHighLight")]
            [Validation(Required=false)]
            public bool? SimHighLight { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>剔除了富文本格式后的释义信息</para>
            /// </summary>
            [NameInMap("simpleWordParaphrase")]
            [Validation(Required=false)]
            public string SimpleWordParaphrase { get; set; }

            [NameInMap("tagsList")]
            [Validation(Required=false)]
            public List<string> TagsList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>修改人钉钉名称</para>
            /// </summary>
            [NameInMap("updaterName")]
            [Validation(Required=false)]
            public string UpdaterName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>312312312</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("uuid")]
            [Validation(Required=false)]
            public long? Uuid { get; set; }

            [NameInMap("wordAlias")]
            [Validation(Required=false)]
            public List<string> WordAlias { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试词条</para>
            /// </summary>
            [NameInMap("wordName")]
            [Validation(Required=false)]
            public string WordName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>释义信息</para>
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
