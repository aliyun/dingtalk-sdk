// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptsBaseInfoRequest extends TeaModel {
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("timeFilterField")
    public String timeFilterField;

    @NameInMap("title")
    public String title;

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
