// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceIdByTypeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetSpaceIdByTypeResponseBody body;

    public static GetSpaceIdByTypeResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceIdByTypeResponse self = new GetSpaceIdByTypeResponse();
        return TeaModel.build(map, self);
    }

    public GetSpaceIdByTypeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSpaceIdByTypeResponse setBody(GetSpaceIdByTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSpaceIdByTypeResponseBody getBody() {
        return this.body;
    }

}
