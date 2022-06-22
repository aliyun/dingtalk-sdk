// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusCreateCampusGroupResponseBody extends TeaModel {
    // 项目组ID
    @NameInMap("content")
    public Long content;

    public static CampusCreateCampusGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusCreateCampusGroupResponseBody self = new CampusCreateCampusGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusCreateCampusGroupResponseBody setContent(Long content) {
        this.content = content;
        return this;
    }
    public Long getContent() {
        return this.content;
    }

}
