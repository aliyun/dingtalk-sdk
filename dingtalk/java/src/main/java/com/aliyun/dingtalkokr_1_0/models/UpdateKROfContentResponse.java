// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateKROfContentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateKROfContentResponseBody body;

    public static UpdateKROfContentResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateKROfContentResponse self = new UpdateKROfContentResponse();
        return TeaModel.build(map, self);
    }

    public UpdateKROfContentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateKROfContentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateKROfContentResponse setBody(UpdateKROfContentResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateKROfContentResponseBody getBody() {
        return this.body;
    }

}
