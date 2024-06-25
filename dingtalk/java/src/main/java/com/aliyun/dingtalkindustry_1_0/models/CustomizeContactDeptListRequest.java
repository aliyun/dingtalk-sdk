// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>XXXX</p>
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

    public static CustomizeContactDeptListRequest build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeptListRequest self = new CustomizeContactDeptListRequest();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeptListRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public CustomizeContactDeptListRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

}
