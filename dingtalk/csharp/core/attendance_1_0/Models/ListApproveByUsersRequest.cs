// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ListApproveByUsersRequest : TeaModel {
        /// <summary>
        /// 传入需要查询的审批单类型：
        /// ● 1：加班
        /// ● 2：出差、外出
        /// ● 3：请假
        /// ● 4:  补卡
        /// ● 5：外勤审批
        /// </summary>
        [NameInMap("bizTypes")]
        [Validation(Required=false)]
        public List<int?> BizTypes { get; set; }

        /// <summary>
        /// 起始日期，Unix时间戳，单位毫秒。（不支持180天前）
        /// </summary>
        [NameInMap("fromDateTime")]
        [Validation(Required=false)]
        public long? FromDateTime { get; set; }

        /// <summary>
        /// 结束日期，Unix时间戳，单位毫秒。（不支持180天前，开始和结束不能超过30天）
        /// </summary>
        [NameInMap("toDateTime")]
        [Validation(Required=false)]
        public long? ToDateTime { get; set; }

        /// <summary>
        /// 要查询的人员userId列表，多个userId用逗号分隔，一次最多可传50个
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

    }

}
