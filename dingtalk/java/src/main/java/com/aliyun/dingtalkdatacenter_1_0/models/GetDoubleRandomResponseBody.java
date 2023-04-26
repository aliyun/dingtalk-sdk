// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetDoubleRandomResponseBody extends TeaModel {
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetDoubleRandomResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDoubleRandomResponseBody self = new GetDoubleRandomResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDoubleRandomResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetDoubleRandomResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
