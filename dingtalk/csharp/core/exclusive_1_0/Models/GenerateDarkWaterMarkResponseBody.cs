// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GenerateDarkWaterMarkResponseBody : TeaModel {
        /// <summary>
        /// 返回码
        /// </summary>
        [NameInMap("darkWatermarkVOList")]
        [Validation(Required=false)]
        public List<GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList> DarkWatermarkVOList { get; set; }
        public class GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList : TeaModel {
            /// <summary>
            /// 暗水印链接
            /// </summary>
            [NameInMap("darkWatermark")]
            [Validation(Required=false)]
            public string DarkWatermark { get; set; }

            /// <summary>
            /// 员工工号
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
