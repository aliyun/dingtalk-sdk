// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectByTemplateResponseBody extends TeaModel {
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
        /**
         * <strong>example:</strong>
         * <p>2022-08-01T09:50:31.275Z</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <strong>example:</strong>
         * <p>62e7a1e721d20b5aexxx</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p><a href="https://www.xxx.com/xxxxx">https://www.xxx.com/xxxxx</a></p>
         */
        @NameInMap("logo")
        public String logo;

        /**
         * <strong>example:</strong>
         * <p>项目1</p>
         */
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
