// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CopyDocWithAppAuthResponseBody : TeaModel {
        [NameInMap("isAsync")]
        [Validation(Required=false)]
        public bool? IsAsync { get; set; }

        [NameInMap("syncCopyResult")]
        [Validation(Required=false)]
        public CopyDocWithAppAuthResponseBodySyncCopyResult SyncCopyResult { get; set; }
        public class CopyDocWithAppAuthResponseBodySyncCopyResult : TeaModel {
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

            [NameInMap("spaceInfo")]
            [Validation(Required=false)]
            public CopyDocWithAppAuthResponseBodySyncCopyResultSpaceInfo SpaceInfo { get; set; }
            public class CopyDocWithAppAuthResponseBodySyncCopyResultSpaceInfo : TeaModel {
                [NameInMap("sceneType")]
                [Validation(Required=false)]
                public string SceneType { get; set; }

            }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
