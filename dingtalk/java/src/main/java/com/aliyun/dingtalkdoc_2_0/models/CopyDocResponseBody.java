// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CopyDocResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("isAsync")
    public Boolean isAsync;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("syncCopyResult")
    public CopyDocResponseBodySyncCopyResult syncCopyResult;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("taskId")
    public String taskId;

    public static CopyDocResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CopyDocResponseBody self = new CopyDocResponseBody();
        return TeaModel.build(map, self);
    }

    public CopyDocResponseBody setIsAsync(Boolean isAsync) {
        this.isAsync = isAsync;
        return this;
    }
    public Boolean getIsAsync() {
        return this.isAsync;
    }

    public CopyDocResponseBody setSyncCopyResult(CopyDocResponseBodySyncCopyResult syncCopyResult) {
        this.syncCopyResult = syncCopyResult;
        return this;
    }
    public CopyDocResponseBodySyncCopyResult getSyncCopyResult() {
        return this.syncCopyResult;
    }

    public CopyDocResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public static class CopyDocResponseBodySyncCopyResultSpaceInfo extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>im</p>
         */
        @NameInMap("sceneType")
        public String sceneType;

        public static CopyDocResponseBodySyncCopyResultSpaceInfo build(java.util.Map<String, ?> map) throws Exception {
            CopyDocResponseBodySyncCopyResultSpaceInfo self = new CopyDocResponseBodySyncCopyResultSpaceInfo();
            return TeaModel.build(map, self);
        }

        public CopyDocResponseBodySyncCopyResultSpaceInfo setSceneType(String sceneType) {
            this.sceneType = sceneType;
            return this;
        }
        public String getSceneType() {
            return this.sceneType;
        }

    }

    public static class CopyDocResponseBodySyncCopyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>dentryUuid</p>
         */
        @NameInMap("dentryUuid")
        public String dentryUuid;

        /**
         * <strong>example:</strong>
         * <p>driveDentryId</p>
         */
        @NameInMap("driveDentryId")
        public String driveDentryId;

        /**
         * <strong>example:</strong>
         * <p>driveSpaceId</p>
         */
        @NameInMap("driveSpaceId")
        public String driveSpaceId;

        /**
         * <strong>example:</strong>
         * <p>docx</p>
         */
        @NameInMap("extension")
        public String extension;

        /**
         * <strong>example:</strong>
         * <p>name</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>spaceInfo</p>
         */
        @NameInMap("spaceInfo")
        public CopyDocResponseBodySyncCopyResultSpaceInfo spaceInfo;

        /**
         * <strong>example:</strong>
         * <p><a href="https://example.com">https://example.com</a></p>
         */
        @NameInMap("url")
        public String url;

        public static CopyDocResponseBodySyncCopyResult build(java.util.Map<String, ?> map) throws Exception {
            CopyDocResponseBodySyncCopyResult self = new CopyDocResponseBodySyncCopyResult();
            return TeaModel.build(map, self);
        }

        public CopyDocResponseBodySyncCopyResult setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

        public CopyDocResponseBodySyncCopyResult setDriveDentryId(String driveDentryId) {
            this.driveDentryId = driveDentryId;
            return this;
        }
        public String getDriveDentryId() {
            return this.driveDentryId;
        }

        public CopyDocResponseBodySyncCopyResult setDriveSpaceId(String driveSpaceId) {
            this.driveSpaceId = driveSpaceId;
            return this;
        }
        public String getDriveSpaceId() {
            return this.driveSpaceId;
        }

        public CopyDocResponseBodySyncCopyResult setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public CopyDocResponseBodySyncCopyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CopyDocResponseBodySyncCopyResult setSpaceInfo(CopyDocResponseBodySyncCopyResultSpaceInfo spaceInfo) {
            this.spaceInfo = spaceInfo;
            return this;
        }
        public CopyDocResponseBodySyncCopyResultSpaceInfo getSpaceInfo() {
            return this.spaceInfo;
        }

        public CopyDocResponseBodySyncCopyResult setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
