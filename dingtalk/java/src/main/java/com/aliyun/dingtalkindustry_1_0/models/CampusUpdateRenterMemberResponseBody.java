// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateRenterMemberResponseBody extends TeaModel {
    @NameInMap("content")
    public String content;

    public static CampusUpdateRenterMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusUpdateRenterMemberResponseBody self = new CampusUpdateRenterMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusUpdateRenterMemberResponseBody setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

}
