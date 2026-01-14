// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivateStoreTaskFileInfosByPageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPrivateStoreTaskFileInfosByPageResponseBody body;

    public static GetPrivateStoreTaskFileInfosByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPrivateStoreTaskFileInfosByPageResponse self = new GetPrivateStoreTaskFileInfosByPageResponse();
        return TeaModel.build(map, self);
    }

    public GetPrivateStoreTaskFileInfosByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPrivateStoreTaskFileInfosByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPrivateStoreTaskFileInfosByPageResponse setBody(GetPrivateStoreTaskFileInfosByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPrivateStoreTaskFileInfosByPageResponseBody getBody() {
        return this.body;
    }

}
