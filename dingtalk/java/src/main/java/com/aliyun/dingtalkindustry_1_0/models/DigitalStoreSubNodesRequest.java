// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreSubNodesRequest extends TeaModel {
    @NameInMap("code")
    public String code;

    @NameInMap("nodeId")
    public Long nodeId;

    public static DigitalStoreSubNodesRequest build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreSubNodesRequest self = new DigitalStoreSubNodesRequest();
        return TeaModel.build(map, self);
    }

    public DigitalStoreSubNodesRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public DigitalStoreSubNodesRequest setNodeId(Long nodeId) {
        this.nodeId = nodeId;
        return this;
    }
    public Long getNodeId() {
        return this.nodeId;
    }

}
