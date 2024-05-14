// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreNodeInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nodeId")
    public Long nodeId;

    public static DigitalStoreNodeInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreNodeInfoRequest self = new DigitalStoreNodeInfoRequest();
        return TeaModel.build(map, self);
    }

    public DigitalStoreNodeInfoRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public DigitalStoreNodeInfoRequest setNodeId(Long nodeId) {
        this.nodeId = nodeId;
        return this;
    }
    public Long getNodeId() {
        return this.nodeId;
    }

}
