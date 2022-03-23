// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetDocCreatedSummaryResponseBody : TeaModel {
        /// <summary>
        /// 最近1天创建文档人数
        /// </summary>
        [NameInMap("docCreateUserCnt1d")]
        [Validation(Required=false)]
        public string DocCreateUserCnt1d { get; set; }

        /// <summary>
        /// 最近1天创建文档数
        /// </summary>
        [NameInMap("docCreatedCnt")]
        [Validation(Required=false)]
        public string DocCreatedCnt { get; set; }

    }

}
