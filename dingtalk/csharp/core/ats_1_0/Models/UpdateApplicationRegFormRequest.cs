// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class UpdateApplicationRegFormRequest : TeaModel {
        /// <summary>
        /// 业务标识
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// 应聘登记表的表单内容
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 钉盘文件信息
        /// </summary>
        [NameInMap("dingPanFile")]
        [Validation(Required=false)]
        public UpdateApplicationRegFormRequestDingPanFile DingPanFile { get; set; }
        public class UpdateApplicationRegFormRequestDingPanFile : TeaModel {
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public long? SpaceId { get; set; }
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }
            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }
        };

    }

}
