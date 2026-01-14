// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteRosterFieldFormRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formId")
    public String formId;

    @NameInMap("userId")
    public String userId;

    public static DeleteRosterFieldFormRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteRosterFieldFormRequest self = new DeleteRosterFieldFormRequest();
        return TeaModel.build(map, self);
    }

    public DeleteRosterFieldFormRequest setFormId(String formId) {
        this.formId = formId;
        return this;
    }
    public String getFormId() {
        return this.formId;
    }

    public DeleteRosterFieldFormRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
