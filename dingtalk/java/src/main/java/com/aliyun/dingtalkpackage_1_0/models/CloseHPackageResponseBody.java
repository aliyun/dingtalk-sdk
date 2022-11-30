// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class CloseHPackageResponseBody extends TeaModel {
    @NameInMap("result")
    public Object result;

    public static CloseHPackageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CloseHPackageResponseBody self = new CloseHPackageResponseBody();
        return TeaModel.build(map, self);
    }

    public CloseHPackageResponseBody setResult(Object result) {
        this.result = result;
        return this;
    }
    public Object getResult() {
        return this.result;
    }

}
