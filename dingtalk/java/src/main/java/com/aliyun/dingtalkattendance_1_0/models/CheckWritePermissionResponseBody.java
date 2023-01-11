// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class CheckWritePermissionResponseBody extends TeaModel {
    /**
     * <p>entityPermissionMap</p>
     */
    @NameInMap("entityPermissionMap")
    public java.util.Map<String, Boolean> entityPermissionMap;

    public static CheckWritePermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CheckWritePermissionResponseBody self = new CheckWritePermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public CheckWritePermissionResponseBody setEntityPermissionMap(java.util.Map<String, Boolean> entityPermissionMap) {
        this.entityPermissionMap = entityPermissionMap;
        return this;
    }
    public java.util.Map<String, Boolean> getEntityPermissionMap() {
        return this.entityPermissionMap;
    }

}
