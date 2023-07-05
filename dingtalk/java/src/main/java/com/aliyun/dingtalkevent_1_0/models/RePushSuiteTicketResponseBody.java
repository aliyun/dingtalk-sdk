// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkevent_1_0.models;

import com.aliyun.tea.*;

public class RePushSuiteTicketResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static RePushSuiteTicketResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RePushSuiteTicketResponseBody self = new RePushSuiteTicketResponseBody();
        return TeaModel.build(map, self);
    }

    public RePushSuiteTicketResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
