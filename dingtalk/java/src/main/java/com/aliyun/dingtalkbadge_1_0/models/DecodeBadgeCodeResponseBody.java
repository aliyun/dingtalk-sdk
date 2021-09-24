// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class DecodeBadgeCodeResponseBody extends TeaModel {
    // 企业id
    @NameInMap("corpId")
    public String corpId;

    // 员工id
    @NameInMap("userId")
    public String userId;

    // 码类型
    @NameInMap("codeType")
    public String codeType;

    // 支付宝付款码
    @NameInMap("alipayCode")
    public String alipayCode;

    // 用户和企业关系
    @NameInMap("userCorpRelationType")
    public String userCorpRelationType;

    public static DecodeBadgeCodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DecodeBadgeCodeResponseBody self = new DecodeBadgeCodeResponseBody();
        return TeaModel.build(map, self);
    }

    public DecodeBadgeCodeResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public DecodeBadgeCodeResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public DecodeBadgeCodeResponseBody setCodeType(String codeType) {
        this.codeType = codeType;
        return this;
    }
    public String getCodeType() {
        return this.codeType;
    }

    public DecodeBadgeCodeResponseBody setAlipayCode(String alipayCode) {
        this.alipayCode = alipayCode;
        return this;
    }
    public String getAlipayCode() {
        return this.alipayCode;
    }

    public DecodeBadgeCodeResponseBody setUserCorpRelationType(String userCorpRelationType) {
        this.userCorpRelationType = userCorpRelationType;
        return this;
    }
    public String getUserCorpRelationType() {
        return this.userCorpRelationType;
    }

}
