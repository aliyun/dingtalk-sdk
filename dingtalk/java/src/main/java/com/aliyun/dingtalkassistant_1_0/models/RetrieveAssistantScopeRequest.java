// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class RetrieveAssistantScopeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("assistantId")
    public String assistantId;

    public static RetrieveAssistantScopeRequest build(java.util.Map<String, ?> map) throws Exception {
        RetrieveAssistantScopeRequest self = new RetrieveAssistantScopeRequest();
        return TeaModel.build(map, self);
    }

    public RetrieveAssistantScopeRequest setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

}
