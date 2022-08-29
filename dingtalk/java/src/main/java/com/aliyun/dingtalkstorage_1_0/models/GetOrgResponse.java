// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetOrgResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetOrgResponseBody body;

    public static GetOrgResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOrgResponse self = new GetOrgResponse();
        return TeaModel.build(map, self);
    }

    public GetOrgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOrgResponse setBody(GetOrgResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOrgResponseBody getBody() {
        return this.body;
    }

}
