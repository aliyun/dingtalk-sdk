// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateRosterFieldFormRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("detail")
    public Boolean detail;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formId")
    public String formId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("userId")
    public String userId;

    public static UpdateRosterFieldFormRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateRosterFieldFormRequest self = new UpdateRosterFieldFormRequest();
        return TeaModel.build(map, self);
    }

    public UpdateRosterFieldFormRequest setDetail(Boolean detail) {
        this.detail = detail;
        return this;
    }
    public Boolean getDetail() {
        return this.detail;
    }

    public UpdateRosterFieldFormRequest setFormId(String formId) {
        this.formId = formId;
        return this;
    }
    public String getFormId() {
        return this.formId;
    }

    public UpdateRosterFieldFormRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateRosterFieldFormRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
