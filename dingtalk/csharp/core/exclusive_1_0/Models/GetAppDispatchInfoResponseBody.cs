// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetAppDispatchInfoResponseBody : TeaModel {
        /// <summary>
        /// android打包记录
        /// </summary>
        [NameInMap("android")]
        [Validation(Required=false)]
        public List<GetAppDispatchInfoResponseBodyAndroid> Android { get; set; }
        public class GetAppDispatchInfoResponseBodyAndroid : TeaModel {
            /// <summary>
            /// 基线版本
            /// </summary>
            [NameInMap("baseLineVersion")]
            [Validation(Required=false)]
            public string BaseLineVersion { get; set; }

            /// <summary>
            /// 下载地址
            /// </summary>
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// 是否灰度。true 灰度发布中 | false 全量灰度发布。为空则为未发布
            /// </summary>
            [NameInMap("inGray")]
            [Validation(Required=false)]
            public bool? InGray { get; set; }

            /// <summary>
            /// 打包时间
            /// </summary>
            [NameInMap("packTime")]
            [Validation(Required=false)]
            public long? PackTime { get; set; }

            /// <summary>
            /// 客户端类型
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// 版本号
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// iOS打包记录
        /// </summary>
        [NameInMap("iOS")]
        [Validation(Required=false)]
        public List<GetAppDispatchInfoResponseBodyIOS> IOS { get; set; }
        public class GetAppDispatchInfoResponseBodyIOS : TeaModel {
            /// <summary>
            /// 基线版本
            /// </summary>
            [NameInMap("baseLineVersion")]
            [Validation(Required=false)]
            public string BaseLineVersion { get; set; }

            /// <summary>
            /// 下载地址
            /// </summary>
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
            };

            /// <summary>
            /// 是否灰度。true 灰度发布中 | false 全量灰度发布。为空则为未发布
            /// </summary>
            [NameInMap("inGray")]
            [Validation(Required=false)]
            public bool? InGray { get; set; }

            /// <summary>
            /// 打包时间
            /// </summary>
            [NameInMap("packTime")]
            [Validation(Required=false)]
            public long? PackTime { get; set; }

            /// <summary>
            /// 客户端类型
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// 版本号
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// mac打包记录
        /// </summary>
        [NameInMap("mac")]
        [Validation(Required=false)]
        public List<GetAppDispatchInfoResponseBodyMac> Mac { get; set; }
        public class GetAppDispatchInfoResponseBodyMac : TeaModel {
            /// <summary>
            /// 基线版本
            /// </summary>
            [NameInMap("baseLineVersion")]
            [Validation(Required=false)]
            public string BaseLineVersion { get; set; }

            /// <summary>
            /// 下载地址
            /// </summary>
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// 是否灰度。true 灰度发布中 | false 全量灰度发布。为空则为未发布
            /// </summary>
            [NameInMap("inGray")]
            [Validation(Required=false)]
            public bool? InGray { get; set; }

            /// <summary>
            /// 打包时间
            /// </summary>
            [NameInMap("packTime")]
            [Validation(Required=false)]
            public long? PackTime { get; set; }

            /// <summary>
            /// 客户端类型
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// 版本号
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// windows打包记录
        /// </summary>
        [NameInMap("windows")]
        [Validation(Required=false)]
        public List<GetAppDispatchInfoResponseBodyWindows> Windows { get; set; }
        public class GetAppDispatchInfoResponseBodyWindows : TeaModel {
            /// <summary>
            /// 基线版本
            /// </summary>
            [NameInMap("baseLineVersion")]
            [Validation(Required=false)]
            public string BaseLineVersion { get; set; }

            /// <summary>
            /// 下载地址
            /// </summary>
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// 是否灰度。true 灰度发布中 | false 全量灰度发布。为空则为未发布
            /// </summary>
            [NameInMap("inGray")]
            [Validation(Required=false)]
            public bool? InGray { get; set; }

            /// <summary>
            /// 打包时间
            /// </summary>
            [NameInMap("packTime")]
            [Validation(Required=false)]
            public long? PackTime { get; set; }

            /// <summary>
            /// 客户端类型
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// 版本号
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
