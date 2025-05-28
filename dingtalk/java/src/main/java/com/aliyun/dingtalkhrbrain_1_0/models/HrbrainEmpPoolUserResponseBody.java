// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainEmpPoolUserResponseBody extends TeaModel {
    @NameInMap("content")
    public HrbrainEmpPoolUserResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static HrbrainEmpPoolUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrbrainEmpPoolUserResponseBody self = new HrbrainEmpPoolUserResponseBody();
        return TeaModel.build(map, self);
    }

    public HrbrainEmpPoolUserResponseBody setContent(HrbrainEmpPoolUserResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public HrbrainEmpPoolUserResponseBodyContent getContent() {
        return this.content;
    }

    public HrbrainEmpPoolUserResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public HrbrainEmpPoolUserResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public HrbrainEmpPoolUserResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class HrbrainEmpPoolUserResponseBodyContentEmpVos extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static HrbrainEmpPoolUserResponseBodyContentEmpVos build(java.util.Map<String, ?> map) throws Exception {
            HrbrainEmpPoolUserResponseBodyContentEmpVos self = new HrbrainEmpPoolUserResponseBodyContentEmpVos();
            return TeaModel.build(map, self);
        }

        public HrbrainEmpPoolUserResponseBodyContentEmpVos setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainEmpPoolUserResponseBodyContentEmpVos setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class HrbrainEmpPoolUserResponseBodyContent extends TeaModel {
        @NameInMap("empVos")
        public java.util.List<HrbrainEmpPoolUserResponseBodyContentEmpVos> empVos;

        @NameInMap("maxResults")
        public Integer maxResults;

        @NameInMap("nextToken")
        public Integer nextToken;

        @NameInMap("totalCount")
        public Integer totalCount;

        public static HrbrainEmpPoolUserResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            HrbrainEmpPoolUserResponseBodyContent self = new HrbrainEmpPoolUserResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public HrbrainEmpPoolUserResponseBodyContent setEmpVos(java.util.List<HrbrainEmpPoolUserResponseBodyContentEmpVos> empVos) {
            this.empVos = empVos;
            return this;
        }
        public java.util.List<HrbrainEmpPoolUserResponseBodyContentEmpVos> getEmpVos() {
            return this.empVos;
        }

        public HrbrainEmpPoolUserResponseBodyContent setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public HrbrainEmpPoolUserResponseBodyContent setNextToken(Integer nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public Integer getNextToken() {
            return this.nextToken;
        }

        public HrbrainEmpPoolUserResponseBodyContent setTotalCount(Integer totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Integer getTotalCount() {
            return this.totalCount;
        }

    }

}
