// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class DeleteInnerAppResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteInnerAppResponseBody body;

    public static DeleteInnerAppResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteInnerAppResponse self = new DeleteInnerAppResponse();
        return TeaModel.build(map, self);
    }

    public DeleteInnerAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteInnerAppResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteInnerAppResponse setBody(DeleteInnerAppResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteInnerAppResponseBody getBody() {
        return this.body;
    }

}
