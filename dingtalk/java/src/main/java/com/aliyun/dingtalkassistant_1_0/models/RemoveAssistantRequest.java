// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class RemoveAssistantRequest extends TeaModel {
    @NameInMap("assistantId")
    public String assistantId;

    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    public static RemoveAssistantRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveAssistantRequest self = new RemoveAssistantRequest();
        return TeaModel.build(map, self);
    }

    public RemoveAssistantRequest setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public RemoveAssistantRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

}
