// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetAllDismissionReasonsResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public GetAllDismissionReasonsResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetAllDismissionReasonsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAllDismissionReasonsResponseBody self = new GetAllDismissionReasonsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAllDismissionReasonsResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetAllDismissionReasonsResponseBody setResult(GetAllDismissionReasonsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetAllDismissionReasonsResponseBodyResult getResult() {
        return this.result;
    }

    public GetAllDismissionReasonsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetAllDismissionReasonsResponseBodyResultPassiveList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>家庭原因</p>
         */
        @NameInMap("name")
        public String name;

        public static GetAllDismissionReasonsResponseBodyResultPassiveList build(java.util.Map<String, ?> map) throws Exception {
            GetAllDismissionReasonsResponseBodyResultPassiveList self = new GetAllDismissionReasonsResponseBodyResultPassiveList();
            return TeaModel.build(map, self);
        }

        public GetAllDismissionReasonsResponseBodyResultPassiveList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetAllDismissionReasonsResponseBodyResultPassiveList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class GetAllDismissionReasonsResponseBodyResultVoluntaryList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>家庭原因</p>
         */
        @NameInMap("name")
        public String name;

        public static GetAllDismissionReasonsResponseBodyResultVoluntaryList build(java.util.Map<String, ?> map) throws Exception {
            GetAllDismissionReasonsResponseBodyResultVoluntaryList self = new GetAllDismissionReasonsResponseBodyResultVoluntaryList();
            return TeaModel.build(map, self);
        }

        public GetAllDismissionReasonsResponseBodyResultVoluntaryList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetAllDismissionReasonsResponseBodyResultVoluntaryList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class GetAllDismissionReasonsResponseBodyResult extends TeaModel {
        @NameInMap("passiveList")
        public java.util.List<GetAllDismissionReasonsResponseBodyResultPassiveList> passiveList;

        @NameInMap("voluntaryList")
        public java.util.List<GetAllDismissionReasonsResponseBodyResultVoluntaryList> voluntaryList;

        public static GetAllDismissionReasonsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetAllDismissionReasonsResponseBodyResult self = new GetAllDismissionReasonsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetAllDismissionReasonsResponseBodyResult setPassiveList(java.util.List<GetAllDismissionReasonsResponseBodyResultPassiveList> passiveList) {
            this.passiveList = passiveList;
            return this;
        }
        public java.util.List<GetAllDismissionReasonsResponseBodyResultPassiveList> getPassiveList() {
            return this.passiveList;
        }

        public GetAllDismissionReasonsResponseBodyResult setVoluntaryList(java.util.List<GetAllDismissionReasonsResponseBodyResultVoluntaryList> voluntaryList) {
            this.voluntaryList = voluntaryList;
            return this;
        }
        public java.util.List<GetAllDismissionReasonsResponseBodyResultVoluntaryList> getVoluntaryList() {
            return this.voluntaryList;
        }

    }

}
