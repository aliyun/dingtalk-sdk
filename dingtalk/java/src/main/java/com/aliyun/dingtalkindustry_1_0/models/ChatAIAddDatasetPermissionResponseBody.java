// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAIAddDatasetPermissionResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static ChatAIAddDatasetPermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatAIAddDatasetPermissionResponseBody self = new ChatAIAddDatasetPermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatAIAddDatasetPermissionResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
