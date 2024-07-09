// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class StaffLabelRecordsQueryRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<StaffLabelRecordsQueryRequestBody> body;

    /**
     * <strong>example:</strong>
     * <p>0140180438261064274667</p>
     */
    @NameInMap("dingCorpId")
    public String dingCorpId;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    public static StaffLabelRecordsQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        StaffLabelRecordsQueryRequest self = new StaffLabelRecordsQueryRequest();
        return TeaModel.build(map, self);
    }

    public StaffLabelRecordsQueryRequest setBody(java.util.List<StaffLabelRecordsQueryRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<StaffLabelRecordsQueryRequestBody> getBody() {
        return this.body;
    }

    public StaffLabelRecordsQueryRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public StaffLabelRecordsQueryRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public StaffLabelRecordsQueryRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class StaffLabelRecordsQueryRequestBodyLabels extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>long_termism_score</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <strong>example:</strong>
         * <p>values</p>
         */
        @NameInMap("typeCode")
        public String typeCode;

        public static StaffLabelRecordsQueryRequestBodyLabels build(java.util.Map<String, ?> map) throws Exception {
            StaffLabelRecordsQueryRequestBodyLabels self = new StaffLabelRecordsQueryRequestBodyLabels();
            return TeaModel.build(map, self);
        }

        public StaffLabelRecordsQueryRequestBodyLabels setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public StaffLabelRecordsQueryRequestBodyLabels setTypeCode(String typeCode) {
            this.typeCode = typeCode;
            return this;
        }
        public String getTypeCode() {
            return this.typeCode;
        }

    }

    public static class StaffLabelRecordsQueryRequestBody extends TeaModel {
        @NameInMap("labels")
        public java.util.List<StaffLabelRecordsQueryRequestBodyLabels> labels;

        /**
         * <strong>example:</strong>
         * <p>0140180438261064274667</p>
         */
        @NameInMap("userId")
        public String userId;

        public static StaffLabelRecordsQueryRequestBody build(java.util.Map<String, ?> map) throws Exception {
            StaffLabelRecordsQueryRequestBody self = new StaffLabelRecordsQueryRequestBody();
            return TeaModel.build(map, self);
        }

        public StaffLabelRecordsQueryRequestBody setLabels(java.util.List<StaffLabelRecordsQueryRequestBodyLabels> labels) {
            this.labels = labels;
            return this;
        }
        public java.util.List<StaffLabelRecordsQueryRequestBodyLabels> getLabels() {
            return this.labels;
        }

        public StaffLabelRecordsQueryRequestBody setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
