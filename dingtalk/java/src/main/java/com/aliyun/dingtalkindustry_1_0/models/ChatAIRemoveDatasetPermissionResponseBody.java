// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAIRemoveDatasetPermissionResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static ChatAIRemoveDatasetPermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatAIRemoveDatasetPermissionResponseBody self = new ChatAIRemoveDatasetPermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatAIRemoveDatasetPermissionResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
