// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetDocCreatedSummaryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("docCreateUserCnt1d")]
        [Validation(Required=false)]
        public string DocCreateUserCnt1d { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("docCreatedCnt")]
        [Validation(Required=false)]
        public string DocCreatedCnt { get; set; }

    }

}
