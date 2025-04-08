// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivateStoreFileInfosByPageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPrivateStoreFileInfosByPageResponseBody body;

    public static GetPrivateStoreFileInfosByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPrivateStoreFileInfosByPageResponse self = new GetPrivateStoreFileInfosByPageResponse();
        return TeaModel.build(map, self);
    }

    public GetPrivateStoreFileInfosByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPrivateStoreFileInfosByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPrivateStoreFileInfosByPageResponse setBody(GetPrivateStoreFileInfosByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPrivateStoreFileInfosByPageResponseBody getBody() {
        return this.body;
    }

}
