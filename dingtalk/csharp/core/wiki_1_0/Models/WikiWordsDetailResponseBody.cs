// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_1_0.Models
{
    public class WikiWordsDetailResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<WikiWordsDetailResponseBodyData> Data { get; set; }
        public class WikiWordsDetailResponseBodyData : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("appLink")]
            [Validation(Required=false)]
            public List<WikiWordsDetailResponseBodyDataAppLink> AppLink { get; set; }
            public class WikiWordsDetailResponseBodyDataAppLink : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("appId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("appName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("iconLink")]
                [Validation(Required=false)]
                public string IconLink { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("pcLink")]
                [Validation(Required=false)]
                public string PcLink { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("phoneLink")]
                [Validation(Required=false)]
                public string PhoneLink { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("approveName")]
            [Validation(Required=false)]
            public string ApproveName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("contacts")]
            [Validation(Required=false)]
            public List<string> Contacts { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtModify")]
            [Validation(Required=false)]
            public long? GmtModify { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("highLightWordAlias")]
            [Validation(Required=false)]
            public List<string> HighLightWordAlias { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("imHighLight")]
            [Validation(Required=false)]
            public bool? ImHighLight { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("relatedDoc")]
            [Validation(Required=false)]
            public List<WikiWordsDetailResponseBodyDataRelatedDoc> RelatedDoc { get; set; }
            public class WikiWordsDetailResponseBodyDataRelatedDoc : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("link")]
                [Validation(Required=false)]
                public string Link { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("relatedLink")]
            [Validation(Required=false)]
            public List<WikiWordsDetailResponseBodyDataRelatedLink> RelatedLink { get; set; }
            public class WikiWordsDetailResponseBodyDataRelatedLink : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("link")]
                [Validation(Required=false)]
                public string Link { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("simHighLight")]
            [Validation(Required=false)]
            public bool? SimHighLight { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("simpleWordParaphrase")]
            [Validation(Required=false)]
            public string SimpleWordParaphrase { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("tagsList")]
            [Validation(Required=false)]
            public List<string> TagsList { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("updaterName")]
            [Validation(Required=false)]
            public string UpdaterName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public long? Uuid { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("wordAlias")]
            [Validation(Required=false)]
            public List<string> WordAlias { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("wordFullName")]
            [Validation(Required=false)]
            public string WordFullName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("wordName")]
            [Validation(Required=false)]
            public string WordName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("wordParaphrase")]
            [Validation(Required=false)]
            public string WordParaphrase { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("errMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
