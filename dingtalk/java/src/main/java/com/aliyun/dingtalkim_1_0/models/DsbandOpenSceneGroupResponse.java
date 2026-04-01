// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class DsbandOpenSceneGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DsbandOpenSceneGroupResponseBody body;

    public static DsbandOpenSceneGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        DsbandOpenSceneGroupResponse self = new DsbandOpenSceneGroupResponse();
        return TeaModel.build(map, self);
    }

    public DsbandOpenSceneGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DsbandOpenSceneGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DsbandOpenSceneGroupResponse setBody(DsbandOpenSceneGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public DsbandOpenSceneGroupResponseBody getBody() {
        return this.body;
    }

}
