// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetHolderInfoResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// STOCK_TYPE:股东类型
        /// STOCK_NAME:股东名称
        /// STOCK_PERCENT:持股比例
        /// SHOULD_CAPI:认缴出资额
        /// SHOULD_CAPI_TIME:认缴出资日期
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
