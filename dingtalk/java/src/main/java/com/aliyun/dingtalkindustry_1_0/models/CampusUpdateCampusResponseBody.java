// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateCampusResponseBody extends TeaModel {
    @NameInMap("content")
    public String content;

    public static CampusUpdateCampusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusUpdateCampusResponseBody self = new CampusUpdateCampusResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusUpdateCampusResponseBody setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

}
