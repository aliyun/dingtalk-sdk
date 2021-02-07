// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetSignNoticeUrlResponseBody extends TeaModel {
    @NameInMap("authStatus")
    public String authStatus;

    @NameInMap("installStatus")
    public String installStatus;

    public static GetSignNoticeUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSignNoticeUrlResponseBody self = new GetSignNoticeUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSignNoticeUrlResponseBody setAuthStatus(String authStatus) {
        this.authStatus = authStatus;
        return this;
    }
    public String getAuthStatus() {
        return this.authStatus;
    }

    public GetSignNoticeUrlResponseBody setInstallStatus(String installStatus) {
        this.installStatus = installStatus;
        return this;
    }
    public String getInstallStatus() {
        return this.installStatus;
    }

}
