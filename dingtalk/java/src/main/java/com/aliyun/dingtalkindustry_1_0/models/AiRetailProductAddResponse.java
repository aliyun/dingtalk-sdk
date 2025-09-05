// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class AiRetailProductAddResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AiRetailProductAddResponseBody body;

    public static AiRetailProductAddResponse build(java.util.Map<String, ?> map) throws Exception {
        AiRetailProductAddResponse self = new AiRetailProductAddResponse();
        return TeaModel.build(map, self);
    }

    public AiRetailProductAddResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AiRetailProductAddResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AiRetailProductAddResponse setBody(AiRetailProductAddResponseBody body) {
        this.body = body;
        return this;
    }
    public AiRetailProductAddResponseBody getBody() {
        return this.body;
    }

}
