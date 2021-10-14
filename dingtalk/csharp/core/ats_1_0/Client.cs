// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkats_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkats_1_0
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


        public AddApplicationRegFormTemplateResponse AddApplicationRegFormTemplate(AddApplicationRegFormTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddApplicationRegFormTemplateHeaders headers = new AddApplicationRegFormTemplateHeaders();
            return AddApplicationRegFormTemplateWithOptions(request, headers, runtime);
        }

        public async Task<AddApplicationRegFormTemplateResponse> AddApplicationRegFormTemplateAsync(AddApplicationRegFormTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddApplicationRegFormTemplateHeaders headers = new AddApplicationRegFormTemplateHeaders();
            return await AddApplicationRegFormTemplateWithOptionsAsync(request, headers, runtime);
        }

        public AddApplicationRegFormTemplateResponse AddApplicationRegFormTemplateWithOptions(AddApplicationRegFormTemplateRequest request, AddApplicationRegFormTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                body["outerId"] = request.OuterId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddApplicationRegFormTemplateResponse>(DoROARequest("AddApplicationRegFormTemplate", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/flows/applicationRegForms/templates", "json", req, runtime));
        }

        public async Task<AddApplicationRegFormTemplateResponse> AddApplicationRegFormTemplateWithOptionsAsync(AddApplicationRegFormTemplateRequest request, AddApplicationRegFormTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                body["outerId"] = request.OuterId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddApplicationRegFormTemplateResponse>(await DoROARequestAsync("AddApplicationRegFormTemplate", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/flows/applicationRegForms/templates", "json", req, runtime));
        }

        public AddFileResponse AddFile(AddFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddFileHeaders headers = new AddFileHeaders();
            return AddFileWithOptions(request, headers, runtime);
        }

        public async Task<AddFileResponse> AddFileAsync(AddFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddFileHeaders headers = new AddFileHeaders();
            return await AddFileWithOptionsAsync(request, headers, runtime);
        }

        public AddFileResponse AddFileWithOptions(AddFileRequest request, AddFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddFileResponse>(DoROARequest("AddFile", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/files", "json", req, runtime));
        }

        public async Task<AddFileResponse> AddFileWithOptionsAsync(AddFileRequest request, AddFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddFileResponse>(await DoROARequestAsync("AddFile", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/files", "json", req, runtime));
        }

        public FinishBeginnerTaskResponse FinishBeginnerTask(string taskCode, FinishBeginnerTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FinishBeginnerTaskHeaders headers = new FinishBeginnerTaskHeaders();
            return FinishBeginnerTaskWithOptions(taskCode, request, headers, runtime);
        }

        public async Task<FinishBeginnerTaskResponse> FinishBeginnerTaskAsync(string taskCode, FinishBeginnerTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FinishBeginnerTaskHeaders headers = new FinishBeginnerTaskHeaders();
            return await FinishBeginnerTaskWithOptionsAsync(taskCode, request, headers, runtime);
        }

        public FinishBeginnerTaskResponse FinishBeginnerTaskWithOptions(string taskCode, FinishBeginnerTaskRequest request, FinishBeginnerTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            taskCode = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskCode);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<FinishBeginnerTaskResponse>(DoROARequest("FinishBeginnerTask", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/beginnerTasks/" + taskCode + "/finish", "json", req, runtime));
        }

        public async Task<FinishBeginnerTaskResponse> FinishBeginnerTaskWithOptionsAsync(string taskCode, FinishBeginnerTaskRequest request, FinishBeginnerTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            taskCode = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskCode);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<FinishBeginnerTaskResponse>(await DoROARequestAsync("FinishBeginnerTask", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/beginnerTasks/" + taskCode + "/finish", "json", req, runtime));
        }

        public GetApplicationRegFormByFlowIdResponse GetApplicationRegFormByFlowId(string flowId, GetApplicationRegFormByFlowIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApplicationRegFormByFlowIdHeaders headers = new GetApplicationRegFormByFlowIdHeaders();
            return GetApplicationRegFormByFlowIdWithOptions(flowId, request, headers, runtime);
        }

        public async Task<GetApplicationRegFormByFlowIdResponse> GetApplicationRegFormByFlowIdAsync(string flowId, GetApplicationRegFormByFlowIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApplicationRegFormByFlowIdHeaders headers = new GetApplicationRegFormByFlowIdHeaders();
            return await GetApplicationRegFormByFlowIdWithOptionsAsync(flowId, request, headers, runtime);
        }

        public GetApplicationRegFormByFlowIdResponse GetApplicationRegFormByFlowIdWithOptions(string flowId, GetApplicationRegFormByFlowIdRequest request, GetApplicationRegFormByFlowIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            flowId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetApplicationRegFormByFlowIdResponse>(DoROARequest("GetApplicationRegFormByFlowId", "ats_1.0", "HTTP", "GET", "AK", "/v1.0/ats/flows/" + flowId + "/applicationRegForms", "json", req, runtime));
        }

        public async Task<GetApplicationRegFormByFlowIdResponse> GetApplicationRegFormByFlowIdWithOptionsAsync(string flowId, GetApplicationRegFormByFlowIdRequest request, GetApplicationRegFormByFlowIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            flowId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetApplicationRegFormByFlowIdResponse>(await DoROARequestAsync("GetApplicationRegFormByFlowId", "ats_1.0", "HTTP", "GET", "AK", "/v1.0/ats/flows/" + flowId + "/applicationRegForms", "json", req, runtime));
        }

        public GetCandidateByPhoneNumberResponse GetCandidateByPhoneNumber(GetCandidateByPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCandidateByPhoneNumberHeaders headers = new GetCandidateByPhoneNumberHeaders();
            return GetCandidateByPhoneNumberWithOptions(request, headers, runtime);
        }

        public async Task<GetCandidateByPhoneNumberResponse> GetCandidateByPhoneNumberAsync(GetCandidateByPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCandidateByPhoneNumberHeaders headers = new GetCandidateByPhoneNumberHeaders();
            return await GetCandidateByPhoneNumberWithOptionsAsync(request, headers, runtime);
        }

        public GetCandidateByPhoneNumberResponse GetCandidateByPhoneNumberWithOptions(GetCandidateByPhoneNumberRequest request, GetCandidateByPhoneNumberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["phoneNumber"] = request.PhoneNumber;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetCandidateByPhoneNumberResponse>(DoROARequest("GetCandidateByPhoneNumber", "ats_1.0", "HTTP", "GET", "AK", "/v1.0/ats/candidates", "json", req, runtime));
        }

        public async Task<GetCandidateByPhoneNumberResponse> GetCandidateByPhoneNumberWithOptionsAsync(GetCandidateByPhoneNumberRequest request, GetCandidateByPhoneNumberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["phoneNumber"] = request.PhoneNumber;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetCandidateByPhoneNumberResponse>(await DoROARequestAsync("GetCandidateByPhoneNumber", "ats_1.0", "HTTP", "GET", "AK", "/v1.0/ats/candidates", "json", req, runtime));
        }

        public GetFileUploadInfoResponse GetFileUploadInfo(GetFileUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileUploadInfoHeaders headers = new GetFileUploadInfoHeaders();
            return GetFileUploadInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetFileUploadInfoResponse> GetFileUploadInfoAsync(GetFileUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileUploadInfoHeaders headers = new GetFileUploadInfoHeaders();
            return await GetFileUploadInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetFileUploadInfoResponse GetFileUploadInfoWithOptions(GetFileUploadInfoRequest request, GetFileUploadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                query["fileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5))
            {
                query["md5"] = request.Md5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFileUploadInfoResponse>(DoROARequest("GetFileUploadInfo", "ats_1.0", "HTTP", "GET", "AK", "/v1.0/ats/files/uploadInfos", "json", req, runtime));
        }

        public async Task<GetFileUploadInfoResponse> GetFileUploadInfoWithOptionsAsync(GetFileUploadInfoRequest request, GetFileUploadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                query["fileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5))
            {
                query["md5"] = request.Md5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFileUploadInfoResponse>(await DoROARequestAsync("GetFileUploadInfo", "ats_1.0", "HTTP", "GET", "AK", "/v1.0/ats/files/uploadInfos", "json", req, runtime));
        }

        public GetFlowIdByRelationEntityIdResponse GetFlowIdByRelationEntityId(GetFlowIdByRelationEntityIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowIdByRelationEntityIdHeaders headers = new GetFlowIdByRelationEntityIdHeaders();
            return GetFlowIdByRelationEntityIdWithOptions(request, headers, runtime);
        }

        public async Task<GetFlowIdByRelationEntityIdResponse> GetFlowIdByRelationEntityIdAsync(GetFlowIdByRelationEntityIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowIdByRelationEntityIdHeaders headers = new GetFlowIdByRelationEntityIdHeaders();
            return await GetFlowIdByRelationEntityIdWithOptionsAsync(request, headers, runtime);
        }

        public GetFlowIdByRelationEntityIdResponse GetFlowIdByRelationEntityIdWithOptions(GetFlowIdByRelationEntityIdRequest request, GetFlowIdByRelationEntityIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationEntity))
            {
                query["relationEntity"] = request.RelationEntity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationEntityId))
            {
                query["relationEntityId"] = request.RelationEntityId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFlowIdByRelationEntityIdResponse>(DoROARequest("GetFlowIdByRelationEntityId", "ats_1.0", "HTTP", "GET", "AK", "/v1.0/ats/flows/ids", "json", req, runtime));
        }

        public async Task<GetFlowIdByRelationEntityIdResponse> GetFlowIdByRelationEntityIdWithOptionsAsync(GetFlowIdByRelationEntityIdRequest request, GetFlowIdByRelationEntityIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationEntity))
            {
                query["relationEntity"] = request.RelationEntity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationEntityId))
            {
                query["relationEntityId"] = request.RelationEntityId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFlowIdByRelationEntityIdResponse>(await DoROARequestAsync("GetFlowIdByRelationEntityId", "ats_1.0", "HTTP", "GET", "AK", "/v1.0/ats/flows/ids", "json", req, runtime));
        }

        public GetJobAuthResponse GetJobAuth(string jobId, GetJobAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobAuthHeaders headers = new GetJobAuthHeaders();
            return GetJobAuthWithOptions(jobId, request, headers, runtime);
        }

        public async Task<GetJobAuthResponse> GetJobAuthAsync(string jobId, GetJobAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobAuthHeaders headers = new GetJobAuthHeaders();
            return await GetJobAuthWithOptionsAsync(jobId, request, headers, runtime);
        }

        public GetJobAuthResponse GetJobAuthWithOptions(string jobId, GetJobAuthRequest request, GetJobAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            jobId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetJobAuthResponse>(DoROARequest("GetJobAuth", "ats_1.0", "HTTP", "GET", "AK", "/v1.0/ats/auths/jobs/" + jobId, "json", req, runtime));
        }

        public async Task<GetJobAuthResponse> GetJobAuthWithOptionsAsync(string jobId, GetJobAuthRequest request, GetJobAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            jobId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetJobAuthResponse>(await DoROARequestAsync("GetJobAuth", "ats_1.0", "HTTP", "GET", "AK", "/v1.0/ats/auths/jobs/" + jobId, "json", req, runtime));
        }

        public QueryInterviewsResponse QueryInterviews(QueryInterviewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInterviewsHeaders headers = new QueryInterviewsHeaders();
            return QueryInterviewsWithOptions(request, headers, runtime);
        }

        public async Task<QueryInterviewsResponse> QueryInterviewsAsync(QueryInterviewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInterviewsHeaders headers = new QueryInterviewsHeaders();
            return await QueryInterviewsWithOptionsAsync(request, headers, runtime);
        }

        public QueryInterviewsResponse QueryInterviewsWithOptions(QueryInterviewsRequest request, QueryInterviewsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CandidateId))
            {
                body["candidateId"] = request.CandidateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeBeginMillis))
            {
                body["startTimeBeginMillis"] = request.StartTimeBeginMillis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeEndMillis))
            {
                body["startTimeEndMillis"] = request.StartTimeEndMillis;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<QueryInterviewsResponse>(DoROARequest("QueryInterviews", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/interviews/query", "json", req, runtime));
        }

        public async Task<QueryInterviewsResponse> QueryInterviewsWithOptionsAsync(QueryInterviewsRequest request, QueryInterviewsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CandidateId))
            {
                body["candidateId"] = request.CandidateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeBeginMillis))
            {
                body["startTimeBeginMillis"] = request.StartTimeBeginMillis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeEndMillis))
            {
                body["startTimeEndMillis"] = request.StartTimeEndMillis;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<QueryInterviewsResponse>(await DoROARequestAsync("QueryInterviews", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/interviews/query", "json", req, runtime));
        }

        public UpdateApplicationRegFormResponse UpdateApplicationRegForm(string flowId, UpdateApplicationRegFormRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateApplicationRegFormHeaders headers = new UpdateApplicationRegFormHeaders();
            return UpdateApplicationRegFormWithOptions(flowId, request, headers, runtime);
        }

        public async Task<UpdateApplicationRegFormResponse> UpdateApplicationRegFormAsync(string flowId, UpdateApplicationRegFormRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateApplicationRegFormHeaders headers = new UpdateApplicationRegFormHeaders();
            return await UpdateApplicationRegFormWithOptionsAsync(flowId, request, headers, runtime);
        }

        public UpdateApplicationRegFormResponse UpdateApplicationRegFormWithOptions(string flowId, UpdateApplicationRegFormRequest request, UpdateApplicationRegFormHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            flowId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingPanFile.ToMap()))
            {
                body["dingPanFile"] = request.DingPanFile;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateApplicationRegFormResponse>(DoROARequest("UpdateApplicationRegForm", "ats_1.0", "HTTP", "PUT", "AK", "/v1.0/ats/flows/" + flowId + "/applicationRegForms", "json", req, runtime));
        }

        public async Task<UpdateApplicationRegFormResponse> UpdateApplicationRegFormWithOptionsAsync(string flowId, UpdateApplicationRegFormRequest request, UpdateApplicationRegFormHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            flowId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingPanFile.ToMap()))
            {
                body["dingPanFile"] = request.DingPanFile;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateApplicationRegFormResponse>(await DoROARequestAsync("UpdateApplicationRegForm", "ats_1.0", "HTTP", "PUT", "AK", "/v1.0/ats/flows/" + flowId + "/applicationRegForms", "json", req, runtime));
        }

        public UpdateInterviewSignInInfoResponse UpdateInterviewSignInInfo(string interviewId, UpdateInterviewSignInInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInterviewSignInInfoHeaders headers = new UpdateInterviewSignInInfoHeaders();
            return UpdateInterviewSignInInfoWithOptions(interviewId, request, headers, runtime);
        }

        public async Task<UpdateInterviewSignInInfoResponse> UpdateInterviewSignInInfoAsync(string interviewId, UpdateInterviewSignInInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInterviewSignInInfoHeaders headers = new UpdateInterviewSignInInfoHeaders();
            return await UpdateInterviewSignInInfoWithOptionsAsync(interviewId, request, headers, runtime);
        }

        public UpdateInterviewSignInInfoResponse UpdateInterviewSignInInfoWithOptions(string interviewId, UpdateInterviewSignInInfoRequest request, UpdateInterviewSignInInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            interviewId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(interviewId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignInTimeMillis))
            {
                body["signInTimeMillis"] = request.SignInTimeMillis;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateInterviewSignInInfoResponse>(DoROARequest("UpdateInterviewSignInInfo", "ats_1.0", "HTTP", "PUT", "AK", "/v1.0/ats/interviews/" + interviewId + "/signInInfos", "none", req, runtime));
        }

        public async Task<UpdateInterviewSignInInfoResponse> UpdateInterviewSignInInfoWithOptionsAsync(string interviewId, UpdateInterviewSignInInfoRequest request, UpdateInterviewSignInInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            interviewId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(interviewId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignInTimeMillis))
            {
                body["signInTimeMillis"] = request.SignInTimeMillis;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateInterviewSignInInfoResponse>(await DoROARequestAsync("UpdateInterviewSignInInfo", "ats_1.0", "HTTP", "PUT", "AK", "/v1.0/ats/interviews/" + interviewId + "/signInInfos", "none", req, runtime));
        }

    }
}
