// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomerInfoResponseBody extends TeaModel {
    // 是否还有数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 客户分页数据
    @NameInMap("list")
    public java.util.List<QueryCustomerInfoResponseBodyList> list;

    // 总数
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
        // 客户code
        @NameInMap("code")
        public String code;

        // 客户描述
        @NameInMap("description")
        public String description;

        // 客户名字
        @NameInMap("name")
        public String name;

        // 购方账户
        @NameInMap("purchaserAccount")
        public String purchaserAccount;

        // 购方地址
        @NameInMap("purchaserAddress")
        public String purchaserAddress;

        // 购方姓名
        @NameInMap("purchaserName")
        public String purchaserName;

        // 购方税号
        @NameInMap("purchaserTaxNo")
        public String purchaserTaxNo;

        // 购方电话
        @NameInMap("purchaserTel")
        public String purchaserTel;

        // 购方银行
        @NameInMap("purchaserrBankName")
        public String purchaserrBankName;

        // 状态
        @NameInMap("status")
        public String status;

        // 用户自定义code
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
