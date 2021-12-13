// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetAppsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetAppsResponseBody body;

    public static GetAppsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAppsResponse self = new GetAppsResponse();
        return TeaModel.build(map, self);
    }

    public GetAppsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAppsResponse setBody(GetAppsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAppsResponseBody getBody() {
        return this.body;
    }

}
