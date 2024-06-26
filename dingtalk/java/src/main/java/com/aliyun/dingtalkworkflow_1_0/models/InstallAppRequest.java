// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class InstallAppRequest extends TeaModel {
    @NameInMap("bizGroup")
    public String bizGroup;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("installOption")
    public InstallAppRequestInstallOption installOption;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>finance</p>
     */
    @NameInMap("sourceDirName")
    public String sourceDirName;

    public static InstallAppRequest build(java.util.Map<String, ?> map) throws Exception {
        InstallAppRequest self = new InstallAppRequest();
        return TeaModel.build(map, self);
    }

    public InstallAppRequest setBizGroup(String bizGroup) {
        this.bizGroup = bizGroup;
        return this;
    }
    public String getBizGroup() {
        return this.bizGroup;
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
