// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalktranscribe_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalktranscribe_1_0
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


        public UpdatePermissionForUsersResponse UpdatePermissionForUsers(string taskId, UpdatePermissionForUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePermissionForUsersHeaders headers = new UpdatePermissionForUsersHeaders();
            return UpdatePermissionForUsersWithOptions(taskId, request, headers, runtime);
        }

        public async Task<UpdatePermissionForUsersResponse> UpdatePermissionForUsersAsync(string taskId, UpdatePermissionForUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePermissionForUsersHeaders headers = new UpdatePermissionForUsersHeaders();
            return await UpdatePermissionForUsersWithOptionsAsync(taskId, request, headers, runtime);
        }

        public UpdatePermissionForUsersResponse UpdatePermissionForUsersWithOptions(string taskId, UpdatePermissionForUsersRequest request, UpdatePermissionForUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            taskId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                query["operatorUid"] = request.OperatorUid;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCreator))
            {
                body["taskCreator"] = request.TaskCreator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdatePermissionForUsersResponse>(DoROARequest("UpdatePermissionForUsers", "transcribe_1.0", "HTTP", "PUT", "AK", "/v1.0/transcribe/tasks/" + taskId + "/permissions", "json", req, runtime));
        }

        public async Task<UpdatePermissionForUsersResponse> UpdatePermissionForUsersWithOptionsAsync(string taskId, UpdatePermissionForUsersRequest request, UpdatePermissionForUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            taskId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                query["operatorUid"] = request.OperatorUid;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCreator))
            {
                body["taskCreator"] = request.TaskCreator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdatePermissionForUsersResponse>(await DoROARequestAsync("UpdatePermissionForUsers", "transcribe_1.0", "HTTP", "PUT", "AK", "/v1.0/transcribe/tasks/" + taskId + "/permissions", "json", req, runtime));
        }

    }
}
