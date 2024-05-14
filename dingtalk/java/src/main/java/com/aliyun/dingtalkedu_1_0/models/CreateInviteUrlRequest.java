// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateInviteUrlRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("authCode")
    public String authCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetOperator")
    public String targetOperator;

    public static CreateInviteUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateInviteUrlRequest self = new CreateInviteUrlRequest();
        return TeaModel.build(map, self);
    }

    public CreateInviteUrlRequest setAuthCode(String authCode) {
        this.authCode = authCode;
        return this;
    }
    public String getAuthCode() {
        return this.authCode;
    }

    public CreateInviteUrlRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

    public CreateInviteUrlRequest setTargetOperator(String targetOperator) {
        this.targetOperator = targetOperator;
        return this;
    }
    public String getTargetOperator() {
        return this.targetOperator;
    }

}
