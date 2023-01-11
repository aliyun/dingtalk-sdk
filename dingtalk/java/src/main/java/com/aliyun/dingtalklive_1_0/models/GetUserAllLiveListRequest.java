// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetUserAllLiveListRequest extends TeaModel {
    /**
     * <p>筛选直播截止时间</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>筛选直播开始时间</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>直播状态列表</p>
     */
    @NameInMap("statuses")
    public java.util.List<Integer> statuses;

    /**
     * <p>筛选直播标题</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>第几页，从1开始</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>单次拉去上限，默认40个</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>用户uid</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetUserAllLiveListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserAllLiveListRequest self = new GetUserAllLiveListRequest();
        return TeaModel.build(map, self);
    }

    public GetUserAllLiveListRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public GetUserAllLiveListRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetUserAllLiveListRequest setStatuses(java.util.List<Integer> statuses) {
        this.statuses = statuses;
        return this;
    }
    public java.util.List<Integer> getStatuses() {
        return this.statuses;
    }

    public GetUserAllLiveListRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public GetUserAllLiveListRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetUserAllLiveListRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetUserAllLiveListRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
