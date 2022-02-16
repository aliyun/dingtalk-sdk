// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateTemplateResponseBody extends TeaModel {
    @NameInMap("updateResultList")
    public java.util.List<BatchUpdateTemplateResponseBodyUpdateResultList> updateResultList;

    public static BatchUpdateTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateTemplateResponseBody self = new BatchUpdateTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchUpdateTemplateResponseBody setUpdateResultList(java.util.List<BatchUpdateTemplateResponseBodyUpdateResultList> updateResultList) {
        this.updateResultList = updateResultList;
        return this;
    }
    public java.util.List<BatchUpdateTemplateResponseBodyUpdateResultList> getUpdateResultList() {
        return this.updateResultList;
    }

    public static class BatchUpdateTemplateResponseBodyUpdateResultList extends TeaModel {
        @NameInMap("templateKey")
        public String templateKey;

        @NameInMap("value")
        public String value;

        public static BatchUpdateTemplateResponseBodyUpdateResultList build(java.util.Map<String, ?> map) throws Exception {
            BatchUpdateTemplateResponseBodyUpdateResultList self = new BatchUpdateTemplateResponseBodyUpdateResultList();
            return TeaModel.build(map, self);
        }

        public BatchUpdateTemplateResponseBodyUpdateResultList setTemplateKey(String templateKey) {
            this.templateKey = templateKey;
            return this;
        }
        public String getTemplateKey() {
            return this.templateKey;
        }

        public BatchUpdateTemplateResponseBodyUpdateResultList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
