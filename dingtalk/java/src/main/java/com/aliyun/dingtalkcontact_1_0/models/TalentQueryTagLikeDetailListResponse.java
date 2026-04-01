// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentQueryTagLikeDetailListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentQueryTagLikeDetailListResponseBody body;

    public static TalentQueryTagLikeDetailListResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentQueryTagLikeDetailListResponse self = new TalentQueryTagLikeDetailListResponse();
        return TeaModel.build(map, self);
    }

    public TalentQueryTagLikeDetailListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentQueryTagLikeDetailListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentQueryTagLikeDetailListResponse setBody(TalentQueryTagLikeDetailListResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentQueryTagLikeDetailListResponseBody getBody() {
        return this.body;
    }

}
