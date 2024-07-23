// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class OperateChartConfigResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.Map<String, String> result;

    @NameInMap("success")
    public Boolean success;

    public static OperateChartConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OperateChartConfigResponseBody self = new OperateChartConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public OperateChartConfigResponseBody setResult(java.util.Map<String, String> result) {
        this.result = result;
        return this;
    }
    public java.util.Map<String, String> getResult() {
        return this.result;
    }

    public OperateChartConfigResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
