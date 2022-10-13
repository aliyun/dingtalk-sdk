// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class ClearRobotPluginRequest extends TeaModel {
    // 钉钉开放平台后台机器人的robotCode
    @NameInMap("robotCode")
    public String robotCode;

    public static ClearRobotPluginRequest build(java.util.Map<String, ?> map) throws Exception {
        ClearRobotPluginRequest self = new ClearRobotPluginRequest();
        return TeaModel.build(map, self);
    }

    public ClearRobotPluginRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
