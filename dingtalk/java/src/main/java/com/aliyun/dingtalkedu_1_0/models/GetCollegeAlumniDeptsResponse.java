// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetCollegeAlumniDeptsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public java.util.List<GetCollegeAlumniDeptsResponseBody> body;

    public static GetCollegeAlumniDeptsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCollegeAlumniDeptsResponse self = new GetCollegeAlumniDeptsResponse();
        return TeaModel.build(map, self);
    }

    public GetCollegeAlumniDeptsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCollegeAlumniDeptsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCollegeAlumniDeptsResponse setBody(java.util.List<GetCollegeAlumniDeptsResponseBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<GetCollegeAlumniDeptsResponseBody> getBody() {
        return this.body;
    }

    public static class GetCollegeAlumniDeptsResponseBody extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("deptId")
        public String deptId;

        @NameInMap("name")
        public String name;

        @NameInMap("superId")
        public String superId;

        @NameInMap("hasSubDept")
        public String hasSubDept;

        @NameInMap("deptType")
        public String deptType;

        public static GetCollegeAlumniDeptsResponseBody build(java.util.Map<String, ?> map) throws Exception {
            GetCollegeAlumniDeptsResponseBody self = new GetCollegeAlumniDeptsResponseBody();
            return TeaModel.build(map, self);
        }

        public GetCollegeAlumniDeptsResponseBody setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetCollegeAlumniDeptsResponseBody setDeptId(String deptId) {
            this.deptId = deptId;
            return this;
        }
        public String getDeptId() {
            return this.deptId;
        }

        public GetCollegeAlumniDeptsResponseBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetCollegeAlumniDeptsResponseBody setSuperId(String superId) {
            this.superId = superId;
            return this;
        }
        public String getSuperId() {
            return this.superId;
        }

        public GetCollegeAlumniDeptsResponseBody setHasSubDept(String hasSubDept) {
            this.hasSubDept = hasSubDept;
            return this;
        }
        public String getHasSubDept() {
            return this.hasSubDept;
        }

        public GetCollegeAlumniDeptsResponseBody setDeptType(String deptType) {
            this.deptType = deptType;
            return this;
        }
        public String getDeptType() {
            return this.deptType;
        }

    }

}
