// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetUserCreateLiveListRequest extends TeaModel {
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("statuses")
    public java.util.List<Long> statuses;

    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetUserCreateLiveListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserCreateLiveListRequest self = new GetUserCreateLiveListRequest();
        return TeaModel.build(map, self);
    }

    public GetUserCreateLiveListRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public GetUserCreateLiveListRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetUserCreateLiveListRequest setStatuses(java.util.List<Long> statuses) {
        this.statuses = statuses;
        return this;
    }
    public java.util.List<Long> getStatuses() {
        return this.statuses;
    }

    public GetUserCreateLiveListRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public GetUserCreateLiveListRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetUserCreateLiveListRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetUserCreateLiveListRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
