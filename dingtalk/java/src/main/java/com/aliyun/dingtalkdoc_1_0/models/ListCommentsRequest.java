// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class ListCommentsRequest extends TeaModel {
    @NameInMap("isGlobal")
    public Boolean isGlobal;

    @NameInMap("isSolved")
    public Boolean isSolved;

    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <strong>example:</strong>
     * <p>next_token</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static ListCommentsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListCommentsRequest self = new ListCommentsRequest();
        return TeaModel.build(map, self);
    }

    public ListCommentsRequest setIsGlobal(Boolean isGlobal) {
        this.isGlobal = isGlobal;
        return this;
    }
    public Boolean getIsGlobal() {
        return this.isGlobal;
    }

    public ListCommentsRequest setIsSolved(Boolean isSolved) {
        this.isSolved = isSolved;
        return this;
    }
    public Boolean getIsSolved() {
        return this.isSolved;
    }

    public ListCommentsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListCommentsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListCommentsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
