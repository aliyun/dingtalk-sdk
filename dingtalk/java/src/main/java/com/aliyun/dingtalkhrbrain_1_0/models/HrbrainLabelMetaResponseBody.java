// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelMetaResponseBody extends TeaModel {
    @NameInMap("content")
    public HrbrainLabelMetaResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static HrbrainLabelMetaResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelMetaResponseBody self = new HrbrainLabelMetaResponseBody();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelMetaResponseBody setContent(HrbrainLabelMetaResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public HrbrainLabelMetaResponseBodyContent getContent() {
        return this.content;
    }

    public HrbrainLabelMetaResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public HrbrainLabelMetaResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public HrbrainLabelMetaResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class HrbrainLabelMetaResponseBodyContentLabelMetas extends TeaModel {
        @NameInMap("categoryCode")
        public String categoryCode;

        @NameInMap("categoryName")
        public String categoryName;

        @NameInMap("code")
        public String code;

        @NameInMap("dataType")
        public String dataType;

        @NameInMap("description")
        public String description;

        @NameInMap("extendInfo")
        public java.util.Map<String, ?> extendInfo;

        @NameInMap("gmtCreated")
        public Long gmtCreated;

        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("importantLevel")
        public String importantLevel;

        @NameInMap("isSensitive")
        public Boolean isSensitive;

        @NameInMap("name")
        public String name;

        @NameInMap("options")
        public java.util.List<java.util.Map<String, ?>> options;

        @NameInMap("required")
        public Boolean required;

        @NameInMap("useStatus")
        public String useStatus;

        public static HrbrainLabelMetaResponseBodyContentLabelMetas build(java.util.Map<String, ?> map) throws Exception {
            HrbrainLabelMetaResponseBodyContentLabelMetas self = new HrbrainLabelMetaResponseBodyContentLabelMetas();
            return TeaModel.build(map, self);
        }

        public HrbrainLabelMetaResponseBodyContentLabelMetas setCategoryCode(String categoryCode) {
            this.categoryCode = categoryCode;
            return this;
        }
        public String getCategoryCode() {
            return this.categoryCode;
        }

        public HrbrainLabelMetaResponseBodyContentLabelMetas setCategoryName(String categoryName) {
            this.categoryName = categoryName;
            return this;
        }
        public String getCategoryName() {
            return this.categoryName;
        }

        public HrbrainLabelMetaResponseBodyContentLabelMetas setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public HrbrainLabelMetaResponseBodyContentLabelMetas setDataType(String dataType) {
            this.dataType = dataType;
            return this;
        }
        public String getDataType() {
            return this.dataType;
        }

        public HrbrainLabelMetaResponseBodyContentLabelMetas setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public HrbrainLabelMetaResponseBodyContentLabelMetas setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainLabelMetaResponseBodyContentLabelMetas setGmtCreated(Long gmtCreated) {
            this.gmtCreated = gmtCreated;
            return this;
        }
        public Long getGmtCreated() {
            return this.gmtCreated;
        }

        public HrbrainLabelMetaResponseBodyContentLabelMetas setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public HrbrainLabelMetaResponseBodyContentLabelMetas setImportantLevel(String importantLevel) {
            this.importantLevel = importantLevel;
            return this;
        }
        public String getImportantLevel() {
            return this.importantLevel;
        }

        public HrbrainLabelMetaResponseBodyContentLabelMetas setIsSensitive(Boolean isSensitive) {
            this.isSensitive = isSensitive;
            return this;
        }
        public Boolean getIsSensitive() {
            return this.isSensitive;
        }

        public HrbrainLabelMetaResponseBodyContentLabelMetas setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainLabelMetaResponseBodyContentLabelMetas setOptions(java.util.List<java.util.Map<String, ?>> options) {
            this.options = options;
            return this;
        }
        public java.util.List<java.util.Map<String, ?>> getOptions() {
            return this.options;
        }

        public HrbrainLabelMetaResponseBodyContentLabelMetas setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public HrbrainLabelMetaResponseBodyContentLabelMetas setUseStatus(String useStatus) {
            this.useStatus = useStatus;
            return this;
        }
        public String getUseStatus() {
            return this.useStatus;
        }

    }

    public static class HrbrainLabelMetaResponseBodyContent extends TeaModel {
        @NameInMap("labelMetas")
        public java.util.List<HrbrainLabelMetaResponseBodyContentLabelMetas> labelMetas;

        @NameInMap("maxResults")
        public Long maxResults;

        @NameInMap("nextToken")
        public String nextToken;

        @NameInMap("totalCount")
        public Long totalCount;

        public static HrbrainLabelMetaResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            HrbrainLabelMetaResponseBodyContent self = new HrbrainLabelMetaResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public HrbrainLabelMetaResponseBodyContent setLabelMetas(java.util.List<HrbrainLabelMetaResponseBodyContentLabelMetas> labelMetas) {
            this.labelMetas = labelMetas;
            return this;
        }
        public java.util.List<HrbrainLabelMetaResponseBodyContentLabelMetas> getLabelMetas() {
            return this.labelMetas;
        }

        public HrbrainLabelMetaResponseBodyContent setMaxResults(Long maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Long getMaxResults() {
            return this.maxResults;
        }

        public HrbrainLabelMetaResponseBodyContent setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public HrbrainLabelMetaResponseBodyContent setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

}
