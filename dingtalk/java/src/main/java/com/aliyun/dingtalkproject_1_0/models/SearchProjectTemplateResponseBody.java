// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectTemplateResponseBody extends TeaModel {
    // 返回结果对象
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
        // 创建时间
        @NameInMap("created")
        public String created;

        // 模板描述
        @NameInMap("description")
        public String description;

        // 模板id
        @NameInMap("id")
        public String id;

        // 是否已删除
        @NameInMap("isDeleted")
        public Boolean isDeleted;

        // 是否demo模板
        @NameInMap("isDemo")
        public Boolean isDemo;

        // 模板log地址
        @NameInMap("logo")
        public String logo;

        // 模板名字
        @NameInMap("name")
        public String name;

        // 更新时间
        @NameInMap("updated")
        public String updated;

        // 模板可见性。organization 或者 involves
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
