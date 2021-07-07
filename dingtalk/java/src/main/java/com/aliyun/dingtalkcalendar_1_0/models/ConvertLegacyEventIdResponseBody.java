// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ConvertLegacyEventIdResponseBody extends TeaModel {
    // legacyEventIdMap
    @NameInMap("legacyEventIdMap")
    public java.util.Map<String, ?> legacyEventIdMap;

    public static ConvertLegacyEventIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ConvertLegacyEventIdResponseBody self = new ConvertLegacyEventIdResponseBody();
        return TeaModel.build(map, self);
    }

    public ConvertLegacyEventIdResponseBody setLegacyEventIdMap(java.util.Map<String, ?> legacyEventIdMap) {
        this.legacyEventIdMap = legacyEventIdMap;
        return this;
    }
    public java.util.Map<String, ?> getLegacyEventIdMap() {
        return this.legacyEventIdMap;
    }

}
