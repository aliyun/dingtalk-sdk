// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetUserAllLiveListRequest extends TeaModel {
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("statuses")
    public java.util.List<Integer> statuses;

    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>This parameter is required.</p>
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
