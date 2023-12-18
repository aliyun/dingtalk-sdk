// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class LinkCommonInvokeResponseBody extends TeaModel {
    @NameInMap("bizType")
    public String bizType;

    @NameInMap("data")
    public String data;

    @NameInMap("invokeId")
    public String invokeId;

    public static LinkCommonInvokeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        LinkCommonInvokeResponseBody self = new LinkCommonInvokeResponseBody();
        return TeaModel.build(map, self);
    }

    public LinkCommonInvokeResponseBody setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public LinkCommonInvokeResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public LinkCommonInvokeResponseBody setInvokeId(String invokeId) {
        this.invokeId = invokeId;
        return this;
    }
    public String getInvokeId() {
        return this.invokeId;
    }

}
