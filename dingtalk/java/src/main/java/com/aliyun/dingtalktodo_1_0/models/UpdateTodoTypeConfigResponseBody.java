// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdateTodoTypeConfigResponseBody extends TeaModel {
    /**
     * <p>更新结果</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static UpdateTodoTypeConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateTodoTypeConfigResponseBody self = new UpdateTodoTypeConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateTodoTypeConfigResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
