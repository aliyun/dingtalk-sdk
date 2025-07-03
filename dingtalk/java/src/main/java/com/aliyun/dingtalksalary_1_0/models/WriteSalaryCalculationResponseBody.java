// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class WriteSalaryCalculationResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.Map<String, ?> result;

    public static WriteSalaryCalculationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        WriteSalaryCalculationResponseBody self = new WriteSalaryCalculationResponseBody();
        return TeaModel.build(map, self);
    }

    public WriteSalaryCalculationResponseBody setResult(java.util.Map<String, ?> result) {
        this.result = result;
        return this;
    }
    public java.util.Map<String, ?> getResult() {
        return this.result;
    }

}
