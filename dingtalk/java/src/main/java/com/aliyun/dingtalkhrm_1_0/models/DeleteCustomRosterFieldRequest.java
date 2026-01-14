// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteCustomRosterFieldRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fieldCode")
    public String fieldCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupId")
    public String groupId;

    public static DeleteCustomRosterFieldRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteCustomRosterFieldRequest self = new DeleteCustomRosterFieldRequest();
        return TeaModel.build(map, self);
    }

    public DeleteCustomRosterFieldRequest setFieldCode(String fieldCode) {
        this.fieldCode = fieldCode;
        return this;
    }
    public String getFieldCode() {
        return this.fieldCode;
    }

    public DeleteCustomRosterFieldRequest setGroupId(String groupId) {
        this.groupId = groupId;
        return this;
    }
    public String getGroupId() {
        return this.groupId;
    }

}
