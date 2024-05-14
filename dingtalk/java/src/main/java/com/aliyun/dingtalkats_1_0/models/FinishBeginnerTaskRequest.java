// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class FinishBeginnerTaskRequest extends TeaModel {
    @NameInMap("scope")
    public String scope;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static FinishBeginnerTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        FinishBeginnerTaskRequest self = new FinishBeginnerTaskRequest();
        return TeaModel.build(map, self);
    }

    public FinishBeginnerTaskRequest setScope(String scope) {
        this.scope = scope;
        return this;
    }
    public String getScope() {
        return this.scope;
    }

    public FinishBeginnerTaskRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
