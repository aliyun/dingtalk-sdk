// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateTaskObjectLinkResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateTaskObjectLinkResponseBodyResult result;

    public static CreateTaskObjectLinkResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTaskObjectLinkResponseBody self = new CreateTaskObjectLinkResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTaskObjectLinkResponseBody setResult(CreateTaskObjectLinkResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateTaskObjectLinkResponseBodyResult getResult() {
        return this.result;
    }

    public static class CreateTaskObjectLinkResponseBodyResult extends TeaModel {
        @NameInMap("created")
        public String created;

        @NameInMap("objectLinkId")
        public String objectLinkId;

        public static CreateTaskObjectLinkResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateTaskObjectLinkResponseBodyResult self = new CreateTaskObjectLinkResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateTaskObjectLinkResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public CreateTaskObjectLinkResponseBodyResult setObjectLinkId(String objectLinkId) {
            this.objectLinkId = objectLinkId;
            return this;
        }
        public String getObjectLinkId() {
            return this.objectLinkId;
        }

    }

}
