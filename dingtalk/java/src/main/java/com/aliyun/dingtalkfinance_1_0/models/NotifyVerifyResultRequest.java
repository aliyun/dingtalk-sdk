// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class NotifyVerifyResultRequest extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("payCode")
    public String payCode;

    @NameInMap("remark")
    public String remark;

    @NameInMap("userCorpRelationType")
    public String userCorpRelationType;

    @NameInMap("userIdentity")
    public String userIdentity;

    @NameInMap("verifyEvent")
    public String verifyEvent;

    @NameInMap("verifyLocation")
    public String verifyLocation;

    @NameInMap("verifyNo")
    public String verifyNo;

    @NameInMap("verifyResult")
    public Boolean verifyResult;

    @NameInMap("verifyTime")
    public String verifyTime;

    public static NotifyVerifyResultRequest build(java.util.Map<String, ?> map) throws Exception {
        NotifyVerifyResultRequest self = new NotifyVerifyResultRequest();
        return TeaModel.build(map, self);
    }

    public NotifyVerifyResultRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public NotifyVerifyResultRequest setPayCode(String payCode) {
        this.payCode = payCode;
        return this;
    }
    public String getPayCode() {
        return this.payCode;
    }

    public NotifyVerifyResultRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public NotifyVerifyResultRequest setUserCorpRelationType(String userCorpRelationType) {
        this.userCorpRelationType = userCorpRelationType;
        return this;
    }
    public String getUserCorpRelationType() {
        return this.userCorpRelationType;
    }

    public NotifyVerifyResultRequest setUserIdentity(String userIdentity) {
        this.userIdentity = userIdentity;
        return this;
    }
    public String getUserIdentity() {
        return this.userIdentity;
    }

    public NotifyVerifyResultRequest setVerifyEvent(String verifyEvent) {
        this.verifyEvent = verifyEvent;
        return this;
    }
    public String getVerifyEvent() {
        return this.verifyEvent;
    }

    public NotifyVerifyResultRequest setVerifyLocation(String verifyLocation) {
        this.verifyLocation = verifyLocation;
        return this;
    }
    public String getVerifyLocation() {
        return this.verifyLocation;
    }

    public NotifyVerifyResultRequest setVerifyNo(String verifyNo) {
        this.verifyNo = verifyNo;
        return this;
    }
    public String getVerifyNo() {
        return this.verifyNo;
    }

    public NotifyVerifyResultRequest setVerifyResult(Boolean verifyResult) {
        this.verifyResult = verifyResult;
        return this;
    }
    public Boolean getVerifyResult() {
        return this.verifyResult;
    }

    public NotifyVerifyResultRequest setVerifyTime(String verifyTime) {
        this.verifyTime = verifyTime;
        return this;
    }
    public String getVerifyTime() {
        return this.verifyTime;
    }

}
