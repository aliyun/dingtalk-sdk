// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetMultipartFileUploadInfosResponseBody : TeaModel {
        [NameInMap("multipartHeaderSignatureInfos")]
        [Validation(Required=false)]
        public List<GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos> MultipartHeaderSignatureInfos { get; set; }
        public class GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos : TeaModel {
            [NameInMap("headerSignatureInfo")]
            [Validation(Required=false)]
            public GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo HeaderSignatureInfo { get; set; }
            public class GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>900</para>
                /// </summary>
                [NameInMap("expirationSeconds")]
                [Validation(Required=false)]
                public int? ExpirationSeconds { get; set; }

                [NameInMap("headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                [NameInMap("internalResourceUrls")]
                [Validation(Required=false)]
                public List<string> InternalResourceUrls { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ZHANGJIAKOU</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("resourceUrls")]
                [Validation(Required=false)]
                public List<string> ResourceUrls { get; set; }

            }

            [NameInMap("partNumber")]
            [Validation(Required=false)]
            public int? PartNumber { get; set; }

        }

    }

}
