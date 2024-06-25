// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class DeleteKnowledgeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("assistantId")
    public String assistantId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("studyId")
    public String studyId;

    public static DeleteKnowledgeRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteKnowledgeRequest self = new DeleteKnowledgeRequest();
        return TeaModel.build(map, self);
    }

    public DeleteKnowledgeRequest setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public DeleteKnowledgeRequest setStudyId(String studyId) {
        this.studyId = studyId;
        return this;
    }
    public String getStudyId() {
        return this.studyId;
    }

}
