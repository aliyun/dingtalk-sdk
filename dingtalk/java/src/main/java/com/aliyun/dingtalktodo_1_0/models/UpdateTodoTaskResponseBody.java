// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdateTodoTaskResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static UpdateTodoTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateTodoTaskResponseBody self = new UpdateTodoTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateTodoTaskResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
