// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class DeleteRecycleFilesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static DeleteRecycleFilesResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteRecycleFilesResponse self = new DeleteRecycleFilesResponse();
        return TeaModel.build(map, self);
    }

    public DeleteRecycleFilesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
