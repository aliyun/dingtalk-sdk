// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksearch_1_0.Models
{
    public class CreateSearchTabRequest : TeaModel {
        /// <summary>
        /// 暗黑模式下，数据源图标，非必填，不填则使用默认图标
        /// </summary>
        [NameInMap("darkIcon")]
        [Validation(Required=false)]
        public string DarkIcon { get; set; }

        /// <summary>
        /// 数据源图标，非必填，不填则使用默认图标
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// 数据源名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 数据源优先级，数值越小优先级越高
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// 数据来源,非必填,默认来源为钉钉搜索内部引擎
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// 数据源状态，1表示上线，0表示下线
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
