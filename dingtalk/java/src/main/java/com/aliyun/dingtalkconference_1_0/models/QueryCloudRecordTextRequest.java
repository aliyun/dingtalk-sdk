// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryCloudRecordTextRequest extends TeaModel {
    // 用户id
    @NameInMap("unionId")
    public String unionId;

    // 开始时间
    @NameInMap("startTime")
    public Long startTime;

    // 0-向前查询，1-向后查询 。 向前查询：此次查询按照时间由小到大的顺序进行。
    @NameInMap("direction")
    public String direction;

    // 单页查询的最大条目数，最多2000
    @NameInMap("maxResults")
    public Long maxResults;

    // 游标，第一次查询可为空，之后每次带上一次的游标
    @NameInMap("nextToken")
    public Long nextToken;

    public static QueryCloudRecordTextRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCloudRecordTextRequest self = new QueryCloudRecordTextRequest();
        return TeaModel.build(map, self);
    }

    public QueryCloudRecordTextRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public QueryCloudRecordTextRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public QueryCloudRecordTextRequest setDirection(String direction) {
        this.direction = direction;
        return this;
    }
    public String getDirection() {
        return this.direction;
    }

    public QueryCloudRecordTextRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QueryCloudRecordTextRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
