// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class NotifyBadgeCodeVerifyResultRequest extends TeaModel {
    // 码值
    @NameInMap("payCode")
    public String payCode;

    // 企业ID
    @NameInMap("corpId")
    public String corpId;

    // 用户和企业的关系类型，区分内部员工，外部联系人，无关系普通用户
    @NameInMap("userCorpRelationType")
    public String userCorpRelationType;

    // 用户身份标识
    @NameInMap("userIdentity")
    public String userIdentity;

    // 验证时间
    @NameInMap("verifyTime")
    public String verifyTime;

    // 验证结果
    @NameInMap("verifyResult")
    public Boolean verifyResult;

    // 验证地点，调用时请务必传入，以便生成工牌使用记录
    @NameInMap("verifyLocation")
    public String verifyLocation;

    // 验证流水号，长度不超过32位，用户下唯一，调用时请务必传入，以便生成工牌使用记录
    @NameInMap("verifyNo")
    public String verifyNo;

    // 验证事件，长度不超过8个中文
    @NameInMap("verifyEvent")
    public String verifyEvent;

    // 备注信息
    @NameInMap("remark")
    public String remark;

    // 组织ID
    @NameInMap("dingOrgId")
    public Long dingOrgId;

    // ISV组织ID
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    public static NotifyBadgeCodeVerifyResultRequest build(java.util.Map<String, ?> map) throws Exception {
        NotifyBadgeCodeVerifyResultRequest self = new NotifyBadgeCodeVerifyResultRequest();
        return TeaModel.build(map, self);
    }

    public NotifyBadgeCodeVerifyResultRequest setPayCode(String payCode) {
        this.payCode = payCode;
        return this;
    }
    public String getPayCode() {
        return this.payCode;
    }

    public NotifyBadgeCodeVerifyResultRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public NotifyBadgeCodeVerifyResultRequest setUserCorpRelationType(String userCorpRelationType) {
        this.userCorpRelationType = userCorpRelationType;
        return this;
    }
    public String getUserCorpRelationType() {
        return this.userCorpRelationType;
    }

    public NotifyBadgeCodeVerifyResultRequest setUserIdentity(String userIdentity) {
        this.userIdentity = userIdentity;
        return this;
    }
    public String getUserIdentity() {
        return this.userIdentity;
    }

    public NotifyBadgeCodeVerifyResultRequest setVerifyTime(String verifyTime) {
        this.verifyTime = verifyTime;
        return this;
    }
    public String getVerifyTime() {
        return this.verifyTime;
    }

    public NotifyBadgeCodeVerifyResultRequest setVerifyResult(Boolean verifyResult) {
        this.verifyResult = verifyResult;
        return this;
    }
    public Boolean getVerifyResult() {
        return this.verifyResult;
    }

    public NotifyBadgeCodeVerifyResultRequest setVerifyLocation(String verifyLocation) {
        this.verifyLocation = verifyLocation;
        return this;
    }
    public String getVerifyLocation() {
        return this.verifyLocation;
    }

    public NotifyBadgeCodeVerifyResultRequest setVerifyNo(String verifyNo) {
        this.verifyNo = verifyNo;
        return this;
    }
    public String getVerifyNo() {
        return this.verifyNo;
    }

    public NotifyBadgeCodeVerifyResultRequest setVerifyEvent(String verifyEvent) {
        this.verifyEvent = verifyEvent;
        return this;
    }
    public String getVerifyEvent() {
        return this.verifyEvent;
    }

    public NotifyBadgeCodeVerifyResultRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public NotifyBadgeCodeVerifyResultRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public NotifyBadgeCodeVerifyResultRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

}
