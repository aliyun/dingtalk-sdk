// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetGeneralFormCreatedSummaryResponseBody : TeaModel {
        /// <summary>
        /// 最近1天智能填表创建数
        /// </summary>
        [NameInMap("generalFormCreatedCnt")]
        [Validation(Required=false)]
        public string GeneralFormCreatedCnt { get; set; }

        /// <summary>
        /// 最近1天使用智能填表人数
        /// </summary>
        [NameInMap("useGeneralFormUserCnt1d")]
        [Validation(Required=false)]
        public string UseGeneralFormUserCnt1d { get; set; }

    }

}
