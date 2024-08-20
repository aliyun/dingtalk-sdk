// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetProcessDesignResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetProcessDesignResponseBody body;

    public static GetProcessDesignResponse build(java.util.Map<String, ?> map) throws Exception {
        GetProcessDesignResponse self = new GetProcessDesignResponse();
        return TeaModel.build(map, self);
    }

    public GetProcessDesignResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetProcessDesignResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetProcessDesignResponse setBody(GetProcessDesignResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProcessDesignResponseBody getBody() {
        return this.body;
    }

}
