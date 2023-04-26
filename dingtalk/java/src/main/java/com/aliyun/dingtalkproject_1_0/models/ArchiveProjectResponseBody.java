// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class ArchiveProjectResponseBody extends TeaModel {
    @NameInMap("result")
    public ArchiveProjectResponseBodyResult result;

    public static ArchiveProjectResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ArchiveProjectResponseBody self = new ArchiveProjectResponseBody();
        return TeaModel.build(map, self);
    }

    public ArchiveProjectResponseBody setResult(ArchiveProjectResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ArchiveProjectResponseBodyResult getResult() {
        return this.result;
    }

    public static class ArchiveProjectResponseBodyResult extends TeaModel {
        @NameInMap("isArchived")
        public Boolean isArchived;

        @NameInMap("updated")
        public String updated;

        public static ArchiveProjectResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ArchiveProjectResponseBodyResult self = new ArchiveProjectResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ArchiveProjectResponseBodyResult setIsArchived(Boolean isArchived) {
            this.isArchived = isArchived;
            return this;
        }
        public Boolean getIsArchived() {
            return this.isArchived;
        }

        public ArchiveProjectResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
