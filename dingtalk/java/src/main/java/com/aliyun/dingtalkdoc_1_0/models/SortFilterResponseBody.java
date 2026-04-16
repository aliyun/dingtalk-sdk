// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SortFilterResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    public static SortFilterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SortFilterResponseBody self = new SortFilterResponseBody();
        return TeaModel.build(map, self);
    }

    public SortFilterResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
