// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainEmpPoolQueryResponseBody extends TeaModel {
    @NameInMap("content")
    public HrbrainEmpPoolQueryResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static HrbrainEmpPoolQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrbrainEmpPoolQueryResponseBody self = new HrbrainEmpPoolQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public HrbrainEmpPoolQueryResponseBody setContent(HrbrainEmpPoolQueryResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public HrbrainEmpPoolQueryResponseBodyContent getContent() {
        return this.content;
    }

    public HrbrainEmpPoolQueryResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public HrbrainEmpPoolQueryResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public HrbrainEmpPoolQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class HrbrainEmpPoolQueryResponseBodyContentPoolInfosPoolTags extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static HrbrainEmpPoolQueryResponseBodyContentPoolInfosPoolTags build(java.util.Map<String, ?> map) throws Exception {
            HrbrainEmpPoolQueryResponseBodyContentPoolInfosPoolTags self = new HrbrainEmpPoolQueryResponseBodyContentPoolInfosPoolTags();
            return TeaModel.build(map, self);
        }

        public HrbrainEmpPoolQueryResponseBodyContentPoolInfosPoolTags setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public HrbrainEmpPoolQueryResponseBodyContentPoolInfosPoolTags setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class HrbrainEmpPoolQueryResponseBodyContentPoolInfos extends TeaModel {
        @NameInMap("poolCode")
        public String poolCode;

        @NameInMap("poolDesc")
        public String poolDesc;

        @NameInMap("poolName")
        public String poolName;

        @NameInMap("poolTags")
        public java.util.List<HrbrainEmpPoolQueryResponseBodyContentPoolInfosPoolTags> poolTags;

        public static HrbrainEmpPoolQueryResponseBodyContentPoolInfos build(java.util.Map<String, ?> map) throws Exception {
            HrbrainEmpPoolQueryResponseBodyContentPoolInfos self = new HrbrainEmpPoolQueryResponseBodyContentPoolInfos();
            return TeaModel.build(map, self);
        }

        public HrbrainEmpPoolQueryResponseBodyContentPoolInfos setPoolCode(String poolCode) {
            this.poolCode = poolCode;
            return this;
        }
        public String getPoolCode() {
            return this.poolCode;
        }

        public HrbrainEmpPoolQueryResponseBodyContentPoolInfos setPoolDesc(String poolDesc) {
            this.poolDesc = poolDesc;
            return this;
        }
        public String getPoolDesc() {
            return this.poolDesc;
        }

        public HrbrainEmpPoolQueryResponseBodyContentPoolInfos setPoolName(String poolName) {
            this.poolName = poolName;
            return this;
        }
        public String getPoolName() {
            return this.poolName;
        }

        public HrbrainEmpPoolQueryResponseBodyContentPoolInfos setPoolTags(java.util.List<HrbrainEmpPoolQueryResponseBodyContentPoolInfosPoolTags> poolTags) {
            this.poolTags = poolTags;
            return this;
        }
        public java.util.List<HrbrainEmpPoolQueryResponseBodyContentPoolInfosPoolTags> getPoolTags() {
            return this.poolTags;
        }

    }

    public static class HrbrainEmpPoolQueryResponseBodyContent extends TeaModel {
        @NameInMap("maxResults")
        public Integer maxResults;

        @NameInMap("nextToken")
        public Integer nextToken;

        @NameInMap("poolInfos")
        public java.util.List<HrbrainEmpPoolQueryResponseBodyContentPoolInfos> poolInfos;

        @NameInMap("totalCount")
        public Integer totalCount;

        public static HrbrainEmpPoolQueryResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            HrbrainEmpPoolQueryResponseBodyContent self = new HrbrainEmpPoolQueryResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public HrbrainEmpPoolQueryResponseBodyContent setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public HrbrainEmpPoolQueryResponseBodyContent setNextToken(Integer nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public Integer getNextToken() {
            return this.nextToken;
        }

        public HrbrainEmpPoolQueryResponseBodyContent setPoolInfos(java.util.List<HrbrainEmpPoolQueryResponseBodyContentPoolInfos> poolInfos) {
            this.poolInfos = poolInfos;
            return this;
        }
        public java.util.List<HrbrainEmpPoolQueryResponseBodyContentPoolInfos> getPoolInfos() {
            return this.poolInfos;
        }

        public HrbrainEmpPoolQueryResponseBodyContent setTotalCount(Integer totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Integer getTotalCount() {
            return this.totalCount;
        }

    }

}
