// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCorrectingDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateCorrectingDataResponseBody body;

    public static UpdateCorrectingDataResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateCorrectingDataResponse self = new UpdateCorrectingDataResponse();
        return TeaModel.build(map, self);
    }

    public UpdateCorrectingDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateCorrectingDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateCorrectingDataResponse setBody(UpdateCorrectingDataResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCorrectingDataResponseBody getBody() {
        return this.body;
    }

}
