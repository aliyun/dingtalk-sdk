// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusDeleteCampusGroupResponseBody extends TeaModel {
    // result
    @NameInMap("content")
    public String content;

    public static CampusDeleteCampusGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusDeleteCampusGroupResponseBody self = new CampusDeleteCampusGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusDeleteCampusGroupResponseBody setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

}
