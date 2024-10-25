// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class OrgAccountMobileVisiblePermissonResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static OrgAccountMobileVisiblePermissonResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OrgAccountMobileVisiblePermissonResponseBody self = new OrgAccountMobileVisiblePermissonResponseBody();
        return TeaModel.build(map, self);
    }

    public OrgAccountMobileVisiblePermissonResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
