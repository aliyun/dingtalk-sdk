// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeletePhysicalClassroomResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeletePhysicalClassroomResponseBody body;

    public static DeletePhysicalClassroomResponse build(java.util.Map<String, ?> map) throws Exception {
        DeletePhysicalClassroomResponse self = new DeletePhysicalClassroomResponse();
        return TeaModel.build(map, self);
    }

    public DeletePhysicalClassroomResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeletePhysicalClassroomResponse setBody(DeletePhysicalClassroomResponseBody body) {
        this.body = body;
        return this;
    }
    public DeletePhysicalClassroomResponseBody getBody() {
        return this.body;
    }

}
