// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class GetAgentTasksRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>Agent--XXXXX</p>
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
     * <p>10001</p>
     */
    @NameInMap("keywords")
    public String keywords;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>ALL</p>
     */
    @NameInMap("status")
    public String status;

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

    public static GetAgentTasksRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAgentTasksRequest self = new GetAgentTasksRequest();
        return TeaModel.build(map, self);
    }

    public GetAgentTasksRequest setAgentUuid(String agentUuid) {
        this.agentUuid = agentUuid;
        return this;
    }
    public String getAgentUuid() {
        return this.agentUuid;
    }

    public GetAgentTasksRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetAgentTasksRequest setKeywords(String keywords) {
        this.keywords = keywords;
        return this;
    }
    public String getKeywords() {
        return this.keywords;
    }

    public GetAgentTasksRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetAgentTasksRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetAgentTasksRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public GetAgentTasksRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

    public GetAgentTasksRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
