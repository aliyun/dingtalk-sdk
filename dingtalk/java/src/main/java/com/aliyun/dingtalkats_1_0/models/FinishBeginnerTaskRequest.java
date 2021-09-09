// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class FinishBeginnerTaskRequest extends TeaModel {
    // 员工标识
    @NameInMap("userId")
    public String userId;

    // 任务范围
    @NameInMap("scope")
    public String scope;

    public static FinishBeginnerTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        FinishBeginnerTaskRequest self = new FinishBeginnerTaskRequest();
        return TeaModel.build(map, self);
    }

    public FinishBeginnerTaskRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public FinishBeginnerTaskRequest setScope(String scope) {
        this.scope = scope;
        return this;
    }
    public String getScope() {
        return this.scope;
    }

}
