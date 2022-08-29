// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateCustomerRequest extends TeaModel {
    @NameInMap("createCustomerRequestList")
    public java.util.List<BatchCreateCustomerRequestCreateCustomerRequestList> createCustomerRequestList;

    // 创建人userId
    @NameInMap("operator")
    public String operator;

    public static BatchCreateCustomerRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateCustomerRequest self = new BatchCreateCustomerRequest();
        return TeaModel.build(map, self);
    }

    public BatchCreateCustomerRequest setCreateCustomerRequestList(java.util.List<BatchCreateCustomerRequestCreateCustomerRequestList> createCustomerRequestList) {
        this.createCustomerRequestList = createCustomerRequestList;
        return this;
    }
    public java.util.List<BatchCreateCustomerRequestCreateCustomerRequestList> getCreateCustomerRequestList() {
        return this.createCustomerRequestList;
    }

    public BatchCreateCustomerRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public static class BatchCreateCustomerRequestCreateCustomerRequestList extends TeaModel {
        // 客户描述
        @NameInMap("description")
        public String description;

        // 客户名字
        @NameInMap("name")
        public String name;

        // 购方账户
        @NameInMap("purchaserAccount")
        public String purchaserAccount;

        // 购房地址
        @NameInMap("purchaserAddress")
        public String purchaserAddress;

        // 购方银行
        @NameInMap("purchaserBankName")
        public String purchaserBankName;

        // 购方名字
        @NameInMap("purchaserName")
        public String purchaserName;

        // 购方税号
        @NameInMap("purchaserTaxNo")
        public String purchaserTaxNo;

        // 购方电话
        @NameInMap("purchaserTel")
        public String purchaserTel;

        public static BatchCreateCustomerRequestCreateCustomerRequestList build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateCustomerRequestCreateCustomerRequestList self = new BatchCreateCustomerRequestCreateCustomerRequestList();
            return TeaModel.build(map, self);
        }

        public BatchCreateCustomerRequestCreateCustomerRequestList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public BatchCreateCustomerRequestCreateCustomerRequestList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public BatchCreateCustomerRequestCreateCustomerRequestList setPurchaserAccount(String purchaserAccount) {
            this.purchaserAccount = purchaserAccount;
            return this;
        }
        public String getPurchaserAccount() {
            return this.purchaserAccount;
        }

        public BatchCreateCustomerRequestCreateCustomerRequestList setPurchaserAddress(String purchaserAddress) {
            this.purchaserAddress = purchaserAddress;
            return this;
        }
        public String getPurchaserAddress() {
            return this.purchaserAddress;
        }

        public BatchCreateCustomerRequestCreateCustomerRequestList setPurchaserBankName(String purchaserBankName) {
            this.purchaserBankName = purchaserBankName;
            return this;
        }
        public String getPurchaserBankName() {
            return this.purchaserBankName;
        }

        public BatchCreateCustomerRequestCreateCustomerRequestList setPurchaserName(String purchaserName) {
            this.purchaserName = purchaserName;
            return this;
        }
        public String getPurchaserName() {
            return this.purchaserName;
        }

        public BatchCreateCustomerRequestCreateCustomerRequestList setPurchaserTaxNo(String purchaserTaxNo) {
            this.purchaserTaxNo = purchaserTaxNo;
            return this;
        }
        public String getPurchaserTaxNo() {
            return this.purchaserTaxNo;
        }

        public BatchCreateCustomerRequestCreateCustomerRequestList setPurchaserTel(String purchaserTel) {
            this.purchaserTel = purchaserTel;
            return this;
        }
        public String getPurchaserTel() {
            return this.purchaserTel;
        }

    }

}
