// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class RelearnKnowledgeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("assistantId")
    public String assistantId;

    public static RelearnKnowledgeRequest build(java.util.Map<String, ?> map) throws Exception {
        RelearnKnowledgeRequest self = new RelearnKnowledgeRequest();
        return TeaModel.build(map, self);
    }

    public RelearnKnowledgeRequest setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

}
