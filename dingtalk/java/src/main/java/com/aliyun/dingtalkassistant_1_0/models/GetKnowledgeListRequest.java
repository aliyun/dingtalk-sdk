// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class GetKnowledgeListRequest extends TeaModel {
    @NameInMap("assistantId")
    public String assistantId;

    public static GetKnowledgeListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetKnowledgeListRequest self = new GetKnowledgeListRequest();
        return TeaModel.build(map, self);
    }

    public GetKnowledgeListRequest setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

}
