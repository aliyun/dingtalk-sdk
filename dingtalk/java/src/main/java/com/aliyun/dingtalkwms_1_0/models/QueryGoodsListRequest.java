// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwms_1_0.models;

import com.aliyun.tea.*;

public class QueryGoodsListRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1631289600000</p>
     */
    @NameInMap("endTimeInMills")
    public Long endTimeInMills;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <strong>example:</strong>
     * <p>1631289600000</p>
     */
    @NameInMap("startTimeInMills")
    public Long startTimeInMills;

    public static QueryGoodsListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGoodsListRequest self = new QueryGoodsListRequest();
        return TeaModel.build(map, self);
    }

    public QueryGoodsListRequest setEndTimeInMills(Long endTimeInMills) {
        this.endTimeInMills = endTimeInMills;
        return this;
    }
    public Long getEndTimeInMills() {
        return this.endTimeInMills;
    }

    public QueryGoodsListRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QueryGoodsListRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public QueryGoodsListRequest setStartTimeInMills(Long startTimeInMills) {
        this.startTimeInMills = startTimeInMills;
        return this;
    }
    public Long getStartTimeInMills() {
        return this.startTimeInMills;
    }

}
