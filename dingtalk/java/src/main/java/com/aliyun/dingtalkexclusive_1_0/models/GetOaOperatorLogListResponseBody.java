// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetOaOperatorLogListResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("data")
    public java.util.List<GetOaOperatorLogListResponseBodyData> data;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("itemCount")
    public Long itemCount;

    public static GetOaOperatorLogListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOaOperatorLogListResponseBody self = new GetOaOperatorLogListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOaOperatorLogListResponseBody setData(java.util.List<GetOaOperatorLogListResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetOaOperatorLogListResponseBodyData> getData() {
        return this.data;
    }

    public GetOaOperatorLogListResponseBody setItemCount(Long itemCount) {
        this.itemCount = itemCount;
        return this;
    }
    public Long getItemCount() {
        return this.itemCount;
    }

    public static class GetOaOperatorLogListResponseBodyData extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("category1Name")
        public String category1Name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("category2Name")
        public String category2Name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("opName")
        public String opName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("opTime")
        public Long opTime;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("opUserId")
        public String opUserId;

        public static GetOaOperatorLogListResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetOaOperatorLogListResponseBodyData self = new GetOaOperatorLogListResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetOaOperatorLogListResponseBodyData setCategory1Name(String category1Name) {
            this.category1Name = category1Name;
            return this;
        }
        public String getCategory1Name() {
            return this.category1Name;
        }

        public GetOaOperatorLogListResponseBodyData setCategory2Name(String category2Name) {
            this.category2Name = category2Name;
            return this;
        }
        public String getCategory2Name() {
            return this.category2Name;
        }

        public GetOaOperatorLogListResponseBodyData setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetOaOperatorLogListResponseBodyData setOpName(String opName) {
            this.opName = opName;
            return this;
        }
        public String getOpName() {
            return this.opName;
        }

        public GetOaOperatorLogListResponseBodyData setOpTime(Long opTime) {
            this.opTime = opTime;
            return this;
        }
        public Long getOpTime() {
            return this.opTime;
        }

        public GetOaOperatorLogListResponseBodyData setOpUserId(String opUserId) {
            this.opUserId = opUserId;
            return this;
        }
        public String getOpUserId() {
            return this.opUserId;
        }

    }

}
