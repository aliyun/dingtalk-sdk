// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetUserLastMetricResponseBody extends TeaModel {
    @NameInMap("metricMap")
    public java.util.Map<String, MetricMapValue> metricMap;

    public static GetUserLastMetricResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserLastMetricResponseBody self = new GetUserLastMetricResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserLastMetricResponseBody setMetricMap(java.util.Map<String, MetricMapValue> metricMap) {
        this.metricMap = metricMap;
        return this;
    }
    public java.util.Map<String, MetricMapValue> getMetricMap() {
        return this.metricMap;
    }

}
