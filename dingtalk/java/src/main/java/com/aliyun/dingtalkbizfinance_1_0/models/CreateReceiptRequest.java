// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateReceiptRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("receipts")
    public java.util.List<CreateReceiptRequestReceipts> receipts;

    public static CreateReceiptRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateReceiptRequest self = new CreateReceiptRequest();
        return TeaModel.build(map, self);
    }

    public CreateReceiptRequest setReceipts(java.util.List<CreateReceiptRequestReceipts> receipts) {
        this.receipts = receipts;
        return this;
    }
    public java.util.List<CreateReceiptRequestReceipts> getReceipts() {
        return this.receipts;
    }

    public static class CreateReceiptRequestReceipts extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>4.44</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>This parameter is required.</p>
         * 
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
         * <p>1636445218000</p>
         */
        @NameInMap("createTime")
        public Long createTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>emp_xxx</p>
         */
        @NameInMap("createUserId")
        public String createUserId;

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
         * <p>测试</p>
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
         * <p>收款单</p>
         */
        @NameInMap("title")
        public String title;

        public static CreateReceiptRequestReceipts build(java.util.Map<String, ?> map) throws Exception {
            CreateReceiptRequestReceipts self = new CreateReceiptRequestReceipts();
            return TeaModel.build(map, self);
        }

        public CreateReceiptRequestReceipts setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public CreateReceiptRequestReceipts setCategoryCode(String categoryCode) {
            this.categoryCode = categoryCode;
            return this;
        }
        public String getCategoryCode() {
            return this.categoryCode;
        }

        public CreateReceiptRequestReceipts setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public CreateReceiptRequestReceipts setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public CreateReceiptRequestReceipts setCreateUserId(String createUserId) {
            this.createUserId = createUserId;
            return this;
        }
        public String getCreateUserId() {
            return this.createUserId;
        }

        public CreateReceiptRequestReceipts setCustomerCode(String customerCode) {
            this.customerCode = customerCode;
            return this;
        }
        public String getCustomerCode() {
            return this.customerCode;
        }

        public CreateReceiptRequestReceipts setEnterpriseAcountCode(String enterpriseAcountCode) {
            this.enterpriseAcountCode = enterpriseAcountCode;
            return this;
        }
        public String getEnterpriseAcountCode() {
            return this.enterpriseAcountCode;
        }

        public CreateReceiptRequestReceipts setOccurDate(Long occurDate) {
            this.occurDate = occurDate;
            return this;
        }
        public Long getOccurDate() {
            return this.occurDate;
        }

        public CreateReceiptRequestReceipts setPrincipalId(String principalId) {
            this.principalId = principalId;
            return this;
        }
        public String getPrincipalId() {
            return this.principalId;
        }

        public CreateReceiptRequestReceipts setProjectCode(String projectCode) {
            this.projectCode = projectCode;
            return this;
        }
        public String getProjectCode() {
            return this.projectCode;
        }

        public CreateReceiptRequestReceipts setReceiptType(Long receiptType) {
            this.receiptType = receiptType;
            return this;
        }
        public Long getReceiptType() {
            return this.receiptType;
        }

        public CreateReceiptRequestReceipts setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public CreateReceiptRequestReceipts setSupplierCode(String supplierCode) {
            this.supplierCode = supplierCode;
            return this;
        }
        public String getSupplierCode() {
            return this.supplierCode;
        }

        public CreateReceiptRequestReceipts setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
