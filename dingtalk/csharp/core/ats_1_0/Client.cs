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
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = _client;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddApplicationRegFormTemplate",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/flows/applicationRegForms/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddApplicationRegFormTemplateResponse>(Execute(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddApplicationRegFormTemplate",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/flows/applicationRegForms/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddApplicationRegFormTemplateResponse>(await ExecuteAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFile",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/files",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFileResponse>(Execute(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFile",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/files",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFileResponse>(await ExecuteAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserAccount",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/channels/users/accounts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserAccountResponse>(Execute(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserAccount",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/channels/users/accounts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserAccountResponse>(await ExecuteAsync(params_, req, runtime));
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

        public CollectRecruitJobDetailResponse CollectRecruitJobDetailWithOptions(CollectRecruitJobDetailRequest request, CollectRecruitJobDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobInfo))
            {
                body["jobInfo"] = request.JobInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutCorpId))
            {
                body["outCorpId"] = request.OutCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutCorpName))
            {
                body["outCorpName"] = request.OutCorpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecruitUserInfo))
            {
                body["recruitUserInfo"] = request.RecruitUserInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTime))
            {
                body["updateTime"] = request.UpdateTime;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CollectRecruitJobDetail",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/channels/jobs/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollectRecruitJobDetailResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollectRecruitJobDetailResponse> CollectRecruitJobDetailWithOptionsAsync(CollectRecruitJobDetailRequest request, CollectRecruitJobDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobInfo))
            {
                body["jobInfo"] = request.JobInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutCorpId))
            {
                body["outCorpId"] = request.OutCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutCorpName))
            {
                body["outCorpName"] = request.OutCorpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecruitUserInfo))
            {
                body["recruitUserInfo"] = request.RecruitUserInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTime))
            {
                body["updateTime"] = request.UpdateTime;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CollectRecruitJobDetail",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/channels/jobs/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollectRecruitJobDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollectRecruitJobDetailResponse CollectRecruitJobDetail(CollectRecruitJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollectRecruitJobDetailHeaders headers = new CollectRecruitJobDetailHeaders();
            return CollectRecruitJobDetailWithOptions(request, headers, runtime);
        }

        public async Task<CollectRecruitJobDetailResponse> CollectRecruitJobDetailAsync(CollectRecruitJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollectRecruitJobDetailHeaders headers = new CollectRecruitJobDetailHeaders();
            return await CollectRecruitJobDetailWithOptionsAsync(request, headers, runtime);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCode))
            {
                body["channelCode"] = request.ChannelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelOuterId))
            {
                body["channelOuterId"] = request.ChannelOuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelTalentId))
            {
                body["channelTalentId"] = request.ChannelTalentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverJobId))
            {
                body["deliverJobId"] = request.DeliverJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResumeChannelUrl))
            {
                body["resumeChannelUrl"] = request.ResumeChannelUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResumeData))
            {
                body["resumeData"] = request.ResumeData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResumeFile))
            {
                body["resumeFile"] = request.ResumeFile;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CollectResumeDetail",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/resumes/details",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollectResumeDetailResponse>(Execute(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCode))
            {
                body["channelCode"] = request.ChannelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelOuterId))
            {
                body["channelOuterId"] = request.ChannelOuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelTalentId))
            {
                body["channelTalentId"] = request.ChannelTalentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverJobId))
            {
                body["deliverJobId"] = request.DeliverJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResumeChannelUrl))
            {
                body["resumeChannelUrl"] = request.ResumeChannelUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResumeData))
            {
                body["resumeData"] = request.ResumeData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResumeFile))
            {
                body["resumeFile"] = request.ResumeFile;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CollectResumeDetail",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/resumes/details",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollectResumeDetailResponse>(await ExecuteAsync(params_, req, runtime));
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

        public CollectResumeMailResponse CollectResumeMailWithOptions(CollectResumeMailRequest request, CollectResumeMailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCode))
            {
                body["channelCode"] = request.ChannelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverJobId))
            {
                body["deliverJobId"] = request.DeliverJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromMailAddress))
            {
                body["fromMailAddress"] = request.FromMailAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryMailImport))
            {
                body["historyMailImport"] = request.HistoryMailImport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MailId))
            {
                body["mailId"] = request.MailId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MailTitle))
            {
                body["mailTitle"] = request.MailTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiveMailAddress))
            {
                body["receiveMailAddress"] = request.ReceiveMailAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiveMailType))
            {
                body["receiveMailType"] = request.ReceiveMailType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceivedTime))
            {
                body["receivedTime"] = request.ReceivedTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResumeChannelUrl))
            {
                body["resumeChannelUrl"] = request.ResumeChannelUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResumeFile))
            {
                body["resumeFile"] = request.ResumeFile;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CollectResumeMail",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/resumes/mails",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollectResumeMailResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollectResumeMailResponse> CollectResumeMailWithOptionsAsync(CollectResumeMailRequest request, CollectResumeMailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCode))
            {
                body["channelCode"] = request.ChannelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverJobId))
            {
                body["deliverJobId"] = request.DeliverJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromMailAddress))
            {
                body["fromMailAddress"] = request.FromMailAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryMailImport))
            {
                body["historyMailImport"] = request.HistoryMailImport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MailId))
            {
                body["mailId"] = request.MailId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MailTitle))
            {
                body["mailTitle"] = request.MailTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiveMailAddress))
            {
                body["receiveMailAddress"] = request.ReceiveMailAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiveMailType))
            {
                body["receiveMailType"] = request.ReceiveMailType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceivedTime))
            {
                body["receivedTime"] = request.ReceivedTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResumeChannelUrl))
            {
                body["resumeChannelUrl"] = request.ResumeChannelUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResumeFile))
            {
                body["resumeFile"] = request.ResumeFile;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CollectResumeMail",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/resumes/mails",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollectResumeMailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollectResumeMailResponse CollectResumeMail(CollectResumeMailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollectResumeMailHeaders headers = new CollectResumeMailHeaders();
            return CollectResumeMailWithOptions(request, headers, runtime);
        }

        public async Task<CollectResumeMailResponse> CollectResumeMailAsync(CollectResumeMailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollectResumeMailHeaders headers = new CollectResumeMailHeaders();
            return await CollectResumeMailWithOptionsAsync(request, headers, runtime);
        }

        public ConfirmRightsResponse ConfirmRightsWithOptions(string rightsCode, ConfirmRightsRequest request, ConfirmRightsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmRights",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/rights/" + rightsCode + "/confirm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmRightsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ConfirmRightsResponse> ConfirmRightsWithOptionsAsync(string rightsCode, ConfirmRightsRequest request, ConfirmRightsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmRights",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/rights/" + rightsCode + "/confirm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmRightsResponse>(await ExecuteAsync(params_, req, runtime));
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

        public FinishBeginnerTaskResponse FinishBeginnerTaskWithOptions(string taskCode, FinishBeginnerTaskRequest request, FinishBeginnerTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FinishBeginnerTask",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/beginnerTasks/" + taskCode + "/finish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishBeginnerTaskResponse>(Execute(params_, req, runtime));
        }

        public async Task<FinishBeginnerTaskResponse> FinishBeginnerTaskWithOptionsAsync(string taskCode, FinishBeginnerTaskRequest request, FinishBeginnerTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FinishBeginnerTask",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/beginnerTasks/" + taskCode + "/finish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishBeginnerTaskResponse>(await ExecuteAsync(params_, req, runtime));
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

        public GetApplicationRegFormByFlowIdResponse GetApplicationRegFormByFlowIdWithOptions(string flowId, GetApplicationRegFormByFlowIdRequest request, GetApplicationRegFormByFlowIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplicationRegFormByFlowId",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/flows/" + flowId + "/applicationRegForms",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationRegFormByFlowIdResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetApplicationRegFormByFlowIdResponse> GetApplicationRegFormByFlowIdWithOptionsAsync(string flowId, GetApplicationRegFormByFlowIdRequest request, GetApplicationRegFormByFlowIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplicationRegFormByFlowId",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/flows/" + flowId + "/applicationRegForms",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationRegFormByFlowIdResponse>(await ExecuteAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCandidateByPhoneNumber",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/candidates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCandidateByPhoneNumberResponse>(Execute(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCandidateByPhoneNumber",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/candidates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCandidateByPhoneNumberResponse>(await ExecuteAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileUploadInfo",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/files/uploadInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileUploadInfoResponse>(Execute(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileUploadInfo",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/files/uploadInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileUploadInfoResponse>(await ExecuteAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowIdByRelationEntityId",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/flows/ids",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowIdByRelationEntityIdResponse>(Execute(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowIdByRelationEntityId",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/flows/ids",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowIdByRelationEntityIdResponse>(await ExecuteAsync(params_, req, runtime));
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

        public GetJobAuthResponse GetJobAuthWithOptions(string jobId, GetJobAuthRequest request, GetJobAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobAuth",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/auths/jobs/" + jobId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobAuthResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetJobAuthResponse> GetJobAuthWithOptionsAsync(string jobId, GetJobAuthRequest request, GetJobAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobAuth",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/auths/jobs/" + jobId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobAuthResponse>(await ExecuteAsync(params_, req, runtime));
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

        public QueryCandidatesResponse QueryCandidatesWithOptions(QueryCandidatesRequest request, QueryCandidatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatId))
            {
                body["statId"] = request.StatId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCandidates",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/candidates/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCandidatesResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryCandidatesResponse> QueryCandidatesWithOptionsAsync(QueryCandidatesRequest request, QueryCandidatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatId))
            {
                body["statId"] = request.StatId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCandidates",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/candidates/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCandidatesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryCandidatesResponse QueryCandidates(QueryCandidatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCandidatesHeaders headers = new QueryCandidatesHeaders();
            return QueryCandidatesWithOptions(request, headers, runtime);
        }

        public async Task<QueryCandidatesResponse> QueryCandidatesAsync(QueryCandidatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCandidatesHeaders headers = new QueryCandidatesHeaders();
            return await QueryCandidatesWithOptionsAsync(request, headers, runtime);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInterviews",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/interviews/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInterviewsResponse>(Execute(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInterviews",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/interviews/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInterviewsResponse>(await ExecuteAsync(params_, req, runtime));
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

        public ReportMessageStatusResponse ReportMessageStatusWithOptions(ReportMessageStatusRequest request, ReportMessageStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserId))
            {
                body["receiverUserId"] = request.ReceiverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUserId))
            {
                body["senderUserId"] = request.SenderUserId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportMessageStatus",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/channels/messages/statuses/report",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportMessageStatusResponse>(Execute(params_, req, runtime));
        }

        public async Task<ReportMessageStatusResponse> ReportMessageStatusWithOptionsAsync(ReportMessageStatusRequest request, ReportMessageStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserId))
            {
                body["receiverUserId"] = request.ReceiverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUserId))
            {
                body["senderUserId"] = request.SenderUserId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportMessageStatus",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/channels/messages/statuses/report",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportMessageStatusResponse>(await ExecuteAsync(params_, req, runtime));
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

        public SyncChannelMessageResponse SyncChannelMessageWithOptions(SyncChannelMessageRequest request, SyncChannelMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncChannelMessage",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/channels/messages/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncChannelMessageResponse>(Execute(params_, req, runtime));
        }

        public async Task<SyncChannelMessageResponse> SyncChannelMessageWithOptionsAsync(SyncChannelMessageRequest request, SyncChannelMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncChannelMessage",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/channels/messages/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncChannelMessageResponse>(await ExecuteAsync(params_, req, runtime));
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

        public UpdateApplicationRegFormResponse UpdateApplicationRegFormWithOptions(string flowId, UpdateApplicationRegFormRequest request, UpdateApplicationRegFormHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingPanFile))
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationRegForm",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/flows/" + flowId + "/applicationRegForms",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationRegFormResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateApplicationRegFormResponse> UpdateApplicationRegFormWithOptionsAsync(string flowId, UpdateApplicationRegFormRequest request, UpdateApplicationRegFormHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingPanFile))
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationRegForm",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/flows/" + flowId + "/applicationRegForms",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationRegFormResponse>(await ExecuteAsync(params_, req, runtime));
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

        public UpdateInterviewSignInInfoResponse UpdateInterviewSignInInfoWithOptions(string interviewId, UpdateInterviewSignInInfoRequest request, UpdateInterviewSignInInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInterviewSignInInfo",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/interviews/" + interviewId + "/signInInfos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInterviewSignInInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateInterviewSignInInfoResponse> UpdateInterviewSignInInfoWithOptionsAsync(string interviewId, UpdateInterviewSignInInfoRequest request, UpdateInterviewSignInInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInterviewSignInInfo",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/interviews/" + interviewId + "/signInInfos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInterviewSignInInfoResponse>(await ExecuteAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateJobDeliver",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/jobs/deliveryStatus",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateJobDeliverResponse>(Execute(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateJobDeliver",
                Version = "ats_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/ats/jobs/deliveryStatus",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateJobDeliverResponse>(await ExecuteAsync(params_, req, runtime));
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

    }
}
