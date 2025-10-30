// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class UpdateAgentTaskRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ALL</p>
     */
    @NameInMap("agentRangeType")
    public String agentRangeType;

    /**
     * <strong>example:</strong>
     * <p>[{&quot;appType&quot;:&quot;APP_xxx&quot;,&quot;formUuid&quot;:&quot;FORM-xxx&quot;}]</p>
     */
    @NameInMap("agentRangeValue")
    public String agentRangeValue;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10001</p>
     */
    @NameInMap("agentUserId")
    public String agentUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>Agent--xxxxx</p>
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
     * <strong>example:</strong>
     * <p>1761204600404</p>
     */
    @NameInMap("endTimestamp")
    public String endTimestamp;

    @NameInMap("needNoticePrincipal")
    public String needNoticePrincipal;

    /**
     * <strong>example:</strong>
     * <p>1761204600404</p>
     */
    @NameInMap("startTimestamp")
    public String startTimestamp;

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

    public static UpdateAgentTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateAgentTaskRequest self = new UpdateAgentTaskRequest();
        return TeaModel.build(map, self);
    }

    public UpdateAgentTaskRequest setAgentRangeType(String agentRangeType) {
        this.agentRangeType = agentRangeType;
        return this;
    }
    public String getAgentRangeType() {
        return this.agentRangeType;
    }

    public UpdateAgentTaskRequest setAgentRangeValue(String agentRangeValue) {
        this.agentRangeValue = agentRangeValue;
        return this;
    }
    public String getAgentRangeValue() {
        return this.agentRangeValue;
    }

    public UpdateAgentTaskRequest setAgentUserId(String agentUserId) {
        this.agentUserId = agentUserId;
        return this;
    }
    public String getAgentUserId() {
        return this.agentUserId;
    }

    public UpdateAgentTaskRequest setAgentUuid(String agentUuid) {
        this.agentUuid = agentUuid;
        return this;
    }
    public String getAgentUuid() {
        return this.agentUuid;
    }

    public UpdateAgentTaskRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public UpdateAgentTaskRequest setEndTimestamp(String endTimestamp) {
        this.endTimestamp = endTimestamp;
        return this;
    }
    public String getEndTimestamp() {
        return this.endTimestamp;
    }

    public UpdateAgentTaskRequest setNeedNoticePrincipal(String needNoticePrincipal) {
        this.needNoticePrincipal = needNoticePrincipal;
        return this;
    }
    public String getNeedNoticePrincipal() {
        return this.needNoticePrincipal;
    }

    public UpdateAgentTaskRequest setStartTimestamp(String startTimestamp) {
        this.startTimestamp = startTimestamp;
        return this;
    }
    public String getStartTimestamp() {
        return this.startTimestamp;
    }

    public UpdateAgentTaskRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

    public UpdateAgentTaskRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
