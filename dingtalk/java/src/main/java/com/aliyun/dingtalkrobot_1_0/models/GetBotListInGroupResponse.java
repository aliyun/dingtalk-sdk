// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class GetBotListInGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetBotListInGroupResponseBody body;

    public static GetBotListInGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBotListInGroupResponse self = new GetBotListInGroupResponse();
        return TeaModel.build(map, self);
    }

    public GetBotListInGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetBotListInGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetBotListInGroupResponse setBody(GetBotListInGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public GetBotListInGroupResponseBody getBody() {
        return this.body;
    }

}
