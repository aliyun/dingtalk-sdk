// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreatePhysicalClassroomResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreatePhysicalClassroomResponseBody body;

    public static CreatePhysicalClassroomResponse build(java.util.Map<String, ?> map) throws Exception {
        CreatePhysicalClassroomResponse self = new CreatePhysicalClassroomResponse();
        return TeaModel.build(map, self);
    }

    public CreatePhysicalClassroomResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreatePhysicalClassroomResponse setBody(CreatePhysicalClassroomResponseBody body) {
        this.body = body;
        return this;
    }
    public CreatePhysicalClassroomResponseBody getBody() {
        return this.body;
    }

}
