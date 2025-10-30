// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class CreateAgentTaskRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>EXECUTE</p>
     */
    @NameInMap("agentCategory")
    public String agentCategory;

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
     * <p>ALL</p>
     */
    @NameInMap("agentType")
    public String agentType;

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
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10002</p>
     */
    @NameInMap("principalUserId")
    public String principalUserId;

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

    public static CreateAgentTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateAgentTaskRequest self = new CreateAgentTaskRequest();
        return TeaModel.build(map, self);
    }

    public CreateAgentTaskRequest setAgentCategory(String agentCategory) {
        this.agentCategory = agentCategory;
        return this;
    }
    public String getAgentCategory() {
        return this.agentCategory;
    }

    public CreateAgentTaskRequest setAgentRangeType(String agentRangeType) {
        this.agentRangeType = agentRangeType;
        return this;
    }
    public String getAgentRangeType() {
        return this.agentRangeType;
    }

    public CreateAgentTaskRequest setAgentRangeValue(String agentRangeValue) {
        this.agentRangeValue = agentRangeValue;
        return this;
    }
    public String getAgentRangeValue() {
        return this.agentRangeValue;
    }

    public CreateAgentTaskRequest setAgentType(String agentType) {
        this.agentType = agentType;
        return this;
    }
    public String getAgentType() {
        return this.agentType;
    }

    public CreateAgentTaskRequest setAgentUserId(String agentUserId) {
        this.agentUserId = agentUserId;
        return this;
    }
    public String getAgentUserId() {
        return this.agentUserId;
    }

    public CreateAgentTaskRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateAgentTaskRequest setEndTimestamp(String endTimestamp) {
        this.endTimestamp = endTimestamp;
        return this;
    }
    public String getEndTimestamp() {
        return this.endTimestamp;
    }

    public CreateAgentTaskRequest setNeedNoticePrincipal(String needNoticePrincipal) {
        this.needNoticePrincipal = needNoticePrincipal;
        return this;
    }
    public String getNeedNoticePrincipal() {
        return this.needNoticePrincipal;
    }

    public CreateAgentTaskRequest setPrincipalUserId(String principalUserId) {
        this.principalUserId = principalUserId;
        return this;
    }
    public String getPrincipalUserId() {
        return this.principalUserId;
    }

    public CreateAgentTaskRequest setStartTimestamp(String startTimestamp) {
        this.startTimestamp = startTimestamp;
        return this;
    }
    public String getStartTimestamp() {
        return this.startTimestamp;
    }

    public CreateAgentTaskRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

    public CreateAgentTaskRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
