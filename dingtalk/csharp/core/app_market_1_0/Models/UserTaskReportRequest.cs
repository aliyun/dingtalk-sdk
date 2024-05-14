// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapp_market_1_0.Models
{
    public class UserTaskReportRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("bizNo")]
        [Validation(Required=false)]
        public string BizNo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operateDate")]
        [Validation(Required=false)]
        public string OperateDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("taskTag")]
        [Validation(Required=false)]
        public string TaskTag { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userid")]
        [Validation(Required=false)]
        public string Userid { get; set; }

    }

}
