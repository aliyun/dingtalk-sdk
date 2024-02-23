// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncInvoiceRequest extends TeaModel {
    @NameInMap("address")
    public String address;

    @NameInMap("bankName")
    public String bankName;

    @NameInMap("bankNo")
    public String bankNo;

    @NameInMap("channelCorpId")
    public String channelCorpId;

    @NameInMap("deleteFlag")
    public Boolean deleteFlag;

    @NameInMap("gmtAction")
    public String gmtAction;

    @NameInMap("invoiceId")
    public String invoiceId;

    @NameInMap("projectIds")
    public java.util.List<String> projectIds;

    @NameInMap("source")
    public String source;

    @NameInMap("taxNo")
    public String taxNo;

    @NameInMap("tel")
    public String tel;

    @NameInMap("thirdPartId")
    public String thirdPartId;

    @NameInMap("title")
    public String title;

    @NameInMap("type")
    public Integer type;

    @NameInMap("unitType")
    public Integer unitType;

    @NameInMap("userId")
    public String userId;

    public static SyncInvoiceRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncInvoiceRequest self = new SyncInvoiceRequest();
        return TeaModel.build(map, self);
    }

    public SyncInvoiceRequest setAddress(String address) {
        this.address = address;
        return this;
    }
    public String getAddress() {
        return this.address;
    }

    public SyncInvoiceRequest setBankName(String bankName) {
        this.bankName = bankName;
        return this;
    }
    public String getBankName() {
        return this.bankName;
    }

    public SyncInvoiceRequest setBankNo(String bankNo) {
        this.bankNo = bankNo;
        return this;
    }
    public String getBankNo() {
        return this.bankNo;
    }

    public SyncInvoiceRequest setChannelCorpId(String channelCorpId) {
        this.channelCorpId = channelCorpId;
        return this;
    }
    public String getChannelCorpId() {
        return this.channelCorpId;
    }

    public SyncInvoiceRequest setDeleteFlag(Boolean deleteFlag) {
        this.deleteFlag = deleteFlag;
        return this;
    }
    public Boolean getDeleteFlag() {
        return this.deleteFlag;
    }

    public SyncInvoiceRequest setGmtAction(String gmtAction) {
        this.gmtAction = gmtAction;
        return this;
    }
    public String getGmtAction() {
        return this.gmtAction;
    }

    public SyncInvoiceRequest setInvoiceId(String invoiceId) {
        this.invoiceId = invoiceId;
        return this;
    }
    public String getInvoiceId() {
        return this.invoiceId;
    }

    public SyncInvoiceRequest setProjectIds(java.util.List<String> projectIds) {
        this.projectIds = projectIds;
        return this;
    }
    public java.util.List<String> getProjectIds() {
        return this.projectIds;
    }

    public SyncInvoiceRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public SyncInvoiceRequest setTaxNo(String taxNo) {
        this.taxNo = taxNo;
        return this;
    }
    public String getTaxNo() {
        return this.taxNo;
    }

    public SyncInvoiceRequest setTel(String tel) {
        this.tel = tel;
        return this;
    }
    public String getTel() {
        return this.tel;
    }

    public SyncInvoiceRequest setThirdPartId(String thirdPartId) {
        this.thirdPartId = thirdPartId;
        return this;
    }
    public String getThirdPartId() {
        return this.thirdPartId;
    }

    public SyncInvoiceRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public SyncInvoiceRequest setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
    }

    public SyncInvoiceRequest setUnitType(Integer unitType) {
        this.unitType = unitType;
        return this;
    }
    public Integer getUnitType() {
        return this.unitType;
    }

    public SyncInvoiceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
