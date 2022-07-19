// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetInvoiceByPageRequest extends TeaModel {
    @NameInMap("request")
    public GetInvoiceByPageRequestRequest request;

    public static GetInvoiceByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        GetInvoiceByPageRequest self = new GetInvoiceByPageRequest();
        return TeaModel.build(map, self);
    }

    public GetInvoiceByPageRequest setRequest(GetInvoiceByPageRequestRequest request) {
        this.request = request;
        return this;
    }
    public GetInvoiceByPageRequestRequest getRequest() {
        return this.request;
    }

    public static class GetInvoiceByPageRequestRequest extends TeaModel {
        // 结束时间
        // 
        @NameInMap("endTime")
        public Long endTime;

        // 进项票/销项票
        @NameInMap("financeType")
        public String financeType;

        // 分页参数
        @NameInMap("pageNumber")
        public Long pageNumber;

        // 分页参数
        @NameInMap("pageSize")
        public Long pageSize;

        // 开始时间
        @NameInMap("startTime")
        public Long startTime;

        // 税号
        @NameInMap("taxNo")
        public String taxNo;

        // 认证状态
        @NameInMap("verifyStatus")
        public String verifyStatus;

        public static GetInvoiceByPageRequestRequest build(java.util.Map<String, ?> map) throws Exception {
            GetInvoiceByPageRequestRequest self = new GetInvoiceByPageRequestRequest();
            return TeaModel.build(map, self);
        }

        public GetInvoiceByPageRequestRequest setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public GetInvoiceByPageRequestRequest setFinanceType(String financeType) {
            this.financeType = financeType;
            return this;
        }
        public String getFinanceType() {
            return this.financeType;
        }

        public GetInvoiceByPageRequestRequest setPageNumber(Long pageNumber) {
            this.pageNumber = pageNumber;
            return this;
        }
        public Long getPageNumber() {
            return this.pageNumber;
        }

        public GetInvoiceByPageRequestRequest setPageSize(Long pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Long getPageSize() {
            return this.pageSize;
        }

        public GetInvoiceByPageRequestRequest setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public GetInvoiceByPageRequestRequest setTaxNo(String taxNo) {
            this.taxNo = taxNo;
            return this;
        }
        public String getTaxNo() {
            return this.taxNo;
        }

        public GetInvoiceByPageRequestRequest setVerifyStatus(String verifyStatus) {
            this.verifyStatus = verifyStatus;
            return this;
        }
        public String getVerifyStatus() {
            return this.verifyStatus;
        }

    }

}
