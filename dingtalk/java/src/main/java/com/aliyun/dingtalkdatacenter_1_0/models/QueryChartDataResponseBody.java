// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryChartDataResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<?> result;

    @NameInMap("success")
    public String success;

    public static QueryChartDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryChartDataResponseBody self = new QueryChartDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryChartDataResponseBody setResult(java.util.List<?> result) {
        this.result = result;
        return this;
    }
    public java.util.List<?> getResult() {
        return this.result;
    }

    public QueryChartDataResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
