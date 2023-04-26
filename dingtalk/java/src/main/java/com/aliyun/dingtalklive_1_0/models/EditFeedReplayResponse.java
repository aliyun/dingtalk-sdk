// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class EditFeedReplayResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public EditFeedReplayResponseBody body;

    public static EditFeedReplayResponse build(java.util.Map<String, ?> map) throws Exception {
        EditFeedReplayResponse self = new EditFeedReplayResponse();
        return TeaModel.build(map, self);
    }

    public EditFeedReplayResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditFeedReplayResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EditFeedReplayResponse setBody(EditFeedReplayResponseBody body) {
        this.body = body;
        return this;
    }
    public EditFeedReplayResponseBody getBody() {
        return this.body;
    }

}
