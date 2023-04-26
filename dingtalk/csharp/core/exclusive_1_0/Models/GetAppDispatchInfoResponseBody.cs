// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetAppDispatchInfoResponseBody : TeaModel {
        [NameInMap("android")]
        [Validation(Required=false)]
        public List<GetAppDispatchInfoResponseBodyAndroid> Android { get; set; }
        public class GetAppDispatchInfoResponseBodyAndroid : TeaModel {
            [NameInMap("baseLineVersion")]
            [Validation(Required=false)]
            public string BaseLineVersion { get; set; }

            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("inGray")]
            [Validation(Required=false)]
            public bool? InGray { get; set; }

            [NameInMap("packTime")]
            [Validation(Required=false)]
            public long? PackTime { get; set; }

            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("iOS")]
        [Validation(Required=false)]
        public List<GetAppDispatchInfoResponseBodyIOS> IOS { get; set; }
        public class GetAppDispatchInfoResponseBodyIOS : TeaModel {
            [NameInMap("baseLineVersion")]
            [Validation(Required=false)]
            public string BaseLineVersion { get; set; }

            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("ext")]
            [Validation(Required=false)]
            public GetAppDispatchInfoResponseBodyIOSExt Ext { get; set; }
            public class GetAppDispatchInfoResponseBodyIOSExt : TeaModel {
                [NameInMap("plist")]
                [Validation(Required=false)]
                public string Plist { get; set; }

            }

            [NameInMap("inGray")]
            [Validation(Required=false)]
            public bool? InGray { get; set; }

            [NameInMap("packTime")]
            [Validation(Required=false)]
            public long? PackTime { get; set; }

            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("mac")]
        [Validation(Required=false)]
        public List<GetAppDispatchInfoResponseBodyMac> Mac { get; set; }
        public class GetAppDispatchInfoResponseBodyMac : TeaModel {
            [NameInMap("baseLineVersion")]
            [Validation(Required=false)]
            public string BaseLineVersion { get; set; }

            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("inGray")]
            [Validation(Required=false)]
            public bool? InGray { get; set; }

            [NameInMap("packTime")]
            [Validation(Required=false)]
            public long? PackTime { get; set; }

            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("windows")]
        [Validation(Required=false)]
        public List<GetAppDispatchInfoResponseBodyWindows> Windows { get; set; }
        public class GetAppDispatchInfoResponseBodyWindows : TeaModel {
            [NameInMap("baseLineVersion")]
            [Validation(Required=false)]
            public string BaseLineVersion { get; set; }

            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("inGray")]
            [Validation(Required=false)]
            public bool? InGray { get; set; }

            [NameInMap("packTime")]
            [Validation(Required=false)]
            public long? PackTime { get; set; }

            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
