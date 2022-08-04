// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListSpaceSectionsResponseBody : TeaModel {
        /// <summary>
        /// 空间分组列表。
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListSpaceSectionsResponseBodyItems> Items { get; set; }
        public class ListSpaceSectionsResponseBodyItems : TeaModel {
            /// <summary>
            /// 展示类型。
            /// </summary>
            [NameInMap("displayType")]
            [Validation(Required=false)]
            public string DisplayType { get; set; }

            /// <summary>
            /// 分组id。
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 分组名称。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 知识库数量。
            /// </summary>
            [NameInMap("spaceNum")]
            [Validation(Required=false)]
            public int? SpaceNum { get; set; }

            /// <summary>
            /// 知识库列表
            /// </summary>
            [NameInMap("spaces")]
            [Validation(Required=false)]
            public List<SpaceModel> Spaces { get; set; }

        }

    }

}
