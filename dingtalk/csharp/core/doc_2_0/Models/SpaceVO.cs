// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class SpaceVO : TeaModel {
        [NameInMap("cover")]
        [Validation(Required=false)]
        public string Cover { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("iconVO")]
        [Validation(Required=false)]
        public SpaceVOIconVO IconVO { get; set; }
        public class SpaceVOIconVO : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
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
        public SpaceVOOwner Owner { get; set; }
        public class SpaceVOOwner : TeaModel {
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
        public SpaceVOVisitorInfo VisitorInfo { get; set; }
        public class SpaceVOVisitorInfo : TeaModel {
            [NameInMap("dentryActions")]
            [Validation(Required=false)]
            public List<string> DentryActions { get; set; }

            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }

            [NameInMap("spaceActions")]
            [Validation(Required=false)]
            public List<string> SpaceActions { get; set; }

        }

    }

}
