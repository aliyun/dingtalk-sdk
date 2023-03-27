// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetProjectMemebersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetProjectMemebersResponseBody body;

    public static GetProjectMemebersResponse build(java.util.Map<String, ?> map) throws Exception {
        GetProjectMemebersResponse self = new GetProjectMemebersResponse();
        return TeaModel.build(map, self);
    }

    public GetProjectMemebersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetProjectMemebersResponse setBody(GetProjectMemebersResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProjectMemebersResponseBody getBody() {
        return this.body;
    }

}
