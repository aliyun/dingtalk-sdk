// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceIdByTypeRequest extends TeaModel {
    @NameInMap("departmentType")
    public String departmentType;

    public static GetSpaceIdByTypeRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceIdByTypeRequest self = new GetSpaceIdByTypeRequest();
        return TeaModel.build(map, self);
    }

    public GetSpaceIdByTypeRequest setDepartmentType(String departmentType) {
        this.departmentType = departmentType;
        return this;
    }
    public String getDepartmentType() {
        return this.departmentType;
    }

}
