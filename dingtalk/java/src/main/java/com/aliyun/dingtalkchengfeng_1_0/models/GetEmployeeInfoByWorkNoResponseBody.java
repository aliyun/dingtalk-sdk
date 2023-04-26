// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetEmployeeInfoByWorkNoResponseBody extends TeaModel {
    @NameInMap("content")
    public GetEmployeeInfoByWorkNoResponseBodyContent content;

    @NameInMap("success")
    public Boolean success;

    public static GetEmployeeInfoByWorkNoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetEmployeeInfoByWorkNoResponseBody self = new GetEmployeeInfoByWorkNoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetEmployeeInfoByWorkNoResponseBody setContent(GetEmployeeInfoByWorkNoResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public GetEmployeeInfoByWorkNoResponseBodyContent getContent() {
        return this.content;
    }

    public GetEmployeeInfoByWorkNoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetEmployeeInfoByWorkNoResponseBodyContent extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("workNo")
        public String workNo;

        public static GetEmployeeInfoByWorkNoResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            GetEmployeeInfoByWorkNoResponseBodyContent self = new GetEmployeeInfoByWorkNoResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public GetEmployeeInfoByWorkNoResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetEmployeeInfoByWorkNoResponseBodyContent setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
