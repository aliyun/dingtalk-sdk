// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class HPackageListGetResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<HPackageListGetResponseBodyList> list;

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
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("avaliable")
        public Long avaliable;

        @NameInMap("creator")
        public String creator;

        @NameInMap("finished")
        public Boolean finished;

        /**
         * <strong>example:</strong>
         * <p>1669261911344</p>
         */
        @NameInMap("operationTime")
        public Long operationTime;

        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("packageSize")
        public Long packageSize;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <strong>example:</strong>
         * <p>00000000Azksf</p>
         */
        @NameInMap("taskId")
        public String taskId;

        /**
         * <strong>example:</strong>
         * <p>0.0.1</p>
         */
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
