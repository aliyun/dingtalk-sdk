// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetOaOperatorLogListRequest extends TeaModel {
    // 操作员userId
    @NameInMap("opUserId")
    public String opUserId;

    // 起始时间
    @NameInMap("startTime")
    public Long startTime;

    // 结束时间
    @NameInMap("endTime")
    public Long endTime;

    // 分页起始页
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 分页大小
    @NameInMap("pageSize")
    public Integer pageSize;

    // 操作分类（一级目录）
    @NameInMap("categoryList")
    public java.util.List<String> categoryList;

    public static GetOaOperatorLogListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOaOperatorLogListRequest self = new GetOaOperatorLogListRequest();
        return TeaModel.build(map, self);
    }

    public GetOaOperatorLogListRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public GetOaOperatorLogListRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetOaOperatorLogListRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public GetOaOperatorLogListRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetOaOperatorLogListRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetOaOperatorLogListRequest setCategoryList(java.util.List<String> categoryList) {
        this.categoryList = categoryList;
        return this;
    }
    public java.util.List<String> getCategoryList() {
        return this.categoryList;
    }

}
