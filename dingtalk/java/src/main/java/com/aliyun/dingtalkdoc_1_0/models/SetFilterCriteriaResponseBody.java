// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetFilterCriteriaResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    public static SetFilterCriteriaResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetFilterCriteriaResponseBody self = new SetFilterCriteriaResponseBody();
        return TeaModel.build(map, self);
    }

    public SetFilterCriteriaResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
