// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class HPackageListGetResponseBody extends TeaModel {
    // 离线包列表
    @NameInMap("list")
    public java.util.List<HPackageListGetResponseBodyList> list;

    // 总数量
    @NameInMap("totalCount")
    public Long totalCount;

    public static HPackageListGetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HPackageListGetResponseBody self = new HPackageListGetResponseBody();
        return TeaModel.build(map, self);
    }

    public HPackageListGetResponseBody setList(java.util.List<HPackageListGetResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<HPackageListGetResponseBodyList> getList() {
        return this.list;
    }

    public HPackageListGetResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class HPackageListGetResponseBodyList extends TeaModel {
        // 版本是否可用
        @NameInMap("avaliable")
        public Long avaliable;

        // 上传者
        @NameInMap("creator")
        public String creator;

        // 上传是否已完成
        @NameInMap("finished")
        public Boolean finished;

        // 上传时间
        @NameInMap("operationTime")
        public Long operationTime;

        // 离线包大小，单位byte
        @NameInMap("packageSize")
        public Long packageSize;

        // 版本状态
        @NameInMap("status")
        public String status;

        // 上传任务ID
        @NameInMap("taskId")
        public String taskId;

        // 版本号
        @NameInMap("version")
        public String version;

        public static HPackageListGetResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            HPackageListGetResponseBodyList self = new HPackageListGetResponseBodyList();
            return TeaModel.build(map, self);
        }

        public HPackageListGetResponseBodyList setAvaliable(Long avaliable) {
            this.avaliable = avaliable;
            return this;
        }
        public Long getAvaliable() {
            return this.avaliable;
        }

        public HPackageListGetResponseBodyList setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public HPackageListGetResponseBodyList setFinished(Boolean finished) {
            this.finished = finished;
            return this;
        }
        public Boolean getFinished() {
            return this.finished;
        }

        public HPackageListGetResponseBodyList setOperationTime(Long operationTime) {
            this.operationTime = operationTime;
            return this;
        }
        public Long getOperationTime() {
            return this.operationTime;
        }

        public HPackageListGetResponseBodyList setPackageSize(Long packageSize) {
            this.packageSize = packageSize;
            return this;
        }
        public Long getPackageSize() {
            return this.packageSize;
        }

        public HPackageListGetResponseBodyList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public HPackageListGetResponseBodyList setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public HPackageListGetResponseBodyList setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

}
