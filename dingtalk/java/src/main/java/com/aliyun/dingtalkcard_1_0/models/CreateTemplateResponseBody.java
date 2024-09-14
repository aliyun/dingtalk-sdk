// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CreateTemplateResponseBody extends TeaModel {
    @NameInMap("data")
    public CreateTemplateResponseBodyData data;

    @NameInMap("success")
    public Boolean success;

    public static CreateTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTemplateResponseBody self = new CreateTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTemplateResponseBody setData(CreateTemplateResponseBodyData data) {
        this.data = data;
        return this;
    }
    public CreateTemplateResponseBodyData getData() {
        return this.data;
    }

    public CreateTemplateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateTemplateResponseBodyData extends TeaModel {
        @NameInMap("templateId")
        public String templateId;

        public static CreateTemplateResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            CreateTemplateResponseBodyData self = new CreateTemplateResponseBodyData();
            return TeaModel.build(map, self);
        }

        public CreateTemplateResponseBodyData setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

    }

}
