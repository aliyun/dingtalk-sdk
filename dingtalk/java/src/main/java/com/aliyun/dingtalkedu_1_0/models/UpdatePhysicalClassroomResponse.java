// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdatePhysicalClassroomResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdatePhysicalClassroomResponseBody body;

    public static UpdatePhysicalClassroomResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdatePhysicalClassroomResponse self = new UpdatePhysicalClassroomResponse();
        return TeaModel.build(map, self);
    }

    public UpdatePhysicalClassroomResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdatePhysicalClassroomResponse setBody(UpdatePhysicalClassroomResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdatePhysicalClassroomResponseBody getBody() {
        return this.body;
    }

}
