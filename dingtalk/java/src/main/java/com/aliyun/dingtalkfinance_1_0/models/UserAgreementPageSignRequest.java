// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UserAgreementPageSignRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizScene")
    public String bizScene;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("instId")
    public String instId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("payChannel")
    public String payChannel;

    @NameInMap("remark")
    public String remark;

    @NameInMap("returnUrl")
    public String returnUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("signScene")
    public String signScene;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subMerchantName")
    public String subMerchantName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subMerchantServiceDesc")
    public String subMerchantServiceDesc;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subMerchantServiceName")
    public String subMerchantServiceName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UserAgreementPageSignRequest build(java.util.Map<String, ?> map) throws Exception {
        UserAgreementPageSignRequest self = new UserAgreementPageSignRequest();
        return TeaModel.build(map, self);
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

    public UserAgreementPageSignRequest setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public UserAgreementPageSignRequest setPayChannel(String payChannel) {
        this.payChannel = payChannel;
        return this;
    }
    public String getPayChannel() {
        return this.payChannel;
    }

    public UserAgreementPageSignRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public UserAgreementPageSignRequest setReturnUrl(String returnUrl) {
        this.returnUrl = returnUrl;
        return this;
    }
    public String getReturnUrl() {
        return this.returnUrl;
    }

    public UserAgreementPageSignRequest setSignScene(String signScene) {
        this.signScene = signScene;
        return this;
    }
    public String getSignScene() {
        return this.signScene;
    }

    public UserAgreementPageSignRequest setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

    public UserAgreementPageSignRequest setSubMerchantName(String subMerchantName) {
        this.subMerchantName = subMerchantName;
        return this;
    }
    public String getSubMerchantName() {
        return this.subMerchantName;
    }

    public UserAgreementPageSignRequest setSubMerchantServiceDesc(String subMerchantServiceDesc) {
        this.subMerchantServiceDesc = subMerchantServiceDesc;
        return this;
    }
    public String getSubMerchantServiceDesc() {
        return this.subMerchantServiceDesc;
    }

    public UserAgreementPageSignRequest setSubMerchantServiceName(String subMerchantServiceName) {
        this.subMerchantServiceName = subMerchantServiceName;
        return this;
    }
    public String getSubMerchantServiceName() {
        return this.subMerchantServiceName;
    }

    public UserAgreementPageSignRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
