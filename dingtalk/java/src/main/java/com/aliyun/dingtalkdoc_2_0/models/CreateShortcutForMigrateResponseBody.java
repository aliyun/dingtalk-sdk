// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CreateShortcutForMigrateResponseBody extends TeaModel {
    @NameInMap("openDentryInfo")
    public CreateShortcutForMigrateResponseBodyOpenDentryInfo openDentryInfo;

    public static CreateShortcutForMigrateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateShortcutForMigrateResponseBody self = new CreateShortcutForMigrateResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateShortcutForMigrateResponseBody setOpenDentryInfo(CreateShortcutForMigrateResponseBodyOpenDentryInfo openDentryInfo) {
        this.openDentryInfo = openDentryInfo;
        return this;
    }
    public CreateShortcutForMigrateResponseBodyOpenDentryInfo getOpenDentryInfo() {
        return this.openDentryInfo;
    }

    public static class CreateShortcutForMigrateResponseBodyOpenDentryInfo extends TeaModel {
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

        @NameInMap("url")
        public String url;

        public static CreateShortcutForMigrateResponseBodyOpenDentryInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateShortcutForMigrateResponseBodyOpenDentryInfo self = new CreateShortcutForMigrateResponseBodyOpenDentryInfo();
            return TeaModel.build(map, self);
        }

        public CreateShortcutForMigrateResponseBodyOpenDentryInfo setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

        public CreateShortcutForMigrateResponseBodyOpenDentryInfo setDriveDentryId(String driveDentryId) {
            this.driveDentryId = driveDentryId;
            return this;
        }
        public String getDriveDentryId() {
            return this.driveDentryId;
        }

        public CreateShortcutForMigrateResponseBodyOpenDentryInfo setDriveSpaceId(String driveSpaceId) {
            this.driveSpaceId = driveSpaceId;
            return this;
        }
        public String getDriveSpaceId() {
            return this.driveSpaceId;
        }

        public CreateShortcutForMigrateResponseBodyOpenDentryInfo setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public CreateShortcutForMigrateResponseBodyOpenDentryInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateShortcutForMigrateResponseBodyOpenDentryInfo setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
