// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class UploadEventResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UploadEventResponseBody body;

    public static UploadEventResponse build(java.util.Map<String, ?> map) throws Exception {
        UploadEventResponse self = new UploadEventResponse();
        return TeaModel.build(map, self);
    }

    public UploadEventResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UploadEventResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UploadEventResponse setBody(UploadEventResponseBody body) {
        this.body = body;
        return this;
    }
    public UploadEventResponseBody getBody() {
        return this.body;
    }

}
