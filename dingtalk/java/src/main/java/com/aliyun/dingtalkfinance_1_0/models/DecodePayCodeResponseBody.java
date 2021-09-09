// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class DecodePayCodeResponseBody extends TeaModel {
    // 企业id
    @NameInMap("corpId")
    public String corpId;

    // 员工id
    @NameInMap("userId")
    public String userId;

    // 用户是否还在组织内
    @NameInMap("userInCorp")
    public Boolean userInCorp;

    // 码类型
    @NameInMap("codeType")
    public String codeType;

    // 支付宝付款码
    @NameInMap("alipayCode")
    public String alipayCode;

    // 用户和企业关系
    @NameInMap("userCorpRelationType")
    public String userCorpRelationType;

    public static DecodePayCodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DecodePayCodeResponseBody self = new DecodePayCodeResponseBody();
        return TeaModel.build(map, self);
    }

    public DecodePayCodeResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
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

    public DecodePayCodeResponseBody setCodeType(String codeType) {
        this.codeType = codeType;
        return this;
    }
    public String getCodeType() {
        return this.codeType;
    }

    public DecodePayCodeResponseBody setAlipayCode(String alipayCode) {
        this.alipayCode = alipayCode;
        return this;
    }
    public String getAlipayCode() {
        return this.alipayCode;
    }

    public DecodePayCodeResponseBody setUserCorpRelationType(String userCorpRelationType) {
        this.userCorpRelationType = userCorpRelationType;
        return this;
    }
    public String getUserCorpRelationType() {
        return this.userCorpRelationType;
    }

}
