// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class RetrieveAssistantScopeResponseBody extends TeaModel {
    @NameInMap("assistantId")
    public String assistantId;

    @NameInMap("sharing")
    public Boolean sharing;

    public static RetrieveAssistantScopeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RetrieveAssistantScopeResponseBody self = new RetrieveAssistantScopeResponseBody();
        return TeaModel.build(map, self);
    }

    public RetrieveAssistantScopeResponseBody setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public RetrieveAssistantScopeResponseBody setSharing(Boolean sharing) {
        this.sharing = sharing;
        return this;
    }
    public Boolean getSharing() {
        return this.sharing;
    }

}
