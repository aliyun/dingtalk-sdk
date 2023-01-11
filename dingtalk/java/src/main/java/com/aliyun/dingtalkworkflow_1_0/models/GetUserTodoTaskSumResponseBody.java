// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetUserTodoTaskSumResponseBody extends TeaModel {
    /**
     * <p>待处理的审批数量。</p>
     */
    @NameInMap("result")
    public Integer result;

    public static GetUserTodoTaskSumResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserTodoTaskSumResponseBody self = new GetUserTodoTaskSumResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserTodoTaskSumResponseBody setResult(Integer result) {
        this.result = result;
        return this;
    }
    public Integer getResult() {
        return this.result;
    }

}
