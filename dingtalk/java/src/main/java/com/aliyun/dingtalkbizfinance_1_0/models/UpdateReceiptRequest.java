// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateReceiptRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("receipts")
    public java.util.List<UpdateReceiptRequestReceipts> receipts;

    public static UpdateReceiptRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateReceiptRequest self = new UpdateReceiptRequest();
        return TeaModel.build(map, self);
    }

    public UpdateReceiptRequest setReceipts(java.util.List<UpdateReceiptRequestReceipts> receipts) {
        this.receipts = receipts;
        return this;
    }
    public java.util.List<UpdateReceiptRequestReceipts> getReceipts() {
        return this.receipts;
    }

    public static class UpdateReceiptRequestReceipts extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2.44</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <strong>example:</strong>
         * <p>INC_XXX</p>
         */
        @NameInMap("categoryCode")
        public String categoryCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>abcd_efgh</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <strong>example:</strong>
         * <p>CUS_XXX</p>
         */
        @NameInMap("customerCode")
        public String customerCode;

        /**
         * <strong>example:</strong>
         * <p>ACC_XXX</p>
         */
        @NameInMap("enterpriseAcountCode")
        public String enterpriseAcountCode;

        /**
         * <strong>example:</strong>
         * <p>1636445218000</p>
         */
        @NameInMap("occurDate")
        public Long occurDate;

        /**
         * <strong>example:</strong>
         * <p>emp_xxx</p>
         */
        @NameInMap("principalId")
        public String principalId;

        /**
         * <strong>example:</strong>
         * <p>PROJ_XXX</p>
         */
        @NameInMap("projectCode")
        public String projectCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("receiptType")
        public Long receiptType;

        /**
         * <strong>example:</strong>
         * <p>测试单据</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <strong>example:</strong>
         * <p>SUP_XXX</p>
         */
        @NameInMap("supplierCode")
        public String supplierCode;

        /**
         * <strong>example:</strong>
         * <p>付款单</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1636445218000</p>
         */
        @NameInMap("updateTime")
        public Long updateTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>emp_xxx</p>
         */
        @NameInMap("updateUserId")
        public String updateUserId;

        public static UpdateReceiptRequestReceipts build(java.util.Map<String, ?> map) throws Exception {
            UpdateReceiptRequestReceipts self = new UpdateReceiptRequestReceipts();
            return TeaModel.build(map, self);
        }

        public UpdateReceiptRequestReceipts setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public UpdateReceiptRequestReceipts setCategoryCode(String categoryCode) {
            this.categoryCode = categoryCode;
            return this;
        }
        public String getCategoryCode() {
            return this.categoryCode;
        }

        public UpdateReceiptRequestReceipts setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public UpdateReceiptRequestReceipts setCustomerCode(String customerCode) {
            this.customerCode = customerCode;
            return this;
        }
        public String getCustomerCode() {
            return this.customerCode;
        }

        public UpdateReceiptRequestReceipts setEnterpriseAcountCode(String enterpriseAcountCode) {
            this.enterpriseAcountCode = enterpriseAcountCode;
            return this;
        }
        public String getEnterpriseAcountCode() {
            return this.enterpriseAcountCode;
        }

        public UpdateReceiptRequestReceipts setOccurDate(Long occurDate) {
            this.occurDate = occurDate;
            return this;
        }
        public Long getOccurDate() {
            return this.occurDate;
        }

        public UpdateReceiptRequestReceipts setPrincipalId(String principalId) {
            this.principalId = principalId;
            return this;
        }
        public String getPrincipalId() {
            return this.principalId;
        }

        public UpdateReceiptRequestReceipts setProjectCode(String projectCode) {
            this.projectCode = projectCode;
            return this;
        }
        public String getProjectCode() {
            return this.projectCode;
        }

        public UpdateReceiptRequestReceipts setReceiptType(Long receiptType) {
            this.receiptType = receiptType;
            return this;
        }
        public Long getReceiptType() {
            return this.receiptType;
        }

        public UpdateReceiptRequestReceipts setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public UpdateReceiptRequestReceipts setSupplierCode(String supplierCode) {
            this.supplierCode = supplierCode;
            return this;
        }
        public String getSupplierCode() {
            return this.supplierCode;
        }

        public UpdateReceiptRequestReceipts setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public UpdateReceiptRequestReceipts setUpdateTime(Long updateTime) {
            this.updateTime = updateTime;
            return this;
        }
        public Long getUpdateTime() {
            return this.updateTime;
        }

        public UpdateReceiptRequestReceipts setUpdateUserId(String updateUserId) {
            this.updateUserId = updateUserId;
            return this;
        }
        public String getUpdateUserId() {
            return this.updateUserId;
        }

    }

}
