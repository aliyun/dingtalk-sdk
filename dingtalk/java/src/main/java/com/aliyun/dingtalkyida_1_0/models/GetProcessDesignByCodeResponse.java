// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetProcessDesignByCodeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetProcessDesignByCodeResponseBody body;

    public static GetProcessDesignByCodeResponse build(java.util.Map<String, ?> map) throws Exception {
        GetProcessDesignByCodeResponse self = new GetProcessDesignByCodeResponse();
        return TeaModel.build(map, self);
    }

    public GetProcessDesignByCodeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetProcessDesignByCodeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetProcessDesignByCodeResponse setBody(GetProcessDesignByCodeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProcessDesignByCodeResponseBody getBody() {
        return this.body;
    }

}
