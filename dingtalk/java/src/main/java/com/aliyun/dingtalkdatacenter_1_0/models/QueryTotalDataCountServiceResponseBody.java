// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryTotalDataCountServiceResponseBody extends TeaModel {
    @NameInMap("success")
    public String success;

    @NameInMap("total")
    public Long total;

    public static QueryTotalDataCountServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryTotalDataCountServiceResponseBody self = new QueryTotalDataCountServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryTotalDataCountServiceResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public QueryTotalDataCountServiceResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
