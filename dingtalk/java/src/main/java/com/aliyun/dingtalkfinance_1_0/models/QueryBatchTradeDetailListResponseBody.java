// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryBatchTradeDetailListResponseBody extends TeaModel {
    // 明细列表
    @NameInMap("batchTradeDetailList")
    public java.util.List<QueryBatchTradeDetailListResponseBodyBatchTradeDetailList> batchTradeDetailList;

    // 当前页数
    @NameInMap("pageNumber")
    public Integer pageNumber;

    // 单页条数
    @NameInMap("pageSize")
    public Integer pageSize;

    // 总记录数
    @NameInMap("total")
    public Integer total;

    // 总页数
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
        // 金额
        @NameInMap("amount")
        public String amount;

        // 明细单号
        @NameInMap("detailNo")
        public String detailNo;

        // 订单时间时间
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 支付完成时间
        @NameInMap("gmtFinish")
        public String gmtFinish;

        // 备注
        @NameInMap("memo")
        public String memo;

        // 收款方电子钱包持有者姓名
        @NameInMap("payeeAccountName")
        public String payeeAccountName;

        // 收款人账号
        @NameInMap("payeeAccountNo")
        public String payeeAccountNo;

        // 收款账号类型
        @NameInMap("payeeAccountType")
        public String payeeAccountType;

        // 序号
        @NameInMap("serialNo")
        public Long serialNo;

        // 状态
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
