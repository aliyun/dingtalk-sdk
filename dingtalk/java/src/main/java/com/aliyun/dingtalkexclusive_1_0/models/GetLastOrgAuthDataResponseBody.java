// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetLastOrgAuthDataResponseBody extends TeaModel {
    // 未通过原因
    @NameInMap("authRemark")
    public String authRemark;

    // 审核状态 0 未提交， 1未审核 2 失败 3通过
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
