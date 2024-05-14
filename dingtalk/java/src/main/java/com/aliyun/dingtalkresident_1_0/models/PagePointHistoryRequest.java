// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class PagePointHistoryRequest extends TeaModel {
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("isCircle")
    public Boolean isCircle;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("userId")
    public String userId;

    public static PagePointHistoryRequest build(java.util.Map<String, ?> map) throws Exception {
        PagePointHistoryRequest self = new PagePointHistoryRequest();
        return TeaModel.build(map, self);
    }

    public PagePointHistoryRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public PagePointHistoryRequest setIsCircle(Boolean isCircle) {
        this.isCircle = isCircle;
        return this;
    }
    public Boolean getIsCircle() {
        return this.isCircle;
    }

    public PagePointHistoryRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public PagePointHistoryRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public PagePointHistoryRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public PagePointHistoryRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
