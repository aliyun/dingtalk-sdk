// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SubmitMemoryLearningTaskRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("agentCode")
    public String agentCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public SubmitMemoryLearningTaskRequestContent content;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("learningMode")
    public String learningMode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("memoryKey")
    public String memoryKey;

    public static SubmitMemoryLearningTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        SubmitMemoryLearningTaskRequest self = new SubmitMemoryLearningTaskRequest();
        return TeaModel.build(map, self);
    }

    public SubmitMemoryLearningTaskRequest setAgentCode(String agentCode) {
        this.agentCode = agentCode;
        return this;
    }
    public String getAgentCode() {
        return this.agentCode;
    }

    public SubmitMemoryLearningTaskRequest setContent(SubmitMemoryLearningTaskRequestContent content) {
        this.content = content;
        return this;
    }
    public SubmitMemoryLearningTaskRequestContent getContent() {
        return this.content;
    }

    public SubmitMemoryLearningTaskRequest setLearningMode(String learningMode) {
        this.learningMode = learningMode;
        return this;
    }
    public String getLearningMode() {
        return this.learningMode;
    }

    public SubmitMemoryLearningTaskRequest setMemoryKey(String memoryKey) {
        this.memoryKey = memoryKey;
        return this;
    }
    public String getMemoryKey() {
        return this.memoryKey;
    }

    public static class SubmitMemoryLearningTaskRequestContent extends TeaModel {
        @NameInMap("knowledgeBaseUrl")
        public String knowledgeBaseUrl;

        @NameInMap("type")
        public String type;

        public static SubmitMemoryLearningTaskRequestContent build(java.util.Map<String, ?> map) throws Exception {
            SubmitMemoryLearningTaskRequestContent self = new SubmitMemoryLearningTaskRequestContent();
            return TeaModel.build(map, self);
        }

        public SubmitMemoryLearningTaskRequestContent setKnowledgeBaseUrl(String knowledgeBaseUrl) {
            this.knowledgeBaseUrl = knowledgeBaseUrl;
            return this;
        }
        public String getKnowledgeBaseUrl() {
            return this.knowledgeBaseUrl;
        }

        public SubmitMemoryLearningTaskRequestContent setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
