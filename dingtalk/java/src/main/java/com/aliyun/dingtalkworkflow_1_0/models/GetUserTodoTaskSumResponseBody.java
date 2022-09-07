// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetUserTodoTaskSumResponseBody extends TeaModel {
    // 请求ID。
    @NameInMap("requestId")
    public String requestId;

    // 待处理的审批数量。
    @NameInMap("result")
    public Integer result;

    public static GetUserTodoTaskSumResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserTodoTaskSumResponseBody self = new GetUserTodoTaskSumResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserTodoTaskSumResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetUserTodoTaskSumResponseBody setResult(Integer result) {
        this.result = result;
        return this;
    }
    public Integer getResult() {
        return this.result;
    }

}
