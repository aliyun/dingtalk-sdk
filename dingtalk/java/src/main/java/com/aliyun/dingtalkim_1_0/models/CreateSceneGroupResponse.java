// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateSceneGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateSceneGroupResponseBody body;

    public static CreateSceneGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateSceneGroupResponse self = new CreateSceneGroupResponse();
        return TeaModel.build(map, self);
    }

    public CreateSceneGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateSceneGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateSceneGroupResponse setBody(CreateSceneGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateSceneGroupResponseBody getBody() {
        return this.body;
    }

}
