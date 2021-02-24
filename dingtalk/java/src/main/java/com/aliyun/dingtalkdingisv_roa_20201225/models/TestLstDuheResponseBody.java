// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingisv_roa_20201225.models;

import com.aliyun.tea.*;

public class TestLstDuheResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("requestId")
    public String requestId;

    public static TestLstDuheResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TestLstDuheResponseBody self = new TestLstDuheResponseBody();
        return TeaModel.build(map, self);
    }

    public TestLstDuheResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
