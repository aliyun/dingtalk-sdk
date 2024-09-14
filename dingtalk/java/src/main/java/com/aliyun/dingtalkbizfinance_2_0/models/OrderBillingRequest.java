// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class OrderBillingRequest extends TeaModel {
    @NameInMap("additionInfos")
    public java.util.List<OrderBillingRequestAdditionInfos> additionInfos;

    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("appKey")
    public String appKey;

    @NameInMap("applyPerson")
    public String applyPerson;

    @NameInMap("invoiceRemark")
    public String invoiceRemark;

    /**
     * <strong>example:</strong>
     * <p>VAT_NORMAL_E</p>
     */
    @NameInMap("invoiceType")
    public String invoiceType;

    @NameInMap("isNaturalPerson")
    public Boolean isNaturalPerson;

    @NameInMap("operator")
    public String operator;

    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("orderId")
    public String orderId;

    @NameInMap("payee")
    public String payee;

    @NameInMap("phone")
    public String phone;

    @NameInMap("products")
    public java.util.List<OrderBillingRequestProducts> products;

    /**
     * <strong>example:</strong>
     * <p>浙江省杭州市XXX街道</p>
     */
    @NameInMap("purchaserAddress")
    public String purchaserAddress;

    @NameInMap("purchaserBankAccount")
    public String purchaserBankAccount;

    @NameInMap("purchaserBankName")
    public String purchaserBankName;

    /**
     * <strong>example:</strong>
     * <p>XXX公司</p>
     */
    @NameInMap("purchaserName")
    public String purchaserName;

    @NameInMap("purchaserTaxNo")
    public String purchaserTaxNo;

    @NameInMap("purchaserTel")
    public String purchaserTel;

    @NameInMap("remark")
    public String remark;

    @NameInMap("reviewer")
    public String reviewer;

    @NameInMap("signature")
    public String signature;

    @NameInMap("taxSign")
    public Integer taxSign;

    public static OrderBillingRequest build(java.util.Map<String, ?> map) throws Exception {
        OrderBillingRequest self = new OrderBillingRequest();
        return TeaModel.build(map, self);
    }

    public OrderBillingRequest setAdditionInfos(java.util.List<OrderBillingRequestAdditionInfos> additionInfos) {
        this.additionInfos = additionInfos;
        return this;
    }
    public java.util.List<OrderBillingRequestAdditionInfos> getAdditionInfos() {
        return this.additionInfos;
    }

    public OrderBillingRequest setAppKey(String appKey) {
        this.appKey = appKey;
        return this;
    }
    public String getAppKey() {
        return this.appKey;
    }

    public OrderBillingRequest setApplyPerson(String applyPerson) {
        this.applyPerson = applyPerson;
        return this;
    }
    public String getApplyPerson() {
        return this.applyPerson;
    }

    public OrderBillingRequest setInvoiceRemark(String invoiceRemark) {
        this.invoiceRemark = invoiceRemark;
        return this;
    }
    public String getInvoiceRemark() {
        return this.invoiceRemark;
    }

    public OrderBillingRequest setInvoiceType(String invoiceType) {
        this.invoiceType = invoiceType;
        return this;
    }
    public String getInvoiceType() {
        return this.invoiceType;
    }

    public OrderBillingRequest setIsNaturalPerson(Boolean isNaturalPerson) {
        this.isNaturalPerson = isNaturalPerson;
        return this;
    }
    public Boolean getIsNaturalPerson() {
        return this.isNaturalPerson;
    }

    public OrderBillingRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public OrderBillingRequest setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

    public OrderBillingRequest setPayee(String payee) {
        this.payee = payee;
        return this;
    }
    public String getPayee() {
        return this.payee;
    }

    public OrderBillingRequest setPhone(String phone) {
        this.phone = phone;
        return this;
    }
    public String getPhone() {
        return this.phone;
    }

    public OrderBillingRequest setProducts(java.util.List<OrderBillingRequestProducts> products) {
        this.products = products;
        return this;
    }
    public java.util.List<OrderBillingRequestProducts> getProducts() {
        return this.products;
    }

    public OrderBillingRequest setPurchaserAddress(String purchaserAddress) {
        this.purchaserAddress = purchaserAddress;
        return this;
    }
    public String getPurchaserAddress() {
        return this.purchaserAddress;
    }

    public OrderBillingRequest setPurchaserBankAccount(String purchaserBankAccount) {
        this.purchaserBankAccount = purchaserBankAccount;
        return this;
    }
    public String getPurchaserBankAccount() {
        return this.purchaserBankAccount;
    }

    public OrderBillingRequest setPurchaserBankName(String purchaserBankName) {
        this.purchaserBankName = purchaserBankName;
        return this;
    }
    public String getPurchaserBankName() {
        return this.purchaserBankName;
    }

    public OrderBillingRequest setPurchaserName(String purchaserName) {
        this.purchaserName = purchaserName;
        return this;
    }
    public String getPurchaserName() {
        return this.purchaserName;
    }

    public OrderBillingRequest setPurchaserTaxNo(String purchaserTaxNo) {
        this.purchaserTaxNo = purchaserTaxNo;
        return this;
    }
    public String getPurchaserTaxNo() {
        return this.purchaserTaxNo;
    }

    public OrderBillingRequest setPurchaserTel(String purchaserTel) {
        this.purchaserTel = purchaserTel;
        return this;
    }
    public String getPurchaserTel() {
        return this.purchaserTel;
    }

    public OrderBillingRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public OrderBillingRequest setReviewer(String reviewer) {
        this.reviewer = reviewer;
        return this;
    }
    public String getReviewer() {
        return this.reviewer;
    }

    public OrderBillingRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

    public OrderBillingRequest setTaxSign(Integer taxSign) {
        this.taxSign = taxSign;
        return this;
    }
    public Integer getTaxSign() {
        return this.taxSign;
    }

    public static class OrderBillingRequestAdditionInfos extends TeaModel {
        @NameInMap("additionContent")
        public String additionContent;

        @NameInMap("additionName")
        public String additionName;

        @NameInMap("dataType")
        public Integer dataType;

        public static OrderBillingRequestAdditionInfos build(java.util.Map<String, ?> map) throws Exception {
            OrderBillingRequestAdditionInfos self = new OrderBillingRequestAdditionInfos();
            return TeaModel.build(map, self);
        }

        public OrderBillingRequestAdditionInfos setAdditionContent(String additionContent) {
            this.additionContent = additionContent;
            return this;
        }
        public String getAdditionContent() {
            return this.additionContent;
        }

        public OrderBillingRequestAdditionInfos setAdditionName(String additionName) {
            this.additionName = additionName;
            return this;
        }
        public String getAdditionName() {
            return this.additionName;
        }

        public OrderBillingRequestAdditionInfos setDataType(Integer dataType) {
            this.dataType = dataType;
            return this;
        }
        public Integer getDataType() {
            return this.dataType;
        }

    }

    public static class OrderBillingRequestProducts extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>12.55</p>
         */
        @NameInMap("amountWithTax")
        public String amountWithTax;

        /**
         * <strong>example:</strong>
         * <p>面包</p>
         */
        @NameInMap("productName")
        public String productName;

        /**
         * <strong>example:</strong>
         * <p>5</p>
         */
        @NameInMap("quantity")
        public String quantity;

        @NameInMap("revenueCode")
        public String revenueCode;

        @NameInMap("specification")
        public String specification;

        /**
         * <strong>example:</strong>
         * <p>个</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <strong>example:</strong>
         * <p>19.99</p>
         */
        @NameInMap("unitPrice")
        public String unitPrice;

        public static OrderBillingRequestProducts build(java.util.Map<String, ?> map) throws Exception {
            OrderBillingRequestProducts self = new OrderBillingRequestProducts();
            return TeaModel.build(map, self);
        }

        public OrderBillingRequestProducts setAmountWithTax(String amountWithTax) {
            this.amountWithTax = amountWithTax;
            return this;
        }
        public String getAmountWithTax() {
            return this.amountWithTax;
        }

        public OrderBillingRequestProducts setProductName(String productName) {
            this.productName = productName;
            return this;
        }
        public String getProductName() {
            return this.productName;
        }

        public OrderBillingRequestProducts setQuantity(String quantity) {
            this.quantity = quantity;
            return this;
        }
        public String getQuantity() {
            return this.quantity;
        }

        public OrderBillingRequestProducts setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public OrderBillingRequestProducts setSpecification(String specification) {
            this.specification = specification;
            return this;
        }
        public String getSpecification() {
            return this.specification;
        }

        public OrderBillingRequestProducts setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public OrderBillingRequestProducts setUnitPrice(String unitPrice) {
            this.unitPrice = unitPrice;
            return this;
        }
        public String getUnitPrice() {
            return this.unitPrice;
        }

    }

}
