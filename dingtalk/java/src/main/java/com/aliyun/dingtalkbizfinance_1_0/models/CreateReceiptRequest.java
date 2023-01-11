// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateReceiptRequest extends TeaModel {
    /**
     * <p>单据列表，不超过10条数据</p>
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
         * <p>单据金额</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>关联收支类别code</p>
         */
        @NameInMap("categoryCode")
        public String categoryCode;

        /**
         * <p>单据唯一编号</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>单据创建时间，默认当前时间</p>
         */
        @NameInMap("createTime")
        public Long createTime;

        /**
         * <p>创建人工号</p>
         */
        @NameInMap("createUserId")
        public String createUserId;

        /**
         * <p>关联客户code</p>
         */
        @NameInMap("customerCode")
        public String customerCode;

        /**
         * <p>关联企业账户code</p>
         */
        @NameInMap("enterpriseAcountCode")
        public String enterpriseAcountCode;

        /**
         * <p>业务发生时间，默认当前时间</p>
         */
        @NameInMap("occurDate")
        public Long occurDate;

        /**
         * <p>负责人工号，传空代表不修改</p>
         */
        @NameInMap("principalId")
        public String principalId;

        /**
         * <p>关联项目code</p>
         */
        @NameInMap("projectCode")
        public String projectCode;

        /**
         * <p>单据类型：1付款单，2收款单</p>
         */
        @NameInMap("receiptType")
        public Long receiptType;

        /**
         * <p>备注</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <p>关联供应商code</p>
         */
        @NameInMap("supplierCode")
        public String supplierCode;

        /**
         * <p>单据标题，不传由系统默认生成</p>
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
