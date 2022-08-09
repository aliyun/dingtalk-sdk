// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptGroupCreateRequest extends TeaModel {
    // 自定义通讯录Code
    @NameInMap("code")
    public String code;

    // 部门Id
    @NameInMap("deptId")
    public Long deptId;

    public static CustomizeContactDeptGroupCreateRequest build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeptGroupCreateRequest self = new CustomizeContactDeptGroupCreateRequest();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeptGroupCreateRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public CustomizeContactDeptGroupCreateRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

}
