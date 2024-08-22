// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class DeleteAssistantRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("assistantId")
    public String assistantId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    public static DeleteAssistantRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteAssistantRequest self = new DeleteAssistantRequest();
        return TeaModel.build(map, self);
    }

    public DeleteAssistantRequest setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public DeleteAssistantRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

}
