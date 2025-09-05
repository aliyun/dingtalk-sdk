// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class OrgInfoShrinkRequest extends TeaModel {
    @NameInMap("orgIds")
    public String orgIdsShrink;

    public static OrgInfoShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        OrgInfoShrinkRequest self = new OrgInfoShrinkRequest();
        return TeaModel.build(map, self);
    }

    public OrgInfoShrinkRequest setOrgIdsShrink(String orgIdsShrink) {
        this.orgIdsShrink = orgIdsShrink;
        return this;
    }
    public String getOrgIdsShrink() {
        return this.orgIdsShrink;
    }

}
