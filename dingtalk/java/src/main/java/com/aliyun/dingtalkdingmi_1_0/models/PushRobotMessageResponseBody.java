// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushRobotMessageResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static PushRobotMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PushRobotMessageResponseBody self = new PushRobotMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public PushRobotMessageResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
