// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class ChannelOrdersResponseBody extends TeaModel {
    @NameInMap("esignOrderId")
    public String esignOrderId;

    public static ChannelOrdersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChannelOrdersResponseBody self = new ChannelOrdersResponseBody();
        return TeaModel.build(map, self);
    }

    public ChannelOrdersResponseBody setEsignOrderId(String esignOrderId) {
        this.esignOrderId = esignOrderId;
        return this;
    }
    public String getEsignOrderId() {
        return this.esignOrderId;
    }

}
