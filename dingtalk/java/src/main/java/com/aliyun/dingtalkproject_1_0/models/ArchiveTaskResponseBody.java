// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class ArchiveTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public ArchiveTaskResponseBodyResult result;

    public static ArchiveTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ArchiveTaskResponseBody self = new ArchiveTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public ArchiveTaskResponseBody setResult(ArchiveTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ArchiveTaskResponseBodyResult getResult() {
        return this.result;
    }

    public static class ArchiveTaskResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        public static ArchiveTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ArchiveTaskResponseBodyResult self = new ArchiveTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ArchiveTaskResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
