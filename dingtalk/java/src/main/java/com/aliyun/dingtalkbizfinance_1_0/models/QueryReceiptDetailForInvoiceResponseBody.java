// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptDetailForInvoiceResponseBody extends TeaModel {
    /**
     * <p>结果</p>
     */
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
        /**
         * <p>创建人头像</p>
         */
        @NameInMap("avatarUrl")
        public String avatarUrl;

        /**
         * <p>创建人昵称</p>
         */
        @NameInMap("nick")
        public String nick;

        /**
         * <p>创建人工号</p>
         */
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
        /**
         * <p>客户code</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>客户名字</p>
         */
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
        /**
         * <p>含税金额</p>
         */
        @NameInMap("amountWithTax")
        public String amountWithTax;

        /**
         * <p>商品名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>数量</p>
         */
        @NameInMap("quantity")
        public String quantity;

        /**
         * <p>规格型号</p>
         */
        @NameInMap("specification")
        public String specification;

        /**
         * <p>税率</p>
         */
        @NameInMap("taxRate")
        public String taxRate;

        /**
         * <p>计量单位</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <p>含税单价</p>
         */
        @NameInMap("unitPriceWithTax")
        public String unitPriceWithTax;

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

    }

    public static class QueryReceiptDetailForInvoiceResponseBodyResult extends TeaModel {
        /**
         * <p>金额</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>开票状态</p>
         */
        @NameInMap("applyStatus")
        public String applyStatus;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <p>创建人</p>
         */
        @NameInMap("creator")
        public QueryReceiptDetailForInvoiceResponseBodyResultCreator creator;

        /**
         * <p>客户</p>
         */
        @NameInMap("customer")
        public QueryReceiptDetailForInvoiceResponseBodyResultCustomer customer;

        /**
         * <p>开票人邮箱</p>
         */
        @NameInMap("drawerEmail")
        public String drawerEmail;

        /**
         * <p>开票人手机号码</p>
         */
        @NameInMap("drawerTelephone")
        public String drawerTelephone;

        /**
         * <p>发票种类</p>
         */
        @NameInMap("invoiceType")
        public String invoiceType;

        /**
         * <p>主数据modelId</p>
         */
        @NameInMap("modelId")
        public String modelId;

        /**
         * <p>商品列表</p>
         */
        @NameInMap("productInfoList")
        public java.util.List<QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList> productInfoList;

        /**
         * <p>购方账户</p>
         */
        @NameInMap("purchaserAccount")
        public String purchaserAccount;

        /**
         * <p>购方地址</p>
         */
        @NameInMap("purchaserAddress")
        public String purchaserAddress;

        /**
         * <p>购方银行</p>
         */
        @NameInMap("purchaserBankName")
        public String purchaserBankName;

        /**
         * <p>购方抬头</p>
         */
        @NameInMap("purchaserName")
        public String purchaserName;

        /**
         * <p>购方税号</p>
         */
        @NameInMap("purchaserTaxNo")
        public String purchaserTaxNo;

        /**
         * <p>购方电话</p>
         */
        @NameInMap("purchaserTel")
        public String purchaserTel;

        /**
         * <p>单据ID</p>
         */
        @NameInMap("receiptId")
        public String receiptId;

        /**
         * <p>记录时间，默认为审批通过时间</p>
         */
        @NameInMap("recordTime")
        public String recordTime;

        /**
         * <p>备注</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <p>来源</p>
         */
        @NameInMap("source")
        public String source;

        /**
         * <p>状态 agree running</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>单据标题</p>
         */
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
