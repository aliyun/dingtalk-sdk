// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class AiRetailProductDeleteResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public Boolean body;

    public static AiRetailProductDeleteResponse build(java.util.Map<String, ?> map) throws Exception {
        AiRetailProductDeleteResponse self = new AiRetailProductDeleteResponse();
        return TeaModel.build(map, self);
    }

    public AiRetailProductDeleteResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AiRetailProductDeleteResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AiRetailProductDeleteResponse setBody(Boolean body) {
        this.body = body;
        return this;
    }
    public Boolean getBody() {
        return this.body;
    }

}
