// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetGroupSetResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetGroupSetResponseBody body;

    public static GetGroupSetResponse build(java.util.Map<String, ?> map) throws Exception {
        GetGroupSetResponse self = new GetGroupSetResponse();
        return TeaModel.build(map, self);
    }

    public GetGroupSetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetGroupSetResponse setBody(GetGroupSetResponseBody body) {
        this.body = body;
        return this;
    }
    public GetGroupSetResponseBody getBody() {
        return this.body;
    }

}
