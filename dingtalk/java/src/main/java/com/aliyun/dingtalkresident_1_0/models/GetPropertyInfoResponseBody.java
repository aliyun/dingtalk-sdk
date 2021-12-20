// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetPropertyInfoResponseBody extends TeaModel {
    @NameInMap("name")
    public String name;

    @NameInMap("orgId")
    public Long orgId;

    @NameInMap("adminName")
    public String adminName;

    @NameInMap("adminUserId")
    public String adminUserId;

    @NameInMap("unifiedSocialCredit")
    public String unifiedSocialCredit;

    public static GetPropertyInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPropertyInfoResponseBody self = new GetPropertyInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPropertyInfoResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetPropertyInfoResponseBody setOrgId(Long orgId) {
        this.orgId = orgId;
        return this;
    }
    public Long getOrgId() {
        return this.orgId;
    }

    public GetPropertyInfoResponseBody setAdminName(String adminName) {
        this.adminName = adminName;
        return this;
    }
    public String getAdminName() {
        return this.adminName;
    }

    public GetPropertyInfoResponseBody setAdminUserId(String adminUserId) {
        this.adminUserId = adminUserId;
        return this;
    }
    public String getAdminUserId() {
        return this.adminUserId;
    }

    public GetPropertyInfoResponseBody setUnifiedSocialCredit(String unifiedSocialCredit) {
        this.unifiedSocialCredit = unifiedSocialCredit;
        return this;
    }
    public String getUnifiedSocialCredit() {
        return this.unifiedSocialCredit;
    }

}
