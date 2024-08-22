// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetRelatedViewTabMetaResponseBody extends TeaModel {
    @NameInMap("results")
    public java.util.List<GetRelatedViewTabMetaResponseBodyResults> results;

    public static GetRelatedViewTabMetaResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRelatedViewTabMetaResponseBody self = new GetRelatedViewTabMetaResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRelatedViewTabMetaResponseBody setResults(java.util.List<GetRelatedViewTabMetaResponseBodyResults> results) {
        this.results = results;
        return this;
    }
    public java.util.List<GetRelatedViewTabMetaResponseBodyResults> getResults() {
        return this.results;
    }

    public static class GetRelatedViewTabMetaResponseBodyResults extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>PROC-4EFE895D-A291-4A65-9FD6-99431604DF67</p>
         */
        @NameInMap("formCode")
        public String formCode;

        /**
         * <strong>example:</strong>
         * <p>OpenDataField_K99RPMMRGJ40</p>
         */
        @NameInMap("relateComponentId")
        public String relateComponentId;

        /**
         * <strong>example:</strong>
         * <p>212</p>
         */
        @NameInMap("tabTitle")
        public String tabTitle;

        public static GetRelatedViewTabMetaResponseBodyResults build(java.util.Map<String, ?> map) throws Exception {
            GetRelatedViewTabMetaResponseBodyResults self = new GetRelatedViewTabMetaResponseBodyResults();
            return TeaModel.build(map, self);
        }

        public GetRelatedViewTabMetaResponseBodyResults setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

        public GetRelatedViewTabMetaResponseBodyResults setRelateComponentId(String relateComponentId) {
            this.relateComponentId = relateComponentId;
            return this;
        }
        public String getRelateComponentId() {
            return this.relateComponentId;
        }

        public GetRelatedViewTabMetaResponseBodyResults setTabTitle(String tabTitle) {
            this.tabTitle = tabTitle;
            return this;
        }
        public String getTabTitle() {
            return this.tabTitle;
        }

    }

}
