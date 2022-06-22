// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateCampusGroupResponseBody extends TeaModel {
    @NameInMap("content")
    public String content;

    public static CampusUpdateCampusGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusUpdateCampusGroupResponseBody self = new CampusUpdateCampusGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusUpdateCampusGroupResponseBody setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

}
