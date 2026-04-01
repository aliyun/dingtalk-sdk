// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CleanFileRequest extends TeaModel {
    @NameInMap("dentryIds")
    public java.util.List<CleanFileRequestDentryIds> dentryIds;

    @NameInMap("staffId")
    public String staffId;

    public static CleanFileRequest build(java.util.Map<String, ?> map) throws Exception {
        CleanFileRequest self = new CleanFileRequest();
        return TeaModel.build(map, self);
    }

    public CleanFileRequest setDentryIds(java.util.List<CleanFileRequestDentryIds> dentryIds) {
        this.dentryIds = dentryIds;
        return this;
    }
    public java.util.List<CleanFileRequestDentryIds> getDentryIds() {
        return this.dentryIds;
    }

    public CleanFileRequest setStaffId(String staffId) {
        this.staffId = staffId;
        return this;
    }
    public String getStaffId() {
        return this.staffId;
    }

    public static class CleanFileRequestDentryIds extends TeaModel {
        @NameInMap("dentryId")
        public Long dentryId;

        @NameInMap("spaceId")
        public Long spaceId;

        public static CleanFileRequestDentryIds build(java.util.Map<String, ?> map) throws Exception {
            CleanFileRequestDentryIds self = new CleanFileRequestDentryIds();
            return TeaModel.build(map, self);
        }

        public CleanFileRequestDentryIds setDentryId(Long dentryId) {
            this.dentryId = dentryId;
            return this;
        }
        public Long getDentryId() {
            return this.dentryId;
        }

        public CleanFileRequestDentryIds setSpaceId(Long spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public Long getSpaceId() {
            return this.spaceId;
        }

    }

}
