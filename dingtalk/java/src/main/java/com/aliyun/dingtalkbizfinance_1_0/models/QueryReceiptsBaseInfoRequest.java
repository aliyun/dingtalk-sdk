// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptsBaseInfoRequest extends TeaModel {
    // 结束时间
    @NameInMap("endTime")
    public Long endTime;

    // 分页参数，从1 开始
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 分页参数，每页查询个数
    @NameInMap("pageSize")
    public Long pageSize;

    // 开始时间
    @NameInMap("startTime")
    public Long startTime;

    // 单据标题
    @NameInMap("title")
    public String title;

    public static QueryReceiptsBaseInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptsBaseInfoRequest self = new QueryReceiptsBaseInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryReceiptsBaseInfoRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryReceiptsBaseInfoRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryReceiptsBaseInfoRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryReceiptsBaseInfoRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public QueryReceiptsBaseInfoRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
