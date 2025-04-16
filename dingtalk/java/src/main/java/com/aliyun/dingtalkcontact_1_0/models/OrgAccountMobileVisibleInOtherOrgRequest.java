// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class OrgAccountMobileVisibleInOtherOrgRequest extends TeaModel {
    @NameInMap("fields")
    public java.util.List<String> fields;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("optUserId")
    public String optUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("toCorpIds")
    public java.util.List<String> toCorpIds;

    public static OrgAccountMobileVisibleInOtherOrgRequest build(java.util.Map<String, ?> map) throws Exception {
        OrgAccountMobileVisibleInOtherOrgRequest self = new OrgAccountMobileVisibleInOtherOrgRequest();
        return TeaModel.build(map, self);
    }

    public OrgAccountMobileVisibleInOtherOrgRequest setFields(java.util.List<String> fields) {
        this.fields = fields;
        return this;
    }
    public java.util.List<String> getFields() {
        return this.fields;
    }

    public OrgAccountMobileVisibleInOtherOrgRequest setOptUserId(String optUserId) {
        this.optUserId = optUserId;
        return this;
    }
    public String getOptUserId() {
        return this.optUserId;
    }

    public OrgAccountMobileVisibleInOtherOrgRequest setToCorpIds(java.util.List<String> toCorpIds) {
        this.toCorpIds = toCorpIds;
        return this;
    }
    public java.util.List<String> getToCorpIds() {
        return this.toCorpIds;
    }

}
