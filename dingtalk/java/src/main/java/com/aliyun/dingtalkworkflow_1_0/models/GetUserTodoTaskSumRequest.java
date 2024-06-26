// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetUserTodoTaskSumRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manager123</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetUserTodoTaskSumRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserTodoTaskSumRequest self = new GetUserTodoTaskSumRequest();
        return TeaModel.build(map, self);
    }

    public GetUserTodoTaskSumRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
