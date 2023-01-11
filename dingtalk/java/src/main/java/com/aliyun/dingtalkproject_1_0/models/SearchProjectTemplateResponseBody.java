// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectTemplateResponseBody extends TeaModel {
    /**
     * <p>返回结果对象</p>
     */
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
         * <p>创建时间</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <p>模板描述</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>模板id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>是否已删除</p>
         */
        @NameInMap("isDeleted")
        public Boolean isDeleted;

        /**
         * <p>是否demo模板</p>
         */
        @NameInMap("isDemo")
        public Boolean isDemo;

        /**
         * <p>模板log地址</p>
         */
        @NameInMap("logo")
        public String logo;

        /**
         * <p>模板名字</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>更新时间</p>
         */
        @NameInMap("updated")
        public String updated;

        /**
         * <p>模板可见性。organization 或者 involves</p>
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
