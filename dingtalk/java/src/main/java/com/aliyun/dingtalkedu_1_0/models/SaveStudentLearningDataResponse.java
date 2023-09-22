// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SaveStudentLearningDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SaveStudentLearningDataResponseBody body;

    public static SaveStudentLearningDataResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveStudentLearningDataResponse self = new SaveStudentLearningDataResponse();
        return TeaModel.build(map, self);
    }

    public SaveStudentLearningDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveStudentLearningDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveStudentLearningDataResponse setBody(SaveStudentLearningDataResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveStudentLearningDataResponseBody getBody() {
        return this.body;
    }

}
