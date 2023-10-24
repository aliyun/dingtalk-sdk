// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptForInvoiceResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public String hasMore;

    @NameInMap("list")
    public java.util.List<QueryReceiptForInvoiceResponseBodyList> list;

    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryReceiptForInvoiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptForInvoiceResponseBody self = new QueryReceiptForInvoiceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryReceiptForInvoiceResponseBody setHasMore(String hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public String getHasMore() {
        return this.hasMore;
    }

    public QueryReceiptForInvoiceResponseBody setList(java.util.List<QueryReceiptForInvoiceResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryReceiptForInvoiceResponseBodyList> getList() {
        return this.list;
    }

    public QueryReceiptForInvoiceResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryReceiptForInvoiceResponseBodyListCreator extends TeaModel {
        @NameInMap("avatarUrl")
        public String avatarUrl;

        @NameInMap("nick")
        public String nick;

        @NameInMap("userId")
        public String userId;

        public static QueryReceiptForInvoiceResponseBodyListCreator build(java.util.Map<String, ?> map) throws Exception {
            QueryReceiptForInvoiceResponseBodyListCreator self = new QueryReceiptForInvoiceResponseBodyListCreator();
            return TeaModel.build(map, self);
        }

        public QueryReceiptForInvoiceResponseBodyListCreator setAvatarUrl(String avatarUrl) {
            this.avatarUrl = avatarUrl;
            return this;
        }
        public String getAvatarUrl() {
            return this.avatarUrl;
        }

        public QueryReceiptForInvoiceResponseBodyListCreator setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public QueryReceiptForInvoiceResponseBodyListCreator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryReceiptForInvoiceResponseBodyListCustomer extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        public static QueryReceiptForInvoiceResponseBodyListCustomer build(java.util.Map<String, ?> map) throws Exception {
            QueryReceiptForInvoiceResponseBodyListCustomer self = new QueryReceiptForInvoiceResponseBodyListCustomer();
            return TeaModel.build(map, self);
        }

        public QueryReceiptForInvoiceResponseBodyListCustomer setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryReceiptForInvoiceResponseBodyListCustomer setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class QueryReceiptForInvoiceResponseBodyListProductInfoList extends TeaModel {
        @NameInMap("amountWithTax")
        public String amountWithTax;

        @NameInMap("amountWithoutTax")
        public String amountWithoutTax;

        @NameInMap("discountAmount")
        public String discountAmount;

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

        public static QueryReceiptForInvoiceResponseBodyListProductInfoList build(java.util.Map<String, ?> map) throws Exception {
            QueryReceiptForInvoiceResponseBodyListProductInfoList self = new QueryReceiptForInvoiceResponseBodyListProductInfoList();
            return TeaModel.build(map, self);
        }

        public QueryReceiptForInvoiceResponseBodyListProductInfoList setAmountWithTax(String amountWithTax) {
            this.amountWithTax = amountWithTax;
            return this;
        }
        public String getAmountWithTax() {
            return this.amountWithTax;
        }

        public QueryReceiptForInvoiceResponseBodyListProductInfoList setAmountWithoutTax(String amountWithoutTax) {
            this.amountWithoutTax = amountWithoutTax;
            return this;
        }
        public String getAmountWithoutTax() {
            return this.amountWithoutTax;
        }

        public QueryReceiptForInvoiceResponseBodyListProductInfoList setDiscountAmount(String discountAmount) {
            this.discountAmount = discountAmount;
            return this;
        }
        public String getDiscountAmount() {
            return this.discountAmount;
        }

        public QueryReceiptForInvoiceResponseBodyListProductInfoList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryReceiptForInvoiceResponseBodyListProductInfoList setQuantity(String quantity) {
            this.quantity = quantity;
            return this;
        }
        public String getQuantity() {
            return this.quantity;
        }

        public QueryReceiptForInvoiceResponseBodyListProductInfoList setSpecification(String specification) {
            this.specification = specification;
            return this;
        }
        public String getSpecification() {
            return this.specification;
        }

        public QueryReceiptForInvoiceResponseBodyListProductInfoList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public QueryReceiptForInvoiceResponseBodyListProductInfoList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public QueryReceiptForInvoiceResponseBodyListProductInfoList setUnitPriceWithTax(String unitPriceWithTax) {
            this.unitPriceWithTax = unitPriceWithTax;
            return this;
        }
        public String getUnitPriceWithTax() {
            return this.unitPriceWithTax;
        }

        public QueryReceiptForInvoiceResponseBodyListProductInfoList setUnitPriceWithoutTax(String unitPriceWithoutTax) {
            this.unitPriceWithoutTax = unitPriceWithoutTax;
            return this;
        }
        public String getUnitPriceWithoutTax() {
            return this.unitPriceWithoutTax;
        }

        public QueryReceiptForInvoiceResponseBodyListProductInfoList setWithTax(Boolean withTax) {
            this.withTax = withTax;
            return this;
        }
        public Boolean getWithTax() {
            return this.withTax;
        }

    }

    public static class QueryReceiptForInvoiceResponseBodyList extends TeaModel {
        @NameInMap("accountantBookId")
        public String accountantBookId;

        @NameInMap("amount")
        public String amount;

        @NameInMap("applyStatus")
        public String applyStatus;

        @NameInMap("bizStatus")
        public String bizStatus;

        @NameInMap("businessId")
        public String businessId;

        @NameInMap("companyCode")
        public String companyCode;

        @NameInMap("createTime")
        public String createTime;

        @NameInMap("creator")
        public QueryReceiptForInvoiceResponseBodyListCreator creator;

        @NameInMap("customer")
        public QueryReceiptForInvoiceResponseBodyListCustomer customer;

        @NameInMap("drawerEmail")
        public String drawerEmail;

        @NameInMap("drawerTelephone")
        public String drawerTelephone;

        @NameInMap("invoiceType")
        public String invoiceType;

        @NameInMap("modelId")
        public String modelId;

        @NameInMap("productInfoList")
        public java.util.List<QueryReceiptForInvoiceResponseBodyListProductInfoList> productInfoList;

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

        public static QueryReceiptForInvoiceResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryReceiptForInvoiceResponseBodyList self = new QueryReceiptForInvoiceResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryReceiptForInvoiceResponseBodyList setAccountantBookId(String accountantBookId) {
            this.accountantBookId = accountantBookId;
            return this;
        }
        public String getAccountantBookId() {
            return this.accountantBookId;
        }

        public QueryReceiptForInvoiceResponseBodyList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public QueryReceiptForInvoiceResponseBodyList setApplyStatus(String applyStatus) {
            this.applyStatus = applyStatus;
            return this;
        }
        public String getApplyStatus() {
            return this.applyStatus;
        }

        public QueryReceiptForInvoiceResponseBodyList setBizStatus(String bizStatus) {
            this.bizStatus = bizStatus;
            return this;
        }
        public String getBizStatus() {
            return this.bizStatus;
        }

        public QueryReceiptForInvoiceResponseBodyList setBusinessId(String businessId) {
            this.businessId = businessId;
            return this;
        }
        public String getBusinessId() {
            return this.businessId;
        }

        public QueryReceiptForInvoiceResponseBodyList setCompanyCode(String companyCode) {
            this.companyCode = companyCode;
            return this;
        }
        public String getCompanyCode() {
            return this.companyCode;
        }

        public QueryReceiptForInvoiceResponseBodyList setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public QueryReceiptForInvoiceResponseBodyList setCreator(QueryReceiptForInvoiceResponseBodyListCreator creator) {
            this.creator = creator;
            return this;
        }
        public QueryReceiptForInvoiceResponseBodyListCreator getCreator() {
            return this.creator;
        }

        public QueryReceiptForInvoiceResponseBodyList setCustomer(QueryReceiptForInvoiceResponseBodyListCustomer customer) {
            this.customer = customer;
            return this;
        }
        public QueryReceiptForInvoiceResponseBodyListCustomer getCustomer() {
            return this.customer;
        }

        public QueryReceiptForInvoiceResponseBodyList setDrawerEmail(String drawerEmail) {
            this.drawerEmail = drawerEmail;
            return this;
        }
        public String getDrawerEmail() {
            return this.drawerEmail;
        }

        public QueryReceiptForInvoiceResponseBodyList setDrawerTelephone(String drawerTelephone) {
            this.drawerTelephone = drawerTelephone;
            return this;
        }
        public String getDrawerTelephone() {
            return this.drawerTelephone;
        }

        public QueryReceiptForInvoiceResponseBodyList setInvoiceType(String invoiceType) {
            this.invoiceType = invoiceType;
            return this;
        }
        public String getInvoiceType() {
            return this.invoiceType;
        }

        public QueryReceiptForInvoiceResponseBodyList setModelId(String modelId) {
            this.modelId = modelId;
            return this;
        }
        public String getModelId() {
            return this.modelId;
        }

        public QueryReceiptForInvoiceResponseBodyList setProductInfoList(java.util.List<QueryReceiptForInvoiceResponseBodyListProductInfoList> productInfoList) {
            this.productInfoList = productInfoList;
            return this;
        }
        public java.util.List<QueryReceiptForInvoiceResponseBodyListProductInfoList> getProductInfoList() {
            return this.productInfoList;
        }

        public QueryReceiptForInvoiceResponseBodyList setPurchaserAccount(String purchaserAccount) {
            this.purchaserAccount = purchaserAccount;
            return this;
        }
        public String getPurchaserAccount() {
            return this.purchaserAccount;
        }

        public QueryReceiptForInvoiceResponseBodyList setPurchaserAddress(String purchaserAddress) {
            this.purchaserAddress = purchaserAddress;
            return this;
        }
        public String getPurchaserAddress() {
            return this.purchaserAddress;
        }

        public QueryReceiptForInvoiceResponseBodyList setPurchaserBankName(String purchaserBankName) {
            this.purchaserBankName = purchaserBankName;
            return this;
        }
        public String getPurchaserBankName() {
            return this.purchaserBankName;
        }

        public QueryReceiptForInvoiceResponseBodyList setPurchaserName(String purchaserName) {
            this.purchaserName = purchaserName;
            return this;
        }
        public String getPurchaserName() {
            return this.purchaserName;
        }

        public QueryReceiptForInvoiceResponseBodyList setPurchaserTaxNo(String purchaserTaxNo) {
            this.purchaserTaxNo = purchaserTaxNo;
            return this;
        }
        public String getPurchaserTaxNo() {
            return this.purchaserTaxNo;
        }

        public QueryReceiptForInvoiceResponseBodyList setPurchaserTel(String purchaserTel) {
            this.purchaserTel = purchaserTel;
            return this;
        }
        public String getPurchaserTel() {
            return this.purchaserTel;
        }

        public QueryReceiptForInvoiceResponseBodyList setReceiptId(String receiptId) {
            this.receiptId = receiptId;
            return this;
        }
        public String getReceiptId() {
            return this.receiptId;
        }

        public QueryReceiptForInvoiceResponseBodyList setRecordTime(String recordTime) {
            this.recordTime = recordTime;
            return this;
        }
        public String getRecordTime() {
            return this.recordTime;
        }

        public QueryReceiptForInvoiceResponseBodyList setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public QueryReceiptForInvoiceResponseBodyList setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

        public QueryReceiptForInvoiceResponseBodyList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryReceiptForInvoiceResponseBodyList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
