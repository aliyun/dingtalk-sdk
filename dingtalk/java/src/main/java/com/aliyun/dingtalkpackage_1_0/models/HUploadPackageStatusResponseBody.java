// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class HUploadPackageStatusResponseBody extends TeaModel {
    @NameInMap("buildTime")
    public Long buildTime;

    @NameInMap("finished")
    public Boolean finished;

    @NameInMap("packageSize")
    public Long packageSize;

    @NameInMap("status")
    public String status;

    @NameInMap("taskId")
    public String taskId;

    @NameInMap("version")
    public String version;

    public static HUploadPackageStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HUploadPackageStatusResponseBody self = new HUploadPackageStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public HUploadPackageStatusResponseBody setBuildTime(Long buildTime) {
        this.buildTime = buildTime;
        return this;
    }
    public Long getBuildTime() {
        return this.buildTime;
    }

    public HUploadPackageStatusResponseBody setFinished(Boolean finished) {
        this.finished = finished;
        return this;
    }
    public Boolean getFinished() {
        return this.finished;
    }

    public HUploadPackageStatusResponseBody setPackageSize(Long packageSize) {
        this.packageSize = packageSize;
        return this;
    }
    public Long getPackageSize() {
        return this.packageSize;
    }

    public HUploadPackageStatusResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public HUploadPackageStatusResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public HUploadPackageStatusResponseBody setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
