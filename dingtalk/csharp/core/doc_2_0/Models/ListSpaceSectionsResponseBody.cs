// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListSpaceSectionsResponseBody : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListSpaceSectionsResponseBodyItems> Items { get; set; }
        public class ListSpaceSectionsResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>base</para>
            /// </summary>
            [NameInMap("displayType")]
            [Validation(Required=false)]
            public string DisplayType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试分组</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("spaceNum")]
            [Validation(Required=false)]
            public int? SpaceNum { get; set; }

            [NameInMap("spaces")]
            [Validation(Required=false)]
            public List<SpaceModel> Spaces { get; set; }

        }

    }

}
