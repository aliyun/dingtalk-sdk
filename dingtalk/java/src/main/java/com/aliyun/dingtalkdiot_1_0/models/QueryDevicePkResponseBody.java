// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class QueryDevicePkResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static QueryDevicePkResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDevicePkResponseBody self = new QueryDevicePkResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDevicePkResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
