// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class DecodeBadgeCodeResponseBody extends TeaModel {
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
     * <p>码标识，工牌码：DT_IDENTITY，访客码：DT_VISITOR，会展码：DT_CONFERENCE</p>
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
     * <p>外部业务ID，值为调用创建工牌码接口传入的requestId</p>
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
