// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAIListDatasetRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>111111</p>
     */
    @NameInMap("appId")
    public Long appId;

    public static ChatAIListDatasetRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatAIListDatasetRequest self = new ChatAIListDatasetRequest();
        return TeaModel.build(map, self);
    }

    public ChatAIListDatasetRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

}
