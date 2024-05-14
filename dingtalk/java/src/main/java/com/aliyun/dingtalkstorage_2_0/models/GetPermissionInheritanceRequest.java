// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class GetPermissionInheritanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetPermissionInheritanceRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPermissionInheritanceRequest self = new GetPermissionInheritanceRequest();
        return TeaModel.build(map, self);
    }

    public GetPermissionInheritanceRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
