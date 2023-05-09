// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class GetPermissionInheritanceResponseBody extends TeaModel {
    @NameInMap("inheritance")
    public String inheritance;

    public static GetPermissionInheritanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPermissionInheritanceResponseBody self = new GetPermissionInheritanceResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPermissionInheritanceResponseBody setInheritance(String inheritance) {
        this.inheritance = inheritance;
        return this;
    }
    public String getInheritance() {
        return this.inheritance;
    }

}
