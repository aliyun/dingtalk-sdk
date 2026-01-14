// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelCategoryTreeResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<HrbrainLabelCategoryTreeResponseBodyContent> content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static HrbrainLabelCategoryTreeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelCategoryTreeResponseBody self = new HrbrainLabelCategoryTreeResponseBody();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelCategoryTreeResponseBody setContent(java.util.List<HrbrainLabelCategoryTreeResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<HrbrainLabelCategoryTreeResponseBodyContent> getContent() {
        return this.content;
    }

    public HrbrainLabelCategoryTreeResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public HrbrainLabelCategoryTreeResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public HrbrainLabelCategoryTreeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class HrbrainLabelCategoryTreeResponseBodyContent extends TeaModel {
        @NameInMap("children")
        public java.util.List<java.util.Map<String, ?>> children;

        @NameInMap("code")
        public String code;

        @NameInMap("currentLabelNum")
        public Long currentLabelNum;

        @NameInMap("name")
        public String name;

        @NameInMap("pcode")
        public String pcode;

        @NameInMap("sortSize")
        public Long sortSize;

        @NameInMap("totalLabelNum")
        public Long totalLabelNum;

        public static HrbrainLabelCategoryTreeResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            HrbrainLabelCategoryTreeResponseBodyContent self = new HrbrainLabelCategoryTreeResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public HrbrainLabelCategoryTreeResponseBodyContent setChildren(java.util.List<java.util.Map<String, ?>> children) {
            this.children = children;
            return this;
        }
        public java.util.List<java.util.Map<String, ?>> getChildren() {
            return this.children;
        }

        public HrbrainLabelCategoryTreeResponseBodyContent setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public HrbrainLabelCategoryTreeResponseBodyContent setCurrentLabelNum(Long currentLabelNum) {
            this.currentLabelNum = currentLabelNum;
            return this;
        }
        public Long getCurrentLabelNum() {
            return this.currentLabelNum;
        }

        public HrbrainLabelCategoryTreeResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainLabelCategoryTreeResponseBodyContent setPcode(String pcode) {
            this.pcode = pcode;
            return this;
        }
        public String getPcode() {
            return this.pcode;
        }

        public HrbrainLabelCategoryTreeResponseBodyContent setSortSize(Long sortSize) {
            this.sortSize = sortSize;
            return this;
        }
        public Long getSortSize() {
            return this.sortSize;
        }

        public HrbrainLabelCategoryTreeResponseBodyContent setTotalLabelNum(Long totalLabelNum) {
            this.totalLabelNum = totalLabelNum;
            return this;
        }
        public Long getTotalLabelNum() {
            return this.totalLabelNum;
        }

    }

}
