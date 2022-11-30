// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayDeployResponseBody extends TeaModel {
    @NameInMap("result")
    public Object result;

    public static ReleaseGrayDeployResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayDeployResponseBody self = new ReleaseGrayDeployResponseBody();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayDeployResponseBody setResult(Object result) {
        this.result = result;
        return this;
    }
    public Object getResult() {
        return this.result;
    }

}
