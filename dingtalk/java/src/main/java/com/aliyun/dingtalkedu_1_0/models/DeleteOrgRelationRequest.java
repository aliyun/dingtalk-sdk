// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteOrgRelationRequest extends TeaModel {
    @NameInMap("targetCorpId")
    public String targetCorpId;

    @NameInMap("authCode")
    public String authCode;

    public static DeleteOrgRelationRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteOrgRelationRequest self = new DeleteOrgRelationRequest();
        return TeaModel.build(map, self);
    }

    public DeleteOrgRelationRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

    public DeleteOrgRelationRequest setAuthCode(String authCode) {
        this.authCode = authCode;
        return this;
    }
    public String getAuthCode() {
        return this.authCode;
    }

}
