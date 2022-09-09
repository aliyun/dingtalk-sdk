// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconv_file_1_0.Models
{
    public class SendByAppRequest : TeaModel {
        /// <summary>
        /// 文件id
        /// </summary>
        [NameInMap("dentryId")]
        [Validation(Required=false)]
        public string DentryId { get; set; }

        /// <summary>
        /// 文件所在空间id
        /// </summary>
        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        /// <summary>
        /// 目标用户id
        /// 会通过应用发送消息给指定用户
        /// </summary>
        [NameInMap("targetUnionId")]
        [Validation(Required=false)]
        public string TargetUnionId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
