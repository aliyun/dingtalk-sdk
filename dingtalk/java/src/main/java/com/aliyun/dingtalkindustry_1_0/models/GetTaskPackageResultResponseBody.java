// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class GetTaskPackageResultResponseBody extends TeaModel {
    @NameInMap("taskPackageId")
    public String taskPackageId;

    @NameInMap("tasks")
    public java.util.List<GetTaskPackageResultResponseBodyTasks> tasks;

    public static GetTaskPackageResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTaskPackageResultResponseBody self = new GetTaskPackageResultResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTaskPackageResultResponseBody setTaskPackageId(String taskPackageId) {
        this.taskPackageId = taskPackageId;
        return this;
    }
    public String getTaskPackageId() {
        return this.taskPackageId;
    }

    public GetTaskPackageResultResponseBody setTasks(java.util.List<GetTaskPackageResultResponseBodyTasks> tasks) {
        this.tasks = tasks;
        return this;
    }
    public java.util.List<GetTaskPackageResultResponseBodyTasks> getTasks() {
        return this.tasks;
    }

    public static class GetTaskPackageResultResponseBodyTasksResultItems extends TeaModel {
        @NameInMap("advantages")
        public String advantages;

        @NameInMap("fabReference")
        public String fabReference;

        @NameInMap("info")
        public String info;

        @NameInMap("name")
        public String name;

        @NameInMap("point")
        public Long point;

        @NameInMap("reference")
        public String reference;

        @NameInMap("res")
        public Boolean res;

        @NameInMap("suggestion")
        public String suggestion;

        public static GetTaskPackageResultResponseBodyTasksResultItems build(java.util.Map<String, ?> map) throws Exception {
            GetTaskPackageResultResponseBodyTasksResultItems self = new GetTaskPackageResultResponseBodyTasksResultItems();
            return TeaModel.build(map, self);
        }

        public GetTaskPackageResultResponseBodyTasksResultItems setAdvantages(String advantages) {
            this.advantages = advantages;
            return this;
        }
        public String getAdvantages() {
            return this.advantages;
        }

        public GetTaskPackageResultResponseBodyTasksResultItems setFabReference(String fabReference) {
            this.fabReference = fabReference;
            return this;
        }
        public String getFabReference() {
            return this.fabReference;
        }

        public GetTaskPackageResultResponseBodyTasksResultItems setInfo(String info) {
            this.info = info;
            return this;
        }
        public String getInfo() {
            return this.info;
        }

        public GetTaskPackageResultResponseBodyTasksResultItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetTaskPackageResultResponseBodyTasksResultItems setPoint(Long point) {
            this.point = point;
            return this;
        }
        public Long getPoint() {
            return this.point;
        }

        public GetTaskPackageResultResponseBodyTasksResultItems setReference(String reference) {
            this.reference = reference;
            return this;
        }
        public String getReference() {
            return this.reference;
        }

        public GetTaskPackageResultResponseBodyTasksResultItems setRes(Boolean res) {
            this.res = res;
            return this;
        }
        public Boolean getRes() {
            return this.res;
        }

        public GetTaskPackageResultResponseBodyTasksResultItems setSuggestion(String suggestion) {
            this.suggestion = suggestion;
            return this;
        }
        public String getSuggestion() {
            return this.suggestion;
        }

    }

    public static class GetTaskPackageResultResponseBodyTasksResult extends TeaModel {
        @NameInMap("audioText")
        public String audioText;

        @NameInMap("audioTextFormatted")
        public String audioTextFormatted;

        @NameInMap("date")
        public String date;

        @NameInMap("desc")
        public String desc;

        @NameInMap("formName")
        public String formName;

        @NameInMap("id")
        public Long id;

        @NameInMap("items")
        public java.util.List<GetTaskPackageResultResponseBodyTasksResultItems> items;

        @NameInMap("name")
        public String name;

        @NameInMap("parseText")
        public String parseText;

        @NameInMap("rawData")
        public String rawData;

        @NameInMap("summary")
        public String summary;

        @NameInMap("total")
        public Long total;

        public static GetTaskPackageResultResponseBodyTasksResult build(java.util.Map<String, ?> map) throws Exception {
            GetTaskPackageResultResponseBodyTasksResult self = new GetTaskPackageResultResponseBodyTasksResult();
            return TeaModel.build(map, self);
        }

        public GetTaskPackageResultResponseBodyTasksResult setAudioText(String audioText) {
            this.audioText = audioText;
            return this;
        }
        public String getAudioText() {
            return this.audioText;
        }

        public GetTaskPackageResultResponseBodyTasksResult setAudioTextFormatted(String audioTextFormatted) {
            this.audioTextFormatted = audioTextFormatted;
            return this;
        }
        public String getAudioTextFormatted() {
            return this.audioTextFormatted;
        }

        public GetTaskPackageResultResponseBodyTasksResult setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public GetTaskPackageResultResponseBodyTasksResult setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public GetTaskPackageResultResponseBodyTasksResult setFormName(String formName) {
            this.formName = formName;
            return this;
        }
        public String getFormName() {
            return this.formName;
        }

        public GetTaskPackageResultResponseBodyTasksResult setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GetTaskPackageResultResponseBodyTasksResult setItems(java.util.List<GetTaskPackageResultResponseBodyTasksResultItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<GetTaskPackageResultResponseBodyTasksResultItems> getItems() {
            return this.items;
        }

        public GetTaskPackageResultResponseBodyTasksResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetTaskPackageResultResponseBodyTasksResult setParseText(String parseText) {
            this.parseText = parseText;
            return this;
        }
        public String getParseText() {
            return this.parseText;
        }

        public GetTaskPackageResultResponseBodyTasksResult setRawData(String rawData) {
            this.rawData = rawData;
            return this;
        }
        public String getRawData() {
            return this.rawData;
        }

        public GetTaskPackageResultResponseBodyTasksResult setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

        public GetTaskPackageResultResponseBodyTasksResult setTotal(Long total) {
            this.total = total;
            return this;
        }
        public Long getTotal() {
            return this.total;
        }

    }

    public static class GetTaskPackageResultResponseBodyTasks extends TeaModel {
        @NameInMap("reportLink")
        public String reportLink;

        @NameInMap("result")
        public GetTaskPackageResultResponseBodyTasksResult result;

        @NameInMap("status")
        public String status;

        @NameInMap("statusInfo")
        public String statusInfo;

        @NameInMap("taskId")
        public String taskId;

        public static GetTaskPackageResultResponseBodyTasks build(java.util.Map<String, ?> map) throws Exception {
            GetTaskPackageResultResponseBodyTasks self = new GetTaskPackageResultResponseBodyTasks();
            return TeaModel.build(map, self);
        }

        public GetTaskPackageResultResponseBodyTasks setReportLink(String reportLink) {
            this.reportLink = reportLink;
            return this;
        }
        public String getReportLink() {
            return this.reportLink;
        }

        public GetTaskPackageResultResponseBodyTasks setResult(GetTaskPackageResultResponseBodyTasksResult result) {
            this.result = result;
            return this;
        }
        public GetTaskPackageResultResponseBodyTasksResult getResult() {
            return this.result;
        }

        public GetTaskPackageResultResponseBodyTasks setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetTaskPackageResultResponseBodyTasks setStatusInfo(String statusInfo) {
            this.statusInfo = statusInfo;
            return this;
        }
        public String getStatusInfo() {
            return this.statusInfo;
        }

        public GetTaskPackageResultResponseBodyTasks setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
