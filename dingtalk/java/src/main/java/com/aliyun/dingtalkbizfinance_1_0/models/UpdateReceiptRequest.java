// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateReceiptRequest extends TeaModel {
    /**
     * <p>单据列表 ，最长10</p>
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
         * <p>总金额，传空代表不修改</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>关联收支类别，传空代表不修改</p>
         */
        @NameInMap("categoryCode")
        public String categoryCode;

        /**
         * <p>单据唯一编号</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>关联客户code，传空代表不修改</p>
         */
        @NameInMap("customerCode")
        public String customerCode;

        /**
         * <p>关联企业账户code，传空代表不修改</p>
         */
        @NameInMap("enterpriseAcountCode")
        public String enterpriseAcountCode;

        /**
         * <p>业务发生时间，传空代表不修改</p>
         */
        @NameInMap("occurDate")
        public Long occurDate;

        /**
         * <p>负责人工号，传空代表不修改</p>
         */
        @NameInMap("principalId")
        public String principalId;

        /**
         * <p>关联项目code，传空代表不修改</p>
         */
        @NameInMap("projectCode")
        public String projectCode;

        /**
         * <p>单据类型：1付款单，2收款单</p>
         */
        @NameInMap("receiptType")
        public Long receiptType;

        /**
         * <p>备注，传空代表不修改</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <p>关联供应商code，传空代表不修改</p>
         */
        @NameInMap("supplierCode")
        public String supplierCode;

        /**
         * <p>单据标题，传空代表不修改</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>单据更新时间</p>
         */
        @NameInMap("updateTime")
        public Long updateTime;

        /**
         * <p>修改者工号</p>
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
