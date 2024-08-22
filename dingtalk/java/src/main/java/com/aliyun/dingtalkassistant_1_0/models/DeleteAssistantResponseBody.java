// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class DeleteAssistantResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteAssistantResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteAssistantResponseBody self = new DeleteAssistantResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteAssistantResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
