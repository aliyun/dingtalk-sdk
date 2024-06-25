// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CountTodoTasksResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>99</p>
     */
    @NameInMap("result")
    public Integer result;

    public static CountTodoTasksResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CountTodoTasksResponseBody self = new CountTodoTasksResponseBody();
        return TeaModel.build(map, self);
    }

    public CountTodoTasksResponseBody setResult(Integer result) {
        this.result = result;
        return this;
    }
    public Integer getResult() {
        return this.result;
    }

}
