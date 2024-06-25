// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class LearnKnowledgeRequest extends TeaModel {
    @NameInMap("assistantId")
    public String assistantId;

    @NameInMap("docUrl")
    public String docUrl;

    public static LearnKnowledgeRequest build(java.util.Map<String, ?> map) throws Exception {
        LearnKnowledgeRequest self = new LearnKnowledgeRequest();
        return TeaModel.build(map, self);
    }

    public LearnKnowledgeRequest setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public LearnKnowledgeRequest setDocUrl(String docUrl) {
        this.docUrl = docUrl;
        return this;
    }
    public String getDocUrl() {
        return this.docUrl;
    }

}
