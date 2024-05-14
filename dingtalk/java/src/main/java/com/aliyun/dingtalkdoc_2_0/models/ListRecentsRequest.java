// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListRecentsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("param")
    public ListRecentsRequestParam param;

    public static ListRecentsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListRecentsRequest self = new ListRecentsRequest();
        return TeaModel.build(map, self);
    }

    public ListRecentsRequest setParam(ListRecentsRequestParam param) {
        this.param = param;
        return this;
    }
    public ListRecentsRequestParam getParam() {
        return this.param;
    }

    public static class ListRecentsRequestParam extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fileTypes")
        public java.util.List<Integer> fileTypes;

        @NameInMap("maxResults")
        public Integer maxResults;

        @NameInMap("nextToken")
        public String nextToken;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("operateTypes")
        public java.util.List<Integer> operateTypes;

        public static ListRecentsRequestParam build(java.util.Map<String, ?> map) throws Exception {
            ListRecentsRequestParam self = new ListRecentsRequestParam();
            return TeaModel.build(map, self);
        }

        public ListRecentsRequestParam setFileTypes(java.util.List<Integer> fileTypes) {
            this.fileTypes = fileTypes;
            return this;
        }
        public java.util.List<Integer> getFileTypes() {
            return this.fileTypes;
        }

        public ListRecentsRequestParam setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public ListRecentsRequestParam setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public ListRecentsRequestParam setOperateTypes(java.util.List<Integer> operateTypes) {
            this.operateTypes = operateTypes;
            return this;
        }
        public java.util.List<Integer> getOperateTypes() {
            return this.operateTypes;
        }

    }

}
