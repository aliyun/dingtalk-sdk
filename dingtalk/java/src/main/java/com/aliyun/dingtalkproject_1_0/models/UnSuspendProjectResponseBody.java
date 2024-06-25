// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UnSuspendProjectResponseBody extends TeaModel {
    @NameInMap("result")
    public UnSuspendProjectResponseBodyResult result;

    public static UnSuspendProjectResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UnSuspendProjectResponseBody self = new UnSuspendProjectResponseBody();
        return TeaModel.build(map, self);
    }

    public UnSuspendProjectResponseBody setResult(UnSuspendProjectResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UnSuspendProjectResponseBodyResult getResult() {
        return this.result;
    }

    public static class UnSuspendProjectResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2022-06-08T07:32:48.958Z</p>
         */
        @NameInMap("updated")
        public String updated;

        public static UnSuspendProjectResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UnSuspendProjectResponseBodyResult self = new UnSuspendProjectResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UnSuspendProjectResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
