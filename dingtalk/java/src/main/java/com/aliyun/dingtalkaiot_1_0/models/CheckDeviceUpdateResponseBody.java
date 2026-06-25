// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class CheckDeviceUpdateResponseBody extends TeaModel {
    @NameInMap("modules")
    public java.util.List<CheckDeviceUpdateResponseBodyModules> modules;

    public static CheckDeviceUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CheckDeviceUpdateResponseBody self = new CheckDeviceUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public CheckDeviceUpdateResponseBody setModules(java.util.List<CheckDeviceUpdateResponseBodyModules> modules) {
        this.modules = modules;
        return this;
    }
    public java.util.List<CheckDeviceUpdateResponseBodyModules> getModules() {
        return this.modules;
    }

    public static class CheckDeviceUpdateResponseBodyModules extends TeaModel {
        @NameInMap("checksum")
        public String checksum;

        @NameInMap("checksumAlgorithm")
        public String checksumAlgorithm;

        @NameInMap("criticalNext")
        public String criticalNext;

        @NameInMap("currentVersion")
        public String currentVersion;

        @NameInMap("fileUrl")
        public String fileUrl;

        @NameInMap("latest")
        public String latest;

        @NameInMap("moduleName")
        public String moduleName;

        @NameInMap("noticeEn")
        public String noticeEn;

        @NameInMap("noticeZh")
        public String noticeZh;

        @NameInMap("upgradeMode")
        public String upgradeMode;

        public static CheckDeviceUpdateResponseBodyModules build(java.util.Map<String, ?> map) throws Exception {
            CheckDeviceUpdateResponseBodyModules self = new CheckDeviceUpdateResponseBodyModules();
            return TeaModel.build(map, self);
        }

        public CheckDeviceUpdateResponseBodyModules setChecksum(String checksum) {
            this.checksum = checksum;
            return this;
        }
        public String getChecksum() {
            return this.checksum;
        }

        public CheckDeviceUpdateResponseBodyModules setChecksumAlgorithm(String checksumAlgorithm) {
            this.checksumAlgorithm = checksumAlgorithm;
            return this;
        }
        public String getChecksumAlgorithm() {
            return this.checksumAlgorithm;
        }

        public CheckDeviceUpdateResponseBodyModules setCriticalNext(String criticalNext) {
            this.criticalNext = criticalNext;
            return this;
        }
        public String getCriticalNext() {
            return this.criticalNext;
        }

        public CheckDeviceUpdateResponseBodyModules setCurrentVersion(String currentVersion) {
            this.currentVersion = currentVersion;
            return this;
        }
        public String getCurrentVersion() {
            return this.currentVersion;
        }

        public CheckDeviceUpdateResponseBodyModules setFileUrl(String fileUrl) {
            this.fileUrl = fileUrl;
            return this;
        }
        public String getFileUrl() {
            return this.fileUrl;
        }

        public CheckDeviceUpdateResponseBodyModules setLatest(String latest) {
            this.latest = latest;
            return this;
        }
        public String getLatest() {
            return this.latest;
        }

        public CheckDeviceUpdateResponseBodyModules setModuleName(String moduleName) {
            this.moduleName = moduleName;
            return this;
        }
        public String getModuleName() {
            return this.moduleName;
        }

        public CheckDeviceUpdateResponseBodyModules setNoticeEn(String noticeEn) {
            this.noticeEn = noticeEn;
            return this;
        }
        public String getNoticeEn() {
            return this.noticeEn;
        }

        public CheckDeviceUpdateResponseBodyModules setNoticeZh(String noticeZh) {
            this.noticeZh = noticeZh;
            return this;
        }
        public String getNoticeZh() {
            return this.noticeZh;
        }

        public CheckDeviceUpdateResponseBodyModules setUpgradeMode(String upgradeMode) {
            this.upgradeMode = upgradeMode;
            return this;
        }
        public String getUpgradeMode() {
            return this.upgradeMode;
        }

    }

}
