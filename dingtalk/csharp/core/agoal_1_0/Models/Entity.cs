// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class Entity : TeaModel {
        [NameInMap("children")]
        [Validation(Required=false)]
        public List<EntityChildren> Children { get; set; }
        public class EntityChildren : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;title&quot;: &quot;123&quot;}</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>y/n</para>
            /// </summary>
            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public string IsDeleted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>67dbb24f7aac3f62d8b98fb5</para>
            /// </summary>
            [NameInMap("linkSourceId")]
            [Validation(Required=false)]
            public string LinkSourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EXTERNAL_PERF_TASK</para>
            /// </summary>
            [NameInMap("linkSourceType")]
            [Validation(Required=false)]
            public string LinkSourceType { get; set; }

            [NameInMap("metas")]
            [Validation(Required=false)]
            public List<Meta> Metas { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DIMENSION</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;title&quot;: &quot;123&quot;}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>y/n</para>
        /// </summary>
        [NameInMap("isDeleted")]
        [Validation(Required=false)]
        public string IsDeleted { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>67dbb24f7aac3f62d8b98fb5</para>
        /// </summary>
        [NameInMap("linkSourceId")]
        [Validation(Required=false)]
        public string LinkSourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EXTERNAL_PERF_TASK</para>
        /// </summary>
        [NameInMap("linkSourceType")]
        [Validation(Required=false)]
        public string LinkSourceType { get; set; }

        [NameInMap("metas")]
        [Validation(Required=false)]
        public List<Meta> Metas { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DIMENSION</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
