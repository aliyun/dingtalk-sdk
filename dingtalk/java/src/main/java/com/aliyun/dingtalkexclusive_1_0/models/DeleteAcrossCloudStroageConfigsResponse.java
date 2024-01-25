// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class DeleteAcrossCloudStroageConfigsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteAcrossCloudStroageConfigsResponseBody body;

    public static DeleteAcrossCloudStroageConfigsResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteAcrossCloudStroageConfigsResponse self = new DeleteAcrossCloudStroageConfigsResponse();
        return TeaModel.build(map, self);
    }

    public DeleteAcrossCloudStroageConfigsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteAcrossCloudStroageConfigsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteAcrossCloudStroageConfigsResponse setBody(DeleteAcrossCloudStroageConfigsResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteAcrossCloudStroageConfigsResponseBody getBody() {
        return this.body;
    }

}
