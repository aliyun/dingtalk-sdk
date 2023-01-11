// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class BatchInsertBizObjectResponseBody extends TeaModel {
    /**
     * <p>状态码</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>返回结果</p>
     */
    @NameInMap("data")
    public BatchInsertBizObjectResponseBodyData data;

    /**
     * <p>提示信息</p>
     */
    @NameInMap("message")
    public String message;

    public static BatchInsertBizObjectResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchInsertBizObjectResponseBody self = new BatchInsertBizObjectResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchInsertBizObjectResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public BatchInsertBizObjectResponseBody setData(BatchInsertBizObjectResponseBodyData data) {
        this.data = data;
        return this;
    }
    public BatchInsertBizObjectResponseBodyData getData() {
        return this.data;
    }

    public BatchInsertBizObjectResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class BatchInsertBizObjectResponseBodyData extends TeaModel {
        /**
         * <p>成功新增的业务对象id数组</p>
         */
        @NameInMap("bizObjectIds")
        public java.util.List<String> bizObjectIds;

        /**
         * <p>新增失败的数据数组</p>
         */
        @NameInMap("failedDatas")
        public java.util.List<String> failedDatas;

        /**
         * <p>失败的提示信息数组</p>
         */
        @NameInMap("failedMessages")
        public java.util.List<String> failedMessages;

        /**
         * <p>新增成功的流程实例id数组</p>
         */
        @NameInMap("processIds")
        public java.util.List<String> processIds;

        public static BatchInsertBizObjectResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            BatchInsertBizObjectResponseBodyData self = new BatchInsertBizObjectResponseBodyData();
            return TeaModel.build(map, self);
        }

        public BatchInsertBizObjectResponseBodyData setBizObjectIds(java.util.List<String> bizObjectIds) {
            this.bizObjectIds = bizObjectIds;
            return this;
        }
        public java.util.List<String> getBizObjectIds() {
            return this.bizObjectIds;
        }

        public BatchInsertBizObjectResponseBodyData setFailedDatas(java.util.List<String> failedDatas) {
            this.failedDatas = failedDatas;
            return this;
        }
        public java.util.List<String> getFailedDatas() {
            return this.failedDatas;
        }

        public BatchInsertBizObjectResponseBodyData setFailedMessages(java.util.List<String> failedMessages) {
            this.failedMessages = failedMessages;
            return this;
        }
        public java.util.List<String> getFailedMessages() {
            return this.failedMessages;
        }

        public BatchInsertBizObjectResponseBodyData setProcessIds(java.util.List<String> processIds) {
            this.processIds = processIds;
            return this;
        }
        public java.util.List<String> getProcessIds() {
            return this.processIds;
        }

    }

}
