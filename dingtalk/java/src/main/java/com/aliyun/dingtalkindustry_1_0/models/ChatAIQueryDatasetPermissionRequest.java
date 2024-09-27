// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAIQueryDatasetPermissionRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>数据集Id</p>
     */
    @NameInMap("datasetId")
    public String datasetId;

    public static ChatAIQueryDatasetPermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatAIQueryDatasetPermissionRequest self = new ChatAIQueryDatasetPermissionRequest();
        return TeaModel.build(map, self);
    }

    public ChatAIQueryDatasetPermissionRequest setDatasetId(String datasetId) {
        this.datasetId = datasetId;
        return this;
    }
    public String getDatasetId() {
        return this.datasetId;
    }

}
