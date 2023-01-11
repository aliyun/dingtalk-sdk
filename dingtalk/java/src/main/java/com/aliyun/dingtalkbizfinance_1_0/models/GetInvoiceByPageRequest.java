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
        /**
         * <p>结束时间</p>
         * <br>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <p>进项票/销项票</p>
         */
        @NameInMap("financeType")
        public String financeType;

        /**
         * <p>分页参数</p>
         */
        @NameInMap("pageNumber")
        public Long pageNumber;

        /**
         * <p>分页参数</p>
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
         * <p>认证状态</p>
         */
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
