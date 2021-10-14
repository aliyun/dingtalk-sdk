// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushIntelligentRobotMessageResponseBody extends TeaModel {
    // 推送queryKey
    @NameInMap("result")
    public String result;

    public static PushIntelligentRobotMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PushIntelligentRobotMessageResponseBody self = new PushIntelligentRobotMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public PushIntelligentRobotMessageResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
