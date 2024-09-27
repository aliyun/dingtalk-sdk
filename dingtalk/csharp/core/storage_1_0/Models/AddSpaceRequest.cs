// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class AddSpaceRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public AddSpaceRequestOption Option { get; set; }
        public class AddSpaceRequestOption : TeaModel {
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public AddSpaceRequestOptionCapabilities Capabilities { get; set; }
            public class AddSpaceRequestOptionCapabilities : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("canRecordRecentFile")]
                [Validation(Required=false)]
                public bool? CanRecordRecentFile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("canRename")]
                [Validation(Required=false)]
                public bool? CanRename { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("canSearch")]
                [Validation(Required=false)]
                public bool? CanSearch { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>space_name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("ownerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            [NameInMap("quota")]
            [Validation(Required=false)]
            public long? Quota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>scene</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>scene_id</para>
            /// </summary>
            [NameInMap("sceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
