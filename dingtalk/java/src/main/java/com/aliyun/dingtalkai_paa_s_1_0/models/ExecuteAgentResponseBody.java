// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class ExecuteAgentResponseBody extends TeaModel {
    @NameInMap("result")
    public ExecuteAgentResponseBodyResult result;

    public static ExecuteAgentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExecuteAgentResponseBody self = new ExecuteAgentResponseBody();
        return TeaModel.build(map, self);
    }

    public ExecuteAgentResponseBody setResult(ExecuteAgentResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ExecuteAgentResponseBodyResult getResult() {
        return this.result;
    }

    public static class ExecuteAgentResponseBodyResult extends TeaModel {
        @NameInMap("executeResult")
        public String executeResult;

        @NameInMap("skillId")
        public String skillId;

        public static ExecuteAgentResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ExecuteAgentResponseBodyResult self = new ExecuteAgentResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ExecuteAgentResponseBodyResult setExecuteResult(String executeResult) {
            this.executeResult = executeResult;
            return this;
        }
        public String getExecuteResult() {
            return this.executeResult;
        }

        public ExecuteAgentResponseBodyResult setSkillId(String skillId) {
            this.skillId = skillId;
            return this;
        }
        public String getSkillId() {
            return this.skillId;
        }

    }

}
