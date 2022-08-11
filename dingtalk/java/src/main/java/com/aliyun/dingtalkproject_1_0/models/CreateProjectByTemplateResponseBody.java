// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectByTemplateResponseBody extends TeaModel {
    // 返回结果对象
    @NameInMap("result")
    public CreateProjectByTemplateResponseBodyResult result;

    public static CreateProjectByTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateProjectByTemplateResponseBody self = new CreateProjectByTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateProjectByTemplateResponseBody setResult(CreateProjectByTemplateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateProjectByTemplateResponseBodyResult getResult() {
        return this.result;
    }

    public static class CreateProjectByTemplateResponseBodyResult extends TeaModel {
        // 创建时间
        @NameInMap("created")
        public String created;

        // 项目ID
        @NameInMap("id")
        public String id;

        // 项目图标地址
        @NameInMap("logo")
        public String logo;

        // 项目名字
        @NameInMap("name")
        public String name;

        public static CreateProjectByTemplateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateProjectByTemplateResponseBodyResult self = new CreateProjectByTemplateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateProjectByTemplateResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public CreateProjectByTemplateResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateProjectByTemplateResponseBodyResult setLogo(String logo) {
            this.logo = logo;
            return this;
        }
        public String getLogo() {
            return this.logo;
        }

        public CreateProjectByTemplateResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
