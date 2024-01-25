// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class UpdateCloudAccountInformationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateCloudAccountInformationResponseBody body;

    public static UpdateCloudAccountInformationResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateCloudAccountInformationResponse self = new UpdateCloudAccountInformationResponse();
        return TeaModel.build(map, self);
    }

    public UpdateCloudAccountInformationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateCloudAccountInformationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateCloudAccountInformationResponse setBody(UpdateCloudAccountInformationResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCloudAccountInformationResponseBody getBody() {
        return this.body;
    }

}
