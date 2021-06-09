// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class GetUserSourceListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetUserSourceListResponseBody body;

    public static GetUserSourceListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserSourceListResponse self = new GetUserSourceListResponse();
        return TeaModel.build(map, self);
    }

    public GetUserSourceListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserSourceListResponse setBody(GetUserSourceListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserSourceListResponseBody getBody() {
        return this.body;
    }

}
