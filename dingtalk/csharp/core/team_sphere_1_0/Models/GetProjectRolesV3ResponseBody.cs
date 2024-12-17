// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class GetProjectRolesV3ResponseBody : TeaModel {
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
        public List<GetProjectRolesV3ResponseBodyResult> Result { get; set; }
        public class GetProjectRolesV3ResponseBodyResult : TeaModel {
            [NameInMap("display")]
            [Validation(Required=false)]
            public bool? Display { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("isDefaultRole")]
            [Validation(Required=false)]
            public bool? IsDefaultRole { get; set; }

            [NameInMap("level")]
            [Validation(Required=false)]
            public int? Level { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("originalId")]
            [Validation(Required=false)]
            public string OriginalId { get; set; }

        }

    }

}
