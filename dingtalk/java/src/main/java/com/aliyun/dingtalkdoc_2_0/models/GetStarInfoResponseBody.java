// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetStarInfoResponseBody extends TeaModel {
    @NameInMap("starred")
    public Boolean starred;

    public static GetStarInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetStarInfoResponseBody self = new GetStarInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetStarInfoResponseBody setStarred(Boolean starred) {
        this.starred = starred;
        return this;
    }
    public Boolean getStarred() {
        return this.starred;
    }

}
