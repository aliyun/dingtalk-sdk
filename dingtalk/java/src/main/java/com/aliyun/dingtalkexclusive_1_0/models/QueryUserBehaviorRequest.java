// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryUserBehaviorRequest extends TeaModel {
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("platform")
    public Integer platform;

    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("type")
    public Integer type;

    /**
     * <strong>example:</strong>
     * <p>12034-1233</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryUserBehaviorRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUserBehaviorRequest self = new QueryUserBehaviorRequest();
        return TeaModel.build(map, self);
    }

    public QueryUserBehaviorRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryUserBehaviorRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryUserBehaviorRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryUserBehaviorRequest setPlatform(Integer platform) {
        this.platform = platform;
        return this;
    }
    public Integer getPlatform() {
        return this.platform;
    }

    public QueryUserBehaviorRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public QueryUserBehaviorRequest setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
    }

    public QueryUserBehaviorRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
