// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UploadLearningDataCallbackResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UploadLearningDataCallbackResponseBody body;

    public static UploadLearningDataCallbackResponse build(java.util.Map<String, ?> map) throws Exception {
        UploadLearningDataCallbackResponse self = new UploadLearningDataCallbackResponse();
        return TeaModel.build(map, self);
    }

    public UploadLearningDataCallbackResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UploadLearningDataCallbackResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UploadLearningDataCallbackResponse setBody(UploadLearningDataCallbackResponseBody body) {
        this.body = body;
        return this;
    }
    public UploadLearningDataCallbackResponseBody getBody() {
        return this.body;
    }

}
