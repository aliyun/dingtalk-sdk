// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class DiotMamaResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static DiotMamaResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DiotMamaResponseBody self = new DiotMamaResponseBody();
        return TeaModel.build(map, self);
    }

    public DiotMamaResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
