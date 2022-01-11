// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListEventsRequest extends TeaModel {
    // 查询返回结果数
    @NameInMap("maxResults")
    public Long maxResults;

    // 查询翻页token
    @NameInMap("nextToken")
    public String nextToken;

    // 是否返回删除事件
    @NameInMap("showDeleted")
    public Boolean showDeleted;

    // 增量查询token
    @NameInMap("syncToken")
    public String syncToken;

    // 查询截止时间
    @NameInMap("timeMax")
    public String timeMax;

    // 查询开始时间
    @NameInMap("timeMin")
    public String timeMin;

    public static ListEventsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListEventsRequest self = new ListEventsRequest();
        return TeaModel.build(map, self);
    }

    public ListEventsRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public ListEventsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListEventsRequest setShowDeleted(Boolean showDeleted) {
        this.showDeleted = showDeleted;
        return this;
    }
    public Boolean getShowDeleted() {
        return this.showDeleted;
    }

    public ListEventsRequest setSyncToken(String syncToken) {
        this.syncToken = syncToken;
        return this;
    }
    public String getSyncToken() {
        return this.syncToken;
    }

    public ListEventsRequest setTimeMax(String timeMax) {
        this.timeMax = timeMax;
        return this;
    }
    public String getTimeMax() {
        return this.timeMax;
    }

    public ListEventsRequest setTimeMin(String timeMin) {
        this.timeMin = timeMin;
        return this;
    }
    public String getTimeMin() {
        return this.timeMin;
    }

}
