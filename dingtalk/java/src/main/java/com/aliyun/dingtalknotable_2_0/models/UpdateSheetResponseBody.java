// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_2_0.models;

import com.aliyun.tea.*;

public class UpdateSheetResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    @NameInMap("name")
    public String name;

    public static UpdateSheetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateSheetResponseBody self = new UpdateSheetResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateSheetResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public UpdateSheetResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
