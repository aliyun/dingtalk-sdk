// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetAttachmentSpaceRequest extends TeaModel {
    @NameInMap("agentId")
    public Long agentId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetAttachmentSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAttachmentSpaceRequest self = new GetAttachmentSpaceRequest();
        return TeaModel.build(map, self);
    }

    public GetAttachmentSpaceRequest setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public GetAttachmentSpaceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
