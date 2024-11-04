// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class RemoveAssistantResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static RemoveAssistantResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveAssistantResponseBody self = new RemoveAssistantResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveAssistantResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
