// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactEmpDeleteRequest extends TeaModel {
    // 自定义通讯录Code
    @NameInMap("code")
    public String code;

    // 部门Id
    @NameInMap("deptId")
    public Long deptId;

    // 人员Id列表
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static CustomizeContactEmpDeleteRequest build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactEmpDeleteRequest self = new CustomizeContactEmpDeleteRequest();
        return TeaModel.build(map, self);
    }

    public CustomizeContactEmpDeleteRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public CustomizeContactEmpDeleteRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CustomizeContactEmpDeleteRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
