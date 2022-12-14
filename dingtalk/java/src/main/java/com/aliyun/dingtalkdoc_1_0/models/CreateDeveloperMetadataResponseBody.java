// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateDeveloperMetadataResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    public static CreateDeveloperMetadataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateDeveloperMetadataResponseBody self = new CreateDeveloperMetadataResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateDeveloperMetadataResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
