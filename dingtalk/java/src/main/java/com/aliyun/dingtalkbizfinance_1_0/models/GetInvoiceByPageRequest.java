// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetInvoiceByPageRequest extends TeaModel {
    // 查询结束时间
    @NameInMap("endTime")
    public Long endTime;

    // 发票类型
    @NameInMap("financeType")
    public String financeType;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    // 查询开始时间
    @NameInMap("startTime")
    public Long startTime;

    // 税号
    @NameInMap("taxNo")
    public String taxNo;

    // 发票状态
    @NameInMap("verifyStatus")
    public String verifyStatus;

    public static GetInvoiceByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        GetInvoiceByPageRequest self = new GetInvoiceByPageRequest();
        return TeaModel.build(map, self);
    }

    public GetInvoiceByPageRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public GetInvoiceByPageRequest setFinanceType(String financeType) {
        this.financeType = financeType;
        return this;
    }
    public String getFinanceType() {
        return this.financeType;
    }

    public GetInvoiceByPageRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetInvoiceByPageRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public GetInvoiceByPageRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetInvoiceByPageRequest setTaxNo(String taxNo) {
        this.taxNo = taxNo;
        return this;
    }
    public String getTaxNo() {
        return this.taxNo;
    }

    public GetInvoiceByPageRequest setVerifyStatus(String verifyStatus) {
        this.verifyStatus = verifyStatus;
        return this;
    }
    public String getVerifyStatus() {
        return this.verifyStatus;
    }

}
