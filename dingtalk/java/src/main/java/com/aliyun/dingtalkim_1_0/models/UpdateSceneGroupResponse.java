// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateSceneGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateSceneGroupResponseBody body;

    public static UpdateSceneGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateSceneGroupResponse self = new UpdateSceneGroupResponse();
        return TeaModel.build(map, self);
    }

    public UpdateSceneGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateSceneGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateSceneGroupResponse setBody(UpdateSceneGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateSceneGroupResponseBody getBody() {
        return this.body;
    }

}
