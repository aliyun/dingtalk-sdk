// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class SendRobotDingMessageResponseBody extends TeaModel {
    /**
     * <p>返回的ding消息id</p>
     */
    @NameInMap("dingSendResultId")
    public String dingSendResultId;

    public static SendRobotDingMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendRobotDingMessageResponseBody self = new SendRobotDingMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public SendRobotDingMessageResponseBody setDingSendResultId(String dingSendResultId) {
        this.dingSendResultId = dingSendResultId;
        return this;
    }
    public String getDingSendResultId() {
        return this.dingSendResultId;
    }

}
