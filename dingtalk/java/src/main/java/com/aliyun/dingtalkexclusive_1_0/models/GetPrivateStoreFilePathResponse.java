// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivateStoreFilePathResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPrivateStoreFilePathResponseBody body;

    public static GetPrivateStoreFilePathResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPrivateStoreFilePathResponse self = new GetPrivateStoreFilePathResponse();
        return TeaModel.build(map, self);
    }

    public GetPrivateStoreFilePathResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPrivateStoreFilePathResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPrivateStoreFilePathResponse setBody(GetPrivateStoreFilePathResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPrivateStoreFilePathResponseBody getBody() {
        return this.body;
    }

}
