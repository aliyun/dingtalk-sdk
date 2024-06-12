// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesTextRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("direction")
    public String direction;

    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("unionId")
    public String unionId;

    public static QueryMinutesTextRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesTextRequest self = new QueryMinutesTextRequest();
        return TeaModel.build(map, self);
    }

    public QueryMinutesTextRequest setDirection(String direction) {
        this.direction = direction;
        return this;
    }
    public String getDirection() {
        return this.direction;
    }

    public QueryMinutesTextRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QueryMinutesTextRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryMinutesTextRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
