// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomerInfoResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<QueryCustomerInfoResponseBodyList> list;

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

        @NameInMap("description")
        public String description;

        @NameInMap("drawerEmail")
        public String drawerEmail;

        @NameInMap("drawerTelephone")
        public String drawerTelephone;

        @NameInMap("name")
        public String name;

        @NameInMap("purchaserAccount")
        public String purchaserAccount;

        @NameInMap("purchaserAddress")
        public String purchaserAddress;

        @NameInMap("purchaserName")
        public String purchaserName;

        @NameInMap("purchaserTaxNo")
        public String purchaserTaxNo;

        @NameInMap("purchaserTel")
        public String purchaserTel;

        @NameInMap("purchaserrBankName")
        public String purchaserrBankName;

        @NameInMap("status")
        public String status;

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

        public QueryCustomerInfoResponseBodyList setDrawerEmail(String drawerEmail) {
            this.drawerEmail = drawerEmail;
            return this;
        }
        public String getDrawerEmail() {
            return this.drawerEmail;
        }

        public QueryCustomerInfoResponseBodyList setDrawerTelephone(String drawerTelephone) {
            this.drawerTelephone = drawerTelephone;
            return this;
        }
        public String getDrawerTelephone() {
            return this.drawerTelephone;
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
