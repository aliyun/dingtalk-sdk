// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class SetPermissionInheritanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PASS_ON</p>
     */
    @NameInMap("inheritance")
    public String inheritance;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static SetPermissionInheritanceRequest build(java.util.Map<String, ?> map) throws Exception {
        SetPermissionInheritanceRequest self = new SetPermissionInheritanceRequest();
        return TeaModel.build(map, self);
    }

    public SetPermissionInheritanceRequest setInheritance(String inheritance) {
        this.inheritance = inheritance;
        return this;
    }
    public String getInheritance() {
        return this.inheritance;
    }

    public SetPermissionInheritanceRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
