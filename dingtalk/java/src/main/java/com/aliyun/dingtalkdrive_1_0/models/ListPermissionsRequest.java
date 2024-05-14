// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ListPermissionsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static ListPermissionsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListPermissionsRequest self = new ListPermissionsRequest();
        return TeaModel.build(map, self);
    }

    public ListPermissionsRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
