// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UpdateFilterViewResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateFilterViewResponseBody body;

    public static UpdateFilterViewResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateFilterViewResponse self = new UpdateFilterViewResponse();
        return TeaModel.build(map, self);
    }

    public UpdateFilterViewResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateFilterViewResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateFilterViewResponse setBody(UpdateFilterViewResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateFilterViewResponseBody getBody() {
        return this.body;
    }

}
