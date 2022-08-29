// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetAdministrativePenaltiesResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// DATE_COL:处罚日期
        /// NUMBER:决定书文号
        /// ILLEGAL_TYPE:处罚类型
        /// DEPARTMENT:处罚机关
        /// PUBLIC_DATE 公示日期
        /// CONTENT:处罚内容
        /// BASED_ON:处罚依据
        /// DESCRIPTION:处罚判决书
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
