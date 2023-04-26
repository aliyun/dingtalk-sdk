// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class CreateSpaceResponseBody extends TeaModel {
    @NameInMap("deptId")
    public String deptId;

    public static CreateSpaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateSpaceResponseBody self = new CreateSpaceResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateSpaceResponseBody setDeptId(String deptId) {
        this.deptId = deptId;
        return this;
    }
    public String getDeptId() {
        return this.deptId;
    }

}
