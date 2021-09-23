// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class CreateDepartmentResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("result")
    public String result;

    public static CreateDepartmentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateDepartmentResponseBody self = new CreateDepartmentResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateDepartmentResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
