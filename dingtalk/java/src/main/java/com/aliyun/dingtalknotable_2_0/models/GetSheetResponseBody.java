// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_2_0.models;

import com.aliyun.tea.*;

public class GetSheetResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    @NameInMap("name")
    public String name;

    public static GetSheetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSheetResponseBody self = new GetSheetResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSheetResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public GetSheetResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
