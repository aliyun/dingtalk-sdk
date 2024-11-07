// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class OrgAccountMobileVisibleInOtherOrgResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static OrgAccountMobileVisibleInOtherOrgResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OrgAccountMobileVisibleInOtherOrgResponseBody self = new OrgAccountMobileVisibleInOtherOrgResponseBody();
        return TeaModel.build(map, self);
    }

    public OrgAccountMobileVisibleInOtherOrgResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
