// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class ExclusiveModelCompleteServiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ExclusiveModelCompleteServiceResponseBody body;

    public static ExclusiveModelCompleteServiceResponse build(java.util.Map<String, ?> map) throws Exception {
        ExclusiveModelCompleteServiceResponse self = new ExclusiveModelCompleteServiceResponse();
        return TeaModel.build(map, self);
    }

    public ExclusiveModelCompleteServiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExclusiveModelCompleteServiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ExclusiveModelCompleteServiceResponse setBody(ExclusiveModelCompleteServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public ExclusiveModelCompleteServiceResponseBody getBody() {
        return this.body;
    }

}
