// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListCommodityResponseBody extends TeaModel {
    @NameInMap("commodityVOList")
    public java.util.List<ListCommodityResponseBodyCommodityVOList> commodityVOList;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>100</p>
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
        @NameInMap("accountDistributionNumber")
        public Integer accountDistributionNumber;

        @NameInMap("accountNumber")
        public Integer accountNumber;

        @NameInMap("activationCode")
        public String activationCode;

        @NameInMap("buyDateGMT")
        public String buyDateGMT;

        @NameInMap("expireDateGMT")
        public String expireDateGMT;

        @NameInMap("instanceId")
        public String instanceId;

        @NameInMap("status")
        public String status;

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
