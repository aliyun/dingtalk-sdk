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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddFileResponse>(await DoROARequestAsync("AddFile", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/files", "json", req, runtime));
        }

        public AddUserAccountResponse AddUserAccount(AddUserAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddUserAccountHeaders headers = new AddUserAccountHeaders();
            return AddUserAccountWithOptions(request, headers, runtime);
        }

        public async Task<AddUserAccountResponse> AddUserAccountAsync(AddUserAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddUserAccountHeaders headers = new AddUserAccountHeaders();
            return await AddUserAccountWithOptionsAsync(request, headers, runtime);
        }

        public AddUserAccountResponse AddUserAccountWithOptions(AddUserAccountRequest request, AddUserAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelAccountName))
            {
                body["channelAccountName"] = request.ChannelAccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelUserIdentify))
            {
                body["channelUserIdentify"] = request.ChannelUserIdentify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["phoneNumber"] = request.PhoneNumber;
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
            return TeaModel.ToObject<AddUserAccountResponse>(DoROARequest("AddUserAccount", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/channels/users/accounts", "json", req, runtime));
        }

        public async Task<AddUserAccountResponse> AddUserAccountWithOptionsAsync(AddUserAccountRequest request, AddUserAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelAccountName))
            {
                body["channelAccountName"] = request.ChannelAccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelUserIdentify))
            {
                body["channelUserIdentify"] = request.ChannelUserIdentify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["phoneNumber"] = request.PhoneNumber;
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
            return TeaModel.ToObject<AddUserAccountResponse>(await DoROARequestAsync("AddUserAccount", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/channels/users/accounts", "json", req, runtime));
        }

        public CollectResumeDetailResponse CollectResumeDetail(CollectResumeDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollectResumeDetailHeaders headers = new CollectResumeDetailHeaders();
            return CollectResumeDetailWithOptions(request, headers, runtime);
        }

        public async Task<CollectResumeDetailResponse> CollectResumeDetailAsync(CollectResumeDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollectResumeDetailHeaders headers = new CollectResumeDetailHeaders();
            return await CollectResumeDetailWithOptionsAsync(request, headers, runtime);
        }

        public CollectResumeDetailResponse CollectResumeDetailWithOptions(CollectResumeDetailRequest request, CollectResumeDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelOuterId))
            {
                body["channelOuterId"] = request.ChannelOuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverJobId))
            {
                body["deliverJobId"] = request.DeliverJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResumeData.ToMap()))
            {
                body["resumeData"] = request.ResumeData;
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
            return TeaModel.ToObject<CollectResumeDetailResponse>(DoROARequest("CollectResumeDetail", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/resumes/details", "json", req, runtime));
        }

        public async Task<CollectResumeDetailResponse> CollectResumeDetailWithOptionsAsync(CollectResumeDetailRequest request, CollectResumeDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelOuterId))
            {
                body["channelOuterId"] = request.ChannelOuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverJobId))
            {
                body["deliverJobId"] = request.DeliverJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResumeData.ToMap()))
            {
                body["resumeData"] = request.ResumeData;
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
            return TeaModel.ToObject<CollectResumeDetailResponse>(await DoROARequestAsync("CollectResumeDetail", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/resumes/details", "json", req, runtime));
        }

        public ConfirmRightsResponse ConfirmRights(string rightsCode, ConfirmRightsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConfirmRightsHeaders headers = new ConfirmRightsHeaders();
            return ConfirmRightsWithOptions(rightsCode, request, headers, runtime);
        }

        public async Task<ConfirmRightsResponse> ConfirmRightsAsync(string rightsCode, ConfirmRightsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConfirmRightsHeaders headers = new ConfirmRightsHeaders();
            return await ConfirmRightsWithOptionsAsync(rightsCode, request, headers, runtime);
        }

        public ConfirmRightsResponse ConfirmRightsWithOptions(string rightsCode, ConfirmRightsRequest request, ConfirmRightsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            rightsCode = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rightsCode);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ConfirmRightsResponse>(DoROARequest("ConfirmRights", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/rights/" + rightsCode + "/confirm", "json", req, runtime));
        }

        public async Task<ConfirmRightsResponse> ConfirmRightsWithOptionsAsync(string rightsCode, ConfirmRightsRequest request, ConfirmRightsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            rightsCode = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rightsCode);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ConfirmRightsResponse>(await DoROARequestAsync("ConfirmRights", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/rights/" + rightsCode + "/confirm", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<QueryInterviewsResponse>(await DoROARequestAsync("QueryInterviews", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/interviews/query", "json", req, runtime));
        }

        public ReportMessageStatusResponse ReportMessageStatus(ReportMessageStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReportMessageStatusHeaders headers = new ReportMessageStatusHeaders();
            return ReportMessageStatusWithOptions(request, headers, runtime);
        }

        public async Task<ReportMessageStatusResponse> ReportMessageStatusAsync(ReportMessageStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReportMessageStatusHeaders headers = new ReportMessageStatusHeaders();
            return await ReportMessageStatusWithOptionsAsync(request, headers, runtime);
        }

        public ReportMessageStatusResponse ReportMessageStatusWithOptions(ReportMessageStatusRequest request, ReportMessageStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                body["errorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMsg))
            {
                body["errorMsg"] = request.ErrorMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["messageId"] = request.MessageId;
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
            return TeaModel.ToObject<ReportMessageStatusResponse>(DoROARequest("ReportMessageStatus", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/channels/messages/statuses/report", "json", req, runtime));
        }

        public async Task<ReportMessageStatusResponse> ReportMessageStatusWithOptionsAsync(ReportMessageStatusRequest request, ReportMessageStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                body["errorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMsg))
            {
                body["errorMsg"] = request.ErrorMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["messageId"] = request.MessageId;
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
            return TeaModel.ToObject<ReportMessageStatusResponse>(await DoROARequestAsync("ReportMessageStatus", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/channels/messages/statuses/report", "json", req, runtime));
        }

        public SyncChannelMessageResponse SyncChannelMessage(SyncChannelMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncChannelMessageHeaders headers = new SyncChannelMessageHeaders();
            return SyncChannelMessageWithOptions(request, headers, runtime);
        }

        public async Task<SyncChannelMessageResponse> SyncChannelMessageAsync(SyncChannelMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncChannelMessageHeaders headers = new SyncChannelMessageHeaders();
            return await SyncChannelMessageWithOptionsAsync(request, headers, runtime);
        }

        public SyncChannelMessageResponse SyncChannelMessageWithOptions(SyncChannelMessageRequest request, SyncChannelMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                body["createTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserId))
            {
                body["receiverUserId"] = request.ReceiverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUserId))
            {
                body["senderUserId"] = request.SenderUserId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<SyncChannelMessageResponse>(DoROARequest("SyncChannelMessage", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/channels/messages/sync", "json", req, runtime));
        }

        public async Task<SyncChannelMessageResponse> SyncChannelMessageWithOptionsAsync(SyncChannelMessageRequest request, SyncChannelMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                body["createTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserId))
            {
                body["receiverUserId"] = request.ReceiverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUserId))
            {
                body["senderUserId"] = request.SenderUserId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<SyncChannelMessageResponse>(await DoROARequestAsync("SyncChannelMessage", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/channels/messages/sync", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateInterviewSignInInfoResponse>(await DoROARequestAsync("UpdateInterviewSignInInfo", "ats_1.0", "HTTP", "PUT", "AK", "/v1.0/ats/interviews/" + interviewId + "/signInInfos", "none", req, runtime));
        }

        public UpdateJobDeliverResponse UpdateJobDeliver(UpdateJobDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateJobDeliverHeaders headers = new UpdateJobDeliverHeaders();
            return UpdateJobDeliverWithOptions(request, headers, runtime);
        }

        public async Task<UpdateJobDeliverResponse> UpdateJobDeliverAsync(UpdateJobDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateJobDeliverHeaders headers = new UpdateJobDeliverHeaders();
            return await UpdateJobDeliverWithOptionsAsync(request, headers, runtime);
        }

        public UpdateJobDeliverResponse UpdateJobDeliverWithOptions(UpdateJobDeliverRequest request, UpdateJobDeliverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["jobId"] = request.JobId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelOuterId))
            {
                body["channelOuterId"] = request.ChannelOuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverUserId))
            {
                body["deliverUserId"] = request.DeliverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                body["errorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMsg))
            {
                body["errorMsg"] = request.ErrorMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTime))
            {
                body["opTime"] = request.OpTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
            return TeaModel.ToObject<UpdateJobDeliverResponse>(DoROARequest("UpdateJobDeliver", "ats_1.0", "HTTP", "PUT", "AK", "/v1.0/ats/jobs/deliveryStatus", "json", req, runtime));
        }

        public async Task<UpdateJobDeliverResponse> UpdateJobDeliverWithOptionsAsync(UpdateJobDeliverRequest request, UpdateJobDeliverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["jobId"] = request.JobId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelOuterId))
            {
                body["channelOuterId"] = request.ChannelOuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverUserId))
            {
                body["deliverUserId"] = request.DeliverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                body["errorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMsg))
            {
                body["errorMsg"] = request.ErrorMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTime))
            {
                body["opTime"] = request.OpTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
            return TeaModel.ToObject<UpdateJobDeliverResponse>(await DoROARequestAsync("UpdateJobDeliver", "ats_1.0", "HTTP", "PUT", "AK", "/v1.0/ats/jobs/deliveryStatus", "json", req, runtime));
        }

    }
}
