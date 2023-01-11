// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetCorpTasksResponseBody extends TeaModel {
    /**
     * <p>data</p>
     */
    @NameInMap("data")
    public java.util.List<GetCorpTasksResponseBodyData> data;

    /**
     * <p>当前第几页</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>总数量</p>
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
        /**
         * <p>activeTime</p>
         */
        @NameInMap("activeTimeGMT")
        public String activeTimeGMT;

        /**
         * <p>actualActionerId</p>
         */
        @NameInMap("actualActionerId")
        public String actualActionerId;

        /**
         * <p>appType</p>
         */
        @NameInMap("appType")
        public String appType;

        /**
         * <p>createTime</p>
         */
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        /**
         * <p>finishTime</p>
         */
        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        /**
         * <p>originatorEmail</p>
         */
        @NameInMap("originatorEmail")
        public String originatorEmail;

        /**
         * <p>originatorId</p>
         */
        @NameInMap("originatorId")
        public String originatorId;

        /**
         * <p>originatorName</p>
         */
        @NameInMap("originatorName")
        public String originatorName;

        /**
         * <p>originatorNameEn</p>
         */
        @NameInMap("originatorNameInEnglish")
        public String originatorNameInEnglish;

        /**
         * <p>originatorNickName</p>
         */
        @NameInMap("originatorNickName")
        public String originatorNickName;

        /**
         * <p>originatorNickNameEn</p>
         */
        @NameInMap("originatorNickNameEn")
        public String originatorNickNameEn;

        /**
         * <p>originatorPhoto</p>
         */
        @NameInMap("originatorPhoto")
        public String originatorPhoto;

        /**
         * <p>outResult</p>
         */
        @NameInMap("outResult")
        public String outResult;

        /**
         * <p>outResultName</p>
         */
        @NameInMap("outResultName")
        public String outResultName;

        /**
         * <p>processInstanceId</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <p>status</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>taskId</p>
         */
        @NameInMap("taskId")
        public String taskId;

        /**
         * <p>taskType</p>
         */
        @NameInMap("taskType")
        public String taskType;

        /**
         * <p>title</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>titleEn</p>
         */
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
