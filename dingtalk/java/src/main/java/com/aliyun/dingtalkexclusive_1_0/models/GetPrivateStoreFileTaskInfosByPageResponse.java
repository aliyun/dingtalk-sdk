// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivateStoreFileTaskInfosByPageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPrivateStoreFileTaskInfosByPageResponseBody body;

    public static GetPrivateStoreFileTaskInfosByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPrivateStoreFileTaskInfosByPageResponse self = new GetPrivateStoreFileTaskInfosByPageResponse();
        return TeaModel.build(map, self);
    }

    public GetPrivateStoreFileTaskInfosByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPrivateStoreFileTaskInfosByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPrivateStoreFileTaskInfosByPageResponse setBody(GetPrivateStoreFileTaskInfosByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPrivateStoreFileTaskInfosByPageResponseBody getBody() {
        return this.body;
    }

}
