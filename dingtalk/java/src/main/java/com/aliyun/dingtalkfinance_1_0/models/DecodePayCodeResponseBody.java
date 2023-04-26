// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class DecodePayCodeResponseBody extends TeaModel {
    @NameInMap("alipayCode")
    public String alipayCode;

    @NameInMap("codeId")
    public String codeId;

    @NameInMap("codeIdentity")
    public String codeIdentity;

    @NameInMap("codeType")
    public String codeType;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("extInfo")
    public String extInfo;

    @NameInMap("outBizId")
    public String outBizId;

    @NameInMap("userCorpRelationType")
    public String userCorpRelationType;

    @NameInMap("userId")
    public String userId;

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
