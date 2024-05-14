// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class QueryMemoryLearningTaskRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("agentCode")
    public String agentCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("learningCode")
    public String learningCode;

    public static QueryMemoryLearningTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMemoryLearningTaskRequest self = new QueryMemoryLearningTaskRequest();
        return TeaModel.build(map, self);
    }

    public QueryMemoryLearningTaskRequest setAgentCode(String agentCode) {
        this.agentCode = agentCode;
        return this;
    }
    public String getAgentCode() {
        return this.agentCode;
    }

    public QueryMemoryLearningTaskRequest setLearningCode(String learningCode) {
        this.learningCode = learningCode;
        return this;
    }
    public String getLearningCode() {
        return this.learningCode;
    }

}
