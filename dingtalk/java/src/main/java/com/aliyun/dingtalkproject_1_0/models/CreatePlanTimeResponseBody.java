// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreatePlanTimeResponseBody extends TeaModel {
    @NameInMap("result")
    public CreatePlanTimeResponseBodyResult result;

    public static CreatePlanTimeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreatePlanTimeResponseBody self = new CreatePlanTimeResponseBody();
        return TeaModel.build(map, self);
    }

    public CreatePlanTimeResponseBody setResult(CreatePlanTimeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreatePlanTimeResponseBodyResult getResult() {
        return this.result;
    }

    public static class CreatePlanTimeResponseBodyResultBody extends TeaModel {
        // 工时关联的数据id
        @NameInMap("objectId")
        public String objectId;

        public static CreatePlanTimeResponseBodyResultBody build(java.util.Map<String, ?> map) throws Exception {
            CreatePlanTimeResponseBodyResultBody self = new CreatePlanTimeResponseBodyResultBody();
            return TeaModel.build(map, self);
        }

        public CreatePlanTimeResponseBodyResultBody setObjectId(String objectId) {
            this.objectId = objectId;
            return this;
        }
        public String getObjectId() {
            return this.objectId;
        }

    }

    public static class CreatePlanTimeResponseBodyResult extends TeaModel {
        @NameInMap("body")
        public java.util.List<CreatePlanTimeResponseBodyResultBody> body;

        // 执行结果描述
        @NameInMap("message")
        public String message;

        @NameInMap("ok")
        public Boolean ok;

        public static CreatePlanTimeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreatePlanTimeResponseBodyResult self = new CreatePlanTimeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreatePlanTimeResponseBodyResult setBody(java.util.List<CreatePlanTimeResponseBodyResultBody> body) {
            this.body = body;
            return this;
        }
        public java.util.List<CreatePlanTimeResponseBodyResultBody> getBody() {
            return this.body;
        }

        public CreatePlanTimeResponseBodyResult setMessage(String message) {
            this.message = message;
            return this;
        }
        public String getMessage() {
            return this.message;
        }

        public CreatePlanTimeResponseBodyResult setOk(Boolean ok) {
            this.ok = ok;
            return this;
        }
        public Boolean getOk() {
            return this.ok;
        }

    }

}
