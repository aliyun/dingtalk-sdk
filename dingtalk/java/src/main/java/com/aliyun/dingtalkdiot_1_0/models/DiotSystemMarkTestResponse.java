// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class DiotSystemMarkTestResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DiotSystemMarkTestResponseBody body;

    public static DiotSystemMarkTestResponse build(java.util.Map<String, ?> map) throws Exception {
        DiotSystemMarkTestResponse self = new DiotSystemMarkTestResponse();
        return TeaModel.build(map, self);
    }

    public DiotSystemMarkTestResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DiotSystemMarkTestResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DiotSystemMarkTestResponse setBody(DiotSystemMarkTestResponseBody body) {
        this.body = body;
        return this;
    }
    public DiotSystemMarkTestResponseBody getBody() {
        return this.body;
    }

}
