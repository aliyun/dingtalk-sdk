// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class UpdateDentryAppPropertiesRequest extends TeaModel {
    /**
     * <p>App属性列表 属性不存在时则新增，存在则覆盖原值</p>
     * <p>最大size:</p>
     * <p>	3</p>
     */
    @NameInMap("appProperties")
    public java.util.List<UpdateDentryAppPropertiesRequestAppProperties> appProperties;

    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static UpdateDentryAppPropertiesRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateDentryAppPropertiesRequest self = new UpdateDentryAppPropertiesRequest();
        return TeaModel.build(map, self);
    }

    public UpdateDentryAppPropertiesRequest setAppProperties(java.util.List<UpdateDentryAppPropertiesRequestAppProperties> appProperties) {
        this.appProperties = appProperties;
        return this;
    }
    public java.util.List<UpdateDentryAppPropertiesRequestAppProperties> getAppProperties() {
        return this.appProperties;
    }

    public UpdateDentryAppPropertiesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class UpdateDentryAppPropertiesRequestAppProperties extends TeaModel {
        /**
         * <p>属性名称 该属性名称在当前app下需要保证唯一，不同app间同名属性互不影响</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>属性值</p>
         */
        @NameInMap("value")
        public String value;

        /**
         * <p>属性可见范围</p>
         * <p>枚举值:</p>
         * <p>	PUBLIC: 该属性所有App可见</p>
         * <p>	PRIVATE: 该属性仅其归属App可见</p>
         */
        @NameInMap("visibility")
        public String visibility;

        public static UpdateDentryAppPropertiesRequestAppProperties build(java.util.Map<String, ?> map) throws Exception {
            UpdateDentryAppPropertiesRequestAppProperties self = new UpdateDentryAppPropertiesRequestAppProperties();
            return TeaModel.build(map, self);
        }

        public UpdateDentryAppPropertiesRequestAppProperties setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public UpdateDentryAppPropertiesRequestAppProperties setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public UpdateDentryAppPropertiesRequestAppProperties setVisibility(String visibility) {
            this.visibility = visibility;
            return this;
        }
        public String getVisibility() {
            return this.visibility;
        }

    }

}
