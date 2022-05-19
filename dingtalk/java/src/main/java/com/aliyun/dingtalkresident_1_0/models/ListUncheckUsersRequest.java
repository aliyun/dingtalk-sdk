// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListUncheckUsersRequest extends TeaModel {
    // 条目数
    @NameInMap("maxResults")
    public Integer maxResults;

    // 开始位置
    @NameInMap("nextToken")
    public Integer nextToken;

    // 起始时间
    @NameInMap("startTime")
    public Long startTime;

    // 状态
    @NameInMap("status")
    public Integer status;

    public static ListUncheckUsersRequest build(java.util.Map<String, ?> map) throws Exception {
        ListUncheckUsersRequest self = new ListUncheckUsersRequest();
        return TeaModel.build(map, self);
    }

    public ListUncheckUsersRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListUncheckUsersRequest setNextToken(Integer nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Integer getNextToken() {
        return this.nextToken;
    }

    public ListUncheckUsersRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public ListUncheckUsersRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
