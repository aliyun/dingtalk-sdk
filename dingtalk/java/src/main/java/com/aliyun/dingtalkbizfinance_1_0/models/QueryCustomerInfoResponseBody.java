// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomerInfoResponseBody extends TeaModel {
    /**
     * <p>是否还有数据</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>客户分页数据</p>
     */
    @NameInMap("list")
    public java.util.List<QueryCustomerInfoResponseBodyList> list;

    /**
     * <p>总数</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryCustomerInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomerInfoResponseBody self = new QueryCustomerInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCustomerInfoResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryCustomerInfoResponseBody setList(java.util.List<QueryCustomerInfoResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryCustomerInfoResponseBodyList> getList() {
        return this.list;
    }

    public QueryCustomerInfoResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryCustomerInfoResponseBodyList extends TeaModel {
        /**
         * <p>客户code</p>
         */
        @NameInMap("code")
        public String code;

        @NameInMap("contactAddress")
        public String contactAddress;

        @NameInMap("contactCompanyTelephone")
        public String contactCompanyTelephone;

        @NameInMap("contactEmail")
        public String contactEmail;

        @NameInMap("contactName")
        public String contactName;

        @NameInMap("contactTelephone")
        public String contactTelephone;

        /**
         * <p>客户描述</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>客户名字</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>购方账户</p>
         */
        @NameInMap("purchaserAccount")
        public String purchaserAccount;

        /**
         * <p>购方地址</p>
         */
        @NameInMap("purchaserAddress")
        public String purchaserAddress;

        /**
         * <p>购方姓名</p>
         */
        @NameInMap("purchaserName")
        public String purchaserName;

        /**
         * <p>购方税号</p>
         */
        @NameInMap("purchaserTaxNo")
        public String purchaserTaxNo;

        /**
         * <p>购方电话</p>
         */
        @NameInMap("purchaserTel")
        public String purchaserTel;

        /**
         * <p>购方银行</p>
         */
        @NameInMap("purchaserrBankName")
        public String purchaserrBankName;

        /**
         * <p>状态</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>用户自定义code</p>
         */
        @NameInMap("userDefineCode")
        public String userDefineCode;

        public static QueryCustomerInfoResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryCustomerInfoResponseBodyList self = new QueryCustomerInfoResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryCustomerInfoResponseBodyList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryCustomerInfoResponseBodyList setContactAddress(String contactAddress) {
            this.contactAddress = contactAddress;
            return this;
        }
        public String getContactAddress() {
            return this.contactAddress;
        }

        public QueryCustomerInfoResponseBodyList setContactCompanyTelephone(String contactCompanyTelephone) {
            this.contactCompanyTelephone = contactCompanyTelephone;
            return this;
        }
        public String getContactCompanyTelephone() {
            return this.contactCompanyTelephone;
        }

        public QueryCustomerInfoResponseBodyList setContactEmail(String contactEmail) {
            this.contactEmail = contactEmail;
            return this;
        }
        public String getContactEmail() {
            return this.contactEmail;
        }

        public QueryCustomerInfoResponseBodyList setContactName(String contactName) {
            this.contactName = contactName;
            return this;
        }
        public String getContactName() {
            return this.contactName;
        }

        public QueryCustomerInfoResponseBodyList setContactTelephone(String contactTelephone) {
            this.contactTelephone = contactTelephone;
            return this;
        }
        public String getContactTelephone() {
            return this.contactTelephone;
        }

        public QueryCustomerInfoResponseBodyList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public QueryCustomerInfoResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryCustomerInfoResponseBodyList setPurchaserAccount(String purchaserAccount) {
            this.purchaserAccount = purchaserAccount;
            return this;
        }
        public String getPurchaserAccount() {
            return this.purchaserAccount;
        }

        public QueryCustomerInfoResponseBodyList setPurchaserAddress(String purchaserAddress) {
            this.purchaserAddress = purchaserAddress;
            return this;
        }
        public String getPurchaserAddress() {
            return this.purchaserAddress;
        }

        public QueryCustomerInfoResponseBodyList setPurchaserName(String purchaserName) {
            this.purchaserName = purchaserName;
            return this;
        }
        public String getPurchaserName() {
            return this.purchaserName;
        }

        public QueryCustomerInfoResponseBodyList setPurchaserTaxNo(String purchaserTaxNo) {
            this.purchaserTaxNo = purchaserTaxNo;
            return this;
        }
        public String getPurchaserTaxNo() {
            return this.purchaserTaxNo;
        }

        public QueryCustomerInfoResponseBodyList setPurchaserTel(String purchaserTel) {
            this.purchaserTel = purchaserTel;
            return this;
        }
        public String getPurchaserTel() {
            return this.purchaserTel;
        }

        public QueryCustomerInfoResponseBodyList setPurchaserrBankName(String purchaserrBankName) {
            this.purchaserrBankName = purchaserrBankName;
            return this;
        }
        public String getPurchaserrBankName() {
            return this.purchaserrBankName;
        }

        public QueryCustomerInfoResponseBodyList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryCustomerInfoResponseBodyList setUserDefineCode(String userDefineCode) {
            this.userDefineCode = userDefineCode;
            return this;
        }
        public String getUserDefineCode() {
            return this.userDefineCode;
        }

    }

}
