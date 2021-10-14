// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapp_market_1_0.Models
{
    public class UserTaskReportRequest : TeaModel {
        /// <summary>
        /// 业务的幂等ID
        /// </summary>
        [NameInMap("bizNo")]
        [Validation(Required=false)]
        public string BizNo { get; set; }

        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        /// <summary>
        /// operateDate
        /// </summary>
        [NameInMap("operateDate")]
        [Validation(Required=false)]
        public string OperateDate { get; set; }

        /// <summary>
        /// taskTag
        /// </summary>
        [NameInMap("taskTag")]
        [Validation(Required=false)]
        public string TaskTag { get; set; }

        /// <summary>
        /// staffId
        /// </summary>
        [NameInMap("userid")]
        [Validation(Required=false)]
        public string Userid { get; set; }

    }

}
