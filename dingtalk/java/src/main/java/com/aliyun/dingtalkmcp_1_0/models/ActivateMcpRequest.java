// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmcp_1_0.models;

import com.aliyun.tea.*;

public class ActivateMcpRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("mcpId")
    public Long mcpId;

    @NameInMap("source")
    public String source;

    public static ActivateMcpRequest build(java.util.Map<String, ?> map) throws Exception {
        ActivateMcpRequest self = new ActivateMcpRequest();
        return TeaModel.build(map, self);
    }

    public ActivateMcpRequest setMcpId(Long mcpId) {
        this.mcpId = mcpId;
        return this;
    }
    public Long getMcpId() {
        return this.mcpId;
    }

    public ActivateMcpRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

}
