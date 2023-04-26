// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CohostsResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static CohostsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CohostsResponseBody self = new CohostsResponseBody();
        return TeaModel.build(map, self);
    }

    public CohostsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
