// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetUserAllLiveListRequest extends TeaModel {
    // 直播状态列表
    @NameInMap("statuses")
    public java.util.List<Long> statuses;

    // 第几页，从1开始
    @NameInMap("pageNumber")
    public Integer pageNumber;

    // 单次拉去上限，默认40个
    @NameInMap("pageSize")
    public Integer pageSize;

    // 用户uid
    @NameInMap("unionId")
    public String unionId;

    public static GetUserAllLiveListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserAllLiveListRequest self = new GetUserAllLiveListRequest();
        return TeaModel.build(map, self);
    }

    public GetUserAllLiveListRequest setStatuses(java.util.List<Long> statuses) {
        this.statuses = statuses;
        return this;
    }
    public java.util.List<Long> getStatuses() {
        return this.statuses;
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
