// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreUsersRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>alt:1213ss</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1231</p>
     */
    @NameInMap("nodeId")
    public Long nodeId;

    public static DigitalStoreUsersRequest build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreUsersRequest self = new DigitalStoreUsersRequest();
        return TeaModel.build(map, self);
    }

    public DigitalStoreUsersRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public DigitalStoreUsersRequest setNodeId(Long nodeId) {
        this.nodeId = nodeId;
        return this;
    }
    public Long getNodeId() {
        return this.nodeId;
    }

}
