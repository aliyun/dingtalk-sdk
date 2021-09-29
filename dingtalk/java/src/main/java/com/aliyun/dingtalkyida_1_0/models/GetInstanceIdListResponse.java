// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetInstanceIdListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetInstanceIdListResponseBody body;

    public static GetInstanceIdListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetInstanceIdListResponse self = new GetInstanceIdListResponse();
        return TeaModel.build(map, self);
    }

    public GetInstanceIdListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetInstanceIdListResponse setBody(GetInstanceIdListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetInstanceIdListResponseBody getBody() {
        return this.body;
    }

}
