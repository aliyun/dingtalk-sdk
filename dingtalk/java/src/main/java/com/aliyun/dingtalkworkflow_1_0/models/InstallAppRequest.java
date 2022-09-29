// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class InstallAppRequest extends TeaModel {
    // 安装选项
    // 
    @NameInMap("installOption")
    public InstallAppRequestInstallOption installOption;

    // 安装的目录名称
    @NameInMap("sourceDirName")
    public String sourceDirName;

    public static InstallAppRequest build(java.util.Map<String, ?> map) throws Exception {
        InstallAppRequest self = new InstallAppRequest();
        return TeaModel.build(map, self);
    }

    public InstallAppRequest setInstallOption(InstallAppRequestInstallOption installOption) {
        this.installOption = installOption;
        return this;
    }
    public InstallAppRequestInstallOption getInstallOption() {
        return this.installOption;
    }

    public InstallAppRequest setSourceDirName(String sourceDirName) {
        this.sourceDirName = sourceDirName;
        return this;
    }
    public String getSourceDirName() {
        return this.sourceDirName;
    }

    public static class InstallAppRequestInstallOption extends TeaModel {
        // 是否同步，目前只有同步
        @NameInMap("isSync")
        public Boolean isSync;

        public static InstallAppRequestInstallOption build(java.util.Map<String, ?> map) throws Exception {
            InstallAppRequestInstallOption self = new InstallAppRequestInstallOption();
            return TeaModel.build(map, self);
        }

        public InstallAppRequestInstallOption setIsSync(Boolean isSync) {
            this.isSync = isSync;
            return this;
        }
        public Boolean getIsSync() {
            return this.isSync;
        }

    }

}
