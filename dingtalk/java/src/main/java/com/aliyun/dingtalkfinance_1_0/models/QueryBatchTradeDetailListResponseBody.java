// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryBatchTradeDetailListResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("batchTradeDetailList")
    public java.util.List<QueryBatchTradeDetailListResponseBodyBatchTradeDetailList> batchTradeDetailList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("total")
    public Integer total;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("totalPageNumber")
    public Integer totalPageNumber;

    public static QueryBatchTradeDetailListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryBatchTradeDetailListResponseBody self = new QueryBatchTradeDetailListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryBatchTradeDetailListResponseBody setBatchTradeDetailList(java.util.List<QueryBatchTradeDetailListResponseBodyBatchTradeDetailList> batchTradeDetailList) {
        this.batchTradeDetailList = batchTradeDetailList;
        return this;
    }
    public java.util.List<QueryBatchTradeDetailListResponseBodyBatchTradeDetailList> getBatchTradeDetailList() {
        return this.batchTradeDetailList;
    }

    public QueryBatchTradeDetailListResponseBody setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public QueryBatchTradeDetailListResponseBody setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryBatchTradeDetailListResponseBody setTotal(Integer total) {
        this.total = total;
        return this;
    }
    public Integer getTotal() {
        return this.total;
    }

    public QueryBatchTradeDetailListResponseBody setTotalPageNumber(Integer totalPageNumber) {
        this.totalPageNumber = totalPageNumber;
        return this;
    }
    public Integer getTotalPageNumber() {
        return this.totalPageNumber;
    }

    public static class QueryBatchTradeDetailListResponseBodyBatchTradeDetailList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1.00</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>20210909153300000002734746770740</p>
         */
        @NameInMap("detailNo")
        public String detailNo;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-09-29 14:46:48</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-09-29 16:05:00</p>
         */
        @NameInMap("gmtFinish")
        public String gmtFinish;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>测试</p>
         */
        @NameInMap("memo")
        public String memo;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>收款人</p>
         */
        @NameInMap("payeeAccountName")
        public String payeeAccountName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>13900000000</p>
         */
        @NameInMap("payeeAccountNo")
        public String payeeAccountNo;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>ALIPAY</p>
         */
        @NameInMap("payeeAccountType")
        public String payeeAccountType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("serialNo")
        public Long serialNo;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>SUCCESS</p>
         */
        @NameInMap("status")
        public String status;

        public static QueryBatchTradeDetailListResponseBodyBatchTradeDetailList build(java.util.Map<String, ?> map) throws Exception {
            QueryBatchTradeDetailListResponseBodyBatchTradeDetailList self = new QueryBatchTradeDetailListResponseBodyBatchTradeDetailList();
            return TeaModel.build(map, self);
        }

        public QueryBatchTradeDetailListResponseBodyBatchTradeDetailList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public QueryBatchTradeDetailListResponseBodyBatchTradeDetailList setDetailNo(String detailNo) {
            this.detailNo = detailNo;
            return this;
        }
        public String getDetailNo() {
            return this.detailNo;
        }

        public QueryBatchTradeDetailListResponseBodyBatchTradeDetailList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryBatchTradeDetailListResponseBodyBatchTradeDetailList setGmtFinish(String gmtFinish) {
            this.gmtFinish = gmtFinish;
            return this;
        }
        public String getGmtFinish() {
            return this.gmtFinish;
        }

        public QueryBatchTradeDetailListResponseBodyBatchTradeDetailList setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public QueryBatchTradeDetailListResponseBodyBatchTradeDetailList setPayeeAccountName(String payeeAccountName) {
            this.payeeAccountName = payeeAccountName;
            return this;
        }
        public String getPayeeAccountName() {
            return this.payeeAccountName;
        }

        public QueryBatchTradeDetailListResponseBodyBatchTradeDetailList setPayeeAccountNo(String payeeAccountNo) {
            this.payeeAccountNo = payeeAccountNo;
            return this;
        }
        public String getPayeeAccountNo() {
            return this.payeeAccountNo;
        }

        public QueryBatchTradeDetailListResponseBodyBatchTradeDetailList setPayeeAccountType(String payeeAccountType) {
            this.payeeAccountType = payeeAccountType;
            return this;
        }
        public String getPayeeAccountType() {
            return this.payeeAccountType;
        }

        public QueryBatchTradeDetailListResponseBodyBatchTradeDetailList setSerialNo(Long serialNo) {
            this.serialNo = serialNo;
            return this;
        }
        public Long getSerialNo() {
            return this.serialNo;
        }

        public QueryBatchTradeDetailListResponseBodyBatchTradeDetailList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
