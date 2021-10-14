// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class StartStreamOutRequest : TeaModel {
        /// <summary>
        /// 布局
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// 是否需要主持人加入后才允许推流
        /// </summary>
        [NameInMap("needHostJoin")]
        [Validation(Required=false)]
        public bool? NeedHostJoin { get; set; }

        /// <summary>
        /// 小窗位置
        /// </summary>
        [NameInMap("smallWindowPosition")]
        [Validation(Required=false)]
        public string SmallWindowPosition { get; set; }

        [NameInMap("streamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// 推流地址列表, 最多10个，需要以RTMP开头
        /// </summary>
        [NameInMap("streamUrlList")]
        [Validation(Required=false)]
        public List<string> StreamUrlList { get; set; }

        /// <summary>
        /// 主持人UID
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
