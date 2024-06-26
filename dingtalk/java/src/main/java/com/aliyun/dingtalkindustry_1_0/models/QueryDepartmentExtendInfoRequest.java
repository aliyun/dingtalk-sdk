// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryDepartmentExtendInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1000</p>
     */
    @NameInMap("deptCode")
    public Long deptCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("propCode")
    public String propCode;

    public static QueryDepartmentExtendInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDepartmentExtendInfoRequest self = new QueryDepartmentExtendInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryDepartmentExtendInfoRequest setDeptCode(Long deptCode) {
        this.deptCode = deptCode;
        return this;
    }
    public Long getDeptCode() {
        return this.deptCode;
    }

    public QueryDepartmentExtendInfoRequest setPropCode(String propCode) {
        this.propCode = propCode;
        return this;
    }
    public String getPropCode() {
        return this.propCode;
    }

}
