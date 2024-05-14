// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class UpdateDentryAppPropertiesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appProperties")
    public java.util.List<UpdateDentryAppPropertiesRequestAppProperties> appProperties;

    /**
     * <p>This parameter is required.</p>
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
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        /**
         * <p>This parameter is required.</p>
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
