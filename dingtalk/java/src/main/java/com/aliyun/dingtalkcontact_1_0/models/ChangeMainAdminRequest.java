// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ChangeMainAdminRequest extends TeaModel {
    /**
     * <p>effectCorpId</p>
     */
    @NameInMap("effectCorpId")
    public String effectCorpId;

    /**
     * <p>sourceUserId</p>
     */
    @NameInMap("sourceUserId")
    public String sourceUserId;

    /**
     * <p>targetUserId</p>
     */
    @NameInMap("targetUserId")
    public String targetUserId;

    public static ChangeMainAdminRequest build(java.util.Map<String, ?> map) throws Exception {
        ChangeMainAdminRequest self = new ChangeMainAdminRequest();
        return TeaModel.build(map, self);
    }

    public ChangeMainAdminRequest setEffectCorpId(String effectCorpId) {
        this.effectCorpId = effectCorpId;
        return this;
    }
    public String getEffectCorpId() {
        return this.effectCorpId;
    }

    public ChangeMainAdminRequest setSourceUserId(String sourceUserId) {
        this.sourceUserId = sourceUserId;
        return this;
    }
    public String getSourceUserId() {
        return this.sourceUserId;
    }

    public ChangeMainAdminRequest setTargetUserId(String targetUserId) {
        this.targetUserId = targetUserId;
        return this;
    }
    public String getTargetUserId() {
        return this.targetUserId;
    }

}
