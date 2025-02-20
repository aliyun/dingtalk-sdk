// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryPositionVersionResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static QueryPositionVersionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPositionVersionResponseBody self = new QueryPositionVersionResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPositionVersionResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
