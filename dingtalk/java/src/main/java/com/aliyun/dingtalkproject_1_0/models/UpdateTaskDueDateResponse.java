// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskDueDateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateTaskDueDateResponseBody body;

    public static UpdateTaskDueDateResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskDueDateResponse self = new UpdateTaskDueDateResponse();
        return TeaModel.build(map, self);
    }

    public UpdateTaskDueDateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateTaskDueDateResponse setBody(UpdateTaskDueDateResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTaskDueDateResponseBody getBody() {
        return this.body;
    }

}
