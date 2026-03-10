// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class OptRecordWhiteAccountRequest extends TeaModel {
    @NameInMap("requestBody")
    public OptRecordWhiteAccountRequestRequestBody requestBody;

    public static OptRecordWhiteAccountRequest build(java.util.Map<String, ?> map) throws Exception {
        OptRecordWhiteAccountRequest self = new OptRecordWhiteAccountRequest();
        return TeaModel.build(map, self);
    }

    public OptRecordWhiteAccountRequest setRequestBody(OptRecordWhiteAccountRequestRequestBody requestBody) {
        this.requestBody = requestBody;
        return this;
    }
    public OptRecordWhiteAccountRequestRequestBody getRequestBody() {
        return this.requestBody;
    }

    public static class OptRecordWhiteAccountRequestRequestBodySettingRangeList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>vLY8xxxxxxxQiEiE</p>
         */
        @NameInMap("settingRangeId")
        public String settingRangeId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>3</p>
         */
        @NameInMap("settingRangeType")
        public Integer settingRangeType;

        public static OptRecordWhiteAccountRequestRequestBodySettingRangeList build(java.util.Map<String, ?> map) throws Exception {
            OptRecordWhiteAccountRequestRequestBodySettingRangeList self = new OptRecordWhiteAccountRequestRequestBodySettingRangeList();
            return TeaModel.build(map, self);
        }

        public OptRecordWhiteAccountRequestRequestBodySettingRangeList setSettingRangeId(String settingRangeId) {
            this.settingRangeId = settingRangeId;
            return this;
        }
        public String getSettingRangeId() {
            return this.settingRangeId;
        }

        public OptRecordWhiteAccountRequestRequestBodySettingRangeList setSettingRangeType(Integer settingRangeType) {
            this.settingRangeType = settingRangeType;
            return this;
        }
        public Integer getSettingRangeType() {
            return this.settingRangeType;
        }

    }

    public static class OptRecordWhiteAccountRequestRequestBody extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>cloud_record</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("operation")
        public Integer operation;

        @NameInMap("settingRangeList")
        public java.util.List<OptRecordWhiteAccountRequestRequestBodySettingRangeList> settingRangeList;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>vLXXXiEiE</p>
         */
        @NameInMap("unionId")
        public String unionId;

        public static OptRecordWhiteAccountRequestRequestBody build(java.util.Map<String, ?> map) throws Exception {
            OptRecordWhiteAccountRequestRequestBody self = new OptRecordWhiteAccountRequestRequestBody();
            return TeaModel.build(map, self);
        }

        public OptRecordWhiteAccountRequestRequestBody setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public OptRecordWhiteAccountRequestRequestBody setOperation(Integer operation) {
            this.operation = operation;
            return this;
        }
        public Integer getOperation() {
            return this.operation;
        }

        public OptRecordWhiteAccountRequestRequestBody setSettingRangeList(java.util.List<OptRecordWhiteAccountRequestRequestBodySettingRangeList> settingRangeList) {
            this.settingRangeList = settingRangeList;
            return this;
        }
        public java.util.List<OptRecordWhiteAccountRequestRequestBodySettingRangeList> getSettingRangeList() {
            return this.settingRangeList;
        }

        public OptRecordWhiteAccountRequestRequestBody setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
