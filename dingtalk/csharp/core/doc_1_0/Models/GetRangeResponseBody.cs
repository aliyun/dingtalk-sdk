// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetRangeResponseBody : TeaModel {
        /// <summary>
        /// 背景颜色
        /// 最大size:
        /// 	1000
        /// </summary>
        [NameInMap("backgroundColors")]
        [Validation(Required=false)]
        public List<List<GetRangeResponseBodyBackgroundColors>> BackgroundColors { get; set; }
        public class GetRangeResponseBodyBackgroundColors : TeaModel {
            /// <summary>
            /// RGB值中的红色值
            /// </summary>
            [NameInMap("red")]
            [Validation(Required=false)]
            public int? Red { get; set; }

            /// <summary>
            /// RGB值中的绿色值
            /// </summary>
            [NameInMap("green")]
            [Validation(Required=false)]
            public int? Green { get; set; }

            /// <summary>
            /// RGB值中的蓝色值
            /// </summary>
            [NameInMap("blue")]
            [Validation(Required=false)]
            public int? Blue { get; set; }

            /// <summary>
            /// 16进制表示的颜色
            /// </summary>
            [NameInMap("hexString")]
            [Validation(Required=false)]
            public string HexString { get; set; }

        }

        /// <summary>
        /// 展示值
        /// 最大size:
        /// 	1000
        /// </summary>
        [NameInMap("displayValues")]
        [Validation(Required=false)]
        public List<List<string>> DisplayValues { get; set; }

        /// <summary>
        /// 公式
        /// 最大size:
        /// 	1000
        /// </summary>
        [NameInMap("formulas")]
        [Validation(Required=false)]
        public List<List<string>> Formulas { get; set; }

        /// <summary>
        /// 值
        /// 最大size:
        /// 	1000
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public List<List<object>> Values { get; set; }

    }

}
