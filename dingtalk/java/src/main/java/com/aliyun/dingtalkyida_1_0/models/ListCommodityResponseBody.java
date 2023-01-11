// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListCommodityResponseBody extends TeaModel {
    /**
     * <p>commodityVOList</p>
     */
    @NameInMap("commodityVOList")
    public java.util.List<ListCommodityResponseBodyCommodityVOList> commodityVOList;

    /**
     * <p>当前第几页</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>分页大小</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>总数量</p>
     */
    @NameInMap("totalCount")
    public Integer totalCount;

    public static ListCommodityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListCommodityResponseBody self = new ListCommodityResponseBody();
        return TeaModel.build(map, self);
    }

    public ListCommodityResponseBody setCommodityVOList(java.util.List<ListCommodityResponseBodyCommodityVOList> commodityVOList) {
        this.commodityVOList = commodityVOList;
        return this;
    }
    public java.util.List<ListCommodityResponseBodyCommodityVOList> getCommodityVOList() {
        return this.commodityVOList;
    }

    public ListCommodityResponseBody setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListCommodityResponseBody setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListCommodityResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class ListCommodityResponseBodyCommodityVOList extends TeaModel {
        /**
         * <p>accountDistributionNumber</p>
         */
        @NameInMap("accountDistributionNumber")
        public Integer accountDistributionNumber;

        /**
         * <p>accountNum</p>
         */
        @NameInMap("accountNumber")
        public Integer accountNumber;

        /**
         * <p>activationCode</p>
         */
        @NameInMap("activationCode")
        public String activationCode;

        /**
         * <p>buyDate</p>
         */
        @NameInMap("buyDateGMT")
        public String buyDateGMT;

        /**
         * <p>expireDate</p>
         */
        @NameInMap("expireDateGMT")
        public String expireDateGMT;

        /**
         * <p>instanceId</p>
         */
        @NameInMap("instanceId")
        public String instanceId;

        /**
         * <p>status</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>version</p>
         */
        @NameInMap("version")
        public Integer version;

        public static ListCommodityResponseBodyCommodityVOList build(java.util.Map<String, ?> map) throws Exception {
            ListCommodityResponseBodyCommodityVOList self = new ListCommodityResponseBodyCommodityVOList();
            return TeaModel.build(map, self);
        }

        public ListCommodityResponseBodyCommodityVOList setAccountDistributionNumber(Integer accountDistributionNumber) {
            this.accountDistributionNumber = accountDistributionNumber;
            return this;
        }
        public Integer getAccountDistributionNumber() {
            return this.accountDistributionNumber;
        }

        public ListCommodityResponseBodyCommodityVOList setAccountNumber(Integer accountNumber) {
            this.accountNumber = accountNumber;
            return this;
        }
        public Integer getAccountNumber() {
            return this.accountNumber;
        }

        public ListCommodityResponseBodyCommodityVOList setActivationCode(String activationCode) {
            this.activationCode = activationCode;
            return this;
        }
        public String getActivationCode() {
            return this.activationCode;
        }

        public ListCommodityResponseBodyCommodityVOList setBuyDateGMT(String buyDateGMT) {
            this.buyDateGMT = buyDateGMT;
            return this;
        }
        public String getBuyDateGMT() {
            return this.buyDateGMT;
        }

        public ListCommodityResponseBodyCommodityVOList setExpireDateGMT(String expireDateGMT) {
            this.expireDateGMT = expireDateGMT;
            return this;
        }
        public String getExpireDateGMT() {
            return this.expireDateGMT;
        }

        public ListCommodityResponseBodyCommodityVOList setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public ListCommodityResponseBodyCommodityVOList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public ListCommodityResponseBodyCommodityVOList setVersion(Integer version) {
            this.version = version;
            return this;
        }
        public Integer getVersion() {
            return this.version;
        }

    }

}
