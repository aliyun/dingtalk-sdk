// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetEnvironmentalPenaltiesResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// DEPARTMENT:处罚单位
        /// ENT_NAME:企业名称
        /// EXEC_STATUS 执行情况
        /// PUNISH_BASIS:处罚依据
        /// PUNISH_CONTENT:处罚事由
        /// PUNISH_LAW:违反法律
        /// PUNISH_NUM:决定文书号
        /// PUNISH_RES:处罚结果
        /// PUNISH_DATE:处罚时间
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
