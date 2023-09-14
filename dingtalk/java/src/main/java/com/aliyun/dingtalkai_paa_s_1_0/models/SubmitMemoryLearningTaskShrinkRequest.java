// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SubmitMemoryLearningTaskShrinkRequest extends TeaModel {
    @NameInMap("agentCode")
    public String agentCode;

    @NameInMap("content")
    public String contentShrink;

    @NameInMap("learningMode")
    public String learningMode;

    @NameInMap("memoryKey")
    public String memoryKey;

    public static SubmitMemoryLearningTaskShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        SubmitMemoryLearningTaskShrinkRequest self = new SubmitMemoryLearningTaskShrinkRequest();
        return TeaModel.build(map, self);
    }

    public SubmitMemoryLearningTaskShrinkRequest setAgentCode(String agentCode) {
        this.agentCode = agentCode;
        return this;
    }
    public String getAgentCode() {
        return this.agentCode;
    }

    public SubmitMemoryLearningTaskShrinkRequest setContentShrink(String contentShrink) {
        this.contentShrink = contentShrink;
        return this;
    }
    public String getContentShrink() {
        return this.contentShrink;
    }

    public SubmitMemoryLearningTaskShrinkRequest setLearningMode(String learningMode) {
        this.learningMode = learningMode;
        return this;
    }
    public String getLearningMode() {
        return this.learningMode;
    }

    public SubmitMemoryLearningTaskShrinkRequest setMemoryKey(String memoryKey) {
        this.memoryKey = memoryKey;
        return this;
    }
    public String getMemoryKey() {
        return this.memoryKey;
    }

}
