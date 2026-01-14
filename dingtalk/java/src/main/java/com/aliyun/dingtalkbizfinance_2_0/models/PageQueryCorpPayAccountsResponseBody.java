// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class PageQueryCorpPayAccountsResponseBody extends TeaModel {
    @NameInMap("accounts")
    public java.util.List<PageQueryCorpPayAccountsResponseBodyAccounts> accounts;

    public static PageQueryCorpPayAccountsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PageQueryCorpPayAccountsResponseBody self = new PageQueryCorpPayAccountsResponseBody();
        return TeaModel.build(map, self);
    }

    public PageQueryCorpPayAccountsResponseBody setAccounts(java.util.List<PageQueryCorpPayAccountsResponseBodyAccounts> accounts) {
        this.accounts = accounts;
        return this;
    }
    public java.util.List<PageQueryCorpPayAccountsResponseBodyAccounts> getAccounts() {
        return this.accounts;
    }

    public static class PageQueryCorpPayAccountsResponseBodyAccounts extends TeaModel {
        @NameInMap("accountClass")
        public String accountClass;

        @NameInMap("accountId")
        public String accountId;

        @NameInMap("accountName")
        public String accountName;

        @NameInMap("accountNo")
        public String accountNo;

        @NameInMap("accountRemark")
        public String accountRemark;

        @NameInMap("accountType")
        public String accountType;

        @NameInMap("creatorUid")
        public Long creatorUid;

        @NameInMap("hasSignReceipt")
        public Boolean hasSignReceipt;

        public static PageQueryCorpPayAccountsResponseBodyAccounts build(java.util.Map<String, ?> map) throws Exception {
            PageQueryCorpPayAccountsResponseBodyAccounts self = new PageQueryCorpPayAccountsResponseBodyAccounts();
            return TeaModel.build(map, self);
        }

        public PageQueryCorpPayAccountsResponseBodyAccounts setAccountClass(String accountClass) {
            this.accountClass = accountClass;
            return this;
        }
        public String getAccountClass() {
            return this.accountClass;
        }

        public PageQueryCorpPayAccountsResponseBodyAccounts setAccountId(String accountId) {
            this.accountId = accountId;
            return this;
        }
        public String getAccountId() {
            return this.accountId;
        }

        public PageQueryCorpPayAccountsResponseBodyAccounts setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public PageQueryCorpPayAccountsResponseBodyAccounts setAccountNo(String accountNo) {
            this.accountNo = accountNo;
            return this;
        }
        public String getAccountNo() {
            return this.accountNo;
        }

        public PageQueryCorpPayAccountsResponseBodyAccounts setAccountRemark(String accountRemark) {
            this.accountRemark = accountRemark;
            return this;
        }
        public String getAccountRemark() {
            return this.accountRemark;
        }

        public PageQueryCorpPayAccountsResponseBodyAccounts setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public PageQueryCorpPayAccountsResponseBodyAccounts setCreatorUid(Long creatorUid) {
            this.creatorUid = creatorUid;
            return this;
        }
        public Long getCreatorUid() {
            return this.creatorUid;
        }

        public PageQueryCorpPayAccountsResponseBodyAccounts setHasSignReceipt(Boolean hasSignReceipt) {
            this.hasSignReceipt = hasSignReceipt;
            return this;
        }
        public Boolean getHasSignReceipt() {
            return this.hasSignReceipt;
        }

    }

}
