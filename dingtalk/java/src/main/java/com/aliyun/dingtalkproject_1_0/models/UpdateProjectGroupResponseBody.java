// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateProjectGroupResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateProjectGroupResponseBodyResult result;

    public static UpdateProjectGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateProjectGroupResponseBody self = new UpdateProjectGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateProjectGroupResponseBody setResult(UpdateProjectGroupResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateProjectGroupResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateProjectGroupResponseBodyResult extends TeaModel {
        @NameInMap("ok")
        public Boolean ok;

        public static UpdateProjectGroupResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateProjectGroupResponseBodyResult self = new UpdateProjectGroupResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateProjectGroupResponseBodyResult setOk(Boolean ok) {
            this.ok = ok;
            return this;
        }
        public Boolean getOk() {
            return this.ok;
        }

    }

}
