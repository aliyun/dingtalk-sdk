// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskContentRequest extends TeaModel {
    @NameInMap("content")
    public String content;

    public static UpdateTaskContentRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskContentRequest self = new UpdateTaskContentRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTaskContentRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

}
