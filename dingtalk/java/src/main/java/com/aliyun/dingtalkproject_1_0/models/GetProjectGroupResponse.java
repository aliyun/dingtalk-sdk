// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetProjectGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetProjectGroupResponseBody body;

    public static GetProjectGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        GetProjectGroupResponse self = new GetProjectGroupResponse();
        return TeaModel.build(map, self);
    }

    public GetProjectGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetProjectGroupResponse setBody(GetProjectGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProjectGroupResponseBody getBody() {
        return this.body;
    }

}
