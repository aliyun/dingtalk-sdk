// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushIntelligentRobotGroupMessageResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1234</p>
     */
    @NameInMap("result")
    public String result;

    public static PushIntelligentRobotGroupMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PushIntelligentRobotGroupMessageResponseBody self = new PushIntelligentRobotGroupMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public PushIntelligentRobotGroupMessageResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
