// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class TripPlatformUnifiedEntryResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static TripPlatformUnifiedEntryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TripPlatformUnifiedEntryResponseBody self = new TripPlatformUnifiedEntryResponseBody();
        return TeaModel.build(map, self);
    }

    public TripPlatformUnifiedEntryResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public TripPlatformUnifiedEntryResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public TripPlatformUnifiedEntryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
