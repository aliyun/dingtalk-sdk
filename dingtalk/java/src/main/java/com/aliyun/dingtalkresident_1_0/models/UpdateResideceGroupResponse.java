// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResideceGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateResideceGroupResponseBody body;

    public static UpdateResideceGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateResideceGroupResponse self = new UpdateResideceGroupResponse();
        return TeaModel.build(map, self);
    }

    public UpdateResideceGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateResideceGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateResideceGroupResponse setBody(UpdateResideceGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateResideceGroupResponseBody getBody() {
        return this.body;
    }

}
