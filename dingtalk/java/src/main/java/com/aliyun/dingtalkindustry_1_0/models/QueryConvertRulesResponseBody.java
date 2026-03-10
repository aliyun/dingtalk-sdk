// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryConvertRulesResponseBody extends TeaModel {
    @NameInMap("dingOpenErrcode")
    public Long dingOpenErrcode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public QueryConvertRulesResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryConvertRulesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryConvertRulesResponseBody self = new QueryConvertRulesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryConvertRulesResponseBody setDingOpenErrcode(Long dingOpenErrcode) {
        this.dingOpenErrcode = dingOpenErrcode;
        return this;
    }
    public Long getDingOpenErrcode() {
        return this.dingOpenErrcode;
    }

    public QueryConvertRulesResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public QueryConvertRulesResponseBody setResult(QueryConvertRulesResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryConvertRulesResponseBodyResult getResult() {
        return this.result;
    }

    public QueryConvertRulesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryConvertRulesResponseBodyResultItemsSourceFiles extends TeaModel {
        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public Float fileSize;

        @NameInMap("fileTag")
        public String fileTag;

        @NameInMap("mediaId")
        public String mediaId;

        @NameInMap("previewUrl")
        public String previewUrl;

        public static QueryConvertRulesResponseBodyResultItemsSourceFiles build(java.util.Map<String, ?> map) throws Exception {
            QueryConvertRulesResponseBodyResultItemsSourceFiles self = new QueryConvertRulesResponseBodyResultItemsSourceFiles();
            return TeaModel.build(map, self);
        }

        public QueryConvertRulesResponseBodyResultItemsSourceFiles setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public QueryConvertRulesResponseBodyResultItemsSourceFiles setFileSize(Float fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Float getFileSize() {
            return this.fileSize;
        }

        public QueryConvertRulesResponseBodyResultItemsSourceFiles setFileTag(String fileTag) {
            this.fileTag = fileTag;
            return this;
        }
        public String getFileTag() {
            return this.fileTag;
        }

        public QueryConvertRulesResponseBodyResultItemsSourceFiles setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

        public QueryConvertRulesResponseBodyResultItemsSourceFiles setPreviewUrl(String previewUrl) {
            this.previewUrl = previewUrl;
            return this;
        }
        public String getPreviewUrl() {
            return this.previewUrl;
        }

    }

    public static class QueryConvertRulesResponseBodyResultItemsTargetFiles extends TeaModel {
        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public Float fileSize;

        @NameInMap("fileTag")
        public String fileTag;

        @NameInMap("mediaId")
        public String mediaId;

        @NameInMap("previewUrl")
        public String previewUrl;

        public static QueryConvertRulesResponseBodyResultItemsTargetFiles build(java.util.Map<String, ?> map) throws Exception {
            QueryConvertRulesResponseBodyResultItemsTargetFiles self = new QueryConvertRulesResponseBodyResultItemsTargetFiles();
            return TeaModel.build(map, self);
        }

        public QueryConvertRulesResponseBodyResultItemsTargetFiles setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public QueryConvertRulesResponseBodyResultItemsTargetFiles setFileSize(Float fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Float getFileSize() {
            return this.fileSize;
        }

        public QueryConvertRulesResponseBodyResultItemsTargetFiles setFileTag(String fileTag) {
            this.fileTag = fileTag;
            return this;
        }
        public String getFileTag() {
            return this.fileTag;
        }

        public QueryConvertRulesResponseBodyResultItemsTargetFiles setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

        public QueryConvertRulesResponseBodyResultItemsTargetFiles setPreviewUrl(String previewUrl) {
            this.previewUrl = previewUrl;
            return this;
        }
        public String getPreviewUrl() {
            return this.previewUrl;
        }

    }

    public static class QueryConvertRulesResponseBodyResultItems extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("description")
        public String description;

        @NameInMap("gmtCreate")
        public Float gmtCreate;

        @NameInMap("gmtModified")
        public Float gmtModified;

        @NameInMap("name")
        public String name;

        @NameInMap("ruleBizId")
        public String ruleBizId;

        @NameInMap("sourceFiles")
        public java.util.List<QueryConvertRulesResponseBodyResultItemsSourceFiles> sourceFiles;

        @NameInMap("targetFiles")
        public java.util.List<QueryConvertRulesResponseBodyResultItemsTargetFiles> targetFiles;

        public static QueryConvertRulesResponseBodyResultItems build(java.util.Map<String, ?> map) throws Exception {
            QueryConvertRulesResponseBodyResultItems self = new QueryConvertRulesResponseBodyResultItems();
            return TeaModel.build(map, self);
        }

        public QueryConvertRulesResponseBodyResultItems setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryConvertRulesResponseBodyResultItems setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public QueryConvertRulesResponseBodyResultItems setGmtCreate(Float gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Float getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryConvertRulesResponseBodyResultItems setGmtModified(Float gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Float getGmtModified() {
            return this.gmtModified;
        }

        public QueryConvertRulesResponseBodyResultItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryConvertRulesResponseBodyResultItems setRuleBizId(String ruleBizId) {
            this.ruleBizId = ruleBizId;
            return this;
        }
        public String getRuleBizId() {
            return this.ruleBizId;
        }

        public QueryConvertRulesResponseBodyResultItems setSourceFiles(java.util.List<QueryConvertRulesResponseBodyResultItemsSourceFiles> sourceFiles) {
            this.sourceFiles = sourceFiles;
            return this;
        }
        public java.util.List<QueryConvertRulesResponseBodyResultItemsSourceFiles> getSourceFiles() {
            return this.sourceFiles;
        }

        public QueryConvertRulesResponseBodyResultItems setTargetFiles(java.util.List<QueryConvertRulesResponseBodyResultItemsTargetFiles> targetFiles) {
            this.targetFiles = targetFiles;
            return this;
        }
        public java.util.List<QueryConvertRulesResponseBodyResultItemsTargetFiles> getTargetFiles() {
            return this.targetFiles;
        }

    }

    public static class QueryConvertRulesResponseBodyResult extends TeaModel {
        @NameInMap("items")
        public java.util.List<QueryConvertRulesResponseBodyResultItems> items;

        @NameInMap("pageNo")
        public Float pageNo;

        @NameInMap("pageSize")
        public Float pageSize;

        @NameInMap("totalCount")
        public Float totalCount;

        @NameInMap("totalPages")
        public Float totalPages;

        public static QueryConvertRulesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryConvertRulesResponseBodyResult self = new QueryConvertRulesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryConvertRulesResponseBodyResult setItems(java.util.List<QueryConvertRulesResponseBodyResultItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<QueryConvertRulesResponseBodyResultItems> getItems() {
            return this.items;
        }

        public QueryConvertRulesResponseBodyResult setPageNo(Float pageNo) {
            this.pageNo = pageNo;
            return this;
        }
        public Float getPageNo() {
            return this.pageNo;
        }

        public QueryConvertRulesResponseBodyResult setPageSize(Float pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Float getPageSize() {
            return this.pageSize;
        }

        public QueryConvertRulesResponseBodyResult setTotalCount(Float totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Float getTotalCount() {
            return this.totalCount;
        }

        public QueryConvertRulesResponseBodyResult setTotalPages(Float totalPages) {
            this.totalPages = totalPages;
            return this;
        }
        public Float getTotalPages() {
            return this.totalPages;
        }

    }

}
