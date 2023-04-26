// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class ManageSingleChatRobotStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static ManageSingleChatRobotStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ManageSingleChatRobotStatusResponseBody self = new ManageSingleChatRobotStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public ManageSingleChatRobotStatusResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
