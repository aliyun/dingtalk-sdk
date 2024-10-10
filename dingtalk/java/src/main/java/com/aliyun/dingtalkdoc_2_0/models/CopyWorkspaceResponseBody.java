// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CopyWorkspaceResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static CopyWorkspaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CopyWorkspaceResponseBody self = new CopyWorkspaceResponseBody();
        return TeaModel.build(map, self);
    }

    public CopyWorkspaceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
