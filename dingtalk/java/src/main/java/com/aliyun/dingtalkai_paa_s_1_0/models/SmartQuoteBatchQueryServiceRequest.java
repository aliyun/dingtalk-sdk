// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartQuoteBatchQueryServiceRequest extends TeaModel {
    @NameInMap("request")
    public String request;

    public static SmartQuoteBatchQueryServiceRequest build(java.util.Map<String, ?> map) throws Exception {
        SmartQuoteBatchQueryServiceRequest self = new SmartQuoteBatchQueryServiceRequest();
        return TeaModel.build(map, self);
    }

    public SmartQuoteBatchQueryServiceRequest setRequest(String request) {
        this.request = request;
        return this;
    }
    public String getRequest() {
        return this.request;
    }

}
