// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class TranslateFileRequest : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

        [NameInMap("eagleEyeTraceId")]
        [Validation(Required=false)]
        public string EagleEyeTraceId { get; set; }

        /// <summary>
        /// key为钉盘文件mediaId，#号开头。只支持xlsx，xls，csv，txt文件。 value为文件名，包含文件扩展名。 不超过20个文件，可以调用单步文件上传接口获取。
        /// </summary>
        [NameInMap("medias")]
        [Validation(Required=false)]
        public Dictionary<string, string> Medias { get; set; }

        /// <summary>
        /// 若medias中文件个数大于1，则该字段必填。 转译完打包的文件名，不需带后缀。钉钉后台会打包成zip压缩文件，并自动拼接上.zip后缀。
        /// </summary>
        [NameInMap("outputFileName")]
        [Validation(Required=false)]
        public string OutputFileName { get; set; }

        /// <summary>
        /// unionId
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
