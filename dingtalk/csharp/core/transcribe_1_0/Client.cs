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


        public GetTranscribeBriefResponse GetTranscribeBrief(string taskUuid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTranscribeBriefHeaders headers = new GetTranscribeBriefHeaders();
            return GetTranscribeBriefWithOptions(taskUuid, headers, runtime);
        }

        public async Task<GetTranscribeBriefResponse> GetTranscribeBriefAsync(string taskUuid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTranscribeBriefHeaders headers = new GetTranscribeBriefHeaders();
            return await GetTranscribeBriefWithOptionsAsync(taskUuid, headers, runtime);
        }

        public GetTranscribeBriefResponse GetTranscribeBriefWithOptions(string taskUuid, GetTranscribeBriefHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            taskUuid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskUuid);
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
            };
            return TeaModel.ToObject<GetTranscribeBriefResponse>(DoROARequest("GetTranscribeBrief", "transcribe_1.0", "HTTP", "GET", "AK", "/v1.0/transcribe/tasks/" + taskUuid + "/briefInfos", "json", req, runtime));
        }

        public async Task<GetTranscribeBriefResponse> GetTranscribeBriefWithOptionsAsync(string taskUuid, GetTranscribeBriefHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            taskUuid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskUuid);
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
            };
            return TeaModel.ToObject<GetTranscribeBriefResponse>(await DoROARequestAsync("GetTranscribeBrief", "transcribe_1.0", "HTTP", "GET", "AK", "/v1.0/transcribe/tasks/" + taskUuid + "/briefInfos", "json", req, runtime));
        }

        public RemovePermissionResponse RemovePermission(string taskUuid, RemovePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemovePermissionHeaders headers = new RemovePermissionHeaders();
            return RemovePermissionWithOptions(taskUuid, request, headers, runtime);
        }

        public async Task<RemovePermissionResponse> RemovePermissionAsync(string taskUuid, RemovePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemovePermissionHeaders headers = new RemovePermissionHeaders();
            return await RemovePermissionWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        public RemovePermissionResponse RemovePermissionWithOptions(string taskUuid, RemovePermissionRequest request, RemovePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            taskUuid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskUuid);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RemovePermissionResponse>(DoROARequest("RemovePermission", "transcribe_1.0", "HTTP", "DELETE", "AK", "/v1.0/transcribe/tasks/" + taskUuid + "/permissions/remove", "json", req, runtime));
        }

        public async Task<RemovePermissionResponse> RemovePermissionWithOptionsAsync(string taskUuid, RemovePermissionRequest request, RemovePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            taskUuid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskUuid);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RemovePermissionResponse>(await DoROARequestAsync("RemovePermission", "transcribe_1.0", "HTTP", "DELETE", "AK", "/v1.0/transcribe/tasks/" + taskUuid + "/permissions/remove", "json", req, runtime));
        }

        public UpdatePermissionForUsersResponse UpdatePermissionForUsers(string taskUuid, UpdatePermissionForUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePermissionForUsersHeaders headers = new UpdatePermissionForUsersHeaders();
            return UpdatePermissionForUsersWithOptions(taskUuid, request, headers, runtime);
        }

        public async Task<UpdatePermissionForUsersResponse> UpdatePermissionForUsersAsync(string taskUuid, UpdatePermissionForUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePermissionForUsersHeaders headers = new UpdatePermissionForUsersHeaders();
            return await UpdatePermissionForUsersWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        public UpdatePermissionForUsersResponse UpdatePermissionForUsersWithOptions(string taskUuid, UpdatePermissionForUsersRequest request, UpdatePermissionForUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            taskUuid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskUuid);
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
            return TeaModel.ToObject<UpdatePermissionForUsersResponse>(DoROARequest("UpdatePermissionForUsers", "transcribe_1.0", "HTTP", "PUT", "AK", "/v1.0/transcribe/tasks/" + taskUuid + "/permissions", "json", req, runtime));
        }

        public async Task<UpdatePermissionForUsersResponse> UpdatePermissionForUsersWithOptionsAsync(string taskUuid, UpdatePermissionForUsersRequest request, UpdatePermissionForUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            taskUuid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskUuid);
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
            return TeaModel.ToObject<UpdatePermissionForUsersResponse>(await DoROARequestAsync("UpdatePermissionForUsers", "transcribe_1.0", "HTTP", "PUT", "AK", "/v1.0/transcribe/tasks/" + taskUuid + "/permissions", "json", req, runtime));
        }

    }
}
