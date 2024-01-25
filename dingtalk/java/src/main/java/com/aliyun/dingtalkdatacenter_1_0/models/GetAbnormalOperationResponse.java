// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetAbnormalOperationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAbnormalOperationResponseBody body;

    public static GetAbnormalOperationResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAbnormalOperationResponse self = new GetAbnormalOperationResponse();
        return TeaModel.build(map, self);
    }

    public GetAbnormalOperationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAbnormalOperationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAbnormalOperationResponse setBody(GetAbnormalOperationResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAbnormalOperationResponseBody getBody() {
        return this.body;
    }

}
