// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetOrgLiveListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("requestBody")
    public GetOrgLiveListRequestRequestBody requestBody;

    public static GetOrgLiveListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOrgLiveListRequest self = new GetOrgLiveListRequest();
        return TeaModel.build(map, self);
    }

    public GetOrgLiveListRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetOrgLiveListRequest setRequestBody(GetOrgLiveListRequestRequestBody requestBody) {
        this.requestBody = requestBody;
        return this;
    }
    public GetOrgLiveListRequestRequestBody getRequestBody() {
        return this.requestBody;
    }

    public static class GetOrgLiveListRequestRequestBody extends TeaModel {
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("pageNumber")
        public Long pageNumber;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("pageSize")
        public Long pageSize;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("unionId")
        public String unionId;

        public static GetOrgLiveListRequestRequestBody build(java.util.Map<String, ?> map) throws Exception {
            GetOrgLiveListRequestRequestBody self = new GetOrgLiveListRequestRequestBody();
            return TeaModel.build(map, self);
        }

        public GetOrgLiveListRequestRequestBody setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public GetOrgLiveListRequestRequestBody setPageNumber(Long pageNumber) {
            this.pageNumber = pageNumber;
            return this;
        }
        public Long getPageNumber() {
            return this.pageNumber;
        }

        public GetOrgLiveListRequestRequestBody setPageSize(Long pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Long getPageSize() {
            return this.pageSize;
        }

        public GetOrgLiveListRequestRequestBody setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public GetOrgLiveListRequestRequestBody setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
