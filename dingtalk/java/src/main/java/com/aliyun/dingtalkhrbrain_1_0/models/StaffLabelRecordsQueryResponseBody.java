// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class StaffLabelRecordsQueryResponseBody extends TeaModel {
    @NameInMap("content")
    public StaffLabelRecordsQueryResponseBodyContent content;

    /**
     * <strong>example:</strong>
     * <p>0140180438261064274667</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static StaffLabelRecordsQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        StaffLabelRecordsQueryResponseBody self = new StaffLabelRecordsQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public StaffLabelRecordsQueryResponseBody setContent(StaffLabelRecordsQueryResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public StaffLabelRecordsQueryResponseBodyContent getContent() {
        return this.content;
    }

    public StaffLabelRecordsQueryResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public StaffLabelRecordsQueryResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public StaffLabelRecordsQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class StaffLabelRecordsQueryResponseBodyContentDataLabelsOptions extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("tip")
        public String tip;

        @NameInMap("value")
        public String value;

        public static StaffLabelRecordsQueryResponseBodyContentDataLabelsOptions build(java.util.Map<String, ?> map) throws Exception {
            StaffLabelRecordsQueryResponseBodyContentDataLabelsOptions self = new StaffLabelRecordsQueryResponseBodyContentDataLabelsOptions();
            return TeaModel.build(map, self);
        }

        public StaffLabelRecordsQueryResponseBodyContentDataLabelsOptions setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public StaffLabelRecordsQueryResponseBodyContentDataLabelsOptions setTip(String tip) {
            this.tip = tip;
            return this;
        }
        public String getTip() {
            return this.tip;
        }

        public StaffLabelRecordsQueryResponseBodyContentDataLabelsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class StaffLabelRecordsQueryResponseBodyContentDataLabels extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>long_termism_score</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <strong>example:</strong>
         * <p>values.long_termism_score</p>
         */
        @NameInMap("guid")
        public String guid;

        /**
         * <strong>example:</strong>
         * <p>持续业绩</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("options")
        public java.util.List<StaffLabelRecordsQueryResponseBodyContentDataLabelsOptions> options;

        /**
         * <strong>example:</strong>
         * <p>values</p>
         */
        @NameInMap("typeCode")
        public String typeCode;

        /**
         * <strong>example:</strong>
         * <p>价值</p>
         */
        @NameInMap("typeName")
        public String typeName;

        /**
         * <strong>example:</strong>
         * <p>5（总是）</p>
         */
        @NameInMap("value")
        public String value;

        public static StaffLabelRecordsQueryResponseBodyContentDataLabels build(java.util.Map<String, ?> map) throws Exception {
            StaffLabelRecordsQueryResponseBodyContentDataLabels self = new StaffLabelRecordsQueryResponseBodyContentDataLabels();
            return TeaModel.build(map, self);
        }

        public StaffLabelRecordsQueryResponseBodyContentDataLabels setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public StaffLabelRecordsQueryResponseBodyContentDataLabels setGuid(String guid) {
            this.guid = guid;
            return this;
        }
        public String getGuid() {
            return this.guid;
        }

        public StaffLabelRecordsQueryResponseBodyContentDataLabels setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public StaffLabelRecordsQueryResponseBodyContentDataLabels setOptions(java.util.List<StaffLabelRecordsQueryResponseBodyContentDataLabelsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<StaffLabelRecordsQueryResponseBodyContentDataLabelsOptions> getOptions() {
            return this.options;
        }

        public StaffLabelRecordsQueryResponseBodyContentDataLabels setTypeCode(String typeCode) {
            this.typeCode = typeCode;
            return this;
        }
        public String getTypeCode() {
            return this.typeCode;
        }

        public StaffLabelRecordsQueryResponseBodyContentDataLabels setTypeName(String typeName) {
            this.typeName = typeName;
            return this;
        }
        public String getTypeName() {
            return this.typeName;
        }

        public StaffLabelRecordsQueryResponseBodyContentDataLabels setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class StaffLabelRecordsQueryResponseBodyContentData extends TeaModel {
        @NameInMap("labels")
        public java.util.List<StaffLabelRecordsQueryResponseBodyContentDataLabels> labels;

        /**
         * <strong>example:</strong>
         * <p>0140180438261064274667</p>
         */
        @NameInMap("userId")
        public String userId;

        public static StaffLabelRecordsQueryResponseBodyContentData build(java.util.Map<String, ?> map) throws Exception {
            StaffLabelRecordsQueryResponseBodyContentData self = new StaffLabelRecordsQueryResponseBodyContentData();
            return TeaModel.build(map, self);
        }

        public StaffLabelRecordsQueryResponseBodyContentData setLabels(java.util.List<StaffLabelRecordsQueryResponseBodyContentDataLabels> labels) {
            this.labels = labels;
            return this;
        }
        public java.util.List<StaffLabelRecordsQueryResponseBodyContentDataLabels> getLabels() {
            return this.labels;
        }

        public StaffLabelRecordsQueryResponseBodyContentData setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class StaffLabelRecordsQueryResponseBodyContent extends TeaModel {
        @NameInMap("data")
        public java.util.List<StaffLabelRecordsQueryResponseBodyContentData> data;

        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("maxResults")
        public Long maxResults;

        @NameInMap("nextToken")
        public String nextToken;

        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("totalCountt")
        public Long totalCountt;

        public static StaffLabelRecordsQueryResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            StaffLabelRecordsQueryResponseBodyContent self = new StaffLabelRecordsQueryResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public StaffLabelRecordsQueryResponseBodyContent setData(java.util.List<StaffLabelRecordsQueryResponseBodyContentData> data) {
            this.data = data;
            return this;
        }
        public java.util.List<StaffLabelRecordsQueryResponseBodyContentData> getData() {
            return this.data;
        }

        public StaffLabelRecordsQueryResponseBodyContent setMaxResults(Long maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Long getMaxResults() {
            return this.maxResults;
        }

        public StaffLabelRecordsQueryResponseBodyContent setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public StaffLabelRecordsQueryResponseBodyContent setTotalCountt(Long totalCountt) {
            this.totalCountt = totalCountt;
            return this;
        }
        public Long getTotalCountt() {
            return this.totalCountt;
        }

    }

}
