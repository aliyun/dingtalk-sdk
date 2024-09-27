// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class RelatedSpacesResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<RelatedSpacesResponseBodyItems> Items { get; set; }
        public class RelatedSpacesResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://img.abc.yyy">https://img.abc.yyy</a></para>
            /// </summary>
            [NameInMap("cover")]
            [Validation(Required=false)]
            public string Cover { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>This is some description.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("hdIconVO")]
            [Validation(Required=false)]
            public RelatedSpacesResponseBodyItemsHdIconVO HdIconVO { get; set; }
            public class RelatedSpacesResponseBodyItemsHdIconVO : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.xxx.yyy">https://img.xxx.yyy</a></para>
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>url</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("iconVO")]
            [Validation(Required=false)]
            public RelatedSpacesResponseBodyItemsIconVO IconVO { get; set; }
            public class RelatedSpacesResponseBodyItemsIconVO : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.xxx.yyy">https://img.xxx.yyy</a></para>
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>url</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("owner")]
            [Validation(Required=false)]
            public RelatedSpacesResponseBodyItemsOwner Owner { get; set; }
            public class RelatedSpacesResponseBodyItemsOwner : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dingtalk</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcd</para>
                /// </summary>
                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

            }

            [NameInMap("recentList")]
            [Validation(Required=false)]
            public List<DentryModel> RecentList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xx.yy">https://xx.yy</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("visitorInfo")]
            [Validation(Required=false)]
            public RelatedSpacesResponseBodyItemsVisitorInfo VisitorInfo { get; set; }
            public class RelatedSpacesResponseBodyItemsVisitorInfo : TeaModel {
                [NameInMap("dentryActions")]
                [Validation(Required=false)]
                public List<string> DentryActions { get; set; }

                [NameInMap("pinned")]
                [Validation(Required=false)]
                public bool? Pinned { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("roleCode")]
                [Validation(Required=false)]
                public string RoleCode { get; set; }

                [NameInMap("spaceActions")]
                [Validation(Required=false)]
                public List<string> SpaceActions { get; set; }

            }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
