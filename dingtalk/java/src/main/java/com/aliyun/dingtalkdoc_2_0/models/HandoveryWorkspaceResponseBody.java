// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class HandoveryWorkspaceResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static HandoveryWorkspaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HandoveryWorkspaceResponseBody self = new HandoveryWorkspaceResponseBody();
        return TeaModel.build(map, self);
    }

    public HandoveryWorkspaceResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
