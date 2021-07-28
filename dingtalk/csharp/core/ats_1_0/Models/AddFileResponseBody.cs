// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class AddFileResponseBody : TeaModel {
        /// <summary>
        /// 空间标识
        /// </summary>
        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public long? SpaceId { get; set; }

        /// <summary>
        /// 文件标识
        /// </summary>
        [NameInMap("fileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

    }

}
