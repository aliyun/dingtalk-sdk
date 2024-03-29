// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateProjectGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateProjectGroupResponseBody body;

    public static UpdateProjectGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateProjectGroupResponse self = new UpdateProjectGroupResponse();
        return TeaModel.build(map, self);
    }

    public UpdateProjectGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateProjectGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateProjectGroupResponse setBody(UpdateProjectGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateProjectGroupResponseBody getBody() {
        return this.body;
    }

}
