// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactEmpListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>65722123</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    public static CustomizeContactEmpListRequest build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactEmpListRequest self = new CustomizeContactEmpListRequest();
        return TeaModel.build(map, self);
    }

    public CustomizeContactEmpListRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

}
