// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class PagePointHistoryRequest extends TeaModel {
    // 是否查询全员圈积分
    @NameInMap("isCircle")
    public Boolean isCircle;

    // 用户userid，可空，不传表示查询组织内所有用户的流水数据
    @NameInMap("userId")
    public String userId;

    // 用来标记当前开始读取的位置
    @NameInMap("nextToken")
    public Long nextToken;

    // 本次读取的最大数据记录数量，最大20
    @NameInMap("maxResults")
    public Integer maxResults;

    // 起始时间Unix时间戳，可空
    @NameInMap("startTime")
    public Long startTime;

    // 结束时间Unix时间戳（不包含），可空
    @NameInMap("endTime")
    public Long endTime;

    public static PagePointHistoryRequest build(java.util.Map<String, ?> map) throws Exception {
        PagePointHistoryRequest self = new PagePointHistoryRequest();
        return TeaModel.build(map, self);
    }

    public PagePointHistoryRequest setIsCircle(Boolean isCircle) {
        this.isCircle = isCircle;
        return this;
    }
    public Boolean getIsCircle() {
        return this.isCircle;
    }

    public PagePointHistoryRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public PagePointHistoryRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public PagePointHistoryRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public PagePointHistoryRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public PagePointHistoryRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

}
