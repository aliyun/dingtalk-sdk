// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomerTaskUserDetailRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <strong>example:</strong>
     * <p>8888</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>8888</p>
     */
    @NameInMap("openBatchTaskId")
    public String openBatchTaskId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>8888</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    @NameInMap("receiverUnionIds")
    public java.util.List<String> receiverUnionIds;

    public static QueryCustomerTaskUserDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomerTaskUserDetailRequest self = new QueryCustomerTaskUserDetailRequest();
        return TeaModel.build(map, self);
    }

    public QueryCustomerTaskUserDetailRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QueryCustomerTaskUserDetailRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryCustomerTaskUserDetailRequest setOpenBatchTaskId(String openBatchTaskId) {
        this.openBatchTaskId = openBatchTaskId;
        return this;
    }
    public String getOpenBatchTaskId() {
        return this.openBatchTaskId;
    }

    public QueryCustomerTaskUserDetailRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public QueryCustomerTaskUserDetailRequest setReceiverUnionIds(java.util.List<String> receiverUnionIds) {
        this.receiverUnionIds = receiverUnionIds;
        return this;
    }
    public java.util.List<String> getReceiverUnionIds() {
        return this.receiverUnionIds;
    }

}
