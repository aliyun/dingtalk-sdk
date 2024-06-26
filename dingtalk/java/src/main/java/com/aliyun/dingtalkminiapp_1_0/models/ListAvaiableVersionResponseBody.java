// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class ListAvaiableVersionResponseBody extends TeaModel {
    @NameInMap("versions")
    public java.util.List<ListAvaiableVersionResponseBodyVersions> versions;

    public static ListAvaiableVersionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAvaiableVersionResponseBody self = new ListAvaiableVersionResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAvaiableVersionResponseBody setVersions(java.util.List<ListAvaiableVersionResponseBodyVersions> versions) {
        this.versions = versions;
        return this;
    }
    public java.util.List<ListAvaiableVersionResponseBodyVersions> getVersions() {
        return this.versions;
    }

    public static class ListAvaiableVersionResponseBodyVersions extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("buildStatus")
        public Long buildStatus;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("h5Bundle")
        public String h5Bundle;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("packageSize")
        public String packageSize;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("packageUrl")
        public String packageUrl;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("version")
        public String version;

        public static ListAvaiableVersionResponseBodyVersions build(java.util.Map<String, ?> map) throws Exception {
            ListAvaiableVersionResponseBodyVersions self = new ListAvaiableVersionResponseBodyVersions();
            return TeaModel.build(map, self);
        }

        public ListAvaiableVersionResponseBodyVersions setBuildStatus(Long buildStatus) {
            this.buildStatus = buildStatus;
            return this;
        }
        public Long getBuildStatus() {
            return this.buildStatus;
        }

        public ListAvaiableVersionResponseBodyVersions setH5Bundle(String h5Bundle) {
            this.h5Bundle = h5Bundle;
            return this;
        }
        public String getH5Bundle() {
            return this.h5Bundle;
        }

        public ListAvaiableVersionResponseBodyVersions setPackageSize(String packageSize) {
            this.packageSize = packageSize;
            return this;
        }
        public String getPackageSize() {
            return this.packageSize;
        }

        public ListAvaiableVersionResponseBodyVersions setPackageUrl(String packageUrl) {
            this.packageUrl = packageUrl;
            return this;
        }
        public String getPackageUrl() {
            return this.packageUrl;
        }

        public ListAvaiableVersionResponseBodyVersions setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

}
