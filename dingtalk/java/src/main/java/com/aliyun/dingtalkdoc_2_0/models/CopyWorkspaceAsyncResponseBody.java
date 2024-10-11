// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CopyWorkspaceAsyncResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("id")
    public Long id;

    public static CopyWorkspaceAsyncResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CopyWorkspaceAsyncResponseBody self = new CopyWorkspaceAsyncResponseBody();
        return TeaModel.build(map, self);
    }

    public CopyWorkspaceAsyncResponseBody setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

}
