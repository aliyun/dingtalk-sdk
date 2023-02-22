// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskTaskflowstatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateTaskTaskflowstatusResponseBody body;

    public static UpdateTaskTaskflowstatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskTaskflowstatusResponse self = new UpdateTaskTaskflowstatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateTaskTaskflowstatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateTaskTaskflowstatusResponse setBody(UpdateTaskTaskflowstatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTaskTaskflowstatusResponseBody getBody() {
        return this.body;
    }

}
