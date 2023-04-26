// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class ClearRobotPluginResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static ClearRobotPluginResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ClearRobotPluginResponseBody self = new ClearRobotPluginResponseBody();
        return TeaModel.build(map, self);
    }

    public ClearRobotPluginResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
