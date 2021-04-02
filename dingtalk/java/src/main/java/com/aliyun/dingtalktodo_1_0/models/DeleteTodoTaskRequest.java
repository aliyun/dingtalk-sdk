// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class DeleteTodoTaskRequest extends TeaModel {
    // 操作者id
    @NameInMap("operatorId")
    public String operatorId;

    public static DeleteTodoTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteTodoTaskRequest self = new DeleteTodoTaskRequest();
        return TeaModel.build(map, self);
    }

    public DeleteTodoTaskRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
