// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkroa_2020_12_16.models;

import com.aliyun.tea.*;

public class ApiTestDuheResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("RequestId")
    public String requestId;

    // dddd
    @NameInMap("UserId")
    public String userId;

    public static ApiTestDuheResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ApiTestDuheResponseBody self = new ApiTestDuheResponseBody();
        return TeaModel.build(map, self);
    }

    public ApiTestDuheResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public ApiTestDuheResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
