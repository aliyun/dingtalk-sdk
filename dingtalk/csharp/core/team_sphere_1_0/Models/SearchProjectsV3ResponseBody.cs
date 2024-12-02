// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class SearchProjectsV3ResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>f279e812-e431-428d-846d-cxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SearchProjectsV3ResponseBodyResult> Result { get; set; }
        public class SearchProjectsV3ResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("isTemplate")]
            [Validation(Required=false)]
            public bool? IsTemplate { get; set; }

            [NameInMap("logo")]
            [Validation(Required=false)]
            public string Logo { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("organizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
