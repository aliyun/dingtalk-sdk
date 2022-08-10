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

    // 时间筛选条件 gmt_create / record_time
    @NameInMap("timeFilterField")
    public String timeFilterField;

    // 单据标题
    @NameInMap("title")
    public String title;

    // 凭证状态
    @NameInMap("voucherStatus")
    public String voucherStatus;

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

    public QueryReceiptsBaseInfoRequest setTimeFilterField(String timeFilterField) {
        this.timeFilterField = timeFilterField;
        return this;
    }
    public String getTimeFilterField() {
        return this.timeFilterField;
    }

    public QueryReceiptsBaseInfoRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public QueryReceiptsBaseInfoRequest setVoucherStatus(String voucherStatus) {
        this.voucherStatus = voucherStatus;
        return this;
    }
    public String getVoucherStatus() {
        return this.voucherStatus;
    }

}
