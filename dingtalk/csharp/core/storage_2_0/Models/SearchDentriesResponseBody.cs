// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0.Models
{
    public class SearchDentriesResponseBody : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<SearchDentriesResponseBodyItems> Items { get; set; }
        public class SearchDentriesResponseBodyItems : TeaModel {
            [NameInMap("creator")]
            [Validation(Required=false)]
            public SearchDentriesResponseBodyItemsCreator Creator { get; set; }
            public class SearchDentriesResponseBodyItemsCreator : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>user_name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>staff_id</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>uuid</para>
            /// </summary>
            [NameInMap("dentryUuid")]
            [Validation(Required=false)]
            public string DentryUuid { get; set; }

            [NameInMap("lastModifyTime")]
            [Validation(Required=false)]
            public long? LastModifyTime { get; set; }

            [NameInMap("modifier")]
            [Validation(Required=false)]
            public SearchDentriesResponseBodyItemsModifier Modifier { get; set; }
            public class SearchDentriesResponseBodyItemsModifier : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>user_name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>staff_id</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("path")]
            [Validation(Required=false)]
            public SearchDentriesResponseBodyItemsPath Path { get; set; }
            public class SearchDentriesResponseBodyItemsPath : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>folderA/folderB</para>
                /// </summary>
                [NameInMap("longPath")]
                [Validation(Required=false)]
                public string LongPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>folderA:folderB</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>url</para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>next_token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
