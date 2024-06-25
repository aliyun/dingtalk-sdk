// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddCollegeAlumniDeptsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public java.util.List<AddCollegeAlumniDeptsResponseBody> body;

    public static AddCollegeAlumniDeptsResponse build(java.util.Map<String, ?> map) throws Exception {
        AddCollegeAlumniDeptsResponse self = new AddCollegeAlumniDeptsResponse();
        return TeaModel.build(map, self);
    }

    public AddCollegeAlumniDeptsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddCollegeAlumniDeptsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddCollegeAlumniDeptsResponse setBody(java.util.List<AddCollegeAlumniDeptsResponseBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<AddCollegeAlumniDeptsResponseBody> getBody() {
        return this.body;
    }

    public static class AddCollegeAlumniDeptsResponseBody extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("name")
        public String name;

        @NameInMap("superId")
        public Long superId;

        @NameInMap("hasSubDept")
        public Boolean hasSubDept;

        @NameInMap("deptType")
        public String deptType;

        public static AddCollegeAlumniDeptsResponseBody build(java.util.Map<String, ?> map) throws Exception {
            AddCollegeAlumniDeptsResponseBody self = new AddCollegeAlumniDeptsResponseBody();
            return TeaModel.build(map, self);
        }

        public AddCollegeAlumniDeptsResponseBody setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public AddCollegeAlumniDeptsResponseBody setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public AddCollegeAlumniDeptsResponseBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public AddCollegeAlumniDeptsResponseBody setSuperId(Long superId) {
            this.superId = superId;
            return this;
        }
        public Long getSuperId() {
            return this.superId;
        }

        public AddCollegeAlumniDeptsResponseBody setHasSubDept(Boolean hasSubDept) {
            this.hasSubDept = hasSubDept;
            return this;
        }
        public Boolean getHasSubDept() {
            return this.hasSubDept;
        }

        public AddCollegeAlumniDeptsResponseBody setDeptType(String deptType) {
            this.deptType = deptType;
            return this;
        }
        public String getDeptType() {
            return this.deptType;
        }

    }

}
