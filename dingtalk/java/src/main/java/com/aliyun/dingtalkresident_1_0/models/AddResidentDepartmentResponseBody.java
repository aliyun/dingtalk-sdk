// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddResidentDepartmentResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public Long result;

    public static AddResidentDepartmentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddResidentDepartmentResponseBody self = new AddResidentDepartmentResponseBody();
        return TeaModel.build(map, self);
    }

    public AddResidentDepartmentResponseBody setResult(Long result) {
        this.result = result;
        return this;
    }
    public Long getResult() {
        return this.result;
    }

}
