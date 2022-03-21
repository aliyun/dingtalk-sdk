// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ConvertLegacyEventIdRequest extends TeaModel {
    @NameInMap("legacyEventIds")
    public java.util.List<String> legacyEventIds;

    public static ConvertLegacyEventIdRequest build(java.util.Map<String, ?> map) throws Exception {
        ConvertLegacyEventIdRequest self = new ConvertLegacyEventIdRequest();
        return TeaModel.build(map, self);
    }

    public ConvertLegacyEventIdRequest setLegacyEventIds(java.util.List<String> legacyEventIds) {
        this.legacyEventIds = legacyEventIds;
        return this;
    }
    public java.util.List<String> getLegacyEventIds() {
        return this.legacyEventIds;
    }

}
