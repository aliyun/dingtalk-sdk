// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class GetUploadInfoResponseBody : TeaModel {
        [NameInMap("stsUploadInfo")]
        [Validation(Required=false)]
        public GetUploadInfoResponseBodyStsUploadInfo StsUploadInfo { get; set; }
        public class GetUploadInfoResponseBodyStsUploadInfo : TeaModel {
            [NameInMap("bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }
            [NameInMap("endPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }
            [NameInMap("accessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }
            [NameInMap("accessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }
            [NameInMap("accessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }
            [NameInMap("accessTokenExpirationMillis")]
            [Validation(Required=false)]
            public long? AccessTokenExpirationMillis { get; set; }
            [NameInMap("mediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }
        };

    }

}
