// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class ExecuteAgentRequest extends TeaModel {
    @NameInMap("agentCode")
    public String agentCode;

    @NameInMap("inputs")
    public ExecuteAgentRequestInputs inputs;

    @NameInMap("scenarioCode")
    public String scenarioCode;

    @NameInMap("scenarioInstanceId")
    public String scenarioInstanceId;

    @NameInMap("skillId")
    public String skillId;

    public static ExecuteAgentRequest build(java.util.Map<String, ?> map) throws Exception {
        ExecuteAgentRequest self = new ExecuteAgentRequest();
        return TeaModel.build(map, self);
    }

    public ExecuteAgentRequest setAgentCode(String agentCode) {
        this.agentCode = agentCode;
        return this;
    }
    public String getAgentCode() {
        return this.agentCode;
    }

    public ExecuteAgentRequest setInputs(ExecuteAgentRequestInputs inputs) {
        this.inputs = inputs;
        return this;
    }
    public ExecuteAgentRequestInputs getInputs() {
        return this.inputs;
    }

    public ExecuteAgentRequest setScenarioCode(String scenarioCode) {
        this.scenarioCode = scenarioCode;
        return this;
    }
    public String getScenarioCode() {
        return this.scenarioCode;
    }

    public ExecuteAgentRequest setScenarioInstanceId(String scenarioInstanceId) {
        this.scenarioInstanceId = scenarioInstanceId;
        return this;
    }
    public String getScenarioInstanceId() {
        return this.scenarioInstanceId;
    }

    public ExecuteAgentRequest setSkillId(String skillId) {
        this.skillId = skillId;
        return this;
    }
    public String getSkillId() {
        return this.skillId;
    }

    public static class ExecuteAgentRequestInputs extends TeaModel {
        @NameInMap("cardData")
        public Object cardData;

        @NameInMap("cardTemplateId")
        public String cardTemplateId;

        @NameInMap("input")
        public String input;

        public static ExecuteAgentRequestInputs build(java.util.Map<String, ?> map) throws Exception {
            ExecuteAgentRequestInputs self = new ExecuteAgentRequestInputs();
            return TeaModel.build(map, self);
        }

        public ExecuteAgentRequestInputs setCardData(Object cardData) {
            this.cardData = cardData;
            return this;
        }
        public Object getCardData() {
            return this.cardData;
        }

        public ExecuteAgentRequestInputs setCardTemplateId(String cardTemplateId) {
            this.cardTemplateId = cardTemplateId;
            return this;
        }
        public String getCardTemplateId() {
            return this.cardTemplateId;
        }

        public ExecuteAgentRequestInputs setInput(String input) {
            this.input = input;
            return this;
        }
        public String getInput() {
            return this.input;
        }

    }

}
