// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeletePhysicalClassroomResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public DeletePhysicalClassroomResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeletePhysicalClassroomResponse setBody(DeletePhysicalClassroomResponseBody body) {
        this.body = body;
        return this;
    }
    public DeletePhysicalClassroomResponseBody getBody() {
        return this.body;
    }

}
