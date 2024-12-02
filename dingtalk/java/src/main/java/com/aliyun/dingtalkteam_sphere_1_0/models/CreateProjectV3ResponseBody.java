// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectV3ResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public CreateProjectV3ResponseBodyResult result;

    public static CreateProjectV3ResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateProjectV3ResponseBody self = new CreateProjectV3ResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateProjectV3ResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CreateProjectV3ResponseBody setResult(CreateProjectV3ResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateProjectV3ResponseBodyResult getResult() {
        return this.result;
    }

    public static class CreateProjectV3ResponseBodyResult extends TeaModel {
        @NameInMap("id")
        public String id;

        public static CreateProjectV3ResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateProjectV3ResponseBodyResult self = new CreateProjectV3ResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateProjectV3ResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

    }

}
