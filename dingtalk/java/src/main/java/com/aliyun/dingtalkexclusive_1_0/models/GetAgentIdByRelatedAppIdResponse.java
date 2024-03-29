// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetAgentIdByRelatedAppIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAgentIdByRelatedAppIdResponseBody body;

    public static GetAgentIdByRelatedAppIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAgentIdByRelatedAppIdResponse self = new GetAgentIdByRelatedAppIdResponse();
        return TeaModel.build(map, self);
    }

    public GetAgentIdByRelatedAppIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAgentIdByRelatedAppIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAgentIdByRelatedAppIdResponse setBody(GetAgentIdByRelatedAppIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAgentIdByRelatedAppIdResponseBody getBody() {
        return this.body;
    }

}
