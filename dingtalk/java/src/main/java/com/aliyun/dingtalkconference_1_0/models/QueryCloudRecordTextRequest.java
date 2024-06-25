// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryCloudRecordTextRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("direction")
    public String direction;

    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("unionId")
    public String unionId;

    public static QueryCloudRecordTextRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCloudRecordTextRequest self = new QueryCloudRecordTextRequest();
        return TeaModel.build(map, self);
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

    public QueryCloudRecordTextRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public QueryCloudRecordTextRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
