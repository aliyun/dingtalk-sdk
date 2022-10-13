// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class SetRobotPluginResponseBody extends TeaModel {
    // 是否成功设置机器人插件
    @NameInMap("result")
    public Boolean result;

    public static SetRobotPluginResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetRobotPluginResponseBody self = new SetRobotPluginResponseBody();
        return TeaModel.build(map, self);
    }

    public SetRobotPluginResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
