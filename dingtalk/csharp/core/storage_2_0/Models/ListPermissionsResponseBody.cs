// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0.Models
{
    public class ListPermissionsResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("permissions")]
        [Validation(Required=false)]
        public List<ListPermissionsResponseBodyPermissions> Permissions { get; set; }
        public class ListPermissionsResponseBodyPermissions : TeaModel {
            [NameInMap("dentryUuid")]
            [Validation(Required=false)]
            public string DentryUuid { get; set; }

            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("member")]
            [Validation(Required=false)]
            public ListPermissionsResponseBodyPermissionsMember Member { get; set; }
            public class ListPermissionsResponseBodyPermissionsMember : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("role")]
            [Validation(Required=false)]
            public ListPermissionsResponseBodyPermissionsRole Role { get; set; }
            public class ListPermissionsResponseBodyPermissionsRole : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

    }

}
