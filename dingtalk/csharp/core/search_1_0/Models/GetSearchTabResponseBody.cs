// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksearch_1_0.Models
{
    public class GetSearchTabResponseBody : TeaModel {
        /// <summary>
        /// 创建时间
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 数据源的id,范围为3000-4000
        /// </summary>
        [NameInMap("tabId")]
        [Validation(Required=false)]
        public int? TabId { get; set; }

        /// <summary>
        /// 数据源名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 数据源优先级，数值越大优先级越高
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// 数据源状态，1表示上线，0表示下线
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
