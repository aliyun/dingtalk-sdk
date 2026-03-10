// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrgPluginSubscribersResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateOrgPluginSubscribersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrgPluginSubscribersResponseBody self = new UpdateOrgPluginSubscribersResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateOrgPluginSubscribersResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
