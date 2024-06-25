// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class HandOverWorkspaceResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static HandOverWorkspaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HandOverWorkspaceResponseBody self = new HandOverWorkspaceResponseBody();
        return TeaModel.build(map, self);
    }

    public HandOverWorkspaceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
