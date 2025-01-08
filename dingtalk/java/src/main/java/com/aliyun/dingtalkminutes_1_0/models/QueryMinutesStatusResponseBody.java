// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesStatusResponseBody extends TeaModel {
    @NameInMap("status")
    public Integer status;

    public static QueryMinutesStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesStatusResponseBody self = new QueryMinutesStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMinutesStatusResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
