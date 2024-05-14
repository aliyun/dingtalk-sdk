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
                [NameInMap("canRecordRecentFile")]
                [Validation(Required=false)]
                public bool? CanRecordRecentFile { get; set; }

                [NameInMap("canRename")]
                [Validation(Required=false)]
                public bool? CanRename { get; set; }

                [NameInMap("canSearch")]
                [Validation(Required=false)]
                public bool? CanSearch { get; set; }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ownerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            [NameInMap("quota")]
            [Validation(Required=false)]
            public long? Quota { get; set; }

            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            [NameInMap("sceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
