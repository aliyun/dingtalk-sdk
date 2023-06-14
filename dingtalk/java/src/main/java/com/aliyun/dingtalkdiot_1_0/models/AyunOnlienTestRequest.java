// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class AyunOnlienTestRequest extends TeaModel {
    @NameInMap("reqId")
    public String reqId;

    public static AyunOnlienTestRequest build(java.util.Map<String, ?> map) throws Exception {
        AyunOnlienTestRequest self = new AyunOnlienTestRequest();
        return TeaModel.build(map, self);
    }

    public AyunOnlienTestRequest setReqId(String reqId) {
        this.reqId = reqId;
        return this;
    }
    public String getReqId() {
        return this.reqId;
    }

}
