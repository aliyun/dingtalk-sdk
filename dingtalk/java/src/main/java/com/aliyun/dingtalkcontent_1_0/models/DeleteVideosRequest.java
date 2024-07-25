// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class DeleteVideosRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<String> body;

    public static DeleteVideosRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteVideosRequest self = new DeleteVideosRequest();
        return TeaModel.build(map, self);
    }

    public DeleteVideosRequest setBody(java.util.List<String> body) {
        this.body = body;
        return this;
    }
    public java.util.List<String> getBody() {
        return this.body;
    }

}
