// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class DecodeBadgeCodeResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2512345678</p>
     */
    @NameInMap("alipayCode")
    public String alipayCode;

    /**
     * <strong>example:</strong>
     * <p>codeIdxxxxx</p>
     */
    @NameInMap("codeId")
    public String codeId;

    /**
     * <strong>example:</strong>
     * <p>DT_VISITOR</p>
     */
    @NameInMap("codeIdentity")
    public String codeIdentity;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PURE_IDENTIFY_CODE</p>
     */
    @NameInMap("codeType")
    public String codeType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding1234</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>{&quot;authRules&quot;:{}}</p>
     */
    @NameInMap("extInfo")
    public String extInfo;

    /**
     * <strong>example:</strong>
     * <p>xxxx</p>
     */
    @NameInMap("outBizId")
    public String outBizId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>INTERNAL_STAFF</p>
     */
    @NameInMap("userCorpRelationType")
    public String userCorpRelationType;

    /**
     * <strong>example:</strong>
     * <p>staffId</p>
     */
    @NameInMap("userId")
    public String userId;

    public static DecodeBadgeCodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DecodeBadgeCodeResponseBody self = new DecodeBadgeCodeResponseBody();
        return TeaModel.build(map, self);
    }

    public DecodeBadgeCodeResponseBody setAlipayCode(String alipayCode) {
        this.alipayCode = alipayCode;
        return this;
    }
    public String getAlipayCode() {
        return this.alipayCode;
    }

    public DecodeBadgeCodeResponseBody setCodeId(String codeId) {
        this.codeId = codeId;
        return this;
    }
    public String getCodeId() {
        return this.codeId;
    }

    public DecodeBadgeCodeResponseBody setCodeIdentity(String codeIdentity) {
        this.codeIdentity = codeIdentity;
        return this;
    }
    public String getCodeIdentity() {
        return this.codeIdentity;
    }

    public DecodeBadgeCodeResponseBody setCodeType(String codeType) {
        this.codeType = codeType;
        return this;
    }
    public String getCodeType() {
        return this.codeType;
    }

    public DecodeBadgeCodeResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public DecodeBadgeCodeResponseBody setExtInfo(String extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public String getExtInfo() {
        return this.extInfo;
    }

    public DecodeBadgeCodeResponseBody setOutBizId(String outBizId) {
        this.outBizId = outBizId;
        return this;
    }
    public String getOutBizId() {
        return this.outBizId;
    }

    public DecodeBadgeCodeResponseBody setUserCorpRelationType(String userCorpRelationType) {
        this.userCorpRelationType = userCorpRelationType;
        return this;
    }
    public String getUserCorpRelationType() {
        return this.userCorpRelationType;
    }

    public DecodeBadgeCodeResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
