// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh5package_1_0.models;

import com.aliyun.tea.*;

public class GetCreateStatusResponseBody extends TeaModel {
    // 创建时间
    @NameInMap("buildTime")
    public Long buildTime;

    // 任务是否已结束
    @NameInMap("finished")
    public Boolean finished;

    // H5离线包体积，单位Byte
    @NameInMap("packageSize")
    public Long packageSize;

    // 任务状态。1：构建中；2：成功；3：失败；5：超时。
    @NameInMap("status")
    public String status;

    // 创建离线包接口返回的taskId
    @NameInMap("taskId")
    public String taskId;

    // H5离线包版本号
    @NameInMap("version")
    public String version;

    public static GetCreateStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCreateStatusResponseBody self = new GetCreateStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCreateStatusResponseBody setBuildTime(Long buildTime) {
        this.buildTime = buildTime;
        return this;
    }
    public Long getBuildTime() {
        return this.buildTime;
    }

    public GetCreateStatusResponseBody setFinished(Boolean finished) {
        this.finished = finished;
        return this;
    }
    public Boolean getFinished() {
        return this.finished;
    }

    public GetCreateStatusResponseBody setPackageSize(Long packageSize) {
        this.packageSize = packageSize;
        return this;
    }
    public Long getPackageSize() {
        return this.packageSize;
    }

    public GetCreateStatusResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public GetCreateStatusResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public GetCreateStatusResponseBody setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
