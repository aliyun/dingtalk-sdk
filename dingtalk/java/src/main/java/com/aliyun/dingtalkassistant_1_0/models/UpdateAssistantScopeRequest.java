// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class UpdateAssistantScopeRequest extends TeaModel {
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

    @NameInMap("sharing")
    public Boolean sharing;

    public static UpdateAssistantScopeRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateAssistantScopeRequest self = new UpdateAssistantScopeRequest();
        return TeaModel.build(map, self);
    }

    public UpdateAssistantScopeRequest setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public UpdateAssistantScopeRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

    public UpdateAssistantScopeRequest setSharing(Boolean sharing) {
        this.sharing = sharing;
        return this;
    }
    public Boolean getSharing() {
        return this.sharing;
    }

}
