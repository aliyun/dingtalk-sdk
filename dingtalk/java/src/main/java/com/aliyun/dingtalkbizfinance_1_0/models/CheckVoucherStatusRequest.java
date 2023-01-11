// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CheckVoucherStatusRequest extends TeaModel {
    /**
     * <p>结束时间</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>进项发票/销项发票</p>
     */
    @NameInMap("financeType")
    public String financeType;

    /**
     * <p>发票编码</p>
     */
    @NameInMap("invoiceCode")
    public String invoiceCode;

    /**
     * <p>发票号码</p>
     */
    @NameInMap("invoiceNo")
    public String invoiceNo;

    /**
     * <p>页号</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>当前页大小</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <p>开始时间</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>税号</p>
     */
    @NameInMap("taxNo")
    public String taxNo;

    /**
     * <p>发票认证状态</p>
     */
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
