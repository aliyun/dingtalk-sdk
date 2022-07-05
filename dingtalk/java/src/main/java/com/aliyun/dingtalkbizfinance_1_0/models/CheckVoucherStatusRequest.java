// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CheckVoucherStatusRequest extends TeaModel {
    // 结束时间
    @NameInMap("endTime")
    public Long endTime;

    // 进项发票/销项发票
    @NameInMap("financeType")
    public String financeType;

    // 发票编码
    @NameInMap("invoiceCode")
    public String invoiceCode;

    // 发票号码
    @NameInMap("invoiceNo")
    public String invoiceNo;

    // 页号
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 当前页大小
    @NameInMap("pageSize")
    public Long pageSize;

    // 开始时间
    @NameInMap("startTime")
    public Long startTime;

    // 税号
    @NameInMap("taxNo")
    public String taxNo;

    // 发票认证状态
    @NameInMap("verifyStatus")
    public String verifyStatus;

    public static CheckVoucherStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        CheckVoucherStatusRequest self = new CheckVoucherStatusRequest();
        return TeaModel.build(map, self);
    }

    public CheckVoucherStatusRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public CheckVoucherStatusRequest setFinanceType(String financeType) {
        this.financeType = financeType;
        return this;
    }
    public String getFinanceType() {
        return this.financeType;
    }

    public CheckVoucherStatusRequest setInvoiceCode(String invoiceCode) {
        this.invoiceCode = invoiceCode;
        return this;
    }
    public String getInvoiceCode() {
        return this.invoiceCode;
    }

    public CheckVoucherStatusRequest setInvoiceNo(String invoiceNo) {
        this.invoiceNo = invoiceNo;
        return this;
    }
    public String getInvoiceNo() {
        return this.invoiceNo;
    }

    public CheckVoucherStatusRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public CheckVoucherStatusRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public CheckVoucherStatusRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CheckVoucherStatusRequest setTaxNo(String taxNo) {
        this.taxNo = taxNo;
        return this;
    }
    public String getTaxNo() {
        return this.taxNo;
    }

    public CheckVoucherStatusRequest setVerifyStatus(String verifyStatus) {
        this.verifyStatus = verifyStatus;
        return this;
    }
    public String getVerifyStatus() {
        return this.verifyStatus;
    }

}
