// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesTextRequest extends TeaModel {
    @NameInMap("direction")
    public Integer direction;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryMinutesTextRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesTextRequest self = new QueryMinutesTextRequest();
        return TeaModel.build(map, self);
    }

    public QueryMinutesTextRequest setDirection(Integer direction) {
        this.direction = direction;
        return this;
    }
    public Integer getDirection() {
        return this.direction;
    }

    public QueryMinutesTextRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
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
