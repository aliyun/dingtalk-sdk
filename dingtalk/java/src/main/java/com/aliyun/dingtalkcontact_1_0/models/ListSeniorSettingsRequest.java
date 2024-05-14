// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListSeniorSettingsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("seniorStaffId")
    public String seniorStaffId;

    public static ListSeniorSettingsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListSeniorSettingsRequest self = new ListSeniorSettingsRequest();
        return TeaModel.build(map, self);
    }

    public ListSeniorSettingsRequest setSeniorStaffId(String seniorStaffId) {
        this.seniorStaffId = seniorStaffId;
        return this;
    }
    public String getSeniorStaffId() {
        return this.seniorStaffId;
    }

}
