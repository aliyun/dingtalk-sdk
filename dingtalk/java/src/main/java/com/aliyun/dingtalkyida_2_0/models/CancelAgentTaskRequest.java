// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class CancelAgentTaskRequest extends TeaModel {
    @NameInMap("agentType")
    public String agentType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("agentUuid")
    public String agentUuid;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingxxxx</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("token")
    public String token;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>501453</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CancelAgentTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelAgentTaskRequest self = new CancelAgentTaskRequest();
        return TeaModel.build(map, self);
    }

    public CancelAgentTaskRequest setAgentType(String agentType) {
        this.agentType = agentType;
        return this;
    }
    public String getAgentType() {
        return this.agentType;
    }

    public CancelAgentTaskRequest setAgentUuid(String agentUuid) {
        this.agentUuid = agentUuid;
        return this;
    }
    public String getAgentUuid() {
        return this.agentUuid;
    }

    public CancelAgentTaskRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CancelAgentTaskRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

    public CancelAgentTaskRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
