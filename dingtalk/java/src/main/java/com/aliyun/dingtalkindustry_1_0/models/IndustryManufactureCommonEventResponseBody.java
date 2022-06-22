// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureCommonEventResponseBody extends TeaModel {
    @NameInMap("errorMsg")
    public String errorMsg;

    // Id of the request
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Object result;

    public static IndustryManufactureCommonEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureCommonEventResponseBody self = new IndustryManufactureCommonEventResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureCommonEventResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
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

}
