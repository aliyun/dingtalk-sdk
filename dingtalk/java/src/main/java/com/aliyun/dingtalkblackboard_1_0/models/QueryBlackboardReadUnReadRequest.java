// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkblackboard_1_0.models;

import com.aliyun.tea.*;

public class QueryBlackboardReadUnReadRequest extends TeaModel {
    @NameInMap("blackboardId")
    public String blackboardId;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("operationUserId")
    public String operationUserId;

    public static QueryBlackboardReadUnReadRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryBlackboardReadUnReadRequest self = new QueryBlackboardReadUnReadRequest();
        return TeaModel.build(map, self);
    }

    public QueryBlackboardReadUnReadRequest setBlackboardId(String blackboardId) {
        this.blackboardId = blackboardId;
        return this;
    }
    public String getBlackboardId() {
        return this.blackboardId;
    }

    public QueryBlackboardReadUnReadRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryBlackboardReadUnReadRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryBlackboardReadUnReadRequest setOperationUserId(String operationUserId) {
        this.operationUserId = operationUserId;
        return this;
    }
    public String getOperationUserId() {
        return this.operationUserId;
    }

}
