// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class ExecuteActivityRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("activityCode")
    public String activityCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("foreignId")
    public String foreignId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("foreignName")
    public String foreignName;

    /**
     * <strong>example:</strong>
     * <p>default</p>
     */
    @NameInMap("openInstanceId")
    public String openInstanceId;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("productionType")
    public Integer productionType;

    @NameInMap("properties")
    public java.util.List<ExecuteActivityRequestProperties> properties;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dcd6cb6b-b537-493c-8953-3507700e9c4b</p>
     */
    @NameInMap("sourceId")
    public String sourceId;

    public static ExecuteActivityRequest build(java.util.Map<String, ?> map) throws Exception {
        ExecuteActivityRequest self = new ExecuteActivityRequest();
        return TeaModel.build(map, self);
    }

    public ExecuteActivityRequest setActivityCode(String activityCode) {
        this.activityCode = activityCode;
        return this;
    }
    public String getActivityCode() {
        return this.activityCode;
    }

    public ExecuteActivityRequest setForeignId(String foreignId) {
        this.foreignId = foreignId;
        return this;
    }
    public String getForeignId() {
        return this.foreignId;
    }

    public ExecuteActivityRequest setForeignName(String foreignName) {
        this.foreignName = foreignName;
        return this;
    }
    public String getForeignName() {
        return this.foreignName;
    }

    public ExecuteActivityRequest setOpenInstanceId(String openInstanceId) {
        this.openInstanceId = openInstanceId;
        return this;
    }
    public String getOpenInstanceId() {
        return this.openInstanceId;
    }

    public ExecuteActivityRequest setProductionType(Integer productionType) {
        this.productionType = productionType;
        return this;
    }
    public Integer getProductionType() {
        return this.productionType;
    }

    public ExecuteActivityRequest setProperties(java.util.List<ExecuteActivityRequestProperties> properties) {
        this.properties = properties;
        return this;
    }
    public java.util.List<ExecuteActivityRequestProperties> getProperties() {
        return this.properties;
    }

    public ExecuteActivityRequest setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public static class ExecuteActivityRequestProperties extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static ExecuteActivityRequestProperties build(java.util.Map<String, ?> map) throws Exception {
            ExecuteActivityRequestProperties self = new ExecuteActivityRequestProperties();
            return TeaModel.build(map, self);
        }

        public ExecuteActivityRequestProperties setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ExecuteActivityRequestProperties setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
