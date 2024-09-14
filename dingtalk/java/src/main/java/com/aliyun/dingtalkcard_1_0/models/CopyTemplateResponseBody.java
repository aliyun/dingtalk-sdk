// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CopyTemplateResponseBody extends TeaModel {
    @NameInMap("data")
    public CopyTemplateResponseBodyData data;

    @NameInMap("success")
    public Boolean success;

    public static CopyTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CopyTemplateResponseBody self = new CopyTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public CopyTemplateResponseBody setData(CopyTemplateResponseBodyData data) {
        this.data = data;
        return this;
    }
    public CopyTemplateResponseBodyData getData() {
        return this.data;
    }

    public CopyTemplateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CopyTemplateResponseBodyData extends TeaModel {
        @NameInMap("templateId")
        public String templateId;

        public static CopyTemplateResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            CopyTemplateResponseBodyData self = new CopyTemplateResponseBodyData();
            return TeaModel.build(map, self);
        }

        public CopyTemplateResponseBodyData setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

    }

}
