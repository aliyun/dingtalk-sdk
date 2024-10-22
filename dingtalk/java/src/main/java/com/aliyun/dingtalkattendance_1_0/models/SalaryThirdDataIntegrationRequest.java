// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class SalaryThirdDataIntegrationRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>atData</p>
     */
    @NameInMap("bizType")
    public String bizType;

    @NameInMap("items")
    public java.util.List<SalaryThirdDataIntegrationRequestItems> items;

    public static SalaryThirdDataIntegrationRequest build(java.util.Map<String, ?> map) throws Exception {
        SalaryThirdDataIntegrationRequest self = new SalaryThirdDataIntegrationRequest();
        return TeaModel.build(map, self);
    }

    public SalaryThirdDataIntegrationRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public SalaryThirdDataIntegrationRequest setItems(java.util.List<SalaryThirdDataIntegrationRequestItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<SalaryThirdDataIntegrationRequestItems> getItems() {
        return this.items;
    }

    public static class SalaryThirdDataIntegrationRequestItemsBizContents extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>工作时长</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <strong>example:</strong>
         * <p>9</p>
         */
        @NameInMap("value")
        public String value;

        public static SalaryThirdDataIntegrationRequestItemsBizContents build(java.util.Map<String, ?> map) throws Exception {
            SalaryThirdDataIntegrationRequestItemsBizContents self = new SalaryThirdDataIntegrationRequestItemsBizContents();
            return TeaModel.build(map, self);
        }

        public SalaryThirdDataIntegrationRequestItemsBizContents setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public SalaryThirdDataIntegrationRequestItemsBizContents setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class SalaryThirdDataIntegrationRequestItems extends TeaModel {
        @NameInMap("bizContents")
        public java.util.List<SalaryThirdDataIntegrationRequestItemsBizContents> bizContents;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizDate")
        public String bizDate;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>100001</p>
         */
        @NameInMap("bizId")
        public String bizId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>user001</p>
         */
        @NameInMap("userId")
        public String userId;

        public static SalaryThirdDataIntegrationRequestItems build(java.util.Map<String, ?> map) throws Exception {
            SalaryThirdDataIntegrationRequestItems self = new SalaryThirdDataIntegrationRequestItems();
            return TeaModel.build(map, self);
        }

        public SalaryThirdDataIntegrationRequestItems setBizContents(java.util.List<SalaryThirdDataIntegrationRequestItemsBizContents> bizContents) {
            this.bizContents = bizContents;
            return this;
        }
        public java.util.List<SalaryThirdDataIntegrationRequestItemsBizContents> getBizContents() {
            return this.bizContents;
        }

        public SalaryThirdDataIntegrationRequestItems setBizDate(String bizDate) {
            this.bizDate = bizDate;
            return this;
        }
        public String getBizDate() {
            return this.bizDate;
        }

        public SalaryThirdDataIntegrationRequestItems setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public SalaryThirdDataIntegrationRequestItems setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
