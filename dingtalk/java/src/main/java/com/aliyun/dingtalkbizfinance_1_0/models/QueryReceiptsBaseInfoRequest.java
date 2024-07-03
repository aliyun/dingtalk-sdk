// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptsBaseInfoRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("accountantBookId")
    public String accountantBookId;

    @NameInMap("amountEnd")
    public Double amountEnd;

    @NameInMap("amountStart")
    public Double amountStart;

    /**
     * <strong>example:</strong>
     * <p>COM_DEFAULT</p>
     */
    @NameInMap("companyCode")
    public String companyCode;

    /**
     * <strong>example:</strong>
     * <p>16000000</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <strong>example:</strong>
     * <p>16000000</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("timeFilterField")
    public String timeFilterField;

    /**
     * <strong>example:</strong>
     * <p>收款单</p>
     */
    @NameInMap("title")
    public String title;

    @NameInMap("voucherStatus")
    public String voucherStatus;

    public static QueryReceiptsBaseInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptsBaseInfoRequest self = new QueryReceiptsBaseInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryReceiptsBaseInfoRequest setAccountantBookId(String accountantBookId) {
        this.accountantBookId = accountantBookId;
        return this;
    }
    public String getAccountantBookId() {
        return this.accountantBookId;
    }

    public QueryReceiptsBaseInfoRequest setAmountEnd(Double amountEnd) {
        this.amountEnd = amountEnd;
        return this;
    }
    public Double getAmountEnd() {
        return this.amountEnd;
    }

    public QueryReceiptsBaseInfoRequest setAmountStart(Double amountStart) {
        this.amountStart = amountStart;
        return this;
    }
    public Double getAmountStart() {
        return this.amountStart;
    }

    public QueryReceiptsBaseInfoRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
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
