// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CreateShortcutForMigrateResponseBody : TeaModel {
        [NameInMap("openDentryInfo")]
        [Validation(Required=false)]
        public CreateShortcutForMigrateResponseBodyOpenDentryInfo OpenDentryInfo { get; set; }
        public class CreateShortcutForMigrateResponseBodyOpenDentryInfo : TeaModel {
            [NameInMap("dentryUuid")]
            [Validation(Required=false)]
            public string DentryUuid { get; set; }

            [NameInMap("driveDentryId")]
            [Validation(Required=false)]
            public string DriveDentryId { get; set; }

            [NameInMap("driveSpaceId")]
            [Validation(Required=false)]
            public string DriveSpaceId { get; set; }

            [NameInMap("extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
