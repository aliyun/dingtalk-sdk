// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class GetPermissionShareScopeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetPermissionShareScopeRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPermissionShareScopeRequest self = new GetPermissionShareScopeRequest();
        return TeaModel.build(map, self);
    }

    public GetPermissionShareScopeRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
