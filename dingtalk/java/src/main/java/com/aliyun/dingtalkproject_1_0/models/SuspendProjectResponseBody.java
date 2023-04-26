// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SuspendProjectResponseBody extends TeaModel {
    @NameInMap("result")
    public SuspendProjectResponseBodyResult result;

    public static SuspendProjectResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SuspendProjectResponseBody self = new SuspendProjectResponseBody();
        return TeaModel.build(map, self);
    }

    public SuspendProjectResponseBody setResult(SuspendProjectResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SuspendProjectResponseBodyResult getResult() {
        return this.result;
    }

    public static class SuspendProjectResponseBodyResult extends TeaModel {
        @NameInMap("updated")
        public String updated;

        public static SuspendProjectResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SuspendProjectResponseBodyResult self = new SuspendProjectResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SuspendProjectResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
