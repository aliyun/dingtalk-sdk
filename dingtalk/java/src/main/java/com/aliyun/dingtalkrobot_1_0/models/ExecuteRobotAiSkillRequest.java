// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class ExecuteRobotAiSkillRequest extends TeaModel {
    @NameInMap("context")
    public java.util.Map<String, ?> context;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("input")
    public String input;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    @NameInMap("skillId")
    public String skillId;

    public static ExecuteRobotAiSkillRequest build(java.util.Map<String, ?> map) throws Exception {
        ExecuteRobotAiSkillRequest self = new ExecuteRobotAiSkillRequest();
        return TeaModel.build(map, self);
    }

    public ExecuteRobotAiSkillRequest setContext(java.util.Map<String, ?> context) {
        this.context = context;
        return this;
    }
    public java.util.Map<String, ?> getContext() {
        return this.context;
    }

    public ExecuteRobotAiSkillRequest setInput(String input) {
        this.input = input;
        return this;
    }
    public String getInput() {
        return this.input;
    }

    public ExecuteRobotAiSkillRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public ExecuteRobotAiSkillRequest setSkillId(String skillId) {
        this.skillId = skillId;
        return this;
    }
    public String getSkillId() {
        return this.skillId;
    }

}
