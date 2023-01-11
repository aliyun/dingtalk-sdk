// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdateTodoTaskExecutorStatusResponseBody extends TeaModel {
    /**
     * <p>更新结果</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static UpdateTodoTaskExecutorStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateTodoTaskExecutorStatusResponseBody self = new UpdateTodoTaskExecutorStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateTodoTaskExecutorStatusResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
