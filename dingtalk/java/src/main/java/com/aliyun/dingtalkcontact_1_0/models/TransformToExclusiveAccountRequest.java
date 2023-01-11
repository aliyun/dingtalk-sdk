// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TransformToExclusiveAccountRequest extends TeaModel {
    /**
     * <p>idpDingTalk</p>
     */
    @NameInMap("idpDingTalk")
    public Boolean idpDingTalk;

    /**
     * <p>initPassword</p>
     */
    @NameInMap("initPassword")
    public String initPassword;

    /**
     * <p>loginId</p>
     */
    @NameInMap("loginId")
    public String loginId;

    /**
     * <p>transformType</p>
     */
    @NameInMap("transformType")
    public String transformType;

    /**
     * <p>userId</p>
     */
    @NameInMap("userId")
    public String userId;

    public static TransformToExclusiveAccountRequest build(java.util.Map<String, ?> map) throws Exception {
        TransformToExclusiveAccountRequest self = new TransformToExclusiveAccountRequest();
        return TeaModel.build(map, self);
    }

    public TransformToExclusiveAccountRequest setIdpDingTalk(Boolean idpDingTalk) {
        this.idpDingTalk = idpDingTalk;
        return this;
    }
    public Boolean getIdpDingTalk() {
        return this.idpDingTalk;
    }

    public TransformToExclusiveAccountRequest setInitPassword(String initPassword) {
        this.initPassword = initPassword;
        return this;
    }
    public String getInitPassword() {
        return this.initPassword;
    }

    public TransformToExclusiveAccountRequest setLoginId(String loginId) {
        this.loginId = loginId;
        return this;
    }
    public String getLoginId() {
        return this.loginId;
    }

    public TransformToExclusiveAccountRequest setTransformType(String transformType) {
        this.transformType = transformType;
        return this;
    }
    public String getTransformType() {
        return this.transformType;
    }

    public TransformToExclusiveAccountRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
