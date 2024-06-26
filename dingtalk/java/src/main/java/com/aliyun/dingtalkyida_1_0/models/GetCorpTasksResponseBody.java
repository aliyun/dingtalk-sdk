// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetCorpTasksResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<GetCorpTasksResponseBodyData> data;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static GetCorpTasksResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCorpTasksResponseBody self = new GetCorpTasksResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCorpTasksResponseBody setData(java.util.List<GetCorpTasksResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetCorpTasksResponseBodyData> getData() {
        return this.data;
    }

    public GetCorpTasksResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetCorpTasksResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class GetCorpTasksResponseBodyData extends TeaModel {
        @NameInMap("activeTimeGMT")
        public String activeTimeGMT;

        @NameInMap("actualActionerId")
        public String actualActionerId;

        @NameInMap("appType")
        public String appType;

        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        @NameInMap("originatorEmail")
        public String originatorEmail;

        @NameInMap("originatorId")
        public String originatorId;

        @NameInMap("originatorName")
        public String originatorName;

        @NameInMap("originatorNameInEnglish")
        public String originatorNameInEnglish;

        @NameInMap("originatorNickName")
        public String originatorNickName;

        @NameInMap("originatorNickNameEn")
        public String originatorNickNameEn;

        @NameInMap("originatorPhoto")
        public String originatorPhoto;

        @NameInMap("outResult")
        public String outResult;

        @NameInMap("outResultName")
        public String outResultName;

        @NameInMap("processInstanceId")
        public String processInstanceId;

        @NameInMap("status")
        public String status;

        @NameInMap("taskId")
        public String taskId;

        @NameInMap("taskType")
        public String taskType;

        @NameInMap("title")
        public String title;

        @NameInMap("titleInEnglish")
        public String titleInEnglish;

        public static GetCorpTasksResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetCorpTasksResponseBodyData self = new GetCorpTasksResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetCorpTasksResponseBodyData setActiveTimeGMT(String activeTimeGMT) {
            this.activeTimeGMT = activeTimeGMT;
            return this;
        }
        public String getActiveTimeGMT() {
            return this.activeTimeGMT;
        }

        public GetCorpTasksResponseBodyData setActualActionerId(String actualActionerId) {
            this.actualActionerId = actualActionerId;
            return this;
        }
        public String getActualActionerId() {
            return this.actualActionerId;
        }

        public GetCorpTasksResponseBodyData setAppType(String appType) {
            this.appType = appType;
            return this;
        }
        public String getAppType() {
            return this.appType;
        }

        public GetCorpTasksResponseBodyData setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public GetCorpTasksResponseBodyData setFinishTimeGMT(String finishTimeGMT) {
            this.finishTimeGMT = finishTimeGMT;
            return this;
        }
        public String getFinishTimeGMT() {
            return this.finishTimeGMT;
        }

        public GetCorpTasksResponseBodyData setOriginatorEmail(String originatorEmail) {
            this.originatorEmail = originatorEmail;
            return this;
        }
        public String getOriginatorEmail() {
            return this.originatorEmail;
        }

        public GetCorpTasksResponseBodyData setOriginatorId(String originatorId) {
            this.originatorId = originatorId;
            return this;
        }
        public String getOriginatorId() {
            return this.originatorId;
        }

        public GetCorpTasksResponseBodyData setOriginatorName(String originatorName) {
            this.originatorName = originatorName;
            return this;
        }
        public String getOriginatorName() {
            return this.originatorName;
        }

        public GetCorpTasksResponseBodyData setOriginatorNameInEnglish(String originatorNameInEnglish) {
            this.originatorNameInEnglish = originatorNameInEnglish;
            return this;
        }
        public String getOriginatorNameInEnglish() {
            return this.originatorNameInEnglish;
        }

        public GetCorpTasksResponseBodyData setOriginatorNickName(String originatorNickName) {
            this.originatorNickName = originatorNickName;
            return this;
        }
        public String getOriginatorNickName() {
            return this.originatorNickName;
        }

        public GetCorpTasksResponseBodyData setOriginatorNickNameEn(String originatorNickNameEn) {
            this.originatorNickNameEn = originatorNickNameEn;
            return this;
        }
        public String getOriginatorNickNameEn() {
            return this.originatorNickNameEn;
        }

        public GetCorpTasksResponseBodyData setOriginatorPhoto(String originatorPhoto) {
            this.originatorPhoto = originatorPhoto;
            return this;
        }
        public String getOriginatorPhoto() {
            return this.originatorPhoto;
        }

        public GetCorpTasksResponseBodyData setOutResult(String outResult) {
            this.outResult = outResult;
            return this;
        }
        public String getOutResult() {
            return this.outResult;
        }

        public GetCorpTasksResponseBodyData setOutResultName(String outResultName) {
            this.outResultName = outResultName;
            return this;
        }
        public String getOutResultName() {
            return this.outResultName;
        }

        public GetCorpTasksResponseBodyData setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetCorpTasksResponseBodyData setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetCorpTasksResponseBodyData setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public GetCorpTasksResponseBodyData setTaskType(String taskType) {
            this.taskType = taskType;
            return this;
        }
        public String getTaskType() {
            return this.taskType;
        }

        public GetCorpTasksResponseBodyData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetCorpTasksResponseBodyData setTitleInEnglish(String titleInEnglish) {
            this.titleInEnglish = titleInEnglish;
            return this;
        }
        public String getTitleInEnglish() {
            return this.titleInEnglish;
        }

    }

}
