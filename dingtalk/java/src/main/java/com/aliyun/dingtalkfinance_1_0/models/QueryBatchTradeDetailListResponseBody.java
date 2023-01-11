// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryBatchTradeDetailListResponseBody extends TeaModel {
    /**
     * <p>明细列表</p>
     */
    @NameInMap("batchTradeDetailList")
    public java.util.List<QueryBatchTradeDetailListResponseBodyBatchTradeDetailList> batchTradeDetailList;

    /**
     * <p>当前页数</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>单页条数</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>总记录数</p>
     */
    @NameInMap("total")
    public Integer total;

    /**
     * <p>总页数</p>
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
         * <p>金额</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>明细单号</p>
         */
        @NameInMap("detailNo")
        public String detailNo;

        /**
         * <p>订单时间时间</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>支付完成时间</p>
         */
        @NameInMap("gmtFinish")
        public String gmtFinish;

        /**
         * <p>备注</p>
         */
        @NameInMap("memo")
        public String memo;

        /**
         * <p>收款方电子钱包持有者姓名</p>
         */
        @NameInMap("payeeAccountName")
        public String payeeAccountName;

        /**
         * <p>收款人账号</p>
         */
        @NameInMap("payeeAccountNo")
        public String payeeAccountNo;

        /**
         * <p>收款账号类型</p>
         */
        @NameInMap("payeeAccountType")
        public String payeeAccountType;

        /**
         * <p>序号</p>
         */
        @NameInMap("serialNo")
        public Long serialNo;

        /**
         * <p>状态</p>
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
