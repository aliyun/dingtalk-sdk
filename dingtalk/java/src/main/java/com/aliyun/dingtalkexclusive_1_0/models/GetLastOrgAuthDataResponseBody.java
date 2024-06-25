// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetLastOrgAuthDataResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>营业执照照片不清晰</p>
     */
    @NameInMap("authRemark")
    public String authRemark;

    /**
     * <strong>example:</strong>
     * <p>2</p>
     */
    @NameInMap("authStatus")
    public Integer authStatus;

    public static GetLastOrgAuthDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetLastOrgAuthDataResponseBody self = new GetLastOrgAuthDataResponseBody();
        return TeaModel.build(map, self);
    }

    public GetLastOrgAuthDataResponseBody setAuthRemark(String authRemark) {
        this.authRemark = authRemark;
        return this;
    }
    public String getAuthRemark() {
        return this.authRemark;
    }

    public GetLastOrgAuthDataResponseBody setAuthStatus(Integer authStatus) {
        this.authStatus = authStatus;
        return this;
    }
    public Integer getAuthStatus() {
        return this.authStatus;
    }

}
