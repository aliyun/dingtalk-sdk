// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RevertDentryVersionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static RevertDentryVersionRequest build(java.util.Map<String, ?> map) throws Exception {
        RevertDentryVersionRequest self = new RevertDentryVersionRequest();
        return TeaModel.build(map, self);
    }

    public RevertDentryVersionRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
