// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptForInvoiceResponseBody extends TeaModel {
    // 是否还有数据
    @NameInMap("hasMore")
    public String hasMore;

    // 分页数据
    @NameInMap("list")
    public java.util.List<QueryReceiptForInvoiceResponseBodyList> list;

    // 总数
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
        // 创建人头像
        @NameInMap("avatarUrl")
        public String avatarUrl;

        // 创建人昵称
        @NameInMap("nick")
        public String nick;

        // 创建人工号
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
        // 客户code
        @NameInMap("code")
        public String code;

        // 客户名字
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

    public static class QueryReceiptForInvoiceResponseBodyList extends TeaModel {
        // 金额
        @NameInMap("amount")
        public String amount;

        // 开票状态
        @NameInMap("applyStatus")
        public String applyStatus;

        // 创建时间
        @NameInMap("createTime")
        public String createTime;

        // 创建人
        @NameInMap("creator")
        public QueryReceiptForInvoiceResponseBodyListCreator creator;

        // 客户
        @NameInMap("customer")
        public QueryReceiptForInvoiceResponseBodyListCustomer customer;

        // 发票种类
        @NameInMap("invoiceType")
        public String invoiceType;

        // 主数据modelId
        @NameInMap("modelId")
        public String modelId;

        // 购方账户
        @NameInMap("purchaserAccount")
        public String purchaserAccount;

        // 购方地址
        @NameInMap("purchaserAddress")
        public String purchaserAddress;

        // 购方银行
        @NameInMap("purchaserBankName")
        public String purchaserBankName;

        // 购方抬头
        @NameInMap("purchaserName")
        public String purchaserName;

        // 购方税号
        @NameInMap("purchaserTaxNo")
        public String purchaserTaxNo;

        // 购方电话
        @NameInMap("purchaserTel")
        public String purchaserTel;

        // 单据ID
        @NameInMap("receiptId")
        public String receiptId;

        // 记录时间，默认为审批通过时间
        @NameInMap("recordTime")
        public String recordTime;

        // 备注
        @NameInMap("remark")
        public String remark;

        // 来源
        @NameInMap("source")
        public String source;

        // 状态 agree running
        @NameInMap("status")
        public String status;

        // 单据标题
        @NameInMap("title")
        public String title;

        public static QueryReceiptForInvoiceResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryReceiptForInvoiceResponseBodyList self = new QueryReceiptForInvoiceResponseBodyList();
            return TeaModel.build(map, self);
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
