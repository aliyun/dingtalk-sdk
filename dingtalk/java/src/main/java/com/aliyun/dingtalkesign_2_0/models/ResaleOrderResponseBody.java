// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class ResaleOrderResponseBody extends TeaModel {
    @NameInMap("esignOrderId")
    public String esignOrderId;

    public static ResaleOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ResaleOrderResponseBody self = new ResaleOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public ResaleOrderResponseBody setEsignOrderId(String esignOrderId) {
        this.esignOrderId = esignOrderId;
        return this;
    }
    public String getEsignOrderId() {
        return this.esignOrderId;
    }

}
