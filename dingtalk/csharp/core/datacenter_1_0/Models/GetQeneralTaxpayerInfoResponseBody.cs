// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetQeneralTaxpayerInfoResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// DEPARTMENT:主管机关
        /// END_DATE:有效日期止
        /// ENT_NAME:纳税人名称
        /// QUALIFICATION 纳税人资格
        /// START_DATE:有效日期起
        /// TAXPAYER_NUM:纳税人识别号
        /// JUDGE_DATE:认定时间
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
