// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetJobPostResponseBody extends TeaModel {
    /**
     * <p>返回数据</p>
     */
    @NameInMap("content")
    public GetJobPostResponseBodyContent content;

    /**
     * <p>Id of the request</p>
     */
    @NameInMap("requestId")
    public String requestId;

    public static GetJobPostResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetJobPostResponseBody self = new GetJobPostResponseBody();
        return TeaModel.build(map, self);
    }

    public GetJobPostResponseBody setContent(GetJobPostResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public GetJobPostResponseBodyContent getContent() {
        return this.content;
    }

    public GetJobPostResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public static class GetJobPostResponseBodyContent extends TeaModel {
        /**
         * <p>职务编码</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>设立日期</p>
         */
        @NameInMap("establishDate")
        public String establishDate;

        /**
         * <p>职务名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>生效日期</p>
         */
        @NameInMap("startDate")
        public String startDate;

        /**
         * <p>失效日期</p>
         */
        @NameInMap("stopDate")
        public String stopDate;

        public static GetJobPostResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            GetJobPostResponseBodyContent self = new GetJobPostResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public GetJobPostResponseBodyContent setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetJobPostResponseBodyContent setEstablishDate(String establishDate) {
            this.establishDate = establishDate;
            return this;
        }
        public String getEstablishDate() {
            return this.establishDate;
        }

        public GetJobPostResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetJobPostResponseBodyContent setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public GetJobPostResponseBodyContent setStopDate(String stopDate) {
            this.stopDate = stopDate;
            return this;
        }
        public String getStopDate() {
            return this.stopDate;
        }

    }

}
