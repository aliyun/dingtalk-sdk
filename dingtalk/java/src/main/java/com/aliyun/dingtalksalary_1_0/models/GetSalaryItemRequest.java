// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class GetSalaryItemRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SalaryItemGroupxxx</p>
     */
    @NameInMap("salaryItemGroupId")
    public String salaryItemGroupId;

    public static GetSalaryItemRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSalaryItemRequest self = new GetSalaryItemRequest();
        return TeaModel.build(map, self);
    }

    public GetSalaryItemRequest setSalaryItemGroupId(String salaryItemGroupId) {
        this.salaryItemGroupId = salaryItemGroupId;
        return this;
    }
    public String getSalaryItemGroupId() {
        return this.salaryItemGroupId;
    }

}
