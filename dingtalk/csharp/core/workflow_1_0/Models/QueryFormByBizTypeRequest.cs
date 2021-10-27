// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QueryFormByBizTypeRequest : TeaModel {
        /// <summary>
        /// 应用搭建id
        /// </summary>
        [NameInMap("appUuid")]
        [Validation(Required=false)]
        public string AppUuid { get; set; }

        /// <summary>
        /// 表单业务标识
        /// </summary>
        [NameInMap("bizTypes")]
        [Validation(Required=false)]
        public List<string> BizTypes { get; set; }

    }

}
