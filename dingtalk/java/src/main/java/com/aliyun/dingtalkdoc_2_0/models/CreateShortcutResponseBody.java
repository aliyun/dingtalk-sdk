// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CreateShortcutResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>dentry</p>
     */
    @NameInMap("openDentryInfo")
    public CreateShortcutResponseBodyOpenDentryInfo openDentryInfo;

    public static CreateShortcutResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateShortcutResponseBody self = new CreateShortcutResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateShortcutResponseBody setOpenDentryInfo(CreateShortcutResponseBodyOpenDentryInfo openDentryInfo) {
        this.openDentryInfo = openDentryInfo;
        return this;
    }
    public CreateShortcutResponseBodyOpenDentryInfo getOpenDentryInfo() {
        return this.openDentryInfo;
    }

    public static class CreateShortcutResponseBodyOpenDentryInfoSpaceInfo extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>im</p>
         */
        @NameInMap("sceneType")
        public String sceneType;

        public static CreateShortcutResponseBodyOpenDentryInfoSpaceInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateShortcutResponseBodyOpenDentryInfoSpaceInfo self = new CreateShortcutResponseBodyOpenDentryInfoSpaceInfo();
            return TeaModel.build(map, self);
        }

        public CreateShortcutResponseBodyOpenDentryInfoSpaceInfo setSceneType(String sceneType) {
            this.sceneType = sceneType;
            return this;
        }
        public String getSceneType() {
            return this.sceneType;
        }

    }

    public static class CreateShortcutResponseBodyOpenDentryInfo extends TeaModel {
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
        public CreateShortcutResponseBodyOpenDentryInfoSpaceInfo spaceInfo;

        /**
         * <strong>example:</strong>
         * <p><a href="https://example.com">https://example.com</a></p>
         */
        @NameInMap("url")
        public String url;

        public static CreateShortcutResponseBodyOpenDentryInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateShortcutResponseBodyOpenDentryInfo self = new CreateShortcutResponseBodyOpenDentryInfo();
            return TeaModel.build(map, self);
        }

        public CreateShortcutResponseBodyOpenDentryInfo setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

        public CreateShortcutResponseBodyOpenDentryInfo setDriveDentryId(String driveDentryId) {
            this.driveDentryId = driveDentryId;
            return this;
        }
        public String getDriveDentryId() {
            return this.driveDentryId;
        }

        public CreateShortcutResponseBodyOpenDentryInfo setDriveSpaceId(String driveSpaceId) {
            this.driveSpaceId = driveSpaceId;
            return this;
        }
        public String getDriveSpaceId() {
            return this.driveSpaceId;
        }

        public CreateShortcutResponseBodyOpenDentryInfo setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public CreateShortcutResponseBodyOpenDentryInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateShortcutResponseBodyOpenDentryInfo setSpaceInfo(CreateShortcutResponseBodyOpenDentryInfoSpaceInfo spaceInfo) {
            this.spaceInfo = spaceInfo;
            return this;
        }
        public CreateShortcutResponseBodyOpenDentryInfoSpaceInfo getSpaceInfo() {
            return this.spaceInfo;
        }

        public CreateShortcutResponseBodyOpenDentryInfo setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
