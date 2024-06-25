// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptDeleteRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>XXX</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>65722123</p>
     */
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
