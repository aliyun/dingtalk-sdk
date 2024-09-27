// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SaveAcrossCloudStroageConfigsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sampleKeyId1234</para>
        /// </summary>
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sampleSecretId1234</para>
        /// </summary>
        [NameInMap("accessKeySecret")]
        [Validation(Required=false)]
        public string AccessKeySecret { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxbucket</para>
        /// </summary>
        [NameInMap("bucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cloudType")]
        [Validation(Required=false)]
        public int? CloudType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://oss-cn-test.aliyuncs.com">https://oss-cn-test.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

    }

}
