// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectV3Request extends TeaModel {
    @NameInMap("name")
    public String name;

    @NameInMap("organizationId")
    public String organizationId;

    public static CreateProjectV3Request build(java.util.Map<String, ?> map) throws Exception {
        CreateProjectV3Request self = new CreateProjectV3Request();
        return TeaModel.build(map, self);
    }

    public CreateProjectV3Request setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateProjectV3Request setOrganizationId(String organizationId) {
        this.organizationId = organizationId;
        return this;
    }
    public String getOrganizationId() {
        return this.organizationId;
    }

}
