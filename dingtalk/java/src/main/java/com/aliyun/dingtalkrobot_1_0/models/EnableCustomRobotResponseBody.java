// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class EnableCustomRobotResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static EnableCustomRobotResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EnableCustomRobotResponseBody self = new EnableCustomRobotResponseBody();
        return TeaModel.build(map, self);
    }

    public EnableCustomRobotResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
