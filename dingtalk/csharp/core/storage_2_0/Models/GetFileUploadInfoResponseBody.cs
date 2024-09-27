// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0.Models
{
    public class GetFileUploadInfoResponseBody : TeaModel {
        [NameInMap("headerSignatureInfo")]
        [Validation(Required=false)]
        public GetFileUploadInfoResponseBodyHeaderSignatureInfo HeaderSignatureInfo { get; set; }
        public class GetFileUploadInfoResponseBodyHeaderSignatureInfo : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>HEADER_SIGNATURE</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DINGTALK</para>
        /// </summary>
        [NameInMap("storageDriver")]
        [Validation(Required=false)]
        public string StorageDriver { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>upload_key</para>
        /// </summary>
        [NameInMap("uploadKey")]
        [Validation(Required=false)]
        public string UploadKey { get; set; }

    }

}
