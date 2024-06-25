// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectTemplateResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<SearchProjectTemplateResponseBodyResult> result;

    public static SearchProjectTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchProjectTemplateResponseBody self = new SearchProjectTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchProjectTemplateResponseBody setResult(java.util.List<SearchProjectTemplateResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<SearchProjectTemplateResponseBodyResult> getResult() {
        return this.result;
    }

    public static class SearchProjectTemplateResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2022-06-13T07:36:50.318Z</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <strong>example:</strong>
         * <p>我是描述内容</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <strong>example:</strong>
         * <p>62e0a88c0axxxx</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("isDeleted")
        public Boolean isDeleted;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("isDemo")
        public Boolean isDemo;

        /**
         * <strong>example:</strong>
         * <p><a href="https://www.xxx.com/xxxx">https://www.xxx.com/xxxx</a></p>
         */
        @NameInMap("logo")
        public String logo;

        /**
         * <strong>example:</strong>
         * <p>模板1</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>2022-06-13T07:36:50.318Z</p>
         */
        @NameInMap("updated")
        public String updated;

        /**
         * <strong>example:</strong>
         * <p>organization</p>
         */
        @NameInMap("visible")
        public String visible;

        public static SearchProjectTemplateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SearchProjectTemplateResponseBodyResult self = new SearchProjectTemplateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SearchProjectTemplateResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public SearchProjectTemplateResponseBodyResult setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public SearchProjectTemplateResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SearchProjectTemplateResponseBodyResult setIsDeleted(Boolean isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Boolean getIsDeleted() {
            return this.isDeleted;
        }

        public SearchProjectTemplateResponseBodyResult setIsDemo(Boolean isDemo) {
            this.isDemo = isDemo;
            return this;
        }
        public Boolean getIsDemo() {
            return this.isDemo;
        }

        public SearchProjectTemplateResponseBodyResult setLogo(String logo) {
            this.logo = logo;
            return this;
        }
        public String getLogo() {
            return this.logo;
        }

        public SearchProjectTemplateResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchProjectTemplateResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

        public SearchProjectTemplateResponseBodyResult setVisible(String visible) {
            this.visible = visible;
            return this;
        }
        public String getVisible() {
            return this.visible;
        }

    }

}
