// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetPrincipalEmployeeResponseBody extends TeaModel {
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetPrincipalEmployeeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPrincipalEmployeeResponseBody self = new GetPrincipalEmployeeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPrincipalEmployeeResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetPrincipalEmployeeResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
