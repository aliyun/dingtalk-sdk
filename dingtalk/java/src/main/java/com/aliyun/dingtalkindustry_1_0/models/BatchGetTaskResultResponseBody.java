// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class BatchGetTaskResultResponseBody extends TeaModel {
    @NameInMap("tasks")
    public java.util.List<BatchGetTaskResultResponseBodyTasks> tasks;

    public static BatchGetTaskResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchGetTaskResultResponseBody self = new BatchGetTaskResultResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchGetTaskResultResponseBody setTasks(java.util.List<BatchGetTaskResultResponseBodyTasks> tasks) {
        this.tasks = tasks;
        return this;
    }
    public java.util.List<BatchGetTaskResultResponseBodyTasks> getTasks() {
        return this.tasks;
    }

    public static class BatchGetTaskResultResponseBodyTasksResultItemsSubs extends TeaModel {
        @NameInMap("point")
        public Long point;

        @NameInMap("reference")
        public String reference;

        @NameInMap("referenceFrame")
        public java.util.List<String> referenceFrame;

        @NameInMap("subInfo")
        public String subInfo;

        @NameInMap("subName")
        public String subName;

        public static BatchGetTaskResultResponseBodyTasksResultItemsSubs build(java.util.Map<String, ?> map) throws Exception {
            BatchGetTaskResultResponseBodyTasksResultItemsSubs self = new BatchGetTaskResultResponseBodyTasksResultItemsSubs();
            return TeaModel.build(map, self);
        }

        public BatchGetTaskResultResponseBodyTasksResultItemsSubs setPoint(Long point) {
            this.point = point;
            return this;
        }
        public Long getPoint() {
            return this.point;
        }

        public BatchGetTaskResultResponseBodyTasksResultItemsSubs setReference(String reference) {
            this.reference = reference;
            return this;
        }
        public String getReference() {
            return this.reference;
        }

        public BatchGetTaskResultResponseBodyTasksResultItemsSubs setReferenceFrame(java.util.List<String> referenceFrame) {
            this.referenceFrame = referenceFrame;
            return this;
        }
        public java.util.List<String> getReferenceFrame() {
            return this.referenceFrame;
        }

        public BatchGetTaskResultResponseBodyTasksResultItemsSubs setSubInfo(String subInfo) {
            this.subInfo = subInfo;
            return this;
        }
        public String getSubInfo() {
            return this.subInfo;
        }

        public BatchGetTaskResultResponseBodyTasksResultItemsSubs setSubName(String subName) {
            this.subName = subName;
            return this;
        }
        public String getSubName() {
            return this.subName;
        }

    }

    public static class BatchGetTaskResultResponseBodyTasksResultItems extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>主持人有问好，并得到积极回应</p>
         */
        @NameInMap("info")
        public String info;

        /**
         * <strong>example:</strong>
         * <p>是否有问好</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("point")
        public Long point;

        @NameInMap("reference")
        public String reference;

        @NameInMap("referenceFrame")
        public java.util.List<String> referenceFrame;

        @NameInMap("subs")
        public java.util.List<BatchGetTaskResultResponseBodyTasksResultItemsSubs> subs;

        public static BatchGetTaskResultResponseBodyTasksResultItems build(java.util.Map<String, ?> map) throws Exception {
            BatchGetTaskResultResponseBodyTasksResultItems self = new BatchGetTaskResultResponseBodyTasksResultItems();
            return TeaModel.build(map, self);
        }

        public BatchGetTaskResultResponseBodyTasksResultItems setInfo(String info) {
            this.info = info;
            return this;
        }
        public String getInfo() {
            return this.info;
        }

        public BatchGetTaskResultResponseBodyTasksResultItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public BatchGetTaskResultResponseBodyTasksResultItems setPoint(Long point) {
            this.point = point;
            return this;
        }
        public Long getPoint() {
            return this.point;
        }

        public BatchGetTaskResultResponseBodyTasksResultItems setReference(String reference) {
            this.reference = reference;
            return this;
        }
        public String getReference() {
            return this.reference;
        }

        public BatchGetTaskResultResponseBodyTasksResultItems setReferenceFrame(java.util.List<String> referenceFrame) {
            this.referenceFrame = referenceFrame;
            return this;
        }
        public java.util.List<String> getReferenceFrame() {
            return this.referenceFrame;
        }

        public BatchGetTaskResultResponseBodyTasksResultItems setSubs(java.util.List<BatchGetTaskResultResponseBodyTasksResultItemsSubs> subs) {
            this.subs = subs;
            return this;
        }
        public java.util.List<BatchGetTaskResultResponseBodyTasksResultItemsSubs> getSubs() {
            return this.subs;
        }

    }

    public static class BatchGetTaskResultResponseBodyTasksResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="https://industry-ai-prod.oss-cn-zhangjiakou.aliyuncs.com/4beae5155406457291fcbdd76c4e8da8.txt">https://industry-ai-prod.oss-cn-zhangjiakou.aliyuncs.com/4beae5155406457291fcbdd76c4e8da8.txt</a></p>
         */
        @NameInMap("audioText")
        public String audioText;

        @NameInMap("audioTextFormatted")
        public String audioTextFormatted;

        /**
         * <strong>example:</strong>
         * <p>2024-05-14</p>
         */
        @NameInMap("date")
        public String date;

        /**
         * <strong>example:</strong>
         * <p>xxx项目</p>
         */
        @NameInMap("desc")
        public String desc;

        /**
         * <strong>example:</strong>
         * <p>1001</p>
         */
        @NameInMap("id")
        public Long id;

        @NameInMap("items")
        public java.util.List<BatchGetTaskResultResponseBodyTasksResultItems> items;

        /**
         * <strong>example:</strong>
         * <p>xxx项目会议</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("summary")
        public String summary;

        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("total")
        public Long total;

        public static BatchGetTaskResultResponseBodyTasksResult build(java.util.Map<String, ?> map) throws Exception {
            BatchGetTaskResultResponseBodyTasksResult self = new BatchGetTaskResultResponseBodyTasksResult();
            return TeaModel.build(map, self);
        }

        public BatchGetTaskResultResponseBodyTasksResult setAudioText(String audioText) {
            this.audioText = audioText;
            return this;
        }
        public String getAudioText() {
            return this.audioText;
        }

        public BatchGetTaskResultResponseBodyTasksResult setAudioTextFormatted(String audioTextFormatted) {
            this.audioTextFormatted = audioTextFormatted;
            return this;
        }
        public String getAudioTextFormatted() {
            return this.audioTextFormatted;
        }

        public BatchGetTaskResultResponseBodyTasksResult setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public BatchGetTaskResultResponseBodyTasksResult setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public BatchGetTaskResultResponseBodyTasksResult setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public BatchGetTaskResultResponseBodyTasksResult setItems(java.util.List<BatchGetTaskResultResponseBodyTasksResultItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<BatchGetTaskResultResponseBodyTasksResultItems> getItems() {
            return this.items;
        }

        public BatchGetTaskResultResponseBodyTasksResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public BatchGetTaskResultResponseBodyTasksResult setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

        public BatchGetTaskResultResponseBodyTasksResult setTotal(Long total) {
            this.total = total;
            return this;
        }
        public Long getTotal() {
            return this.total;
        }

    }

    public static class BatchGetTaskResultResponseBodyTasks extends TeaModel {
        @NameInMap("result")
        public BatchGetTaskResultResponseBodyTasksResult result;

        /**
         * <strong>example:</strong>
         * <p>COMPLETED</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <strong>example:</strong>
         * <p>4beae5155406457291fcbdd76c4e8da8</p>
         */
        @NameInMap("taskId")
        public String taskId;

        public static BatchGetTaskResultResponseBodyTasks build(java.util.Map<String, ?> map) throws Exception {
            BatchGetTaskResultResponseBodyTasks self = new BatchGetTaskResultResponseBodyTasks();
            return TeaModel.build(map, self);
        }

        public BatchGetTaskResultResponseBodyTasks setResult(BatchGetTaskResultResponseBodyTasksResult result) {
            this.result = result;
            return this;
        }
        public BatchGetTaskResultResponseBodyTasksResult getResult() {
            return this.result;
        }

        public BatchGetTaskResultResponseBodyTasks setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public BatchGetTaskResultResponseBodyTasks setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
