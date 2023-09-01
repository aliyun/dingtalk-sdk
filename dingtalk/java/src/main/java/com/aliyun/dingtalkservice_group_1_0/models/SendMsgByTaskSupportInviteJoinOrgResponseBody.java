// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SendMsgByTaskSupportInviteJoinOrgResponseBody extends TeaModel {
    @NameInMap("openBatchTaskId")
    public String openBatchTaskId;

    public static SendMsgByTaskSupportInviteJoinOrgResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendMsgByTaskSupportInviteJoinOrgResponseBody self = new SendMsgByTaskSupportInviteJoinOrgResponseBody();
        return TeaModel.build(map, self);
    }

    public SendMsgByTaskSupportInviteJoinOrgResponseBody setOpenBatchTaskId(String openBatchTaskId) {
        this.openBatchTaskId = openBatchTaskId;
        return this;
    }
    public String getOpenBatchTaskId() {
        return this.openBatchTaskId;
    }

}
