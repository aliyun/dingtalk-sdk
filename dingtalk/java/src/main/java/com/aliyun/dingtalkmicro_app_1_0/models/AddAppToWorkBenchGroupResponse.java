// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AddAppToWorkBenchGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddAppToWorkBenchGroupResponseBody body;

    public static AddAppToWorkBenchGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        AddAppToWorkBenchGroupResponse self = new AddAppToWorkBenchGroupResponse();
        return TeaModel.build(map, self);
    }

    public AddAppToWorkBenchGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddAppToWorkBenchGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddAppToWorkBenchGroupResponse setBody(AddAppToWorkBenchGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public AddAppToWorkBenchGroupResponseBody getBody() {
        return this.body;
    }

}
