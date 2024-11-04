// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartQuoteQueryServiceRequest extends TeaModel {
    @NameInMap("request")
    public String request;

    public static SmartQuoteQueryServiceRequest build(java.util.Map<String, ?> map) throws Exception {
        SmartQuoteQueryServiceRequest self = new SmartQuoteQueryServiceRequest();
        return TeaModel.build(map, self);
    }

    public SmartQuoteQueryServiceRequest setRequest(String request) {
        this.request = request;
        return this;
    }
    public String getRequest() {
        return this.request;
    }

}
