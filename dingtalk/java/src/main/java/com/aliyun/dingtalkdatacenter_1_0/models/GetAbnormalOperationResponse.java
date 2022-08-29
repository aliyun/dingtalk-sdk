// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetAbnormalOperationResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetAbnormalOperationResponse setBody(GetAbnormalOperationResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAbnormalOperationResponseBody getBody() {
        return this.body;
    }

}
