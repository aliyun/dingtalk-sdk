// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class SendRobotMessageResponseBody extends TeaModel {
    @NameInMap("openMsgId")
    public String openMsgId;

    public static SendRobotMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendRobotMessageResponseBody self = new SendRobotMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public SendRobotMessageResponseBody setOpenMsgId(String openMsgId) {
        this.openMsgId = openMsgId;
        return this;
    }
    public String getOpenMsgId() {
        return this.openMsgId;
    }

}
