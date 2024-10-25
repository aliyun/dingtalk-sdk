// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class OrgAccountMobileVisiblePermissonRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.List<String> body;

    public static OrgAccountMobileVisiblePermissonRequest build(java.util.Map<String, ?> map) throws Exception {
        OrgAccountMobileVisiblePermissonRequest self = new OrgAccountMobileVisiblePermissonRequest();
        return TeaModel.build(map, self);
    }

    public OrgAccountMobileVisiblePermissonRequest setBody(java.util.List<String> body) {
        this.body = body;
        return this;
    }
    public java.util.List<String> getBody() {
        return this.body;
    }

}
