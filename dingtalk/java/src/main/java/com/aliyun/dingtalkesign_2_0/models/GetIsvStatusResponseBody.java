// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetIsvStatusResponseBody extends TeaModel {
    @NameInMap("installStatus")
    public String installStatus;

    @NameInMap("authStatus")
    public String authStatus;

    public static GetIsvStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetIsvStatusResponseBody self = new GetIsvStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public GetIsvStatusResponseBody setInstallStatus(String installStatus) {
        this.installStatus = installStatus;
        return this;
    }
    public String getInstallStatus() {
        return this.installStatus;
    }

    public GetIsvStatusResponseBody setAuthStatus(String authStatus) {
        this.authStatus = authStatus;
        return this;
    }
    public String getAuthStatus() {
        return this.authStatus;
    }

}
