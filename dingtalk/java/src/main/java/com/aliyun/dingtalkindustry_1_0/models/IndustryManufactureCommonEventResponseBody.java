// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureCommonEventResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Object result;

    @NameInMap("success")
    public Boolean success;

    public static IndustryManufactureCommonEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureCommonEventResponseBody self = new IndustryManufactureCommonEventResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureCommonEventResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public IndustryManufactureCommonEventResponseBody setResult(Object result) {
        this.result = result;
        return this;
    }
    public Object getResult() {
        return this.result;
    }

    public IndustryManufactureCommonEventResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
