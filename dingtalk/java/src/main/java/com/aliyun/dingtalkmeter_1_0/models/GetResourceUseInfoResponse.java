// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmeter_1_0.models;

import com.aliyun.tea.*;

public class GetResourceUseInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetResourceUseInfoResponseBody body;

    public static GetResourceUseInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetResourceUseInfoResponse self = new GetResourceUseInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetResourceUseInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetResourceUseInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetResourceUseInfoResponse setBody(GetResourceUseInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetResourceUseInfoResponseBody getBody() {
        return this.body;
    }

}
