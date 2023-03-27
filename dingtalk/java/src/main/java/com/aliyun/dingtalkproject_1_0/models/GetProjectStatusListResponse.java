// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetProjectStatusListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetProjectStatusListResponseBody body;

    public static GetProjectStatusListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetProjectStatusListResponse self = new GetProjectStatusListResponse();
        return TeaModel.build(map, self);
    }

    public GetProjectStatusListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetProjectStatusListResponse setBody(GetProjectStatusListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProjectStatusListResponseBody getBody() {
        return this.body;
    }

}
