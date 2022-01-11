// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class DecodePayCodeResponseBody extends TeaModel {
    // 支付宝付款码
    @NameInMap("alipayCode")
    public String alipayCode;

    // 码ID，对于访客或会展码等静态码值返回
    @NameInMap("codeId")
    public String codeId;

    // 工牌码：DT_IDENTITY，访客码：DT_VISITOR，会展码：DT_CONFERENCE
    @NameInMap("codeIdentity")
    public String codeIdentity;

    // 码类型
    @NameInMap("codeType")
    public String codeType;

    // 企业id
    @NameInMap("corpId")
    public String corpId;

    // 外部业务ID,其值为调用创建用户码接口传入的requestId
    @NameInMap("outBizId")
    public String outBizId;

    // 用户和企业关系
    @NameInMap("userCorpRelationType")
    public String userCorpRelationType;

    // 员工id
    @NameInMap("userId")
    public String userId;

    // 用户是否还在组织内
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
