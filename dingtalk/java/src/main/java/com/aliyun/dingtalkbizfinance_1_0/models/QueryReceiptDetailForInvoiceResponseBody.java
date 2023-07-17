// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptDetailForInvoiceResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryReceiptDetailForInvoiceResponseBodyResult result;

    public static QueryReceiptDetailForInvoiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptDetailForInvoiceResponseBody self = new QueryReceiptDetailForInvoiceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryReceiptDetailForInvoiceResponseBody setResult(QueryReceiptDetailForInvoiceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryReceiptDetailForInvoiceResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryReceiptDetailForInvoiceResponseBodyResultCreator extends TeaModel {
        @NameInMap("avatarUrl")
        public String avatarUrl;

        @NameInMap("nick")
        public String nick;

        @NameInMap("userId")
        public String userId;

        public static QueryReceiptDetailForInvoiceResponseBodyResultCreator build(java.util.Map<String, ?> map) throws Exception {
            QueryReceiptDetailForInvoiceResponseBodyResultCreator self = new QueryReceiptDetailForInvoiceResponseBodyResultCreator();
            return TeaModel.build(map, self);
        }

        public QueryReceiptDetailForInvoiceResponseBodyResultCreator setAvatarUrl(String avatarUrl) {
            this.avatarUrl = avatarUrl;
            return this;
        }
        public String getAvatarUrl() {
            return this.avatarUrl;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResultCreator setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResultCreator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryReceiptDetailForInvoiceResponseBodyResultCustomer extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        public static QueryReceiptDetailForInvoiceResponseBodyResultCustomer build(java.util.Map<String, ?> map) throws Exception {
            QueryReceiptDetailForInvoiceResponseBodyResultCustomer self = new QueryReceiptDetailForInvoiceResponseBodyResultCustomer();
            return TeaModel.build(map, self);
        }

        public QueryReceiptDetailForInvoiceResponseBodyResultCustomer setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResultCustomer setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList extends TeaModel {
        @NameInMap("amountWithTax")
        public String amountWithTax;

        @NameInMap("amountWithoutTax")
        public String amountWithoutTax;

        @NameInMap("name")
        public String name;

        @NameInMap("quantity")
        public String quantity;

        @NameInMap("specification")
        public String specification;

        @NameInMap("taxRate")
        public String taxRate;

        @NameInMap("unit")
        public String unit;

        @NameInMap("unitPriceWithTax")
        public String unitPriceWithTax;

        @NameInMap("unitPriceWithoutTax")
        public String unitPriceWithoutTax;

        @NameInMap("withTax")
        public Boolean withTax;

        public static QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList build(java.util.Map<String, ?> map) throws Exception {
            QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList self = new QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList();
            return TeaModel.build(map, self);
        }

        public QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList setAmountWithTax(String amountWithTax) {
            this.amountWithTax = amountWithTax;
            return this;
        }
        public String getAmountWithTax() {
            return this.amountWithTax;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList setAmountWithoutTax(String amountWithoutTax) {
            this.amountWithoutTax = amountWithoutTax;
            return this;
        }
        public String getAmountWithoutTax() {
            return this.amountWithoutTax;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList setQuantity(String quantity) {
            this.quantity = quantity;
            return this;
        }
        public String getQuantity() {
            return this.quantity;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList setSpecification(String specification) {
            this.specification = specification;
            return this;
        }
        public String getSpecification() {
            return this.specification;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList setUnitPriceWithTax(String unitPriceWithTax) {
            this.unitPriceWithTax = unitPriceWithTax;
            return this;
        }
        public String getUnitPriceWithTax() {
            return this.unitPriceWithTax;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList setUnitPriceWithoutTax(String unitPriceWithoutTax) {
            this.unitPriceWithoutTax = unitPriceWithoutTax;
            return this;
        }
        public String getUnitPriceWithoutTax() {
            return this.unitPriceWithoutTax;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList setWithTax(Boolean withTax) {
            this.withTax = withTax;
            return this;
        }
        public Boolean getWithTax() {
            return this.withTax;
        }

    }

    public static class QueryReceiptDetailForInvoiceResponseBodyResult extends TeaModel {
        @NameInMap("amount")
        public String amount;

        @NameInMap("applyStatus")
        public String applyStatus;

        @NameInMap("bizStatus")
        public String bizStatus;

        @NameInMap("businessId")
        public String businessId;

        @NameInMap("createTime")
        public String createTime;

        @NameInMap("creator")
        public QueryReceiptDetailForInvoiceResponseBodyResultCreator creator;

        @NameInMap("customer")
        public QueryReceiptDetailForInvoiceResponseBodyResultCustomer customer;

        @NameInMap("drawerEmail")
        public String drawerEmail;

        @NameInMap("drawerTelephone")
        public String drawerTelephone;

        @NameInMap("invoiceType")
        public String invoiceType;

        @NameInMap("modelId")
        public String modelId;

        @NameInMap("productInfoList")
        public java.util.List<QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList> productInfoList;

        @NameInMap("purchaserAccount")
        public String purchaserAccount;

        @NameInMap("purchaserAddress")
        public String purchaserAddress;

        @NameInMap("purchaserBankName")
        public String purchaserBankName;

        @NameInMap("purchaserName")
        public String purchaserName;

        @NameInMap("purchaserTaxNo")
        public String purchaserTaxNo;

        @NameInMap("purchaserTel")
        public String purchaserTel;

        @NameInMap("receiptId")
        public String receiptId;

        @NameInMap("recordTime")
        public String recordTime;

        @NameInMap("remark")
        public String remark;

        @NameInMap("source")
        public String source;

        @NameInMap("status")
        public String status;

        @NameInMap("title")
        public String title;

        public static QueryReceiptDetailForInvoiceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryReceiptDetailForInvoiceResponseBodyResult self = new QueryReceiptDetailForInvoiceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setApplyStatus(String applyStatus) {
            this.applyStatus = applyStatus;
            return this;
        }
        public String getApplyStatus() {
            return this.applyStatus;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setBizStatus(String bizStatus) {
            this.bizStatus = bizStatus;
            return this;
        }
        public String getBizStatus() {
            return this.bizStatus;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setBusinessId(String businessId) {
            this.businessId = businessId;
            return this;
        }
        public String getBusinessId() {
            return this.businessId;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setCreator(QueryReceiptDetailForInvoiceResponseBodyResultCreator creator) {
            this.creator = creator;
            return this;
        }
        public QueryReceiptDetailForInvoiceResponseBodyResultCreator getCreator() {
            return this.creator;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setCustomer(QueryReceiptDetailForInvoiceResponseBodyResultCustomer customer) {
            this.customer = customer;
            return this;
        }
        public QueryReceiptDetailForInvoiceResponseBodyResultCustomer getCustomer() {
            return this.customer;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setDrawerEmail(String drawerEmail) {
            this.drawerEmail = drawerEmail;
            return this;
        }
        public String getDrawerEmail() {
            return this.drawerEmail;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setDrawerTelephone(String drawerTelephone) {
            this.drawerTelephone = drawerTelephone;
            return this;
        }
        public String getDrawerTelephone() {
            return this.drawerTelephone;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setInvoiceType(String invoiceType) {
            this.invoiceType = invoiceType;
            return this;
        }
        public String getInvoiceType() {
            return this.invoiceType;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setModelId(String modelId) {
            this.modelId = modelId;
            return this;
        }
        public String getModelId() {
            return this.modelId;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setProductInfoList(java.util.List<QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList> productInfoList) {
            this.productInfoList = productInfoList;
            return this;
        }
        public java.util.List<QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList> getProductInfoList() {
            return this.productInfoList;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setPurchaserAccount(String purchaserAccount) {
            this.purchaserAccount = purchaserAccount;
            return this;
        }
        public String getPurchaserAccount() {
            return this.purchaserAccount;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setPurchaserAddress(String purchaserAddress) {
            this.purchaserAddress = purchaserAddress;
            return this;
        }
        public String getPurchaserAddress() {
            return this.purchaserAddress;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setPurchaserBankName(String purchaserBankName) {
            this.purchaserBankName = purchaserBankName;
            return this;
        }
        public String getPurchaserBankName() {
            return this.purchaserBankName;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setPurchaserName(String purchaserName) {
            this.purchaserName = purchaserName;
            return this;
        }
        public String getPurchaserName() {
            return this.purchaserName;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setPurchaserTaxNo(String purchaserTaxNo) {
            this.purchaserTaxNo = purchaserTaxNo;
            return this;
        }
        public String getPurchaserTaxNo() {
            return this.purchaserTaxNo;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setPurchaserTel(String purchaserTel) {
            this.purchaserTel = purchaserTel;
            return this;
        }
        public String getPurchaserTel() {
            return this.purchaserTel;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setReceiptId(String receiptId) {
            this.receiptId = receiptId;
            return this;
        }
        public String getReceiptId() {
            return this.receiptId;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setRecordTime(String recordTime) {
            this.recordTime = recordTime;
            return this;
        }
        public String getRecordTime() {
            return this.recordTime;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryReceiptDetailForInvoiceResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
