// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptDeleteRequest extends TeaModel {
    // 自定义通讯录Code
    @NameInMap("code")
    public String code;

    // 部门Id
    @NameInMap("deptId")
    public Long deptId;

    public static CustomizeContactDeptDeleteRequest build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeptDeleteRequest self = new CustomizeContactDeptDeleteRequest();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeptDeleteRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public CustomizeContactDeptDeleteRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

}
