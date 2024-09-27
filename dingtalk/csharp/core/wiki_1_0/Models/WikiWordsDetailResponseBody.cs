// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_1_0.Models
{
    public class WikiWordsDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<WikiWordsDetailResponseBodyData> Data { get; set; }
        public class WikiWordsDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("appLink")]
            [Validation(Required=false)]
            public List<WikiWordsDetailResponseBodyDataAppLink> AppLink { get; set; }
            public class WikiWordsDetailResponseBodyDataAppLink : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("appId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("appName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("iconLink")]
                [Validation(Required=false)]
                public string IconLink { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("pcLink")]
                [Validation(Required=false)]
                public string PcLink { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("phoneLink")]
                [Validation(Required=false)]
                public string PhoneLink { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("approveName")]
            [Validation(Required=false)]
            public string ApproveName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("contacts")]
            [Validation(Required=false)]
            public List<string> Contacts { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("gmtModify")]
            [Validation(Required=false)]
            public long? GmtModify { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("highLightWordAlias")]
            [Validation(Required=false)]
            public List<string> HighLightWordAlias { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("imHighLight")]
            [Validation(Required=false)]
            public bool? ImHighLight { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("relatedDoc")]
            [Validation(Required=false)]
            public List<WikiWordsDetailResponseBodyDataRelatedDoc> RelatedDoc { get; set; }
            public class WikiWordsDetailResponseBodyDataRelatedDoc : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("link")]
                [Validation(Required=false)]
                public string Link { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("relatedLink")]
            [Validation(Required=false)]
            public List<WikiWordsDetailResponseBodyDataRelatedLink> RelatedLink { get; set; }
            public class WikiWordsDetailResponseBodyDataRelatedLink : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("link")]
                [Validation(Required=false)]
                public string Link { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("simHighLight")]
            [Validation(Required=false)]
            public bool? SimHighLight { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("simpleWordParaphrase")]
            [Validation(Required=false)]
            public string SimpleWordParaphrase { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("tagsList")]
            [Validation(Required=false)]
            public List<string> TagsList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("updaterName")]
            [Validation(Required=false)]
            public string UpdaterName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public long? Uuid { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("wordAlias")]
            [Validation(Required=false)]
            public List<string> WordAlias { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("wordFullName")]
            [Validation(Required=false)]
            public string WordFullName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("wordName")]
            [Validation(Required=false)]
            public string WordName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("wordParaphrase")]
            [Validation(Required=false)]
            public string WordParaphrase { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("errMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
