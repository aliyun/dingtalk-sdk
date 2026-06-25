// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkaiot_1_0.Models
{
    public class CheckDeviceUpdateResponseBody : TeaModel {
        [NameInMap("modules")]
        [Validation(Required=false)]
        public List<CheckDeviceUpdateResponseBodyModules> Modules { get; set; }
        public class CheckDeviceUpdateResponseBodyModules : TeaModel {
            [NameInMap("checksum")]
            [Validation(Required=false)]
            public string Checksum { get; set; }

            [NameInMap("checksumAlgorithm")]
            [Validation(Required=false)]
            public string ChecksumAlgorithm { get; set; }

            [NameInMap("criticalNext")]
            [Validation(Required=false)]
            public string CriticalNext { get; set; }

            [NameInMap("currentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            [NameInMap("fileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            [NameInMap("latest")]
            [Validation(Required=false)]
            public string Latest { get; set; }

            [NameInMap("moduleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            [NameInMap("noticeEn")]
            [Validation(Required=false)]
            public string NoticeEn { get; set; }

            [NameInMap("noticeZh")]
            [Validation(Required=false)]
            public string NoticeZh { get; set; }

            [NameInMap("upgradeMode")]
            [Validation(Required=false)]
            public string UpgradeMode { get; set; }

        }

    }

}
