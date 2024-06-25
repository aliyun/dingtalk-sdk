// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetCollegeAlumniDeptsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>staff234</p>
     */
    @NameInMap("operator")
    public String operator;

    public static GetCollegeAlumniDeptsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCollegeAlumniDeptsRequest self = new GetCollegeAlumniDeptsRequest();
        return TeaModel.build(map, self);
    }

    public GetCollegeAlumniDeptsRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public GetCollegeAlumniDeptsRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

}
