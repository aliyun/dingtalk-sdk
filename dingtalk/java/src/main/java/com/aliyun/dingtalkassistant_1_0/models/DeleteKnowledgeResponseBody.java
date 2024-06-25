// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class DeleteKnowledgeResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteKnowledgeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteKnowledgeResponseBody self = new DeleteKnowledgeResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteKnowledgeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
