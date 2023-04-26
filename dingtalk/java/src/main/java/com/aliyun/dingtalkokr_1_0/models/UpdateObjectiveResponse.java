// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateObjectiveResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateObjectiveResponseBody body;

    public static UpdateObjectiveResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateObjectiveResponse self = new UpdateObjectiveResponse();
        return TeaModel.build(map, self);
    }

    public UpdateObjectiveResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateObjectiveResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateObjectiveResponse setBody(UpdateObjectiveResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateObjectiveResponseBody getBody() {
        return this.body;
    }

}
