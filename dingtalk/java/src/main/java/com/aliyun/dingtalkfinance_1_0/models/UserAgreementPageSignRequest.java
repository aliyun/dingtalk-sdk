// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UserAgreementPageSignRequest extends TeaModel {
    // 主机构编号
    @NameInMap("instId")
    public String instId;

    // 子机构编号
    @NameInMap("subInstId")
    public String subInstId;

    // 付款人staffId
    @NameInMap("userId")
    public String userId;

    // 备注
    @NameInMap("remark")
    public String remark;

    // 支付渠道
    @NameInMap("payChannel")
    public String payChannel;

    // 子商户服务名称
    @NameInMap("subMerchantServiceName")
    public String subMerchantServiceName;

    // 子商户服务描述
    @NameInMap("subMerchantServiceDesc")
    public String subMerchantServiceDesc;

    // 子商户商户名称
    @NameInMap("subMerchantName")
    public String subMerchantName;

    // 业务编码
    @NameInMap("bizCode")
    public String bizCode;

    // 业务场景
    @NameInMap("bizScene")
    public String bizScene;

    // 签约场景
    @NameInMap("signScene")
    public String signScene;

    // 组织id
    @NameInMap("dingOrgId")
    public Long dingOrgId;

    // isv组织id
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    // 应用id
    @NameInMap("dingClientId")
    public String dingClientId;

    // 应用类型
    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    public static UserAgreementPageSignRequest build(java.util.Map<String, ?> map) throws Exception {
        UserAgreementPageSignRequest self = new UserAgreementPageSignRequest();
        return TeaModel.build(map, self);
    }

    public UserAgreementPageSignRequest setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public UserAgreementPageSignRequest setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

    public UserAgreementPageSignRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public UserAgreementPageSignRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public UserAgreementPageSignRequest setPayChannel(String payChannel) {
        this.payChannel = payChannel;
        return this;
    }
    public String getPayChannel() {
        return this.payChannel;
    }

    public UserAgreementPageSignRequest setSubMerchantServiceName(String subMerchantServiceName) {
        this.subMerchantServiceName = subMerchantServiceName;
        return this;
    }
    public String getSubMerchantServiceName() {
        return this.subMerchantServiceName;
    }

    public UserAgreementPageSignRequest setSubMerchantServiceDesc(String subMerchantServiceDesc) {
        this.subMerchantServiceDesc = subMerchantServiceDesc;
        return this;
    }
    public String getSubMerchantServiceDesc() {
        return this.subMerchantServiceDesc;
    }

    public UserAgreementPageSignRequest setSubMerchantName(String subMerchantName) {
        this.subMerchantName = subMerchantName;
        return this;
    }
    public String getSubMerchantName() {
        return this.subMerchantName;
    }

    public UserAgreementPageSignRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public UserAgreementPageSignRequest setBizScene(String bizScene) {
        this.bizScene = bizScene;
        return this;
    }
    public String getBizScene() {
        return this.bizScene;
    }

    public UserAgreementPageSignRequest setSignScene(String signScene) {
        this.signScene = signScene;
        return this;
    }
    public String getSignScene() {
        return this.signScene;
    }

    public UserAgreementPageSignRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public UserAgreementPageSignRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public UserAgreementPageSignRequest setDingClientId(String dingClientId) {
        this.dingClientId = dingClientId;
        return this;
    }
    public String getDingClientId() {
        return this.dingClientId;
    }

    public UserAgreementPageSignRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

}
