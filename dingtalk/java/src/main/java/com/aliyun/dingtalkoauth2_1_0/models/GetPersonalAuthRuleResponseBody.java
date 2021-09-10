// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetPersonalAuthRuleResponseBody extends TeaModel {
    // list
    @NameInMap("result")
    public java.util.List<GetPersonalAuthRuleResponseBodyResult> result;

    public static GetPersonalAuthRuleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPersonalAuthRuleResponseBody self = new GetPersonalAuthRuleResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPersonalAuthRuleResponseBody setResult(java.util.List<GetPersonalAuthRuleResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetPersonalAuthRuleResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetPersonalAuthRuleResponseBodyResult extends TeaModel {
        // resource
        @NameInMap("resource")
        public String resource;

        // authItems
        @NameInMap("authItems")
        public java.util.List<String> authItems;

        public static GetPersonalAuthRuleResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetPersonalAuthRuleResponseBodyResult self = new GetPersonalAuthRuleResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetPersonalAuthRuleResponseBodyResult setResource(String resource) {
            this.resource = resource;
            return this;
        }
        public String getResource() {
            return this.resource;
        }

        public GetPersonalAuthRuleResponseBodyResult setAuthItems(java.util.List<String> authItems) {
            this.authItems = authItems;
            return this;
        }
        public java.util.List<String> getAuthItems() {
            return this.authItems;
        }

    }

}
