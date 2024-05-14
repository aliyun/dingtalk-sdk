// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateTemplateResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("createResultList")
    public java.util.List<BatchCreateTemplateResponseBodyCreateResultList> createResultList;

    public static BatchCreateTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateTemplateResponseBody self = new BatchCreateTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchCreateTemplateResponseBody setCreateResultList(java.util.List<BatchCreateTemplateResponseBodyCreateResultList> createResultList) {
        this.createResultList = createResultList;
        return this;
    }
    public java.util.List<BatchCreateTemplateResponseBodyCreateResultList> getCreateResultList() {
        return this.createResultList;
    }

    public static class BatchCreateTemplateResponseBodyCreateResultList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("templateKey")
        public String templateKey;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        public static BatchCreateTemplateResponseBodyCreateResultList build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateTemplateResponseBodyCreateResultList self = new BatchCreateTemplateResponseBodyCreateResultList();
            return TeaModel.build(map, self);
        }

        public BatchCreateTemplateResponseBodyCreateResultList setTemplateKey(String templateKey) {
            this.templateKey = templateKey;
            return this;
        }
        public String getTemplateKey() {
            return this.templateKey;
        }

        public BatchCreateTemplateResponseBodyCreateResultList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
