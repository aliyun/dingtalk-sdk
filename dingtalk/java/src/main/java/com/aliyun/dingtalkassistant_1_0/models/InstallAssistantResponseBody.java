// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class InstallAssistantResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static InstallAssistantResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InstallAssistantResponseBody self = new InstallAssistantResponseBody();
        return TeaModel.build(map, self);
    }

    public InstallAssistantResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
