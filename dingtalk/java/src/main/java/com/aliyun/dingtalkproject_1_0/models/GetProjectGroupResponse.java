// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetProjectGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetProjectGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetProjectGroupResponse setBody(GetProjectGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProjectGroupResponseBody getBody() {
        return this.body;
    }

}
