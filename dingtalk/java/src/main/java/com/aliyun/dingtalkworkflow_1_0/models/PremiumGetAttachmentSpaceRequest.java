// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetAttachmentSpaceRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>8345000</p>
     */
    @NameInMap("agentId")
    public Long agentId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user123</p>
     */
    @NameInMap("userId")
    public String userId;

    public static PremiumGetAttachmentSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetAttachmentSpaceRequest self = new PremiumGetAttachmentSpaceRequest();
        return TeaModel.build(map, self);
    }

    public PremiumGetAttachmentSpaceRequest setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public PremiumGetAttachmentSpaceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
