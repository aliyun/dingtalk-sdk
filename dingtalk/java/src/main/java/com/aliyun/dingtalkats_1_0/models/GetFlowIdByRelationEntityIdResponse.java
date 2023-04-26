// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetFlowIdByRelationEntityIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetFlowIdByRelationEntityIdResponseBody body;

    public static GetFlowIdByRelationEntityIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFlowIdByRelationEntityIdResponse self = new GetFlowIdByRelationEntityIdResponse();
        return TeaModel.build(map, self);
    }

    public GetFlowIdByRelationEntityIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFlowIdByRelationEntityIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFlowIdByRelationEntityIdResponse setBody(GetFlowIdByRelationEntityIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFlowIdByRelationEntityIdResponseBody getBody() {
        return this.body;
    }

}
