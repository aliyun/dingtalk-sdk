// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetDentryOpenInfoResponseBody : TeaModel {
        /// <summary>
        /// 是否支持水印
        /// </summary>
        [NameInMap("hasWaterMark")]
        [Validation(Required=false)]
        public bool? HasWaterMark { get; set; }

        /// <summary>
        /// 链接, 用于编辑或预览
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
