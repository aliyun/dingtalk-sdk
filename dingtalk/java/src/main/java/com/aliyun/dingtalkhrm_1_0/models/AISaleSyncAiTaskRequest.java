// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleSyncAiTaskRequest extends TeaModel {
    @NameInMap("scenarioCode")
    public String scenarioCode;

    @NameInMap("userId")
    public String userId;

    @NameInMap("userPrompt")
    public String userPrompt;

    @NameInMap("variables")
    public java.util.Map<String, ?> variables;

    public static AISaleSyncAiTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        AISaleSyncAiTaskRequest self = new AISaleSyncAiTaskRequest();
        return TeaModel.build(map, self);
    }

    public AISaleSyncAiTaskRequest setScenarioCode(String scenarioCode) {
        this.scenarioCode = scenarioCode;
        return this;
    }
    public String getScenarioCode() {
        return this.scenarioCode;
    }

    public AISaleSyncAiTaskRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public AISaleSyncAiTaskRequest setUserPrompt(String userPrompt) {
        this.userPrompt = userPrompt;
        return this;
    }
    public String getUserPrompt() {
        return this.userPrompt;
    }

    public AISaleSyncAiTaskRequest setVariables(java.util.Map<String, ?> variables) {
        this.variables = variables;
        return this;
    }
    public java.util.Map<String, ?> getVariables() {
        return this.variables;
    }

}
