// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CopyDocWithAppAuthResponseBody extends TeaModel {
    @NameInMap("isAsync")
    public Boolean isAsync;

    @NameInMap("syncCopyResult")
    public CopyDocWithAppAuthResponseBodySyncCopyResult syncCopyResult;

    @NameInMap("taskId")
    public String taskId;

    public static CopyDocWithAppAuthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CopyDocWithAppAuthResponseBody self = new CopyDocWithAppAuthResponseBody();
        return TeaModel.build(map, self);
    }

    public CopyDocWithAppAuthResponseBody setIsAsync(Boolean isAsync) {
        this.isAsync = isAsync;
        return this;
    }
    public Boolean getIsAsync() {
        return this.isAsync;
    }

    public CopyDocWithAppAuthResponseBody setSyncCopyResult(CopyDocWithAppAuthResponseBodySyncCopyResult syncCopyResult) {
        this.syncCopyResult = syncCopyResult;
        return this;
    }
    public CopyDocWithAppAuthResponseBodySyncCopyResult getSyncCopyResult() {
        return this.syncCopyResult;
    }

    public CopyDocWithAppAuthResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public static class CopyDocWithAppAuthResponseBodySyncCopyResultSpaceInfo extends TeaModel {
        @NameInMap("sceneType")
        public String sceneType;

        public static CopyDocWithAppAuthResponseBodySyncCopyResultSpaceInfo build(java.util.Map<String, ?> map) throws Exception {
            CopyDocWithAppAuthResponseBodySyncCopyResultSpaceInfo self = new CopyDocWithAppAuthResponseBodySyncCopyResultSpaceInfo();
            return TeaModel.build(map, self);
        }

        public CopyDocWithAppAuthResponseBodySyncCopyResultSpaceInfo setSceneType(String sceneType) {
            this.sceneType = sceneType;
            return this;
        }
        public String getSceneType() {
            return this.sceneType;
        }

    }

    public static class CopyDocWithAppAuthResponseBodySyncCopyResult extends TeaModel {
        @NameInMap("dentryUuid")
        public String dentryUuid;

        @NameInMap("driveDentryId")
        public String driveDentryId;

        @NameInMap("driveSpaceId")
        public String driveSpaceId;

        @NameInMap("extension")
        public String extension;

        @NameInMap("name")
        public String name;

        @NameInMap("spaceInfo")
        public CopyDocWithAppAuthResponseBodySyncCopyResultSpaceInfo spaceInfo;

        @NameInMap("url")
        public String url;

        public static CopyDocWithAppAuthResponseBodySyncCopyResult build(java.util.Map<String, ?> map) throws Exception {
            CopyDocWithAppAuthResponseBodySyncCopyResult self = new CopyDocWithAppAuthResponseBodySyncCopyResult();
            return TeaModel.build(map, self);
        }

        public CopyDocWithAppAuthResponseBodySyncCopyResult setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

        public CopyDocWithAppAuthResponseBodySyncCopyResult setDriveDentryId(String driveDentryId) {
            this.driveDentryId = driveDentryId;
            return this;
        }
        public String getDriveDentryId() {
            return this.driveDentryId;
        }

        public CopyDocWithAppAuthResponseBodySyncCopyResult setDriveSpaceId(String driveSpaceId) {
            this.driveSpaceId = driveSpaceId;
            return this;
        }
        public String getDriveSpaceId() {
            return this.driveSpaceId;
        }

        public CopyDocWithAppAuthResponseBodySyncCopyResult setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public CopyDocWithAppAuthResponseBodySyncCopyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CopyDocWithAppAuthResponseBodySyncCopyResult setSpaceInfo(CopyDocWithAppAuthResponseBodySyncCopyResultSpaceInfo spaceInfo) {
            this.spaceInfo = spaceInfo;
            return this;
        }
        public CopyDocWithAppAuthResponseBodySyncCopyResultSpaceInfo getSpaceInfo() {
            return this.spaceInfo;
        }

        public CopyDocWithAppAuthResponseBodySyncCopyResult setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
