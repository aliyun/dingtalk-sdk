// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetAdministrativePenaltiesResponseBody extends TeaModel {
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetAdministrativePenaltiesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAdministrativePenaltiesResponseBody self = new GetAdministrativePenaltiesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAdministrativePenaltiesResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetAdministrativePenaltiesResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
