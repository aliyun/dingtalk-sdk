// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetCustomerInsightResponseBody extends TeaModel {
    @NameInMap("result")
    public GetCustomerInsightResponseBodyResult result;

    public static GetCustomerInsightResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCustomerInsightResponseBody self = new GetCustomerInsightResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCustomerInsightResponseBody setResult(GetCustomerInsightResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetCustomerInsightResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetCustomerInsightResponseBodyResultIntention extends TeaModel {
        @NameInMap("description")
        public String description;

        @NameInMap("intention")
        public String intention;

        public static GetCustomerInsightResponseBodyResultIntention build(java.util.Map<String, ?> map) throws Exception {
            GetCustomerInsightResponseBodyResultIntention self = new GetCustomerInsightResponseBodyResultIntention();
            return TeaModel.build(map, self);
        }

        public GetCustomerInsightResponseBodyResultIntention setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetCustomerInsightResponseBodyResultIntention setIntention(String intention) {
            this.intention = intention;
            return this;
        }
        public String getIntention() {
            return this.intention;
        }

    }

    public static class GetCustomerInsightResponseBodyResultTagAiTag extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static GetCustomerInsightResponseBodyResultTagAiTag build(java.util.Map<String, ?> map) throws Exception {
            GetCustomerInsightResponseBodyResultTagAiTag self = new GetCustomerInsightResponseBodyResultTagAiTag();
            return TeaModel.build(map, self);
        }

        public GetCustomerInsightResponseBodyResultTagAiTag setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetCustomerInsightResponseBodyResultTagAiTag setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetCustomerInsightResponseBodyResultTagAiTag setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetCustomerInsightResponseBodyResultTagUserTag extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("value")
        public String value;

        public static GetCustomerInsightResponseBodyResultTagUserTag build(java.util.Map<String, ?> map) throws Exception {
            GetCustomerInsightResponseBodyResultTagUserTag self = new GetCustomerInsightResponseBodyResultTagUserTag();
            return TeaModel.build(map, self);
        }

        public GetCustomerInsightResponseBodyResultTagUserTag setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetCustomerInsightResponseBodyResultTagUserTag setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetCustomerInsightResponseBodyResultTag extends TeaModel {
        @NameInMap("aiTag")
        public java.util.List<GetCustomerInsightResponseBodyResultTagAiTag> aiTag;

        @NameInMap("userTag")
        public java.util.List<GetCustomerInsightResponseBodyResultTagUserTag> userTag;

        public static GetCustomerInsightResponseBodyResultTag build(java.util.Map<String, ?> map) throws Exception {
            GetCustomerInsightResponseBodyResultTag self = new GetCustomerInsightResponseBodyResultTag();
            return TeaModel.build(map, self);
        }

        public GetCustomerInsightResponseBodyResultTag setAiTag(java.util.List<GetCustomerInsightResponseBodyResultTagAiTag> aiTag) {
            this.aiTag = aiTag;
            return this;
        }
        public java.util.List<GetCustomerInsightResponseBodyResultTagAiTag> getAiTag() {
            return this.aiTag;
        }

        public GetCustomerInsightResponseBodyResultTag setUserTag(java.util.List<GetCustomerInsightResponseBodyResultTagUserTag> userTag) {
            this.userTag = userTag;
            return this;
        }
        public java.util.List<GetCustomerInsightResponseBodyResultTagUserTag> getUserTag() {
            return this.userTag;
        }

    }

    public static class GetCustomerInsightResponseBodyResult extends TeaModel {
        @NameInMap("intention")
        public GetCustomerInsightResponseBodyResultIntention intention;

        @NameInMap("tag")
        public GetCustomerInsightResponseBodyResultTag tag;

        public static GetCustomerInsightResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetCustomerInsightResponseBodyResult self = new GetCustomerInsightResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetCustomerInsightResponseBodyResult setIntention(GetCustomerInsightResponseBodyResultIntention intention) {
            this.intention = intention;
            return this;
        }
        public GetCustomerInsightResponseBodyResultIntention getIntention() {
            return this.intention;
        }

        public GetCustomerInsightResponseBodyResult setTag(GetCustomerInsightResponseBodyResultTag tag) {
            this.tag = tag;
            return this;
        }
        public GetCustomerInsightResponseBodyResultTag getTag() {
            return this.tag;
        }

    }

}
