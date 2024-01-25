// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class DiotMamaResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DiotMamaResponseBody body;

    public static DiotMamaResponse build(java.util.Map<String, ?> map) throws Exception {
        DiotMamaResponse self = new DiotMamaResponse();
        return TeaModel.build(map, self);
    }

    public DiotMamaResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DiotMamaResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DiotMamaResponse setBody(DiotMamaResponseBody body) {
        this.body = body;
        return this;
    }
    public DiotMamaResponseBody getBody() {
        return this.body;
    }

}
