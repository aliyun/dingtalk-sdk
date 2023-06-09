// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetOutGroupsByPageResponseBody extends TeaModel {
    @NameInMap("responseBody")
    public GetOutGroupsByPageResponseBodyResponseBody responseBody;

    public static GetOutGroupsByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOutGroupsByPageResponseBody self = new GetOutGroupsByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOutGroupsByPageResponseBody setResponseBody(GetOutGroupsByPageResponseBodyResponseBody responseBody) {
        this.responseBody = responseBody;
        return this;
    }
    public GetOutGroupsByPageResponseBodyResponseBody getResponseBody() {
        return this.responseBody;
    }

    public static class GetOutGroupsByPageResponseBodyResponseBodyGroupList extends TeaModel {
        @NameInMap("openConversationId")
        public String openConversationId;

        public static GetOutGroupsByPageResponseBodyResponseBodyGroupList build(java.util.Map<String, ?> map) throws Exception {
            GetOutGroupsByPageResponseBodyResponseBodyGroupList self = new GetOutGroupsByPageResponseBodyResponseBodyGroupList();
            return TeaModel.build(map, self);
        }

        public GetOutGroupsByPageResponseBodyResponseBodyGroupList setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

    }

    public static class GetOutGroupsByPageResponseBodyResponseBody extends TeaModel {
        @NameInMap("groupList")
        public java.util.List<GetOutGroupsByPageResponseBodyResponseBodyGroupList> groupList;

        @NameInMap("total")
        public Integer total;

        public static GetOutGroupsByPageResponseBodyResponseBody build(java.util.Map<String, ?> map) throws Exception {
            GetOutGroupsByPageResponseBodyResponseBody self = new GetOutGroupsByPageResponseBodyResponseBody();
            return TeaModel.build(map, self);
        }

        public GetOutGroupsByPageResponseBodyResponseBody setGroupList(java.util.List<GetOutGroupsByPageResponseBodyResponseBodyGroupList> groupList) {
            this.groupList = groupList;
            return this;
        }
        public java.util.List<GetOutGroupsByPageResponseBodyResponseBodyGroupList> getGroupList() {
            return this.groupList;
        }

        public GetOutGroupsByPageResponseBodyResponseBody setTotal(Integer total) {
            this.total = total;
            return this;
        }
        public Integer getTotal() {
            return this.total;
        }

    }

}
