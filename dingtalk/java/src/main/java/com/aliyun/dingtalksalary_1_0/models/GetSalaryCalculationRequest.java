// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class GetSalaryCalculationRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2025-06</p>
     */
    @NameInMap("date")
    public String date;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SalaryGroupxxx</p>
     */
    @NameInMap("salaryGroupId")
    public String salaryGroupId;

    public static GetSalaryCalculationRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSalaryCalculationRequest self = new GetSalaryCalculationRequest();
        return TeaModel.build(map, self);
    }

    public GetSalaryCalculationRequest setDate(String date) {
        this.date = date;
        return this;
    }
    public String getDate() {
        return this.date;
    }

    public GetSalaryCalculationRequest setSalaryGroupId(String salaryGroupId) {
        this.salaryGroupId = salaryGroupId;
        return this;
    }
    public String getSalaryGroupId() {
        return this.salaryGroupId;
    }

}
