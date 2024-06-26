// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class QueryCandidatesRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <strong>example:</strong>
     * <p>154XXX</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>entry</p>
     */
    @NameInMap("statId")
    public String statId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>013224566462XXXXXXXXXX</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static QueryCandidatesRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCandidatesRequest self = new QueryCandidatesRequest();
        return TeaModel.build(map, self);
    }

    public QueryCandidatesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryCandidatesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryCandidatesRequest setStatId(String statId) {
        this.statId = statId;
        return this;
    }
    public String getStatId() {
        return this.statId;
    }

    public QueryCandidatesRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
