// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class ManageSingleChatRobotStatusRequest extends TeaModel {
    // 钉钉开放平台后台机器人的robotCode
    @NameInMap("robotCode")
    public String robotCode;

    // 机器人的可用状态，enable-启用、disable-停用
    @NameInMap("status")
    public String status;

    public static ManageSingleChatRobotStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        ManageSingleChatRobotStatusRequest self = new ManageSingleChatRobotStatusRequest();
        return TeaModel.build(map, self);
    }

    public ManageSingleChatRobotStatusRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public ManageSingleChatRobotStatusRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
