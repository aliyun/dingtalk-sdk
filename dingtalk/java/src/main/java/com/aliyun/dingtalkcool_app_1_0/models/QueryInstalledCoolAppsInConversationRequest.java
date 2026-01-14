// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_app_1_0.models;

import com.aliyun.tea.*;

public class QueryInstalledCoolAppsInConversationRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>cidxxx</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static QueryInstalledCoolAppsInConversationRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryInstalledCoolAppsInConversationRequest self = new QueryInstalledCoolAppsInConversationRequest();
        return TeaModel.build(map, self);
    }

    public QueryInstalledCoolAppsInConversationRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
