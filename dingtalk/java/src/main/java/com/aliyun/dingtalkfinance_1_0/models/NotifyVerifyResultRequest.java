// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class NotifyVerifyResultRequest extends TeaModel {
    /**
     * <p>企业ID</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>码值</p>
     */
    @NameInMap("payCode")
    public String payCode;

    /**
     * <p>备注信息</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>用户和企业的关系类型，区分内部员工，外部联系人，无关系普通用户</p>
     */
    @NameInMap("userCorpRelationType")
    public String userCorpRelationType;

    /**
     * <p>用户身份标识</p>
     */
    @NameInMap("userIdentity")
    public String userIdentity;

    /**
     * <p>验证事件，长度不超过8个中文</p>
     */
    @NameInMap("verifyEvent")
    public String verifyEvent;

    /**
     * <p>验证地点，调用时请务必传入，以便生成工牌使用记录</p>
     */
    @NameInMap("verifyLocation")
    public String verifyLocation;

    /**
     * <p>验证流水号，长度不超过32位，用户下唯一，调用时请务必传入，以便生成工牌使用记录</p>
     */
    @NameInMap("verifyNo")
    public String verifyNo;

    /**
     * <p>验证结果</p>
     */
    @NameInMap("verifyResult")
    public Boolean verifyResult;

    /**
     * <p>验证时间</p>
     */
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
