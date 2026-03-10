// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryOrderConvertResultResponseBody extends TeaModel {
    @NameInMap("dingOpenErrcode")
    public Long dingOpenErrcode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public QueryOrderConvertResultResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryOrderConvertResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOrderConvertResultResponseBody self = new QueryOrderConvertResultResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOrderConvertResultResponseBody setDingOpenErrcode(Long dingOpenErrcode) {
        this.dingOpenErrcode = dingOpenErrcode;
        return this;
    }
    public Long getDingOpenErrcode() {
        return this.dingOpenErrcode;
    }

    public QueryOrderConvertResultResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public QueryOrderConvertResultResponseBody setResult(QueryOrderConvertResultResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryOrderConvertResultResponseBodyResult getResult() {
        return this.result;
    }

    public QueryOrderConvertResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryOrderConvertResultResponseBodyResultItemsOutputInfo extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public String fileSize;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("fileUrl")
        public String fileUrl;

        public static QueryOrderConvertResultResponseBodyResultItemsOutputInfo build(java.util.Map<String, ?> map) throws Exception {
            QueryOrderConvertResultResponseBodyResultItemsOutputInfo self = new QueryOrderConvertResultResponseBodyResultItemsOutputInfo();
            return TeaModel.build(map, self);
        }

        public QueryOrderConvertResultResponseBodyResultItemsOutputInfo setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public QueryOrderConvertResultResponseBodyResultItemsOutputInfo setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public QueryOrderConvertResultResponseBodyResultItemsOutputInfo setFileSize(String fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public String getFileSize() {
            return this.fileSize;
        }

        public QueryOrderConvertResultResponseBodyResultItemsOutputInfo setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public QueryOrderConvertResultResponseBodyResultItemsOutputInfo setFileUrl(String fileUrl) {
            this.fileUrl = fileUrl;
            return this;
        }
        public String getFileUrl() {
            return this.fileUrl;
        }

    }

    public static class QueryOrderConvertResultResponseBodyResultItems extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("creatorName")
        public String creatorName;

        @NameInMap("outputInfo")
        public QueryOrderConvertResultResponseBodyResultItemsOutputInfo outputInfo;

        @NameInMap("status")
        public String status;

        @NameInMap("taskBizId")
        public String taskBizId;

        @NameInMap("title")
        public String title;

        public static QueryOrderConvertResultResponseBodyResultItems build(java.util.Map<String, ?> map) throws Exception {
            QueryOrderConvertResultResponseBodyResultItems self = new QueryOrderConvertResultResponseBodyResultItems();
            return TeaModel.build(map, self);
        }

        public QueryOrderConvertResultResponseBodyResultItems setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryOrderConvertResultResponseBodyResultItems setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryOrderConvertResultResponseBodyResultItems setCreatorName(String creatorName) {
            this.creatorName = creatorName;
            return this;
        }
        public String getCreatorName() {
            return this.creatorName;
        }

        public QueryOrderConvertResultResponseBodyResultItems setOutputInfo(QueryOrderConvertResultResponseBodyResultItemsOutputInfo outputInfo) {
            this.outputInfo = outputInfo;
            return this;
        }
        public QueryOrderConvertResultResponseBodyResultItemsOutputInfo getOutputInfo() {
            return this.outputInfo;
        }

        public QueryOrderConvertResultResponseBodyResultItems setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryOrderConvertResultResponseBodyResultItems setTaskBizId(String taskBizId) {
            this.taskBizId = taskBizId;
            return this;
        }
        public String getTaskBizId() {
            return this.taskBizId;
        }

        public QueryOrderConvertResultResponseBodyResultItems setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryOrderConvertResultResponseBodyResult extends TeaModel {
        @NameInMap("items")
        public java.util.List<QueryOrderConvertResultResponseBodyResultItems> items;

        @NameInMap("pageNo")
        public Float pageNo;

        @NameInMap("pageSize")
        public Float pageSize;

        @NameInMap("totalCount")
        public Float totalCount;

        @NameInMap("totalPages")
        public Float totalPages;

        public static QueryOrderConvertResultResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryOrderConvertResultResponseBodyResult self = new QueryOrderConvertResultResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryOrderConvertResultResponseBodyResult setItems(java.util.List<QueryOrderConvertResultResponseBodyResultItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<QueryOrderConvertResultResponseBodyResultItems> getItems() {
            return this.items;
        }

        public QueryOrderConvertResultResponseBodyResult setPageNo(Float pageNo) {
            this.pageNo = pageNo;
            return this;
        }
        public Float getPageNo() {
            return this.pageNo;
        }

        public QueryOrderConvertResultResponseBodyResult setPageSize(Float pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Float getPageSize() {
            return this.pageSize;
        }

        public QueryOrderConvertResultResponseBodyResult setTotalCount(Float totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Float getTotalCount() {
            return this.totalCount;
        }

        public QueryOrderConvertResultResponseBodyResult setTotalPages(Float totalPages) {
            this.totalPages = totalPages;
            return this;
        }
        public Float getTotalPages() {
            return this.totalPages;
        }

    }

}
