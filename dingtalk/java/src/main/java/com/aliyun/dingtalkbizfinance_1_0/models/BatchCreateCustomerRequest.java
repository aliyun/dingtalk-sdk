// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateCustomerRequest extends TeaModel {
    @NameInMap("createCustomerRequestList")
    public java.util.List<BatchCreateCustomerRequestCreateCustomerRequestList> createCustomerRequestList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>55001121</p>
     */
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
        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <strong>example:</strong>
         * <p><a href="http://www.abc.com">www.abc.com</a></p>
         */
        @NameInMap("drawerEmail")
        public String drawerEmail;

        /**
         * <strong>example:</strong>
         * <p>1234567890</p>
         */
        @NameInMap("drawerTelephone")
        public String drawerTelephone;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("purchaserAccount")
        public String purchaserAccount;

        /**
         * <strong>example:</strong>
         * <p>杭州市</p>
         */
        @NameInMap("purchaserAddress")
        public String purchaserAddress;

        /**
         * <strong>example:</strong>
         * <p>建行</p>
         */
        @NameInMap("purchaserBankName")
        public String purchaserBankName;

        /**
         * <strong>example:</strong>
         * <p>李四</p>
         */
        @NameInMap("purchaserName")
        public String purchaserName;

        /**
         * <strong>example:</strong>
         * <p>1333</p>
         */
        @NameInMap("purchaserTaxNo")
        public String purchaserTaxNo;

        /**
         * <strong>example:</strong>
         * <p>13333333333</p>
         */
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

        public BatchCreateCustomerRequestCreateCustomerRequestList setDrawerEmail(String drawerEmail) {
            this.drawerEmail = drawerEmail;
            return this;
        }
        public String getDrawerEmail() {
            return this.drawerEmail;
        }

        public BatchCreateCustomerRequestCreateCustomerRequestList setDrawerTelephone(String drawerTelephone) {
            this.drawerTelephone = drawerTelephone;
            return this;
        }
        public String getDrawerTelephone() {
            return this.drawerTelephone;
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
