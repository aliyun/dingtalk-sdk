// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivateStoreFileTaskInfosByPageResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasNext")
    public Integer hasNext;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("itemCount")
    public Integer itemCount;

    @NameInMap("items")
    public java.util.List<GetPrivateStoreFileTaskInfosByPageResponseBodyItems> items;

    /**
     * <strong>example:</strong>
     * <p>200</p>
     */
    @NameInMap("totalCount")
    public Integer totalCount;

    public static GetPrivateStoreFileTaskInfosByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPrivateStoreFileTaskInfosByPageResponseBody self = new GetPrivateStoreFileTaskInfosByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPrivateStoreFileTaskInfosByPageResponseBody setHasNext(Integer hasNext) {
        this.hasNext = hasNext;
        return this;
    }
    public Integer getHasNext() {
        return this.hasNext;
    }

    public GetPrivateStoreFileTaskInfosByPageResponseBody setItemCount(Integer itemCount) {
        this.itemCount = itemCount;
        return this;
    }
    public Integer getItemCount() {
        return this.itemCount;
    }

    public GetPrivateStoreFileTaskInfosByPageResponseBody setItems(java.util.List<GetPrivateStoreFileTaskInfosByPageResponseBodyItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<GetPrivateStoreFileTaskInfosByPageResponseBodyItems> getItems() {
        return this.items;
    }

    public GetPrivateStoreFileTaskInfosByPageResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class GetPrivateStoreFileTaskInfosByPageResponseBodyItems extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("classTagId")
        public String classTagId;

        /**
         * <strong>example:</strong>
         * <p>大于 0 小于 1 等于 2</p>
         */
        @NameInMap("classTagOperator")
        public String classTagOperator;

        /**
         * <strong>example:</strong>
         * <p>普通文件</p>
         */
        @NameInMap("classTagText")
        public String classTagText;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("creatorLeaveStatus")
        public Integer creatorLeaveStatus;

        @NameInMap("dealFileFormats")
        public java.util.List<String> dealFileFormats;

        /**
         * <strong>example:</strong>
         * <p>大于等于 0 小于等于 1</p>
         */
        @NameInMap("dealFileOperator")
        public Integer dealFileOperator;

        @NameInMap("dealFileScopes")
        public java.util.List<String> dealFileScopes;

        /**
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("dealFileSize")
        public Long dealFileSize;

        /**
         * <strong>example:</strong>
         * <p>12345</p>
         */
        @NameInMap("fileCreateTimeEnd")
        public Long fileCreateTimeEnd;

        /**
         * <strong>example:</strong>
         * <p>12345</p>
         */
        @NameInMap("fileCreateTimeStart")
        public Long fileCreateTimeStart;

        /**
         * <strong>example:</strong>
         * <p>12345</p>
         */
        @NameInMap("fileModifiedTimeEnd")
        public Long fileModifiedTimeEnd;

        /**
         * <strong>example:</strong>
         * <p>12345</p>
         */
        @NameInMap("fileModifiedTimeStart")
        public Long fileModifiedTimeStart;

        /**
         * <strong>example:</strong>
         * <p>12345</p>
         */
        @NameInMap("taskCreateTime")
        public Long taskCreateTime;

        /**
         * <strong>example:</strong>
         * <p>钉三多</p>
         */
        @NameInMap("taskCreatorName")
        public String taskCreatorName;

        /**
         * <strong>example:</strong>
         * <p>钉三多</p>
         */
        @NameInMap("taskDeleterName")
        public String taskDeleterName;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("taskId")
        public Long taskId;

        /**
         * <strong>example:</strong>
         * <p>初始化完毕 0 正在删除 1 删除完成 2 正在回滚 3 回滚完成 4 数据初始化中 5  任务状态异常 6  待删除 7</p>
         */
        @NameInMap("taskStatus")
        public Integer taskStatus;

        public static GetPrivateStoreFileTaskInfosByPageResponseBodyItems build(java.util.Map<String, ?> map) throws Exception {
            GetPrivateStoreFileTaskInfosByPageResponseBodyItems self = new GetPrivateStoreFileTaskInfosByPageResponseBodyItems();
            return TeaModel.build(map, self);
        }

        public GetPrivateStoreFileTaskInfosByPageResponseBodyItems setClassTagId(String classTagId) {
            this.classTagId = classTagId;
            return this;
        }
        public String getClassTagId() {
            return this.classTagId;
        }

        public GetPrivateStoreFileTaskInfosByPageResponseBodyItems setClassTagOperator(String classTagOperator) {
            this.classTagOperator = classTagOperator;
            return this;
        }
        public String getClassTagOperator() {
            return this.classTagOperator;
        }

        public GetPrivateStoreFileTaskInfosByPageResponseBodyItems setClassTagText(String classTagText) {
            this.classTagText = classTagText;
            return this;
        }
        public String getClassTagText() {
            return this.classTagText;
        }

        public GetPrivateStoreFileTaskInfosByPageResponseBodyItems setCreatorLeaveStatus(Integer creatorLeaveStatus) {
            this.creatorLeaveStatus = creatorLeaveStatus;
            return this;
        }
        public Integer getCreatorLeaveStatus() {
            return this.creatorLeaveStatus;
        }

        public GetPrivateStoreFileTaskInfosByPageResponseBodyItems setDealFileFormats(java.util.List<String> dealFileFormats) {
            this.dealFileFormats = dealFileFormats;
            return this;
        }
        public java.util.List<String> getDealFileFormats() {
            return this.dealFileFormats;
        }

        public GetPrivateStoreFileTaskInfosByPageResponseBodyItems setDealFileOperator(Integer dealFileOperator) {
            this.dealFileOperator = dealFileOperator;
            return this;
        }
        public Integer getDealFileOperator() {
            return this.dealFileOperator;
        }

        public GetPrivateStoreFileTaskInfosByPageResponseBodyItems setDealFileScopes(java.util.List<String> dealFileScopes) {
            this.dealFileScopes = dealFileScopes;
            return this;
        }
        public java.util.List<String> getDealFileScopes() {
            return this.dealFileScopes;
        }

        public GetPrivateStoreFileTaskInfosByPageResponseBodyItems setDealFileSize(Long dealFileSize) {
            this.dealFileSize = dealFileSize;
            return this;
        }
        public Long getDealFileSize() {
            return this.dealFileSize;
        }

        public GetPrivateStoreFileTaskInfosByPageResponseBodyItems setFileCreateTimeEnd(Long fileCreateTimeEnd) {
            this.fileCreateTimeEnd = fileCreateTimeEnd;
            return this;
        }
        public Long getFileCreateTimeEnd() {
            return this.fileCreateTimeEnd;
        }

        public GetPrivateStoreFileTaskInfosByPageResponseBodyItems setFileCreateTimeStart(Long fileCreateTimeStart) {
            this.fileCreateTimeStart = fileCreateTimeStart;
            return this;
        }
        public Long getFileCreateTimeStart() {
            return this.fileCreateTimeStart;
        }

        public GetPrivateStoreFileTaskInfosByPageResponseBodyItems setFileModifiedTimeEnd(Long fileModifiedTimeEnd) {
            this.fileModifiedTimeEnd = fileModifiedTimeEnd;
            return this;
        }
        public Long getFileModifiedTimeEnd() {
            return this.fileModifiedTimeEnd;
        }

        public GetPrivateStoreFileTaskInfosByPageResponseBodyItems setFileModifiedTimeStart(Long fileModifiedTimeStart) {
            this.fileModifiedTimeStart = fileModifiedTimeStart;
            return this;
        }
        public Long getFileModifiedTimeStart() {
            return this.fileModifiedTimeStart;
        }

        public GetPrivateStoreFileTaskInfosByPageResponseBodyItems setTaskCreateTime(Long taskCreateTime) {
            this.taskCreateTime = taskCreateTime;
            return this;
        }
        public Long getTaskCreateTime() {
            return this.taskCreateTime;
        }

        public GetPrivateStoreFileTaskInfosByPageResponseBodyItems setTaskCreatorName(String taskCreatorName) {
            this.taskCreatorName = taskCreatorName;
            return this;
        }
        public String getTaskCreatorName() {
            return this.taskCreatorName;
        }

        public GetPrivateStoreFileTaskInfosByPageResponseBodyItems setTaskDeleterName(String taskDeleterName) {
            this.taskDeleterName = taskDeleterName;
            return this;
        }
        public String getTaskDeleterName() {
            return this.taskDeleterName;
        }

        public GetPrivateStoreFileTaskInfosByPageResponseBodyItems setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

        public GetPrivateStoreFileTaskInfosByPageResponseBodyItems setTaskStatus(Integer taskStatus) {
            this.taskStatus = taskStatus;
            return this;
        }
        public Integer getTaskStatus() {
            return this.taskStatus;
        }

    }

}
