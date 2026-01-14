// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class CreateMinutesByUploadFileResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateMinutesByUploadFileResponseBody body;

    public static CreateMinutesByUploadFileResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateMinutesByUploadFileResponse self = new CreateMinutesByUploadFileResponse();
        return TeaModel.build(map, self);
    }

    public CreateMinutesByUploadFileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateMinutesByUploadFileResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateMinutesByUploadFileResponse setBody(CreateMinutesByUploadFileResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateMinutesByUploadFileResponseBody getBody() {
        return this.body;
    }

}
