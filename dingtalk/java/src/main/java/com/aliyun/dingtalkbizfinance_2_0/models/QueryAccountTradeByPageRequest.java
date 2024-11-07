// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryAccountTradeByPageRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ACC_XXXXX</p>
     */
    @NameInMap("accountId")
    public String accountId;

    /**
     * <strong>example:</strong>
     * <p>1730778990150</p>
     */
    @NameInMap("endDate")
    public Long endDate;

    @NameInMap("filter")
    public QueryAccountTradeByPageRequestFilter filter;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>1730778990150</p>
     */
    @NameInMap("startDate")
    public Long startDate;

    public static QueryAccountTradeByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAccountTradeByPageRequest self = new QueryAccountTradeByPageRequest();
        return TeaModel.build(map, self);
    }

    public QueryAccountTradeByPageRequest setAccountId(String accountId) {
        this.accountId = accountId;
        return this;
    }
    public String getAccountId() {
        return this.accountId;
    }

    public QueryAccountTradeByPageRequest setEndDate(Long endDate) {
        this.endDate = endDate;
        return this;
    }
    public Long getEndDate() {
        return this.endDate;
    }

    public QueryAccountTradeByPageRequest setFilter(QueryAccountTradeByPageRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public QueryAccountTradeByPageRequestFilter getFilter() {
        return this.filter;
    }

    public QueryAccountTradeByPageRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public QueryAccountTradeByPageRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryAccountTradeByPageRequest setStartDate(Long startDate) {
        this.startDate = startDate;
        return this;
    }
    public Long getStartDate() {
        return this.startDate;
    }

    public static class QueryAccountTradeByPageRequestFilter extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("endAmount")
        public String endAmount;

        /**
         * <strong>example:</strong>
         * <p>钉钉</p>
         */
        @NameInMap("otherAccountName")
        public String otherAccountName;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("startAmount")
        public String startAmount;

        /**
         * <strong>example:</strong>
         * <p>in</p>
         */
        @NameInMap("tradeType")
        public String tradeType;

        public static QueryAccountTradeByPageRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            QueryAccountTradeByPageRequestFilter self = new QueryAccountTradeByPageRequestFilter();
            return TeaModel.build(map, self);
        }

        public QueryAccountTradeByPageRequestFilter setEndAmount(String endAmount) {
            this.endAmount = endAmount;
            return this;
        }
        public String getEndAmount() {
            return this.endAmount;
        }

        public QueryAccountTradeByPageRequestFilter setOtherAccountName(String otherAccountName) {
            this.otherAccountName = otherAccountName;
            return this;
        }
        public String getOtherAccountName() {
            return this.otherAccountName;
        }

        public QueryAccountTradeByPageRequestFilter setStartAmount(String startAmount) {
            this.startAmount = startAmount;
            return this;
        }
        public String getStartAmount() {
            return this.startAmount;
        }

        public QueryAccountTradeByPageRequestFilter setTradeType(String tradeType) {
            this.tradeType = tradeType;
            return this;
        }
        public String getTradeType() {
            return this.tradeType;
        }

    }

}
