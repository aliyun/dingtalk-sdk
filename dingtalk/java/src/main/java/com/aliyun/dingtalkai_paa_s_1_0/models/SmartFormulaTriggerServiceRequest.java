// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartFormulaTriggerServiceRequest extends TeaModel {
    @NameInMap("request")
    public String request;

    public static SmartFormulaTriggerServiceRequest build(java.util.Map<String, ?> map) throws Exception {
        SmartFormulaTriggerServiceRequest self = new SmartFormulaTriggerServiceRequest();
        return TeaModel.build(map, self);
    }

    public SmartFormulaTriggerServiceRequest setRequest(String request) {
        this.request = request;
        return this;
    }
    public String getRequest() {
        return this.request;
    }

}
