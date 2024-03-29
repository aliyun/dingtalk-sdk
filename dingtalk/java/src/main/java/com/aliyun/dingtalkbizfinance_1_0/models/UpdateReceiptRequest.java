// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateReceiptRequest extends TeaModel {
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
        @NameInMap("amount")
        public String amount;

        @NameInMap("categoryCode")
        public String categoryCode;

        @NameInMap("code")
        public String code;

        @NameInMap("customerCode")
        public String customerCode;

        @NameInMap("enterpriseAcountCode")
        public String enterpriseAcountCode;

        @NameInMap("occurDate")
        public Long occurDate;

        @NameInMap("principalId")
        public String principalId;

        @NameInMap("projectCode")
        public String projectCode;

        @NameInMap("receiptType")
        public Long receiptType;

        @NameInMap("remark")
        public String remark;

        @NameInMap("supplierCode")
        public String supplierCode;

        @NameInMap("title")
        public String title;

        @NameInMap("updateTime")
        public Long updateTime;

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
