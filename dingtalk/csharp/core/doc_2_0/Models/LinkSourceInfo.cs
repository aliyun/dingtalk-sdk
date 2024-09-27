// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class LinkSourceInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>docx</para>
        /// </summary>
        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        [NameInMap("iconUrl")]
        [Validation(Required=false)]
        public LinkSourceInfoIconUrl IconUrl { get; set; }
        public class LinkSourceInfoIconUrl : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>gh</para>
            /// </summary>
            [NameInMap("line")]
            [Validation(Required=false)]
            public string Line { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>def</para>
            /// </summary>
            [NameInMap("small")]
            [Validation(Required=false)]
            public string Small { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("linkType")]
        [Validation(Required=false)]
        public long? LinkType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>def</para>
        /// </summary>
        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

    }

}
