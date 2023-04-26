// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveAcrossCloudStroageConfigsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SaveAcrossCloudStroageConfigsResponseBody body;

    public static SaveAcrossCloudStroageConfigsResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveAcrossCloudStroageConfigsResponse self = new SaveAcrossCloudStroageConfigsResponse();
        return TeaModel.build(map, self);
    }

    public SaveAcrossCloudStroageConfigsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveAcrossCloudStroageConfigsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveAcrossCloudStroageConfigsResponse setBody(SaveAcrossCloudStroageConfigsResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveAcrossCloudStroageConfigsResponseBody getBody() {
        return this.body;
    }

}
