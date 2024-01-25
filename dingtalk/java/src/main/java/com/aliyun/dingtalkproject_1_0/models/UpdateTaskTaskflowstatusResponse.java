// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskTaskflowstatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public UpdateTaskTaskflowstatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateTaskTaskflowstatusResponse setBody(UpdateTaskTaskflowstatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTaskTaskflowstatusResponseBody getBody() {
        return this.body;
    }

}
