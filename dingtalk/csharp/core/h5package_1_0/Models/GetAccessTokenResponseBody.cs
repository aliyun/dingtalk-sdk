// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh5package_1_0.Models
{
    public class GetAccessTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>STS.NUPjgnMhCVWvo1HSxfftf</para>
        /// </summary>
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASviryNDy9tTuS5KiYMA6fCYf81vHg4KdoX7CVHz4CSx</para>
        /// </summary>
        [NameInMap("accessKeySecret")]
        [Validation(Required=false)]
        public string AccessKeySecret { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk-bucket</para>
        /// </summary>
        [NameInMap("bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss-cn-shanghai.aliyuncs.com</para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-09-21T09:32:16Z</para>
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5000000002761167/1663751835956</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss-cn-shanghai</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CAIS0QJ1q6Ft5B2yfSjIr5blId3aoLdi4ZWdbRf5t3gzavt...</para>
        /// </summary>
        [NameInMap("stsToken")]
        [Validation(Required=false)]
        public string StsToken { get; set; }

    }

}
