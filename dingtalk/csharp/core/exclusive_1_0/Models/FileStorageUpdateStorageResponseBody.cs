// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class FileStorageUpdateStorageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sampleKeyId1234</para>
        /// </summary>
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://oss-cn-test.aliyuncs.com%5C">https://oss-cn-test.aliyuncs.com\</a></para>
        /// </summary>
        [NameInMap("oss")]
        [Validation(Required=false)]
        public string Oss { get; set; }

    }

}
