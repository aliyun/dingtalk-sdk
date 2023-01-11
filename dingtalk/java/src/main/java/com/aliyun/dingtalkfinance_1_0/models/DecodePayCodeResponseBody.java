// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class DecodePayCodeResponseBody extends TeaModel {
    /**
     * <p>支付宝付款码</p>
     */
    @NameInMap("alipayCode")
    public String alipayCode;

    /**
     * <p>码ID，对于访客或会展码等静态码值返回</p>
     */
    @NameInMap("codeId")
    public String codeId;

    /**
     * <p>工牌码：DT_IDENTITY，访客码：DT_VISITOR，会展码：DT_CONFERENCE</p>
     */
    @NameInMap("codeIdentity")
    public String codeIdentity;

    /**
     * <p>码类型</p>
     */
    @NameInMap("codeType")
    public String codeType;

    /**
     * <p>企业id</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>扩展信息</p>
     */
    @NameInMap("extInfo")
    public String extInfo;

    /**
     * <p>外部业务ID,其值为调用创建用户码接口传入的requestId</p>
     */
    @NameInMap("outBizId")
    public String outBizId;

    /**
     * <p>用户和企业关系</p>
     */
    @NameInMap("userCorpRelationType")
    public String userCorpRelationType;

    /**
     * <p>员工id</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>用户是否还在组织内</p>
     */
    @NameInMap("userInCorp")
    public Boolean userInCorp;

    public static DecodePayCodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DecodePayCodeResponseBody self = new DecodePayCodeResponseBody();
        return TeaModel.build(map, self);
    }

    public DecodePayCodeResponseBody setAlipayCode(String alipayCode) {
        this.alipayCode = alipayCode;
        return this;
    }
    public String getAlipayCode() {
        return this.alipayCode;
    }

    public DecodePayCodeResponseBody setCodeId(String codeId) {
        this.codeId = codeId;
        return this;
    }
    public String getCodeId() {
        return this.codeId;
    }

    public DecodePayCodeResponseBody setCodeIdentity(String codeIdentity) {
        this.codeIdentity = codeIdentity;
        return this;
    }
    public String getCodeIdentity() {
        return this.codeIdentity;
    }

    public DecodePayCodeResponseBody setCodeType(String codeType) {
        this.codeType = codeType;
        return this;
    }
    public String getCodeType() {
        return this.codeType;
    }

    public DecodePayCodeResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public DecodePayCodeResponseBody setExtInfo(String extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public String getExtInfo() {
        return this.extInfo;
    }

    public DecodePayCodeResponseBody setOutBizId(String outBizId) {
        this.outBizId = outBizId;
        return this;
    }
    public String getOutBizId() {
        return this.outBizId;
    }

    public DecodePayCodeResponseBody setUserCorpRelationType(String userCorpRelationType) {
        this.userCorpRelationType = userCorpRelationType;
        return this;
    }
    public String getUserCorpRelationType() {
        return this.userCorpRelationType;
    }

    public DecodePayCodeResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public DecodePayCodeResponseBody setUserInCorp(Boolean userInCorp) {
        this.userInCorp = userInCorp;
        return this;
    }
    public Boolean getUserInCorp() {
        return this.userInCorp;
    }

}
