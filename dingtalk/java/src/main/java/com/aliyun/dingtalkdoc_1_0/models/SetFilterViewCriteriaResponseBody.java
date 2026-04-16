// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetFilterViewCriteriaResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    public static SetFilterViewCriteriaResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetFilterViewCriteriaResponseBody self = new SetFilterViewCriteriaResponseBody();
        return TeaModel.build(map, self);
    }

    public SetFilterViewCriteriaResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
