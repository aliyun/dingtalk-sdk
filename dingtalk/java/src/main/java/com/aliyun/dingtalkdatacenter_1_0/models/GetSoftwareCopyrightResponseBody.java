// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetSoftwareCopyrightResponseBody extends TeaModel {
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetSoftwareCopyrightResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSoftwareCopyrightResponseBody self = new GetSoftwareCopyrightResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSoftwareCopyrightResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetSoftwareCopyrightResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
