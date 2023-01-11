// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class RobotMessageRecallResponseBody extends TeaModel {
    /**
     * <p>撤回成功的消息ID，失败时为空</p>
     */
    @NameInMap("result")
    public String result;

    public static RobotMessageRecallResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RobotMessageRecallResponseBody self = new RobotMessageRecallResponseBody();
        return TeaModel.build(map, self);
    }

    public RobotMessageRecallResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
