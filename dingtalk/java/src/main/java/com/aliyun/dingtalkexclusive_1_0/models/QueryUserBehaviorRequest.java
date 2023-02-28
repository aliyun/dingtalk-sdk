// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryUserBehaviorRequest extends TeaModel {
    /**
     * <p>结束时间(默认当前时间)</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>起始页(默认从1开始)</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>页大小(最大100)</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>端类型((0-全部，1-iOS，2-Android, 3-Mac, 4-Windows))</p>
     */
    @NameInMap("platform")
    public Integer platform;

    /**
     * <p>开始时间(默认当前时间前7天)</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>用户行为((0-全部，1-截屏，2-录屏))</p>
     */
    @NameInMap("type")
    public Integer type;

    /**
     * <p>工号</p>
     */
    @NameInMap("userId")
    public Long userId;

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

    public QueryUserBehaviorRequest setUserId(Long userId) {
        this.userId = userId;
        return this;
    }
    public Long getUserId() {
        return this.userId;
    }

}
