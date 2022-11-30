// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class OpenMicroAppPackageResponseBody extends TeaModel {
    @NameInMap("result")
    public Object result;

    public static OpenMicroAppPackageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OpenMicroAppPackageResponseBody self = new OpenMicroAppPackageResponseBody();
        return TeaModel.build(map, self);
    }

    public OpenMicroAppPackageResponseBody setResult(Object result) {
        this.result = result;
        return this;
    }
    public Object getResult() {
        return this.result;
    }

}
