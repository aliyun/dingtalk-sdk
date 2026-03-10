// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class ConvertUnionIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ConvertUnionIdResponseBody body;

    public static ConvertUnionIdResponse build(java.util.Map<String, ?> map) throws Exception {
        ConvertUnionIdResponse self = new ConvertUnionIdResponse();
        return TeaModel.build(map, self);
    }

    public ConvertUnionIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ConvertUnionIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ConvertUnionIdResponse setBody(ConvertUnionIdResponseBody body) {
        this.body = body;
        return this;
    }
    public ConvertUnionIdResponseBody getBody() {
        return this.body;
    }

}
