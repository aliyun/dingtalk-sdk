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

    // 码标识，工牌码：DT_IDENTITY，访客码：DT_VISITOR，会展码：DT_CONFERENCE
    @NameInMap("codeIdentity")
    public String codeIdentity;

    // 码ID，对于访客或会展码等静态码值返回
    @NameInMap("codeId")
    public String codeId;

    // 外部业务ID，值为调用创建工牌码接口传入的requestId
    @NameInMap("outBizId")
    public String outBizId;

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

    public DecodeBadgeCodeResponseBody setCodeIdentity(String codeIdentity) {
        this.codeIdentity = codeIdentity;
        return this;
    }
    public String getCodeIdentity() {
        return this.codeIdentity;
    }

    public DecodeBadgeCodeResponseBody setCodeId(String codeId) {
        this.codeId = codeId;
        return this;
    }
    public String getCodeId() {
        return this.codeId;
    }

    public DecodeBadgeCodeResponseBody setOutBizId(String outBizId) {
        this.outBizId = outBizId;
        return this;
    }
    public String getOutBizId() {
        return this.outBizId;
    }

}
