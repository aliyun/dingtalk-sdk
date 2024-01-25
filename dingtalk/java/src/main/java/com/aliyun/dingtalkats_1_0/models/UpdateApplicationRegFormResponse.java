// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class UpdateApplicationRegFormResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateApplicationRegFormResponseBody body;

    public static UpdateApplicationRegFormResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateApplicationRegFormResponse self = new UpdateApplicationRegFormResponse();
        return TeaModel.build(map, self);
    }

    public UpdateApplicationRegFormResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateApplicationRegFormResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateApplicationRegFormResponse setBody(UpdateApplicationRegFormResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateApplicationRegFormResponseBody getBody() {
        return this.body;
    }

}
