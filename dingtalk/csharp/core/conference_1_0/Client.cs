// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkconference_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 取消预约会议
         *
         * @param request CancelScheduleConferenceRequest
         * @param headers CancelScheduleConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelScheduleConferenceResponse
         */
        public CancelScheduleConferenceResponse CancelScheduleConferenceWithOptions(CancelScheduleConferenceRequest request, CancelScheduleConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["scheduleConferenceId"] = request.ScheduleConferenceId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelScheduleConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelScheduleConferenceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 取消预约会议
         *
         * @param request CancelScheduleConferenceRequest
         * @param headers CancelScheduleConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelScheduleConferenceResponse
         */
        public async Task<CancelScheduleConferenceResponse> CancelScheduleConferenceWithOptionsAsync(CancelScheduleConferenceRequest request, CancelScheduleConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["scheduleConferenceId"] = request.ScheduleConferenceId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelScheduleConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelScheduleConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 取消预约会议
         *
         * @param request CancelScheduleConferenceRequest
         * @return CancelScheduleConferenceResponse
         */
        public CancelScheduleConferenceResponse CancelScheduleConference(CancelScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelScheduleConferenceHeaders headers = new CancelScheduleConferenceHeaders();
            return CancelScheduleConferenceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 取消预约会议
         *
         * @param request CancelScheduleConferenceRequest
         * @return CancelScheduleConferenceResponse
         */
        public async Task<CancelScheduleConferenceResponse> CancelScheduleConferenceAsync(CancelScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelScheduleConferenceHeaders headers = new CancelScheduleConferenceHeaders();
            return await CancelScheduleConferenceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 关闭视频会议
         *
         * @param request CloseVideoConferenceRequest
         * @param headers CloseVideoConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloseVideoConferenceResponse
         */
        public CloseVideoConferenceResponse CloseVideoConferenceWithOptions(string conferenceId, CloseVideoConferenceRequest request, CloseVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "CloseVideoConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseVideoConferenceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 关闭视频会议
         *
         * @param request CloseVideoConferenceRequest
         * @param headers CloseVideoConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloseVideoConferenceResponse
         */
        public async Task<CloseVideoConferenceResponse> CloseVideoConferenceWithOptionsAsync(string conferenceId, CloseVideoConferenceRequest request, CloseVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "CloseVideoConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseVideoConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 关闭视频会议
         *
         * @param request CloseVideoConferenceRequest
         * @return CloseVideoConferenceResponse
         */
        public CloseVideoConferenceResponse CloseVideoConference(string conferenceId, CloseVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseVideoConferenceHeaders headers = new CloseVideoConferenceHeaders();
            return CloseVideoConferenceWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 关闭视频会议
         *
         * @param request CloseVideoConferenceRequest
         * @return CloseVideoConferenceResponse
         */
        public async Task<CloseVideoConferenceResponse> CloseVideoConferenceAsync(string conferenceId, CloseVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseVideoConferenceHeaders headers = new CloseVideoConferenceHeaders();
            return await CloseVideoConferenceWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 设置联席主持人
         *
         * @param request CohostsRequest
         * @param headers CohostsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CohostsResponse
         */
        public CohostsResponse CohostsWithOptions(string conferenceId, CohostsRequest request, CohostsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserList))
            {
                body["userList"] = request.UserList;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Cohosts",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/coHosts/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CohostsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 设置联席主持人
         *
         * @param request CohostsRequest
         * @param headers CohostsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CohostsResponse
         */
        public async Task<CohostsResponse> CohostsWithOptionsAsync(string conferenceId, CohostsRequest request, CohostsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserList))
            {
                body["userList"] = request.UserList;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Cohosts",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/coHosts/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CohostsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 设置联席主持人
         *
         * @param request CohostsRequest
         * @return CohostsResponse
         */
        public CohostsResponse Cohosts(string conferenceId, CohostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CohostsHeaders headers = new CohostsHeaders();
            return CohostsWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 设置联席主持人
         *
         * @param request CohostsRequest
         * @return CohostsResponse
         */
        public async Task<CohostsResponse> CohostsAsync(string conferenceId, CohostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CohostsHeaders headers = new CohostsHeaders();
            return await CohostsWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 创建专属短链
         *
         * @param request CreateCustomShortLinkRequest
         * @param headers CreateCustomShortLinkHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCustomShortLinkResponse
         */
        public CreateCustomShortLinkResponse CreateCustomShortLinkWithOptions(CreateCustomShortLinkRequest request, CreateCustomShortLinkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtensionAppBizData))
            {
                body["extensionAppBizData"] = request.ExtensionAppBizData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["scheduleConferenceId"] = request.ScheduleConferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseExtensionApp))
            {
                body["useExtensionApp"] = request.UseExtensionApp;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomShortLink",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/customShortLinks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomShortLinkResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建专属短链
         *
         * @param request CreateCustomShortLinkRequest
         * @param headers CreateCustomShortLinkHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCustomShortLinkResponse
         */
        public async Task<CreateCustomShortLinkResponse> CreateCustomShortLinkWithOptionsAsync(CreateCustomShortLinkRequest request, CreateCustomShortLinkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtensionAppBizData))
            {
                body["extensionAppBizData"] = request.ExtensionAppBizData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["scheduleConferenceId"] = request.ScheduleConferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseExtensionApp))
            {
                body["useExtensionApp"] = request.UseExtensionApp;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomShortLink",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/customShortLinks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomShortLinkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建专属短链
         *
         * @param request CreateCustomShortLinkRequest
         * @return CreateCustomShortLinkResponse
         */
        public CreateCustomShortLinkResponse CreateCustomShortLink(CreateCustomShortLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomShortLinkHeaders headers = new CreateCustomShortLinkHeaders();
            return CreateCustomShortLinkWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建专属短链
         *
         * @param request CreateCustomShortLinkRequest
         * @return CreateCustomShortLinkResponse
         */
        public async Task<CreateCustomShortLinkResponse> CreateCustomShortLinkAsync(CreateCustomShortLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomShortLinkHeaders headers = new CreateCustomShortLinkHeaders();
            return await CreateCustomShortLinkWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建预约会议
         *
         * @param request CreateScheduleConferenceRequest
         * @param headers CreateScheduleConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScheduleConferenceResponse
         */
        public CreateScheduleConferenceResponse CreateScheduleConferenceWithOptions(CreateScheduleConferenceRequest request, CreateScheduleConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduleConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduleConferenceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建预约会议
         *
         * @param request CreateScheduleConferenceRequest
         * @param headers CreateScheduleConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScheduleConferenceResponse
         */
        public async Task<CreateScheduleConferenceResponse> CreateScheduleConferenceWithOptionsAsync(CreateScheduleConferenceRequest request, CreateScheduleConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduleConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduleConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建预约会议
         *
         * @param request CreateScheduleConferenceRequest
         * @return CreateScheduleConferenceResponse
         */
        public CreateScheduleConferenceResponse CreateScheduleConference(CreateScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateScheduleConferenceHeaders headers = new CreateScheduleConferenceHeaders();
            return CreateScheduleConferenceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建预约会议
         *
         * @param request CreateScheduleConferenceRequest
         * @return CreateScheduleConferenceResponse
         */
        public async Task<CreateScheduleConferenceResponse> CreateScheduleConferenceAsync(CreateScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateScheduleConferenceHeaders headers = new CreateScheduleConferenceHeaders();
            return await CreateScheduleConferenceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建视频会议
         *
         * @param request CreateVideoConferenceRequest
         * @param headers CreateVideoConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVideoConferenceResponse
         */
        public CreateVideoConferenceResponse CreateVideoConferenceWithOptions(CreateVideoConferenceRequest request, CreateVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfTitle))
            {
                body["confTitle"] = request.ConfTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteCaller))
            {
                body["inviteCaller"] = request.InviteCaller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteUserIds))
            {
                body["inviteUserIds"] = request.InviteUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoConferenceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建视频会议
         *
         * @param request CreateVideoConferenceRequest
         * @param headers CreateVideoConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVideoConferenceResponse
         */
        public async Task<CreateVideoConferenceResponse> CreateVideoConferenceWithOptionsAsync(CreateVideoConferenceRequest request, CreateVideoConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfTitle))
            {
                body["confTitle"] = request.ConfTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteCaller))
            {
                body["inviteCaller"] = request.InviteCaller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteUserIds))
            {
                body["inviteUserIds"] = request.InviteUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建视频会议
         *
         * @param request CreateVideoConferenceRequest
         * @return CreateVideoConferenceResponse
         */
        public CreateVideoConferenceResponse CreateVideoConference(CreateVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVideoConferenceHeaders headers = new CreateVideoConferenceHeaders();
            return CreateVideoConferenceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建视频会议
         *
         * @param request CreateVideoConferenceRequest
         * @return CreateVideoConferenceResponse
         */
        public async Task<CreateVideoConferenceResponse> CreateVideoConferenceAsync(CreateVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVideoConferenceHeaders headers = new CreateVideoConferenceHeaders();
            return await CreateVideoConferenceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 设置全员看他
         *
         * @param request FocusRequest
         * @param headers FocusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FocusResponse
         */
        public FocusResponse FocusWithOptions(string conferenceId, FocusRequest request, FocusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Focus",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/focus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FocusResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 设置全员看他
         *
         * @param request FocusRequest
         * @param headers FocusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FocusResponse
         */
        public async Task<FocusResponse> FocusWithOptionsAsync(string conferenceId, FocusRequest request, FocusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Focus",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/focus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FocusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 设置全员看他
         *
         * @param request FocusRequest
         * @return FocusResponse
         */
        public FocusResponse Focus(string conferenceId, FocusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FocusHeaders headers = new FocusHeaders();
            return FocusWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 设置全员看他
         *
         * @param request FocusRequest
         * @return FocusResponse
         */
        public async Task<FocusResponse> FocusAsync(string conferenceId, FocusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FocusHeaders headers = new FocusHeaders();
            return await FocusWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 通过conferenceId获取指定音视频会议信息
         *
         * @param request GetConfDataByConferenceIdRequest
         * @param headers GetConfDataByConferenceIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConfDataByConferenceIdResponse
         */
        public GetConfDataByConferenceIdResponse GetConfDataByConferenceIdWithOptions(string conferenceId, GetConfDataByConferenceIdRequest request, GetConfDataByConferenceIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealData))
            {
                query["realData"] = request.RealData;
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
                Action = "GetConfDataByConferenceId",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfDataByConferenceIdResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通过conferenceId获取指定音视频会议信息
         *
         * @param request GetConfDataByConferenceIdRequest
         * @param headers GetConfDataByConferenceIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConfDataByConferenceIdResponse
         */
        public async Task<GetConfDataByConferenceIdResponse> GetConfDataByConferenceIdWithOptionsAsync(string conferenceId, GetConfDataByConferenceIdRequest request, GetConfDataByConferenceIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealData))
            {
                query["realData"] = request.RealData;
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
                Action = "GetConfDataByConferenceId",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfDataByConferenceIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通过conferenceId获取指定音视频会议信息
         *
         * @param request GetConfDataByConferenceIdRequest
         * @return GetConfDataByConferenceIdResponse
         */
        public GetConfDataByConferenceIdResponse GetConfDataByConferenceId(string conferenceId, GetConfDataByConferenceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConfDataByConferenceIdHeaders headers = new GetConfDataByConferenceIdHeaders();
            return GetConfDataByConferenceIdWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 通过conferenceId获取指定音视频会议信息
         *
         * @param request GetConfDataByConferenceIdRequest
         * @return GetConfDataByConferenceIdResponse
         */
        public async Task<GetConfDataByConferenceIdResponse> GetConfDataByConferenceIdAsync(string conferenceId, GetConfDataByConferenceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConfDataByConferenceIdHeaders headers = new GetConfDataByConferenceIdHeaders();
            return await GetConfDataByConferenceIdWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 通过conferenceId获取指定音视频会议成员信息
         *
         * @param request GetConfDetailDataRequest
         * @param headers GetConfDetailDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConfDetailDataResponse
         */
        public GetConfDetailDataResponse GetConfDetailDataWithOptions(string conferenceId, GetConfDetailDataRequest request, GetConfDetailDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nick))
            {
                query["nick"] = request.Nick;
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
                Action = "GetConfDetailData",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfDetailDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通过conferenceId获取指定音视频会议成员信息
         *
         * @param request GetConfDetailDataRequest
         * @param headers GetConfDetailDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConfDetailDataResponse
         */
        public async Task<GetConfDetailDataResponse> GetConfDetailDataWithOptionsAsync(string conferenceId, GetConfDetailDataRequest request, GetConfDetailDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nick))
            {
                query["nick"] = request.Nick;
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
                Action = "GetConfDetailData",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfDetailDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通过conferenceId获取指定音视频会议成员信息
         *
         * @param request GetConfDetailDataRequest
         * @return GetConfDetailDataResponse
         */
        public GetConfDetailDataResponse GetConfDetailData(string conferenceId, GetConfDetailDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConfDetailDataHeaders headers = new GetConfDetailDataHeaders();
            return GetConfDetailDataWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 通过conferenceId获取指定音视频会议成员信息
         *
         * @param request GetConfDetailDataRequest
         * @return GetConfDetailDataResponse
         */
        public async Task<GetConfDetailDataResponse> GetConfDetailDataAsync(string conferenceId, GetConfDetailDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConfDetailDataHeaders headers = new GetConfDetailDataHeaders();
            return await GetConfDetailDataWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 获取音视频会议列表数据
         *
         * @param request GetHistoryConfDataListRequest
         * @param headers GetHistoryConfDataListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHistoryConfDataListResponse
         */
        public GetHistoryConfDataListResponse GetHistoryConfDataListWithOptions(GetHistoryConfDataListRequest request, GetHistoryConfDataListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorNike))
            {
                query["creatorNike"] = request.CreatorNike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeType))
            {
                query["freeType"] = request.FreeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealData))
            {
                query["realData"] = request.RealData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
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
                Action = "GetHistoryConfDataList",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/histories/dataLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoryConfDataListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取音视频会议列表数据
         *
         * @param request GetHistoryConfDataListRequest
         * @param headers GetHistoryConfDataListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHistoryConfDataListResponse
         */
        public async Task<GetHistoryConfDataListResponse> GetHistoryConfDataListWithOptionsAsync(GetHistoryConfDataListRequest request, GetHistoryConfDataListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorNike))
            {
                query["creatorNike"] = request.CreatorNike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeType))
            {
                query["freeType"] = request.FreeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealData))
            {
                query["realData"] = request.RealData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
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
                Action = "GetHistoryConfDataList",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/histories/dataLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoryConfDataListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取音视频会议列表数据
         *
         * @param request GetHistoryConfDataListRequest
         * @return GetHistoryConfDataListResponse
         */
        public GetHistoryConfDataListResponse GetHistoryConfDataList(GetHistoryConfDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHistoryConfDataListHeaders headers = new GetHistoryConfDataListHeaders();
            return GetHistoryConfDataListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取音视频会议列表数据
         *
         * @param request GetHistoryConfDataListRequest
         * @return GetHistoryConfDataListResponse
         */
        public async Task<GetHistoryConfDataListResponse> GetHistoryConfDataListAsync(GetHistoryConfDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHistoryConfDataListHeaders headers = new GetHistoryConfDataListHeaders();
            return await GetHistoryConfDataListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通过conferenceId和unionId获取最新会议质量数据
         *
         * @param request GetUserLastMetricRequest
         * @param headers GetUserLastMetricHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserLastMetricResponse
         */
        public GetUserLastMetricResponse GetUserLastMetricWithOptions(string conferenceId, GetUserLastMetricRequest request, GetUserLastMetricHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionIdList))
            {
                body["unionIdList"] = request.UnionIdList;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserLastMetric",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/lastMetricDatas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserLastMetricResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通过conferenceId和unionId获取最新会议质量数据
         *
         * @param request GetUserLastMetricRequest
         * @param headers GetUserLastMetricHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserLastMetricResponse
         */
        public async Task<GetUserLastMetricResponse> GetUserLastMetricWithOptionsAsync(string conferenceId, GetUserLastMetricRequest request, GetUserLastMetricHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionIdList))
            {
                body["unionIdList"] = request.UnionIdList;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserLastMetric",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/lastMetricDatas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserLastMetricResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通过conferenceId和unionId获取最新会议质量数据
         *
         * @param request GetUserLastMetricRequest
         * @return GetUserLastMetricResponse
         */
        public GetUserLastMetricResponse GetUserLastMetric(string conferenceId, GetUserLastMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserLastMetricHeaders headers = new GetUserLastMetricHeaders();
            return GetUserLastMetricWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 通过conferenceId和unionId获取最新会议质量数据
         *
         * @param request GetUserLastMetricRequest
         * @return GetUserLastMetricResponse
         */
        public async Task<GetUserLastMetricResponse> GetUserLastMetricAsync(string conferenceId, GetUserLastMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserLastMetricHeaders headers = new GetUserLastMetricHeaders();
            return await GetUserLastMetricWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 通过conferenceId和unionId获取指定音视频会议人员的会议质量数据
         *
         * @param request GetUserMetricDataRequest
         * @param headers GetUserMetricDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserMetricDataResponse
         */
        public GetUserMetricDataResponse GetUserMetricDataWithOptions(string conferenceId, GetUserMetricDataRequest request, GetUserMetricDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["beginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "GetUserMetricData",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/metricDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserMetricDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通过conferenceId和unionId获取指定音视频会议人员的会议质量数据
         *
         * @param request GetUserMetricDataRequest
         * @param headers GetUserMetricDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserMetricDataResponse
         */
        public async Task<GetUserMetricDataResponse> GetUserMetricDataWithOptionsAsync(string conferenceId, GetUserMetricDataRequest request, GetUserMetricDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["beginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "GetUserMetricData",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/metricDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserMetricDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通过conferenceId和unionId获取指定音视频会议人员的会议质量数据
         *
         * @param request GetUserMetricDataRequest
         * @return GetUserMetricDataResponse
         */
        public GetUserMetricDataResponse GetUserMetricData(string conferenceId, GetUserMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserMetricDataHeaders headers = new GetUserMetricDataHeaders();
            return GetUserMetricDataWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 通过conferenceId和unionId获取指定音视频会议人员的会议质量数据
         *
         * @param request GetUserMetricDataRequest
         * @return GetUserMetricDataResponse
         */
        public async Task<GetUserMetricDataResponse> GetUserMetricDataAsync(string conferenceId, GetUserMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserMetricDataHeaders headers = new GetUserMetricDataHeaders();
            return await GetUserMetricDataWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 邀请其他人员
         *
         * @param request InviteUsersRequest
         * @param headers InviteUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InviteUsersResponse
         */
        public InviteUsersResponse InviteUsersWithOptions(string conferenceId, InviteUsersRequest request, InviteUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteeList))
            {
                body["inviteeList"] = request.InviteeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneInviteeList))
            {
                body["phoneInviteeList"] = request.PhoneInviteeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InviteUsers",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/users/invite",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InviteUsersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 邀请其他人员
         *
         * @param request InviteUsersRequest
         * @param headers InviteUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InviteUsersResponse
         */
        public async Task<InviteUsersResponse> InviteUsersWithOptionsAsync(string conferenceId, InviteUsersRequest request, InviteUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteeList))
            {
                body["inviteeList"] = request.InviteeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneInviteeList))
            {
                body["phoneInviteeList"] = request.PhoneInviteeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InviteUsers",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/users/invite",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InviteUsersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 邀请其他人员
         *
         * @param request InviteUsersRequest
         * @return InviteUsersResponse
         */
        public InviteUsersResponse InviteUsers(string conferenceId, InviteUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InviteUsersHeaders headers = new InviteUsersHeaders();
            return InviteUsersWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 邀请其他人员
         *
         * @param request InviteUsersRequest
         * @return InviteUsersResponse
         */
        public async Task<InviteUsersResponse> InviteUsersAsync(string conferenceId, InviteUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InviteUsersHeaders headers = new InviteUsersHeaders();
            return await InviteUsersWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 会议踢出成员
         *
         * @param request KickMembersRequest
         * @param headers KickMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return KickMembersResponse
         */
        public KickMembersResponse KickMembersWithOptions(string conferenceId, KickMembersRequest request, KickMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForbiddenRejoin))
            {
                body["forbiddenRejoin"] = request.ForbiddenRejoin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserList))
            {
                body["userList"] = request.UserList;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KickMembers",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/members/kick",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<KickMembersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 会议踢出成员
         *
         * @param request KickMembersRequest
         * @param headers KickMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return KickMembersResponse
         */
        public async Task<KickMembersResponse> KickMembersWithOptionsAsync(string conferenceId, KickMembersRequest request, KickMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForbiddenRejoin))
            {
                body["forbiddenRejoin"] = request.ForbiddenRejoin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserList))
            {
                body["userList"] = request.UserList;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KickMembers",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/members/kick",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<KickMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 会议踢出成员
         *
         * @param request KickMembersRequest
         * @return KickMembersResponse
         */
        public KickMembersResponse KickMembers(string conferenceId, KickMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            KickMembersHeaders headers = new KickMembersHeaders();
            return KickMembersWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 会议踢出成员
         *
         * @param request KickMembersRequest
         * @return KickMembersResponse
         */
        public async Task<KickMembersResponse> KickMembersAsync(string conferenceId, KickMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            KickMembersHeaders headers = new KickMembersHeaders();
            return await KickMembersWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 锁定会议
         *
         * @param request LockConferenceRequest
         * @param headers LockConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return LockConferenceResponse
         */
        public LockConferenceResponse LockConferenceWithOptions(string conferenceId, LockConferenceRequest request, LockConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LockConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/lock",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockConferenceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 锁定会议
         *
         * @param request LockConferenceRequest
         * @param headers LockConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return LockConferenceResponse
         */
        public async Task<LockConferenceResponse> LockConferenceWithOptionsAsync(string conferenceId, LockConferenceRequest request, LockConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LockConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/lock",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 锁定会议
         *
         * @param request LockConferenceRequest
         * @return LockConferenceResponse
         */
        public LockConferenceResponse LockConference(string conferenceId, LockConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LockConferenceHeaders headers = new LockConferenceHeaders();
            return LockConferenceWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 锁定会议
         *
         * @param request LockConferenceRequest
         * @return LockConferenceResponse
         */
        public async Task<LockConferenceResponse> LockConferenceAsync(string conferenceId, LockConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LockConferenceHeaders headers = new LockConferenceHeaders();
            return await LockConferenceWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 会议全员静音或解除静音
         *
         * @param request MuteAllRequest
         * @param headers MuteAllHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MuteAllResponse
         */
        public MuteAllResponse MuteAllWithOptions(string conferenceId, MuteAllRequest request, MuteAllHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceMute))
            {
                body["forceMute"] = request.ForceMute;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MuteAll",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/allMembers/mute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MuteAllResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 会议全员静音或解除静音
         *
         * @param request MuteAllRequest
         * @param headers MuteAllHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MuteAllResponse
         */
        public async Task<MuteAllResponse> MuteAllWithOptionsAsync(string conferenceId, MuteAllRequest request, MuteAllHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceMute))
            {
                body["forceMute"] = request.ForceMute;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MuteAll",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/allMembers/mute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MuteAllResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 会议全员静音或解除静音
         *
         * @param request MuteAllRequest
         * @return MuteAllResponse
         */
        public MuteAllResponse MuteAll(string conferenceId, MuteAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MuteAllHeaders headers = new MuteAllHeaders();
            return MuteAllWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 会议全员静音或解除静音
         *
         * @param request MuteAllRequest
         * @return MuteAllResponse
         */
        public async Task<MuteAllResponse> MuteAllAsync(string conferenceId, MuteAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MuteAllHeaders headers = new MuteAllHeaders();
            return await MuteAllWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 指定人员静音或取消静音
         *
         * @param request MuteMembersRequest
         * @param headers MuteMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MuteMembersResponse
         */
        public MuteMembersResponse MuteMembersWithOptions(string conferenceId, MuteMembersRequest request, MuteMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserList))
            {
                body["userList"] = request.UserList;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MuteMembers",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/members/mute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MuteMembersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 指定人员静音或取消静音
         *
         * @param request MuteMembersRequest
         * @param headers MuteMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MuteMembersResponse
         */
        public async Task<MuteMembersResponse> MuteMembersWithOptionsAsync(string conferenceId, MuteMembersRequest request, MuteMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserList))
            {
                body["userList"] = request.UserList;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MuteMembers",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/members/mute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MuteMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 指定人员静音或取消静音
         *
         * @param request MuteMembersRequest
         * @return MuteMembersResponse
         */
        public MuteMembersResponse MuteMembers(string conferenceId, MuteMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MuteMembersHeaders headers = new MuteMembersHeaders();
            return MuteMembersWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 指定人员静音或取消静音
         *
         * @param request MuteMembersRequest
         * @return MuteMembersResponse
         */
        public async Task<MuteMembersResponse> MuteMembersAsync(string conferenceId, MuteMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MuteMembersHeaders headers = new MuteMembersHeaders();
            return await MuteMembersWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 查询云录制文本信息
         *
         * @param request QueryCloudRecordTextRequest
         * @param headers QueryCloudRecordTextHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCloudRecordTextResponse
         */
        public QueryCloudRecordTextResponse QueryCloudRecordTextWithOptions(string conferenceId, QueryCloudRecordTextRequest request, QueryCloudRecordTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "QueryCloudRecordText",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/getTexts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordTextResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询云录制文本信息
         *
         * @param request QueryCloudRecordTextRequest
         * @param headers QueryCloudRecordTextHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCloudRecordTextResponse
         */
        public async Task<QueryCloudRecordTextResponse> QueryCloudRecordTextWithOptionsAsync(string conferenceId, QueryCloudRecordTextRequest request, QueryCloudRecordTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "QueryCloudRecordText",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/getTexts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordTextResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询云录制文本信息
         *
         * @param request QueryCloudRecordTextRequest
         * @return QueryCloudRecordTextResponse
         */
        public QueryCloudRecordTextResponse QueryCloudRecordText(string conferenceId, QueryCloudRecordTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordTextHeaders headers = new QueryCloudRecordTextHeaders();
            return QueryCloudRecordTextWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 查询云录制文本信息
         *
         * @param request QueryCloudRecordTextRequest
         * @return QueryCloudRecordTextResponse
         */
        public async Task<QueryCloudRecordTextResponse> QueryCloudRecordTextAsync(string conferenceId, QueryCloudRecordTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordTextHeaders headers = new QueryCloudRecordTextHeaders();
            return await QueryCloudRecordTextWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 查询云录制视频
         *
         * @param request QueryCloudRecordVideoRequest
         * @param headers QueryCloudRecordVideoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCloudRecordVideoResponse
         */
        public QueryCloudRecordVideoResponse QueryCloudRecordVideoWithOptions(string conferenceId, QueryCloudRecordVideoRequest request, QueryCloudRecordVideoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "QueryCloudRecordVideo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/getVideos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordVideoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询云录制视频
         *
         * @param request QueryCloudRecordVideoRequest
         * @param headers QueryCloudRecordVideoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCloudRecordVideoResponse
         */
        public async Task<QueryCloudRecordVideoResponse> QueryCloudRecordVideoWithOptionsAsync(string conferenceId, QueryCloudRecordVideoRequest request, QueryCloudRecordVideoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "QueryCloudRecordVideo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/getVideos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordVideoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询云录制视频
         *
         * @param request QueryCloudRecordVideoRequest
         * @return QueryCloudRecordVideoResponse
         */
        public QueryCloudRecordVideoResponse QueryCloudRecordVideo(string conferenceId, QueryCloudRecordVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordVideoHeaders headers = new QueryCloudRecordVideoHeaders();
            return QueryCloudRecordVideoWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 查询云录制视频
         *
         * @param request QueryCloudRecordVideoRequest
         * @return QueryCloudRecordVideoResponse
         */
        public async Task<QueryCloudRecordVideoResponse> QueryCloudRecordVideoAsync(string conferenceId, QueryCloudRecordVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordVideoHeaders headers = new QueryCloudRecordVideoHeaders();
            return await QueryCloudRecordVideoWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 查询云录制视频播放信息
         *
         * @param request QueryCloudRecordVideoPlayInfoRequest
         * @param headers QueryCloudRecordVideoPlayInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCloudRecordVideoPlayInfoResponse
         */
        public QueryCloudRecordVideoPlayInfoResponse QueryCloudRecordVideoPlayInfoWithOptions(string conferenceId, QueryCloudRecordVideoPlayInfoRequest request, QueryCloudRecordVideoPlayInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "QueryCloudRecordVideoPlayInfo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/videos/getPlayInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordVideoPlayInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询云录制视频播放信息
         *
         * @param request QueryCloudRecordVideoPlayInfoRequest
         * @param headers QueryCloudRecordVideoPlayInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCloudRecordVideoPlayInfoResponse
         */
        public async Task<QueryCloudRecordVideoPlayInfoResponse> QueryCloudRecordVideoPlayInfoWithOptionsAsync(string conferenceId, QueryCloudRecordVideoPlayInfoRequest request, QueryCloudRecordVideoPlayInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "QueryCloudRecordVideoPlayInfo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/videos/getPlayInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordVideoPlayInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询云录制视频播放信息
         *
         * @param request QueryCloudRecordVideoPlayInfoRequest
         * @return QueryCloudRecordVideoPlayInfoResponse
         */
        public QueryCloudRecordVideoPlayInfoResponse QueryCloudRecordVideoPlayInfo(string conferenceId, QueryCloudRecordVideoPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordVideoPlayInfoHeaders headers = new QueryCloudRecordVideoPlayInfoHeaders();
            return QueryCloudRecordVideoPlayInfoWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 查询云录制视频播放信息
         *
         * @param request QueryCloudRecordVideoPlayInfoRequest
         * @return QueryCloudRecordVideoPlayInfoResponse
         */
        public async Task<QueryCloudRecordVideoPlayInfoResponse> QueryCloudRecordVideoPlayInfoAsync(string conferenceId, QueryCloudRecordVideoPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordVideoPlayInfoHeaders headers = new QueryCloudRecordVideoPlayInfoHeaders();
            return await QueryCloudRecordVideoPlayInfoWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 查询视频会议信息
         *
         * @param headers QueryConferenceInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryConferenceInfoResponse
         */
        public QueryConferenceInfoResponse QueryConferenceInfoWithOptions(string conferenceId, QueryConferenceInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConferenceInfo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询视频会议信息
         *
         * @param headers QueryConferenceInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryConferenceInfoResponse
         */
        public async Task<QueryConferenceInfoResponse> QueryConferenceInfoWithOptionsAsync(string conferenceId, QueryConferenceInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConferenceInfo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询视频会议信息
         *
         * @return QueryConferenceInfoResponse
         */
        public QueryConferenceInfoResponse QueryConferenceInfo(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceInfoHeaders headers = new QueryConferenceInfoHeaders();
            return QueryConferenceInfoWithOptions(conferenceId, headers, runtime);
        }

        /**
         * @summary 查询视频会议信息
         *
         * @return QueryConferenceInfoResponse
         */
        public async Task<QueryConferenceInfoResponse> QueryConferenceInfoAsync(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceInfoHeaders headers = new QueryConferenceInfoHeaders();
            return await QueryConferenceInfoWithOptionsAsync(conferenceId, headers, runtime);
        }

        /**
         * @summary 批量查询视频会议信息
         *
         * @param request QueryConferenceInfoBatchRequest
         * @param headers QueryConferenceInfoBatchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryConferenceInfoBatchResponse
         */
        public QueryConferenceInfoBatchResponse QueryConferenceInfoBatchWithOptions(QueryConferenceInfoBatchRequest request, QueryConferenceInfoBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceIdList))
            {
                body["conferenceIdList"] = request.ConferenceIdList;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConferenceInfoBatch",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceInfoBatchResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量查询视频会议信息
         *
         * @param request QueryConferenceInfoBatchRequest
         * @param headers QueryConferenceInfoBatchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryConferenceInfoBatchResponse
         */
        public async Task<QueryConferenceInfoBatchResponse> QueryConferenceInfoBatchWithOptionsAsync(QueryConferenceInfoBatchRequest request, QueryConferenceInfoBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceIdList))
            {
                body["conferenceIdList"] = request.ConferenceIdList;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConferenceInfoBatch",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceInfoBatchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量查询视频会议信息
         *
         * @param request QueryConferenceInfoBatchRequest
         * @return QueryConferenceInfoBatchResponse
         */
        public QueryConferenceInfoBatchResponse QueryConferenceInfoBatch(QueryConferenceInfoBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceInfoBatchHeaders headers = new QueryConferenceInfoBatchHeaders();
            return QueryConferenceInfoBatchWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询视频会议信息
         *
         * @param request QueryConferenceInfoBatchRequest
         * @return QueryConferenceInfoBatchResponse
         */
        public async Task<QueryConferenceInfoBatchResponse> QueryConferenceInfoBatchAsync(QueryConferenceInfoBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceInfoBatchHeaders headers = new QueryConferenceInfoBatchHeaders();
            return await QueryConferenceInfoBatchWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询视频会议成员
         *
         * @param request QueryConferenceMembersRequest
         * @param headers QueryConferenceMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryConferenceMembersResponse
         */
        public QueryConferenceMembersResponse QueryConferenceMembersWithOptions(string conferenceId, QueryConferenceMembersRequest request, QueryConferenceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "QueryConferenceMembers",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceMembersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询视频会议成员
         *
         * @param request QueryConferenceMembersRequest
         * @param headers QueryConferenceMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryConferenceMembersResponse
         */
        public async Task<QueryConferenceMembersResponse> QueryConferenceMembersWithOptionsAsync(string conferenceId, QueryConferenceMembersRequest request, QueryConferenceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "QueryConferenceMembers",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询视频会议成员
         *
         * @param request QueryConferenceMembersRequest
         * @return QueryConferenceMembersResponse
         */
        public QueryConferenceMembersResponse QueryConferenceMembers(string conferenceId, QueryConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceMembersHeaders headers = new QueryConferenceMembersHeaders();
            return QueryConferenceMembersWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 查询视频会议成员
         *
         * @param request QueryConferenceMembersRequest
         * @return QueryConferenceMembersResponse
         */
        public async Task<QueryConferenceMembersResponse> QueryConferenceMembersAsync(string conferenceId, QueryConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceMembersHeaders headers = new QueryConferenceMembersHeaders();
            return await QueryConferenceMembersWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 查询会议闪记的音频信息
         *
         * @param request QueryMinutesAudioRequest
         * @param headers QueryMinutesAudioHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMinutesAudioResponse
         */
        public QueryMinutesAudioResponse QueryMinutesAudioWithOptions(string conferenceId, QueryMinutesAudioRequest request, QueryMinutesAudioHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "QueryMinutesAudio",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/audioInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesAudioResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询会议闪记的音频信息
         *
         * @param request QueryMinutesAudioRequest
         * @param headers QueryMinutesAudioHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMinutesAudioResponse
         */
        public async Task<QueryMinutesAudioResponse> QueryMinutesAudioWithOptionsAsync(string conferenceId, QueryMinutesAudioRequest request, QueryMinutesAudioHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "QueryMinutesAudio",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/audioInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesAudioResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询会议闪记的音频信息
         *
         * @param request QueryMinutesAudioRequest
         * @return QueryMinutesAudioResponse
         */
        public QueryMinutesAudioResponse QueryMinutesAudio(string conferenceId, QueryMinutesAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesAudioHeaders headers = new QueryMinutesAudioHeaders();
            return QueryMinutesAudioWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 查询会议闪记的音频信息
         *
         * @param request QueryMinutesAudioRequest
         * @return QueryMinutesAudioResponse
         */
        public async Task<QueryMinutesAudioResponse> QueryMinutesAudioAsync(string conferenceId, QueryMinutesAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesAudioHeaders headers = new QueryMinutesAudioHeaders();
            return await QueryMinutesAudioWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 查询会议闪记智能纪要
         *
         * @param request QueryMinutesSummaryRequest
         * @param headers QueryMinutesSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMinutesSummaryResponse
         */
        public QueryMinutesSummaryResponse QueryMinutesSummaryWithOptions(string conferenceId, QueryMinutesSummaryRequest request, QueryMinutesSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryTypeList))
            {
                body["summaryTypeList"] = request.SummaryTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMinutesSummary",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/summaries/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesSummaryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询会议闪记智能纪要
         *
         * @param request QueryMinutesSummaryRequest
         * @param headers QueryMinutesSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMinutesSummaryResponse
         */
        public async Task<QueryMinutesSummaryResponse> QueryMinutesSummaryWithOptionsAsync(string conferenceId, QueryMinutesSummaryRequest request, QueryMinutesSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryTypeList))
            {
                body["summaryTypeList"] = request.SummaryTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMinutesSummary",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/summaries/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询会议闪记智能纪要
         *
         * @param request QueryMinutesSummaryRequest
         * @return QueryMinutesSummaryResponse
         */
        public QueryMinutesSummaryResponse QueryMinutesSummary(string conferenceId, QueryMinutesSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesSummaryHeaders headers = new QueryMinutesSummaryHeaders();
            return QueryMinutesSummaryWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 查询会议闪记智能纪要
         *
         * @param request QueryMinutesSummaryRequest
         * @return QueryMinutesSummaryResponse
         */
        public async Task<QueryMinutesSummaryResponse> QueryMinutesSummaryAsync(string conferenceId, QueryMinutesSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesSummaryHeaders headers = new QueryMinutesSummaryHeaders();
            return await QueryMinutesSummaryWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 查询会议闪记文本信息
         *
         * @param request QueryMinutesTextRequest
         * @param headers QueryMinutesTextHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMinutesTextResponse
         */
        public QueryMinutesTextResponse QueryMinutesTextWithOptions(string conferenceId, QueryMinutesTextRequest request, QueryMinutesTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "QueryMinutesText",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/textInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesTextResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询会议闪记文本信息
         *
         * @param request QueryMinutesTextRequest
         * @param headers QueryMinutesTextHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMinutesTextResponse
         */
        public async Task<QueryMinutesTextResponse> QueryMinutesTextWithOptionsAsync(string conferenceId, QueryMinutesTextRequest request, QueryMinutesTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "QueryMinutesText",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/textInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesTextResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询会议闪记文本信息
         *
         * @param request QueryMinutesTextRequest
         * @return QueryMinutesTextResponse
         */
        public QueryMinutesTextResponse QueryMinutesText(string conferenceId, QueryMinutesTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesTextHeaders headers = new QueryMinutesTextHeaders();
            return QueryMinutesTextWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 查询会议闪记文本信息
         *
         * @param request QueryMinutesTextRequest
         * @return QueryMinutesTextResponse
         */
        public async Task<QueryMinutesTextResponse> QueryMinutesTextAsync(string conferenceId, QueryMinutesTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesTextHeaders headers = new QueryMinutesTextHeaders();
            return await QueryMinutesTextWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 查询预约会议设置
         *
         * @param request QueryScheduleConfSettingsRequest
         * @param headers QueryScheduleConfSettingsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryScheduleConfSettingsResponse
         */
        public QueryScheduleConfSettingsResponse QueryScheduleConfSettingsWithOptions(QueryScheduleConfSettingsRequest request, QueryScheduleConfSettingsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                query["scheduleConferenceId"] = request.ScheduleConferenceId;
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
                Action = "QueryScheduleConfSettings",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences/settings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConfSettingsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询预约会议设置
         *
         * @param request QueryScheduleConfSettingsRequest
         * @param headers QueryScheduleConfSettingsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryScheduleConfSettingsResponse
         */
        public async Task<QueryScheduleConfSettingsResponse> QueryScheduleConfSettingsWithOptionsAsync(QueryScheduleConfSettingsRequest request, QueryScheduleConfSettingsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                query["scheduleConferenceId"] = request.ScheduleConferenceId;
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
                Action = "QueryScheduleConfSettings",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences/settings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConfSettingsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询预约会议设置
         *
         * @param request QueryScheduleConfSettingsRequest
         * @return QueryScheduleConfSettingsResponse
         */
        public QueryScheduleConfSettingsResponse QueryScheduleConfSettings(QueryScheduleConfSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConfSettingsHeaders headers = new QueryScheduleConfSettingsHeaders();
            return QueryScheduleConfSettingsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询预约会议设置
         *
         * @param request QueryScheduleConfSettingsRequest
         * @return QueryScheduleConfSettingsResponse
         */
        public async Task<QueryScheduleConfSettingsResponse> QueryScheduleConfSettingsAsync(QueryScheduleConfSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConfSettingsHeaders headers = new QueryScheduleConfSettingsHeaders();
            return await QueryScheduleConfSettingsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询预约会议信息
         *
         * @param request QueryScheduleConferenceRequest
         * @param headers QueryScheduleConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryScheduleConferenceResponse
         */
        public QueryScheduleConferenceResponse QueryScheduleConferenceWithOptions(string scheduleConferenceId, QueryScheduleConferenceRequest request, QueryScheduleConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUnionId))
            {
                query["requestUnionId"] = request.RequestUnionId;
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
                Action = "QueryScheduleConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences/" + scheduleConferenceId + "/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConferenceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询预约会议信息
         *
         * @param request QueryScheduleConferenceRequest
         * @param headers QueryScheduleConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryScheduleConferenceResponse
         */
        public async Task<QueryScheduleConferenceResponse> QueryScheduleConferenceWithOptionsAsync(string scheduleConferenceId, QueryScheduleConferenceRequest request, QueryScheduleConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUnionId))
            {
                query["requestUnionId"] = request.RequestUnionId;
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
                Action = "QueryScheduleConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences/" + scheduleConferenceId + "/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询预约会议信息
         *
         * @param request QueryScheduleConferenceRequest
         * @return QueryScheduleConferenceResponse
         */
        public QueryScheduleConferenceResponse QueryScheduleConference(string scheduleConferenceId, QueryScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConferenceHeaders headers = new QueryScheduleConferenceHeaders();
            return QueryScheduleConferenceWithOptions(scheduleConferenceId, request, headers, runtime);
        }

        /**
         * @summary 查询预约会议信息
         *
         * @param request QueryScheduleConferenceRequest
         * @return QueryScheduleConferenceResponse
         */
        public async Task<QueryScheduleConferenceResponse> QueryScheduleConferenceAsync(string scheduleConferenceId, QueryScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConferenceHeaders headers = new QueryScheduleConferenceHeaders();
            return await QueryScheduleConferenceWithOptionsAsync(scheduleConferenceId, request, headers, runtime);
        }

        /**
         * @summary 分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息
         *
         * @param request QueryScheduleConferenceInfoRequest
         * @param headers QueryScheduleConferenceInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryScheduleConferenceInfoResponse
         */
        public QueryScheduleConferenceInfoResponse QueryScheduleConferenceInfoWithOptions(string scheduleConferenceId, QueryScheduleConferenceInfoRequest request, QueryScheduleConferenceInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "QueryScheduleConferenceInfo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/scheduleConferences/" + scheduleConferenceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConferenceInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息
         *
         * @param request QueryScheduleConferenceInfoRequest
         * @param headers QueryScheduleConferenceInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryScheduleConferenceInfoResponse
         */
        public async Task<QueryScheduleConferenceInfoResponse> QueryScheduleConferenceInfoWithOptionsAsync(string scheduleConferenceId, QueryScheduleConferenceInfoRequest request, QueryScheduleConferenceInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "QueryScheduleConferenceInfo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/scheduleConferences/" + scheduleConferenceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConferenceInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息
         *
         * @param request QueryScheduleConferenceInfoRequest
         * @return QueryScheduleConferenceInfoResponse
         */
        public QueryScheduleConferenceInfoResponse QueryScheduleConferenceInfo(string scheduleConferenceId, QueryScheduleConferenceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConferenceInfoHeaders headers = new QueryScheduleConferenceInfoHeaders();
            return QueryScheduleConferenceInfoWithOptions(scheduleConferenceId, request, headers, runtime);
        }

        /**
         * @summary 分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息
         *
         * @param request QueryScheduleConferenceInfoRequest
         * @return QueryScheduleConferenceInfoResponse
         */
        public async Task<QueryScheduleConferenceInfoResponse> QueryScheduleConferenceInfoAsync(string scheduleConferenceId, QueryScheduleConferenceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConferenceInfoHeaders headers = new QueryScheduleConferenceInfoHeaders();
            return await QueryScheduleConferenceInfoWithOptionsAsync(scheduleConferenceId, request, headers, runtime);
        }

        /**
         * @summary 查询用户进行中会议
         *
         * @param request QueryUserOnGoingConferenceRequest
         * @param headers QueryUserOnGoingConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserOnGoingConferenceResponse
         */
        public QueryUserOnGoingConferenceResponse QueryUserOnGoingConferenceWithOptions(QueryUserOnGoingConferenceRequest request, QueryUserOnGoingConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "QueryUserOnGoingConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/users/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserOnGoingConferenceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询用户进行中会议
         *
         * @param request QueryUserOnGoingConferenceRequest
         * @param headers QueryUserOnGoingConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserOnGoingConferenceResponse
         */
        public async Task<QueryUserOnGoingConferenceResponse> QueryUserOnGoingConferenceWithOptionsAsync(QueryUserOnGoingConferenceRequest request, QueryUserOnGoingConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "QueryUserOnGoingConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/users/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserOnGoingConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询用户进行中会议
         *
         * @param request QueryUserOnGoingConferenceRequest
         * @return QueryUserOnGoingConferenceResponse
         */
        public QueryUserOnGoingConferenceResponse QueryUserOnGoingConference(QueryUserOnGoingConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserOnGoingConferenceHeaders headers = new QueryUserOnGoingConferenceHeaders();
            return QueryUserOnGoingConferenceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询用户进行中会议
         *
         * @param request QueryUserOnGoingConferenceRequest
         * @return QueryUserOnGoingConferenceResponse
         */
        public async Task<QueryUserOnGoingConferenceResponse> QueryUserOnGoingConferenceAsync(QueryUserOnGoingConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserOnGoingConferenceHeaders headers = new QueryUserOnGoingConferenceHeaders();
            return await QueryUserOnGoingConferenceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 开启云录制
         *
         * @param request StartCloudRecordRequest
         * @param headers StartCloudRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartCloudRecordResponse
         */
        public StartCloudRecordResponse StartCloudRecordWithOptions(string conferenceId, StartCloudRecordRequest request, StartCloudRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmallWindowPosition))
            {
                body["smallWindowPosition"] = request.SmallWindowPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCloudRecord",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCloudRecordResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 开启云录制
         *
         * @param request StartCloudRecordRequest
         * @param headers StartCloudRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartCloudRecordResponse
         */
        public async Task<StartCloudRecordResponse> StartCloudRecordWithOptionsAsync(string conferenceId, StartCloudRecordRequest request, StartCloudRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmallWindowPosition))
            {
                body["smallWindowPosition"] = request.SmallWindowPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCloudRecord",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCloudRecordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 开启云录制
         *
         * @param request StartCloudRecordRequest
         * @return StartCloudRecordResponse
         */
        public StartCloudRecordResponse StartCloudRecord(string conferenceId, StartCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartCloudRecordHeaders headers = new StartCloudRecordHeaders();
            return StartCloudRecordWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 开启云录制
         *
         * @param request StartCloudRecordRequest
         * @return StartCloudRecordResponse
         */
        public async Task<StartCloudRecordResponse> StartCloudRecordAsync(string conferenceId, StartCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartCloudRecordHeaders headers = new StartCloudRecordHeaders();
            return await StartCloudRecordWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 开启会议闪记
         *
         * @param request StartMinutesRequest
         * @param headers StartMinutesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartMinutesResponse
         */
        public StartMinutesResponse StartMinutesWithOptions(string conferenceId, StartMinutesRequest request, StartMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUnionId))
            {
                body["ownerUnionId"] = request.OwnerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordAudio))
            {
                body["recordAudio"] = request.RecordAudio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartMinutes",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartMinutesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 开启会议闪记
         *
         * @param request StartMinutesRequest
         * @param headers StartMinutesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartMinutesResponse
         */
        public async Task<StartMinutesResponse> StartMinutesWithOptionsAsync(string conferenceId, StartMinutesRequest request, StartMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUnionId))
            {
                body["ownerUnionId"] = request.OwnerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordAudio))
            {
                body["recordAudio"] = request.RecordAudio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartMinutes",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartMinutesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 开启会议闪记
         *
         * @param request StartMinutesRequest
         * @return StartMinutesResponse
         */
        public StartMinutesResponse StartMinutes(string conferenceId, StartMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartMinutesHeaders headers = new StartMinutesHeaders();
            return StartMinutesWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 开启会议闪记
         *
         * @param request StartMinutesRequest
         * @return StartMinutesResponse
         */
        public async Task<StartMinutesResponse> StartMinutesAsync(string conferenceId, StartMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartMinutesHeaders headers = new StartMinutesHeaders();
            return await StartMinutesWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 会议开始直播推流
         *
         * @param request StartStreamOutRequest
         * @param headers StartStreamOutHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartStreamOutResponse
         */
        public StartStreamOutResponse StartStreamOutWithOptions(string conferenceId, StartStreamOutRequest request, StartStreamOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedHostJoin))
            {
                body["needHostJoin"] = request.NeedHostJoin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmallWindowPosition))
            {
                body["smallWindowPosition"] = request.SmallWindowPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamName))
            {
                body["streamName"] = request.StreamName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamUrlList))
            {
                body["streamUrlList"] = request.StreamUrlList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartStreamOut",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/streamOuts/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartStreamOutResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 会议开始直播推流
         *
         * @param request StartStreamOutRequest
         * @param headers StartStreamOutHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartStreamOutResponse
         */
        public async Task<StartStreamOutResponse> StartStreamOutWithOptionsAsync(string conferenceId, StartStreamOutRequest request, StartStreamOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedHostJoin))
            {
                body["needHostJoin"] = request.NeedHostJoin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmallWindowPosition))
            {
                body["smallWindowPosition"] = request.SmallWindowPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamName))
            {
                body["streamName"] = request.StreamName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamUrlList))
            {
                body["streamUrlList"] = request.StreamUrlList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartStreamOut",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/streamOuts/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartStreamOutResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 会议开始直播推流
         *
         * @param request StartStreamOutRequest
         * @return StartStreamOutResponse
         */
        public StartStreamOutResponse StartStreamOut(string conferenceId, StartStreamOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartStreamOutHeaders headers = new StartStreamOutHeaders();
            return StartStreamOutWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 会议开始直播推流
         *
         * @param request StartStreamOutRequest
         * @return StartStreamOutResponse
         */
        public async Task<StartStreamOutResponse> StartStreamOutAsync(string conferenceId, StartStreamOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartStreamOutHeaders headers = new StartStreamOutHeaders();
            return await StartStreamOutWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 关闭云录制
         *
         * @param request StopCloudRecordRequest
         * @param headers StopCloudRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopCloudRecordResponse
         */
        public StopCloudRecordResponse StopCloudRecordWithOptions(string conferenceId, StopCloudRecordRequest request, StopCloudRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopCloudRecord",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCloudRecordResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 关闭云录制
         *
         * @param request StopCloudRecordRequest
         * @param headers StopCloudRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopCloudRecordResponse
         */
        public async Task<StopCloudRecordResponse> StopCloudRecordWithOptionsAsync(string conferenceId, StopCloudRecordRequest request, StopCloudRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopCloudRecord",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/cloudRecords/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCloudRecordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 关闭云录制
         *
         * @param request StopCloudRecordRequest
         * @return StopCloudRecordResponse
         */
        public StopCloudRecordResponse StopCloudRecord(string conferenceId, StopCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopCloudRecordHeaders headers = new StopCloudRecordHeaders();
            return StopCloudRecordWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 关闭云录制
         *
         * @param request StopCloudRecordRequest
         * @return StopCloudRecordResponse
         */
        public async Task<StopCloudRecordResponse> StopCloudRecordAsync(string conferenceId, StopCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopCloudRecordHeaders headers = new StopCloudRecordHeaders();
            return await StopCloudRecordWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 暂停会议闪记
         *
         * @param request StopMinutesRequest
         * @param headers StopMinutesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopMinutesResponse
         */
        public StopMinutesResponse StopMinutesWithOptions(string conferenceId, StopMinutesRequest request, StopMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopMinutes",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/pause",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopMinutesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 暂停会议闪记
         *
         * @param request StopMinutesRequest
         * @param headers StopMinutesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopMinutesResponse
         */
        public async Task<StopMinutesResponse> StopMinutesWithOptionsAsync(string conferenceId, StopMinutesRequest request, StopMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopMinutes",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/minutes/pause",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopMinutesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 暂停会议闪记
         *
         * @param request StopMinutesRequest
         * @return StopMinutesResponse
         */
        public StopMinutesResponse StopMinutes(string conferenceId, StopMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopMinutesHeaders headers = new StopMinutesHeaders();
            return StopMinutesWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 暂停会议闪记
         *
         * @param request StopMinutesRequest
         * @return StopMinutesResponse
         */
        public async Task<StopMinutesResponse> StopMinutesAsync(string conferenceId, StopMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopMinutesHeaders headers = new StopMinutesHeaders();
            return await StopMinutesWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 会议停止直播推流
         *
         * @param request StopStreamOutRequest
         * @param headers StopStreamOutHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopStreamOutResponse
         */
        public StopStreamOutResponse StopStreamOutWithOptions(string conferenceId, StopStreamOutRequest request, StopStreamOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopAllStream))
            {
                body["stopAllStream"] = request.StopAllStream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamId))
            {
                body["streamId"] = request.StreamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopStreamOut",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/streamOuts/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopStreamOutResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 会议停止直播推流
         *
         * @param request StopStreamOutRequest
         * @param headers StopStreamOutHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopStreamOutResponse
         */
        public async Task<StopStreamOutResponse> StopStreamOutWithOptionsAsync(string conferenceId, StopStreamOutRequest request, StopStreamOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopAllStream))
            {
                body["stopAllStream"] = request.StopAllStream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamId))
            {
                body["streamId"] = request.StreamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopStreamOut",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/streamOuts/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopStreamOutResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 会议停止直播推流
         *
         * @param request StopStreamOutRequest
         * @return StopStreamOutResponse
         */
        public StopStreamOutResponse StopStreamOut(string conferenceId, StopStreamOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopStreamOutHeaders headers = new StopStreamOutHeaders();
            return StopStreamOutWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 会议停止直播推流
         *
         * @param request StopStreamOutRequest
         * @return StopStreamOutResponse
         */
        public async Task<StopStreamOutResponse> StopStreamOutAsync(string conferenceId, StopStreamOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopStreamOutHeaders headers = new StopStreamOutHeaders();
            return await StopStreamOutWithOptionsAsync(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 更新预约会议设置
         *
         * @param request UpdateScheduleConfSettingsRequest
         * @param headers UpdateScheduleConfSettingsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateScheduleConfSettingsResponse
         */
        public UpdateScheduleConfSettingsResponse UpdateScheduleConfSettingsWithOptions(UpdateScheduleConfSettingsRequest request, UpdateScheduleConfSettingsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfSettingModel))
            {
                body["scheduleConfSettingModel"] = request.ScheduleConfSettingModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["scheduleConferenceId"] = request.ScheduleConferenceId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScheduleConfSettings",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences/settings",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduleConfSettingsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新预约会议设置
         *
         * @param request UpdateScheduleConfSettingsRequest
         * @param headers UpdateScheduleConfSettingsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateScheduleConfSettingsResponse
         */
        public async Task<UpdateScheduleConfSettingsResponse> UpdateScheduleConfSettingsWithOptionsAsync(UpdateScheduleConfSettingsRequest request, UpdateScheduleConfSettingsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfSettingModel))
            {
                body["scheduleConfSettingModel"] = request.ScheduleConfSettingModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["scheduleConferenceId"] = request.ScheduleConferenceId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScheduleConfSettings",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences/settings",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduleConfSettingsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新预约会议设置
         *
         * @param request UpdateScheduleConfSettingsRequest
         * @return UpdateScheduleConfSettingsResponse
         */
        public UpdateScheduleConfSettingsResponse UpdateScheduleConfSettings(UpdateScheduleConfSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateScheduleConfSettingsHeaders headers = new UpdateScheduleConfSettingsHeaders();
            return UpdateScheduleConfSettingsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新预约会议设置
         *
         * @param request UpdateScheduleConfSettingsRequest
         * @return UpdateScheduleConfSettingsResponse
         */
        public async Task<UpdateScheduleConfSettingsResponse> UpdateScheduleConfSettingsAsync(UpdateScheduleConfSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateScheduleConfSettingsHeaders headers = new UpdateScheduleConfSettingsHeaders();
            return await UpdateScheduleConfSettingsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新预约会议
         *
         * @param request UpdateScheduleConferenceRequest
         * @param headers UpdateScheduleConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateScheduleConferenceResponse
         */
        public UpdateScheduleConferenceResponse UpdateScheduleConferenceWithOptions(UpdateScheduleConferenceRequest request, UpdateScheduleConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["scheduleConferenceId"] = request.ScheduleConferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScheduleConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduleConferenceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新预约会议
         *
         * @param request UpdateScheduleConferenceRequest
         * @param headers UpdateScheduleConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateScheduleConferenceResponse
         */
        public async Task<UpdateScheduleConferenceResponse> UpdateScheduleConferenceWithOptionsAsync(UpdateScheduleConferenceRequest request, UpdateScheduleConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["scheduleConferenceId"] = request.ScheduleConferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScheduleConference",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/scheduleConferences",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduleConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新预约会议
         *
         * @param request UpdateScheduleConferenceRequest
         * @return UpdateScheduleConferenceResponse
         */
        public UpdateScheduleConferenceResponse UpdateScheduleConference(UpdateScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateScheduleConferenceHeaders headers = new UpdateScheduleConferenceHeaders();
            return UpdateScheduleConferenceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新预约会议
         *
         * @param request UpdateScheduleConferenceRequest
         * @return UpdateScheduleConferenceResponse
         */
        public async Task<UpdateScheduleConferenceResponse> UpdateScheduleConferenceAsync(UpdateScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateScheduleConferenceHeaders headers = new UpdateScheduleConferenceHeaders();
            return await UpdateScheduleConferenceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新会议额外信息
         *
         * @param headers UpdateVideoConferenceExtInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateVideoConferenceExtInfoResponse
         */
        public UpdateVideoConferenceExtInfoResponse UpdateVideoConferenceExtInfoWithOptions(string conferenceId, UpdateVideoConferenceExtInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVideoConferenceExtInfo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/extInfo",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVideoConferenceExtInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新会议额外信息
         *
         * @param headers UpdateVideoConferenceExtInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateVideoConferenceExtInfoResponse
         */
        public async Task<UpdateVideoConferenceExtInfoResponse> UpdateVideoConferenceExtInfoWithOptionsAsync(string conferenceId, UpdateVideoConferenceExtInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVideoConferenceExtInfo",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId + "/extInfo",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVideoConferenceExtInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新会议额外信息
         *
         * @return UpdateVideoConferenceExtInfoResponse
         */
        public UpdateVideoConferenceExtInfoResponse UpdateVideoConferenceExtInfo(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVideoConferenceExtInfoHeaders headers = new UpdateVideoConferenceExtInfoHeaders();
            return UpdateVideoConferenceExtInfoWithOptions(conferenceId, headers, runtime);
        }

        /**
         * @summary 更新会议额外信息
         *
         * @return UpdateVideoConferenceExtInfoResponse
         */
        public async Task<UpdateVideoConferenceExtInfoResponse> UpdateVideoConferenceExtInfoAsync(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVideoConferenceExtInfoHeaders headers = new UpdateVideoConferenceExtInfoHeaders();
            return await UpdateVideoConferenceExtInfoWithOptionsAsync(conferenceId, headers, runtime);
        }

        /**
         * @summary 设置会议中的会议属性
         *
         * @param request UpdateVideoConferenceSettingRequest
         * @param headers UpdateVideoConferenceSettingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateVideoConferenceSettingResponse
         */
        public UpdateVideoConferenceSettingResponse UpdateVideoConferenceSettingWithOptions(string conferenceId, UpdateVideoConferenceSettingRequest request, UpdateVideoConferenceSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUnmuteSelf))
            {
                body["allowUnmuteSelf"] = request.AllowUnmuteSelf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoTransferHost))
            {
                body["autoTransferHost"] = request.AutoTransferHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForbiddenShareScreen))
            {
                body["forbiddenShareScreen"] = request.ForbiddenShareScreen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockConference))
            {
                body["lockConference"] = request.LockConference;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MuteAll))
            {
                body["muteAll"] = request.MuteAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyInternalEmployeesJoin))
            {
                body["onlyInternalEmployeesJoin"] = request.OnlyInternalEmployeesJoin;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVideoConferenceSetting",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVideoConferenceSettingResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 设置会议中的会议属性
         *
         * @param request UpdateVideoConferenceSettingRequest
         * @param headers UpdateVideoConferenceSettingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateVideoConferenceSettingResponse
         */
        public async Task<UpdateVideoConferenceSettingResponse> UpdateVideoConferenceSettingWithOptionsAsync(string conferenceId, UpdateVideoConferenceSettingRequest request, UpdateVideoConferenceSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUnmuteSelf))
            {
                body["allowUnmuteSelf"] = request.AllowUnmuteSelf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoTransferHost))
            {
                body["autoTransferHost"] = request.AutoTransferHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForbiddenShareScreen))
            {
                body["forbiddenShareScreen"] = request.ForbiddenShareScreen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockConference))
            {
                body["lockConference"] = request.LockConference;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MuteAll))
            {
                body["muteAll"] = request.MuteAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyInternalEmployeesJoin))
            {
                body["onlyInternalEmployeesJoin"] = request.OnlyInternalEmployeesJoin;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVideoConferenceSetting",
                Version = "conference_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/conference/videoConferences/" + conferenceId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVideoConferenceSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 设置会议中的会议属性
         *
         * @param request UpdateVideoConferenceSettingRequest
         * @return UpdateVideoConferenceSettingResponse
         */
        public UpdateVideoConferenceSettingResponse UpdateVideoConferenceSetting(string conferenceId, UpdateVideoConferenceSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVideoConferenceSettingHeaders headers = new UpdateVideoConferenceSettingHeaders();
            return UpdateVideoConferenceSettingWithOptions(conferenceId, request, headers, runtime);
        }

        /**
         * @summary 设置会议中的会议属性
         *
         * @param request UpdateVideoConferenceSettingRequest
         * @return UpdateVideoConferenceSettingResponse
         */
        public async Task<UpdateVideoConferenceSettingResponse> UpdateVideoConferenceSettingAsync(string conferenceId, UpdateVideoConferenceSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVideoConferenceSettingHeaders headers = new UpdateVideoConferenceSettingHeaders();
            return await UpdateVideoConferenceSettingWithOptionsAsync(conferenceId, request, headers, runtime);
        }

    }
}
