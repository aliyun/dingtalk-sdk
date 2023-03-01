// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkblackboard_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkblackboard_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public QueryBlackboardSpaceResponse QueryBlackboardSpace(QueryBlackboardSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBlackboardSpaceHeaders headers = new QueryBlackboardSpaceHeaders();
            return QueryBlackboardSpaceWithOptions(request, headers, runtime);
        }

        public async Task<QueryBlackboardSpaceResponse> QueryBlackboardSpaceAsync(QueryBlackboardSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBlackboardSpaceHeaders headers = new QueryBlackboardSpaceHeaders();
            return await QueryBlackboardSpaceWithOptionsAsync(request, headers, runtime);
        }

        public QueryBlackboardSpaceResponse QueryBlackboardSpaceWithOptions(QueryBlackboardSpaceRequest request, QueryBlackboardSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationUserId))
            {
                query["operationUserId"] = request.OperationUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryBlackboardSpaceResponse>(DoROARequest("QueryBlackboardSpace", "blackboard_1.0", "HTTP", "GET", "AK", "/v1.0/blackboard/spaces", "json", req, runtime));
        }

        public async Task<QueryBlackboardSpaceResponse> QueryBlackboardSpaceWithOptionsAsync(QueryBlackboardSpaceRequest request, QueryBlackboardSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationUserId))
            {
                query["operationUserId"] = request.OperationUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryBlackboardSpaceResponse>(await DoROARequestAsync("QueryBlackboardSpace", "blackboard_1.0", "HTTP", "GET", "AK", "/v1.0/blackboard/spaces", "json", req, runtime));
        }

    }
}
