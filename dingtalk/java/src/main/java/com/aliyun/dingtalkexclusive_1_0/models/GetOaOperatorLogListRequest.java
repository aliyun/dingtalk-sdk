// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetOaOperatorLogListRequest extends TeaModel {
    /**
     * <p>操作分类（一级目录）</p>
     */
    @NameInMap("categoryList")
    public java.util.List<String> categoryList;

    /**
     * <p>结束时间</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>操作员userId</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>分页起始页</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>分页大小</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>起始时间</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    public static GetOaOperatorLogListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOaOperatorLogListRequest self = new GetOaOperatorLogListRequest();
        return TeaModel.build(map, self);
    }

    public GetOaOperatorLogListRequest setCategoryList(java.util.List<String> categoryList) {
        this.categoryList = categoryList;
        return this;
    }
    public java.util.List<String> getCategoryList() {
        return this.categoryList;
    }

    public GetOaOperatorLogListRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public GetOaOperatorLogListRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
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

    public GetOaOperatorLogListRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

}
