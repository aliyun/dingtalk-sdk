// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetRelatedViewTabMetaResponseBody extends TeaModel {
    @NameInMap("baseViewTabModels")
    public java.util.List<GetRelatedViewTabMetaResponseBodyBaseViewTabModels> baseViewTabModels;

    public static GetRelatedViewTabMetaResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRelatedViewTabMetaResponseBody self = new GetRelatedViewTabMetaResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRelatedViewTabMetaResponseBody setBaseViewTabModels(java.util.List<GetRelatedViewTabMetaResponseBodyBaseViewTabModels> baseViewTabModels) {
        this.baseViewTabModels = baseViewTabModels;
        return this;
    }
    public java.util.List<GetRelatedViewTabMetaResponseBodyBaseViewTabModels> getBaseViewTabModels() {
        return this.baseViewTabModels;
    }

    public static class GetRelatedViewTabMetaResponseBodyBaseViewTabModels extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>PROC-C9EA3AB8-8BCD-4FAD-857D-18D579663366</p>
         */
        @NameInMap("formCode")
        public String formCode;

        /**
         * <strong>example:</strong>
         * <p>OpenDataField_S0RIE8G0YAKG&quot;,             &quot;sourceFormUuid&quot;: &quot;PROC-C9EA3AB8-8BCD-4FAD-857D-18D579663366</p>
         */
        @NameInMap("relateComponentId")
        public String relateComponentId;

        /**
         * <strong>example:</strong>
         * <p>楚衣的流程表单1</p>
         */
        @NameInMap("tabTitle")
        public String tabTitle;

        public static GetRelatedViewTabMetaResponseBodyBaseViewTabModels build(java.util.Map<String, ?> map) throws Exception {
            GetRelatedViewTabMetaResponseBodyBaseViewTabModels self = new GetRelatedViewTabMetaResponseBodyBaseViewTabModels();
            return TeaModel.build(map, self);
        }

        public GetRelatedViewTabMetaResponseBodyBaseViewTabModels setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

        public GetRelatedViewTabMetaResponseBodyBaseViewTabModels setRelateComponentId(String relateComponentId) {
            this.relateComponentId = relateComponentId;
            return this;
        }
        public String getRelateComponentId() {
            return this.relateComponentId;
        }

        public GetRelatedViewTabMetaResponseBodyBaseViewTabModels setTabTitle(String tabTitle) {
            this.tabTitle = tabTitle;
            return this;
        }
        public String getTabTitle() {
            return this.tabTitle;
        }

    }

}
