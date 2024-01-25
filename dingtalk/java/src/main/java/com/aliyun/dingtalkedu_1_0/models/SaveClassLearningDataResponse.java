// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SaveClassLearningDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SaveClassLearningDataResponseBody body;

    public static SaveClassLearningDataResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveClassLearningDataResponse self = new SaveClassLearningDataResponse();
        return TeaModel.build(map, self);
    }

    public SaveClassLearningDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveClassLearningDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveClassLearningDataResponse setBody(SaveClassLearningDataResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveClassLearningDataResponseBody getBody() {
        return this.body;
    }

}
