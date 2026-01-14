// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelTaskDataResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<HrbrainLabelTaskDataResponseBodyContent> content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static HrbrainLabelTaskDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelTaskDataResponseBody self = new HrbrainLabelTaskDataResponseBody();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelTaskDataResponseBody setContent(java.util.List<HrbrainLabelTaskDataResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<HrbrainLabelTaskDataResponseBodyContent> getContent() {
        return this.content;
    }

    public HrbrainLabelTaskDataResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public HrbrainLabelTaskDataResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public HrbrainLabelTaskDataResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class HrbrainLabelTaskDataResponseBodyContentTags extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("description")
        public String description;

        @NameInMap("name")
        public String name;

        @NameInMap("values")
        public java.util.List<String> values;

        public static HrbrainLabelTaskDataResponseBodyContentTags build(java.util.Map<String, ?> map) throws Exception {
            HrbrainLabelTaskDataResponseBodyContentTags self = new HrbrainLabelTaskDataResponseBodyContentTags();
            return TeaModel.build(map, self);
        }

        public HrbrainLabelTaskDataResponseBodyContentTags setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public HrbrainLabelTaskDataResponseBodyContentTags setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public HrbrainLabelTaskDataResponseBodyContentTags setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainLabelTaskDataResponseBodyContentTags setValues(java.util.List<String> values) {
            this.values = values;
            return this;
        }
        public java.util.List<String> getValues() {
            return this.values;
        }

    }

    public static class HrbrainLabelTaskDataResponseBodyContent extends TeaModel {
        @NameInMap("deptName")
        public String deptName;

        @NameInMap("deptNo")
        public String deptNo;

        @NameInMap("name")
        public String name;

        @NameInMap("tags")
        public java.util.List<HrbrainLabelTaskDataResponseBodyContentTags> tags;

        @NameInMap("workNo")
        public String workNo;

        public static HrbrainLabelTaskDataResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            HrbrainLabelTaskDataResponseBodyContent self = new HrbrainLabelTaskDataResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public HrbrainLabelTaskDataResponseBodyContent setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public HrbrainLabelTaskDataResponseBodyContent setDeptNo(String deptNo) {
            this.deptNo = deptNo;
            return this;
        }
        public String getDeptNo() {
            return this.deptNo;
        }

        public HrbrainLabelTaskDataResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainLabelTaskDataResponseBodyContent setTags(java.util.List<HrbrainLabelTaskDataResponseBodyContentTags> tags) {
            this.tags = tags;
            return this;
        }
        public java.util.List<HrbrainLabelTaskDataResponseBodyContentTags> getTags() {
            return this.tags;
        }

        public HrbrainLabelTaskDataResponseBodyContent setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
