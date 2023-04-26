// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class DeleteResidentDepartmentRequest extends TeaModel {
    @NameInMap("departmentId")
    public Long departmentId;

    public static DeleteResidentDepartmentRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteResidentDepartmentRequest self = new DeleteResidentDepartmentRequest();
        return TeaModel.build(map, self);
    }

    public DeleteResidentDepartmentRequest setDepartmentId(Long departmentId) {
        this.departmentId = departmentId;
        return this;
    }
    public Long getDepartmentId() {
        return this.departmentId;
    }

}
