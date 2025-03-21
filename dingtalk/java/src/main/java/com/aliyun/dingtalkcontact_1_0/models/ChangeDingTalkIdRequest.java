// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ChangeDingTalkIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>abc123</p>
     */
    @NameInMap("dingTalkId")
    public String dingTalkId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>userIdBB</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ChangeDingTalkIdRequest build(java.util.Map<String, ?> map) throws Exception {
        ChangeDingTalkIdRequest self = new ChangeDingTalkIdRequest();
        return TeaModel.build(map, self);
    }

    public ChangeDingTalkIdRequest setDingTalkId(String dingTalkId) {
        this.dingTalkId = dingTalkId;
        return this;
    }
    public String getDingTalkId() {
        return this.dingTalkId;
    }

    public ChangeDingTalkIdRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
