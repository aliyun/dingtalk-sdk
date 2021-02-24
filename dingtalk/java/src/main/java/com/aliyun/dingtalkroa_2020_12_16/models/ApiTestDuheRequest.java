// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkroa_2020_12_16.models;

import com.aliyun.tea.*;

public class ApiTestDuheRequest extends TeaModel {
    @NameInMap("AccessToken")
    public String accessToken;

    public static ApiTestDuheRequest build(java.util.Map<String, ?> map) throws Exception {
        ApiTestDuheRequest self = new ApiTestDuheRequest();
        return TeaModel.build(map, self);
    }

    public ApiTestDuheRequest setAccessToken(String accessToken) {
        this.accessToken = accessToken;
        return this;
    }
    public String getAccessToken() {
        return this.accessToken;
    }

}
