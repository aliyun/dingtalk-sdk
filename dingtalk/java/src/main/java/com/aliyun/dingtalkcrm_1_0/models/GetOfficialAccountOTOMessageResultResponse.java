// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountOTOMessageResultResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetOfficialAccountOTOMessageResultResponseBody body;

    public static GetOfficialAccountOTOMessageResultResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountOTOMessageResultResponse self = new GetOfficialAccountOTOMessageResultResponse();
        return TeaModel.build(map, self);
    }

    public GetOfficialAccountOTOMessageResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOfficialAccountOTOMessageResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOfficialAccountOTOMessageResultResponse setBody(GetOfficialAccountOTOMessageResultResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOfficialAccountOTOMessageResultResponseBody getBody() {
        return this.body;
    }

}
