// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TransformToExclusiveAccountRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>false/true</p>
     */
    @NameInMap("idpDingTalk")
    public Boolean idpDingTalk;

    @NameInMap("initPassword")
    public String initPassword;

    @NameInMap("loginId")
    public String loginId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>migrate</p>
     */
    @NameInMap("transformType")
    public String transformType;

    /**
     * <p>This parameter is required.</p>
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
