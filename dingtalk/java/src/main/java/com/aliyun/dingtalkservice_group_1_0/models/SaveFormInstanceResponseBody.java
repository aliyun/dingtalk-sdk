// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SaveFormInstanceResponseBody extends TeaModel {
    @NameInMap("openContactId")
    public String openContactId;

    @NameInMap("openCustomerId")
    public String openCustomerId;

    public static SaveFormInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveFormInstanceResponseBody self = new SaveFormInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveFormInstanceResponseBody setOpenContactId(String openContactId) {
        this.openContactId = openContactId;
        return this;
    }
    public String getOpenContactId() {
        return this.openContactId;
    }

    public SaveFormInstanceResponseBody setOpenCustomerId(String openCustomerId) {
        this.openCustomerId = openCustomerId;
        return this;
    }
    public String getOpenCustomerId() {
        return this.openCustomerId;
    }

}
