// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class ExecuteRobotAiSkillResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("skillExecuteId")
    public String skillExecuteId;

    public static ExecuteRobotAiSkillResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExecuteRobotAiSkillResponseBody self = new ExecuteRobotAiSkillResponseBody();
        return TeaModel.build(map, self);
    }

    public ExecuteRobotAiSkillResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public ExecuteRobotAiSkillResponseBody setSkillExecuteId(String skillExecuteId) {
        this.skillExecuteId = skillExecuteId;
        return this;
    }
    public String getSkillExecuteId() {
        return this.skillExecuteId;
    }

}
