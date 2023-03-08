// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryDevicePropertiesResponseBody extends TeaModel {
    /**
     * <p>响应结果</p>
     */
    @NameInMap("result")
    public java.util.List<QueryDevicePropertiesResponseBodyResult> result;

    public static QueryDevicePropertiesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDevicePropertiesResponseBody self = new QueryDevicePropertiesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDevicePropertiesResponseBody setResult(java.util.List<QueryDevicePropertiesResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryDevicePropertiesResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryDevicePropertiesResponseBodyResult extends TeaModel {
        /**
         * <p>设备属性名称</p>
         */
        @NameInMap("propertyName")
        public String propertyName;

        /**
         * <p>设备属性值</p>
         */
        @NameInMap("propertyValue")
        public String propertyValue;

        public static QueryDevicePropertiesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryDevicePropertiesResponseBodyResult self = new QueryDevicePropertiesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryDevicePropertiesResponseBodyResult setPropertyName(String propertyName) {
            this.propertyName = propertyName;
            return this;
        }
        public String getPropertyName() {
            return this.propertyName;
        }

        public QueryDevicePropertiesResponseBodyResult setPropertyValue(String propertyValue) {
            this.propertyValue = propertyValue;
            return this;
        }
        public String getPropertyValue() {
            return this.propertyValue;
        }

    }

}
