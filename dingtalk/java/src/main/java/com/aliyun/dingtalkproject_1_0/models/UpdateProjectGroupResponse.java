// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateProjectGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public UpdateProjectGroupResponse setBody(UpdateProjectGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateProjectGroupResponseBody getBody() {
        return this.body;
    }

}
