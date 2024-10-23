// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class IssueInvoiceWithOrderRequest extends TeaModel {
    @NameInMap("content")
    public IssueInvoiceWithOrderRequestContent content;

    @NameInMap("financeAppKey")
    public String financeAppKey;

    @NameInMap("operator")
    public String operator;

    @NameInMap("signature")
    public String signature;

    public static IssueInvoiceWithOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        IssueInvoiceWithOrderRequest self = new IssueInvoiceWithOrderRequest();
        return TeaModel.build(map, self);
    }

    public IssueInvoiceWithOrderRequest setContent(IssueInvoiceWithOrderRequestContent content) {
        this.content = content;
        return this;
    }
    public IssueInvoiceWithOrderRequestContent getContent() {
        return this.content;
    }

    public IssueInvoiceWithOrderRequest setFinanceAppKey(String financeAppKey) {
        this.financeAppKey = financeAppKey;
        return this;
    }
    public String getFinanceAppKey() {
        return this.financeAppKey;
    }

    public IssueInvoiceWithOrderRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public IssueInvoiceWithOrderRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

    public static class IssueInvoiceWithOrderRequestContentAdditionInfo extends TeaModel {
        @NameInMap("additionContent")
        public String additionContent;

        @NameInMap("additionName")
        public String additionName;

        @NameInMap("dataType")
        public Long dataType;

        public static IssueInvoiceWithOrderRequestContentAdditionInfo build(java.util.Map<String, ?> map) throws Exception {
            IssueInvoiceWithOrderRequestContentAdditionInfo self = new IssueInvoiceWithOrderRequestContentAdditionInfo();
            return TeaModel.build(map, self);
        }

        public IssueInvoiceWithOrderRequestContentAdditionInfo setAdditionContent(String additionContent) {
            this.additionContent = additionContent;
            return this;
        }
        public String getAdditionContent() {
            return this.additionContent;
        }

        public IssueInvoiceWithOrderRequestContentAdditionInfo setAdditionName(String additionName) {
            this.additionName = additionName;
            return this;
        }
        public String getAdditionName() {
            return this.additionName;
        }

        public IssueInvoiceWithOrderRequestContentAdditionInfo setDataType(Long dataType) {
            this.dataType = dataType;
            return this;
        }
        public Long getDataType() {
            return this.dataType;
        }

    }

    public static class IssueInvoiceWithOrderRequestContentProducts extends TeaModel {
        @NameInMap("amountIncludeTax")
        public String amountIncludeTax;

        @NameInMap("productName")
        public String productName;

        @NameInMap("quantity")
        public String quantity;

        @NameInMap("revenueCode")
        public String revenueCode;

        @NameInMap("specs")
        public String specs;

        @NameInMap("taxSign")
        public String taxSign;

        @NameInMap("unit")
        public String unit;

        public static IssueInvoiceWithOrderRequestContentProducts build(java.util.Map<String, ?> map) throws Exception {
            IssueInvoiceWithOrderRequestContentProducts self = new IssueInvoiceWithOrderRequestContentProducts();
            return TeaModel.build(map, self);
        }

        public IssueInvoiceWithOrderRequestContentProducts setAmountIncludeTax(String amountIncludeTax) {
            this.amountIncludeTax = amountIncludeTax;
            return this;
        }
        public String getAmountIncludeTax() {
            return this.amountIncludeTax;
        }

        public IssueInvoiceWithOrderRequestContentProducts setProductName(String productName) {
            this.productName = productName;
            return this;
        }
        public String getProductName() {
            return this.productName;
        }

        public IssueInvoiceWithOrderRequestContentProducts setQuantity(String quantity) {
            this.quantity = quantity;
            return this;
        }
        public String getQuantity() {
            return this.quantity;
        }

        public IssueInvoiceWithOrderRequestContentProducts setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public IssueInvoiceWithOrderRequestContentProducts setSpecs(String specs) {
            this.specs = specs;
            return this;
        }
        public String getSpecs() {
            return this.specs;
        }

        public IssueInvoiceWithOrderRequestContentProducts setTaxSign(String taxSign) {
            this.taxSign = taxSign;
            return this;
        }
        public String getTaxSign() {
            return this.taxSign;
        }

        public IssueInvoiceWithOrderRequestContentProducts setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class IssueInvoiceWithOrderRequestContent extends TeaModel {
        @NameInMap("additionInfo")
        public java.util.List<IssueInvoiceWithOrderRequestContentAdditionInfo> additionInfo;

        @NameInMap("applyPerson")
        public String applyPerson;

        @NameInMap("bankAccount")
        public String bankAccount;

        @NameInMap("bankName")
        public String bankName;

        @NameInMap("invoiceRemark")
        public String invoiceRemark;

        @NameInMap("invoiceType")
        public Long invoiceType;

        @NameInMap("naturalPerson")
        public String naturalPerson;

        @NameInMap("orderId")
        public String orderId;

        @NameInMap("payee")
        public String payee;

        @NameInMap("phone")
        public String phone;

        @NameInMap("products")
        public java.util.List<IssueInvoiceWithOrderRequestContentProducts> products;

        @NameInMap("purchaser")
        public String purchaser;

        @NameInMap("purchaserAddress")
        public String purchaserAddress;

        @NameInMap("purchaserTel")
        public String purchaserTel;

        @NameInMap("remark")
        public String remark;

        @NameInMap("reviewer")
        public String reviewer;

        @NameInMap("taxnum")
        public String taxnum;

        public static IssueInvoiceWithOrderRequestContent build(java.util.Map<String, ?> map) throws Exception {
            IssueInvoiceWithOrderRequestContent self = new IssueInvoiceWithOrderRequestContent();
            return TeaModel.build(map, self);
        }

        public IssueInvoiceWithOrderRequestContent setAdditionInfo(java.util.List<IssueInvoiceWithOrderRequestContentAdditionInfo> additionInfo) {
            this.additionInfo = additionInfo;
            return this;
        }
        public java.util.List<IssueInvoiceWithOrderRequestContentAdditionInfo> getAdditionInfo() {
            return this.additionInfo;
        }

        public IssueInvoiceWithOrderRequestContent setApplyPerson(String applyPerson) {
            this.applyPerson = applyPerson;
            return this;
        }
        public String getApplyPerson() {
            return this.applyPerson;
        }

        public IssueInvoiceWithOrderRequestContent setBankAccount(String bankAccount) {
            this.bankAccount = bankAccount;
            return this;
        }
        public String getBankAccount() {
            return this.bankAccount;
        }

        public IssueInvoiceWithOrderRequestContent setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

        public IssueInvoiceWithOrderRequestContent setInvoiceRemark(String invoiceRemark) {
            this.invoiceRemark = invoiceRemark;
            return this;
        }
        public String getInvoiceRemark() {
            return this.invoiceRemark;
        }

        public IssueInvoiceWithOrderRequestContent setInvoiceType(Long invoiceType) {
            this.invoiceType = invoiceType;
            return this;
        }
        public Long getInvoiceType() {
            return this.invoiceType;
        }

        public IssueInvoiceWithOrderRequestContent setNaturalPerson(String naturalPerson) {
            this.naturalPerson = naturalPerson;
            return this;
        }
        public String getNaturalPerson() {
            return this.naturalPerson;
        }

        public IssueInvoiceWithOrderRequestContent setOrderId(String orderId) {
            this.orderId = orderId;
            return this;
        }
        public String getOrderId() {
            return this.orderId;
        }

        public IssueInvoiceWithOrderRequestContent setPayee(String payee) {
            this.payee = payee;
            return this;
        }
        public String getPayee() {
            return this.payee;
        }

        public IssueInvoiceWithOrderRequestContent setPhone(String phone) {
            this.phone = phone;
            return this;
        }
        public String getPhone() {
            return this.phone;
        }

        public IssueInvoiceWithOrderRequestContent setProducts(java.util.List<IssueInvoiceWithOrderRequestContentProducts> products) {
            this.products = products;
            return this;
        }
        public java.util.List<IssueInvoiceWithOrderRequestContentProducts> getProducts() {
            return this.products;
        }

        public IssueInvoiceWithOrderRequestContent setPurchaser(String purchaser) {
            this.purchaser = purchaser;
            return this;
        }
        public String getPurchaser() {
            return this.purchaser;
        }

        public IssueInvoiceWithOrderRequestContent setPurchaserAddress(String purchaserAddress) {
            this.purchaserAddress = purchaserAddress;
            return this;
        }
        public String getPurchaserAddress() {
            return this.purchaserAddress;
        }

        public IssueInvoiceWithOrderRequestContent setPurchaserTel(String purchaserTel) {
            this.purchaserTel = purchaserTel;
            return this;
        }
        public String getPurchaserTel() {
            return this.purchaserTel;
        }

        public IssueInvoiceWithOrderRequestContent setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public IssueInvoiceWithOrderRequestContent setReviewer(String reviewer) {
            this.reviewer = reviewer;
            return this;
        }
        public String getReviewer() {
            return this.reviewer;
        }

        public IssueInvoiceWithOrderRequestContent setTaxnum(String taxnum) {
            this.taxnum = taxnum;
            return this;
        }
        public String getTaxnum() {
            return this.taxnum;
        }

    }

}
