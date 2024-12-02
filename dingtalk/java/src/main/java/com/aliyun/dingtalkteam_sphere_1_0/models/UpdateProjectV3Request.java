// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class UpdateProjectV3Request extends TeaModel {
    @NameInMap("description")
    public String description;

    @NameInMap("name")
    public String name;

    public static UpdateProjectV3Request build(java.util.Map<String, ?> map) throws Exception {
        UpdateProjectV3Request self = new UpdateProjectV3Request();
        return TeaModel.build(map, self);
    }

    public UpdateProjectV3Request setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateProjectV3Request setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
