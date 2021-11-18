// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkedu_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0
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


        public BatchCreateResponse BatchCreate(BatchCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchCreateHeaders headers = new BatchCreateHeaders();
            return BatchCreateWithOptions(request, headers, runtime);
        }

        public async Task<BatchCreateResponse> BatchCreateAsync(BatchCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchCreateHeaders headers = new BatchCreateHeaders();
            return await BatchCreateWithOptionsAsync(request, headers, runtime);
        }

        public BatchCreateResponse BatchCreateWithOptions(BatchCreateRequest request, BatchCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardBizCode))
            {
                body["cardBizCode"] = request.CardBizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsVersion))
            {
                body["jsVersion"] = request.JsVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["sourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userid))
            {
                body["userid"] = request.Userid;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<BatchCreateResponse>(DoROARequest("BatchCreate", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/cards", "json", req, runtime));
        }

        public async Task<BatchCreateResponse> BatchCreateWithOptionsAsync(BatchCreateRequest request, BatchCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardBizCode))
            {
                body["cardBizCode"] = request.CardBizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsVersion))
            {
                body["jsVersion"] = request.JsVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["sourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userid))
            {
                body["userid"] = request.Userid;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<BatchCreateResponse>(await DoROARequestAsync("BatchCreate", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/cards", "json", req, runtime));
        }

        public BatchOrgCreateHWResponse BatchOrgCreateHW(BatchOrgCreateHWRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchOrgCreateHWHeaders headers = new BatchOrgCreateHWHeaders();
            return BatchOrgCreateHWWithOptions(request, headers, runtime);
        }

        public async Task<BatchOrgCreateHWResponse> BatchOrgCreateHWAsync(BatchOrgCreateHWRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchOrgCreateHWHeaders headers = new BatchOrgCreateHWHeaders();
            return await BatchOrgCreateHWWithOptionsAsync(request, headers, runtime);
        }

        public BatchOrgCreateHWResponse BatchOrgCreateHWWithOptions(BatchOrgCreateHWRequest request, BatchOrgCreateHWHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                body["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseName))
            {
                body["courseName"] = request.CourseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwContent))
            {
                body["hwContent"] = request.HwContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwDeadline))
            {
                body["hwDeadline"] = request.HwDeadline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwDeadlineOpen))
            {
                body["hwDeadlineOpen"] = request.HwDeadlineOpen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwMedia))
            {
                body["hwMedia"] = request.HwMedia;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwPhoto))
            {
                body["hwPhoto"] = request.HwPhoto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwTitle))
            {
                body["hwTitle"] = request.HwTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwType))
            {
                body["hwType"] = request.HwType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwVideo))
            {
                body["hwVideo"] = request.HwVideo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenSelectItemList))
            {
                body["openSelectItemList"] = request.OpenSelectItemList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledRelease))
            {
                body["scheduledRelease"] = request.ScheduledRelease;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTime))
            {
                body["scheduledTime"] = request.ScheduledTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRole))
            {
                body["targetRole"] = request.TargetRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeacherName))
            {
                body["teacherName"] = request.TeacherName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeacherUserId))
            {
                body["teacherUserId"] = request.TeacherUserId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<BatchOrgCreateHWResponse>(DoROARequest("BatchOrgCreateHW", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/homeworks", "json", req, runtime));
        }

        public async Task<BatchOrgCreateHWResponse> BatchOrgCreateHWWithOptionsAsync(BatchOrgCreateHWRequest request, BatchOrgCreateHWHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                body["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseName))
            {
                body["courseName"] = request.CourseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwContent))
            {
                body["hwContent"] = request.HwContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwDeadline))
            {
                body["hwDeadline"] = request.HwDeadline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwDeadlineOpen))
            {
                body["hwDeadlineOpen"] = request.HwDeadlineOpen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwMedia))
            {
                body["hwMedia"] = request.HwMedia;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwPhoto))
            {
                body["hwPhoto"] = request.HwPhoto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwTitle))
            {
                body["hwTitle"] = request.HwTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwType))
            {
                body["hwType"] = request.HwType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwVideo))
            {
                body["hwVideo"] = request.HwVideo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenSelectItemList))
            {
                body["openSelectItemList"] = request.OpenSelectItemList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledRelease))
            {
                body["scheduledRelease"] = request.ScheduledRelease;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTime))
            {
                body["scheduledTime"] = request.ScheduledTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRole))
            {
                body["targetRole"] = request.TargetRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeacherName))
            {
                body["teacherName"] = request.TeacherName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeacherUserId))
            {
                body["teacherUserId"] = request.TeacherUserId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<BatchOrgCreateHWResponse>(await DoROARequestAsync("BatchOrgCreateHW", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/homeworks", "json", req, runtime));
        }

        public CourseSchedulingComplimentNoticeResponse CourseSchedulingComplimentNotice(CourseSchedulingComplimentNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CourseSchedulingComplimentNoticeHeaders headers = new CourseSchedulingComplimentNoticeHeaders();
            return CourseSchedulingComplimentNoticeWithOptions(request, headers, runtime);
        }

        public async Task<CourseSchedulingComplimentNoticeResponse> CourseSchedulingComplimentNoticeAsync(CourseSchedulingComplimentNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CourseSchedulingComplimentNoticeHeaders headers = new CourseSchedulingComplimentNoticeHeaders();
            return await CourseSchedulingComplimentNoticeWithOptionsAsync(request, headers, runtime);
        }

        public CourseSchedulingComplimentNoticeResponse CourseSchedulingComplimentNoticeWithOptions(CourseSchedulingComplimentNoticeRequest request, CourseSchedulingComplimentNoticeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CourseSchedulingComplimentNoticeResponse>(DoROARequest("CourseSchedulingComplimentNotice", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/schedules/finishNotify", "json", req, runtime));
        }

        public async Task<CourseSchedulingComplimentNoticeResponse> CourseSchedulingComplimentNoticeWithOptionsAsync(CourseSchedulingComplimentNoticeRequest request, CourseSchedulingComplimentNoticeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CourseSchedulingComplimentNoticeResponse>(await DoROARequestAsync("CourseSchedulingComplimentNotice", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/schedules/finishNotify", "json", req, runtime));
        }

        public CreateCustomClassResponse CreateCustomClass(CreateCustomClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomClassHeaders headers = new CreateCustomClassHeaders();
            return CreateCustomClassWithOptions(request, headers, runtime);
        }

        public async Task<CreateCustomClassResponse> CreateCustomClassAsync(CreateCustomClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomClassHeaders headers = new CreateCustomClassHeaders();
            return await CreateCustomClassWithOptionsAsync(request, headers, runtime);
        }

        public CreateCustomClassResponse CreateCustomClassWithOptions(CreateCustomClassRequest request, CreateCustomClassHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomClass.ToMap()))
            {
                body["customClass"] = request.CustomClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOauthAppId))
            {
                body["dingOauthAppId"] = request.DingOauthAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperId))
            {
                body["superId"] = request.SuperId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateCustomClassResponse>(DoROARequest("CreateCustomClass", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/customClasses", "json", req, runtime));
        }

        public async Task<CreateCustomClassResponse> CreateCustomClassWithOptionsAsync(CreateCustomClassRequest request, CreateCustomClassHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomClass.ToMap()))
            {
                body["customClass"] = request.CustomClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOauthAppId))
            {
                body["dingOauthAppId"] = request.DingOauthAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperId))
            {
                body["superId"] = request.SuperId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateCustomClassResponse>(await DoROARequestAsync("CreateCustomClass", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/customClasses", "json", req, runtime));
        }

        public CreateCustomDeptResponse CreateCustomDept(CreateCustomDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomDeptHeaders headers = new CreateCustomDeptHeaders();
            return CreateCustomDeptWithOptions(request, headers, runtime);
        }

        public async Task<CreateCustomDeptResponse> CreateCustomDeptAsync(CreateCustomDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomDeptHeaders headers = new CreateCustomDeptHeaders();
            return await CreateCustomDeptWithOptionsAsync(request, headers, runtime);
        }

        public CreateCustomDeptResponse CreateCustomDeptWithOptions(CreateCustomDeptRequest request, CreateCustomDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDept.ToMap()))
            {
                body["customDept"] = request.CustomDept;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOauthAppId))
            {
                body["dingOauthAppId"] = request.DingOauthAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperId))
            {
                body["superId"] = request.SuperId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateCustomDeptResponse>(DoROARequest("CreateCustomDept", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/customDepts", "json", req, runtime));
        }

        public async Task<CreateCustomDeptResponse> CreateCustomDeptWithOptionsAsync(CreateCustomDeptRequest request, CreateCustomDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDept.ToMap()))
            {
                body["customDept"] = request.CustomDept;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOauthAppId))
            {
                body["dingOauthAppId"] = request.DingOauthAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperId))
            {
                body["superId"] = request.SuperId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateCustomDeptResponse>(await DoROARequestAsync("CreateCustomDept", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/customDepts", "json", req, runtime));
        }

        public CreateInviteUrlResponse CreateInviteUrl(CreateInviteUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInviteUrlHeaders headers = new CreateInviteUrlHeaders();
            return CreateInviteUrlWithOptions(request, headers, runtime);
        }

        public async Task<CreateInviteUrlResponse> CreateInviteUrlAsync(CreateInviteUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInviteUrlHeaders headers = new CreateInviteUrlHeaders();
            return await CreateInviteUrlWithOptionsAsync(request, headers, runtime);
        }

        public CreateInviteUrlResponse CreateInviteUrlWithOptions(CreateInviteUrlRequest request, CreateInviteUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                body["authCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOauthAppId))
            {
                body["dingOauthAppId"] = request.DingOauthAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetOperator))
            {
                body["targetOperator"] = request.TargetOperator;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateInviteUrlResponse>(DoROARequest("CreateInviteUrl", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/remoteClasses/orgRelations/inviteUrls", "json", req, runtime));
        }

        public async Task<CreateInviteUrlResponse> CreateInviteUrlWithOptionsAsync(CreateInviteUrlRequest request, CreateInviteUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                body["authCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOauthAppId))
            {
                body["dingOauthAppId"] = request.DingOauthAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetOperator))
            {
                body["targetOperator"] = request.TargetOperator;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateInviteUrlResponse>(await DoROARequestAsync("CreateInviteUrl", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/remoteClasses/orgRelations/inviteUrls", "json", req, runtime));
        }

        public CreatePhysicalClassroomResponse CreatePhysicalClassroom(CreatePhysicalClassroomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatePhysicalClassroomHeaders headers = new CreatePhysicalClassroomHeaders();
            return CreatePhysicalClassroomWithOptions(request, headers, runtime);
        }

        public async Task<CreatePhysicalClassroomResponse> CreatePhysicalClassroomAsync(CreatePhysicalClassroomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatePhysicalClassroomHeaders headers = new CreatePhysicalClassroomHeaders();
            return await CreatePhysicalClassroomWithOptionsAsync(request, headers, runtime);
        }

        public CreatePhysicalClassroomResponse CreatePhysicalClassroomWithOptions(CreatePhysicalClassroomRequest request, CreatePhysicalClassroomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomBuilding))
            {
                body["classroomBuilding"] = request.ClassroomBuilding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomCampus))
            {
                body["classroomCampus"] = request.ClassroomCampus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomFloor))
            {
                body["classroomFloor"] = request.ClassroomFloor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomName))
            {
                body["classroomName"] = request.ClassroomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomNumber))
            {
                body["classroomNumber"] = request.ClassroomNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectBroadcast))
            {
                body["directBroadcast"] = request.DirectBroadcast;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
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
            return TeaModel.ToObject<CreatePhysicalClassroomResponse>(DoROARequest("CreatePhysicalClassroom", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/physicalClassrooms", "json", req, runtime));
        }

        public async Task<CreatePhysicalClassroomResponse> CreatePhysicalClassroomWithOptionsAsync(CreatePhysicalClassroomRequest request, CreatePhysicalClassroomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomBuilding))
            {
                body["classroomBuilding"] = request.ClassroomBuilding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomCampus))
            {
                body["classroomCampus"] = request.ClassroomCampus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomFloor))
            {
                body["classroomFloor"] = request.ClassroomFloor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomName))
            {
                body["classroomName"] = request.ClassroomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomNumber))
            {
                body["classroomNumber"] = request.ClassroomNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectBroadcast))
            {
                body["directBroadcast"] = request.DirectBroadcast;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
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
            return TeaModel.ToObject<CreatePhysicalClassroomResponse>(await DoROARequestAsync("CreatePhysicalClassroom", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/physicalClassrooms", "json", req, runtime));
        }

        public CreateRemoteClassCourseResponse CreateRemoteClassCourse(CreateRemoteClassCourseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRemoteClassCourseHeaders headers = new CreateRemoteClassCourseHeaders();
            return CreateRemoteClassCourseWithOptions(request, headers, runtime);
        }

        public async Task<CreateRemoteClassCourseResponse> CreateRemoteClassCourseAsync(CreateRemoteClassCourseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRemoteClassCourseHeaders headers = new CreateRemoteClassCourseHeaders();
            return await CreateRemoteClassCourseWithOptionsAsync(request, headers, runtime);
        }

        public CreateRemoteClassCourseResponse CreateRemoteClassCourseWithOptions(CreateRemoteClassCourseRequest request, CreateRemoteClassCourseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendParticipants))
            {
                body["attendParticipants"] = request.AttendParticipants;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                body["authCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseName))
            {
                body["courseName"] = request.CourseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingClientId))
            {
                body["dingClientId"] = request.DingClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOauthAppId))
            {
                body["dingOauthAppId"] = request.DingOauthAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeachingParticipant.ToMap()))
            {
                body["teachingParticipant"] = request.TeachingParticipant;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateRemoteClassCourseResponse>(DoROARequest("CreateRemoteClassCourse", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/remoteClasses/courses", "json", req, runtime));
        }

        public async Task<CreateRemoteClassCourseResponse> CreateRemoteClassCourseWithOptionsAsync(CreateRemoteClassCourseRequest request, CreateRemoteClassCourseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendParticipants))
            {
                body["attendParticipants"] = request.AttendParticipants;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                body["authCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseName))
            {
                body["courseName"] = request.CourseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingClientId))
            {
                body["dingClientId"] = request.DingClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOauthAppId))
            {
                body["dingOauthAppId"] = request.DingOauthAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeachingParticipant.ToMap()))
            {
                body["teachingParticipant"] = request.TeachingParticipant;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateRemoteClassCourseResponse>(await DoROARequestAsync("CreateRemoteClassCourse", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/remoteClasses/courses", "json", req, runtime));
        }

        public CreateSectionConfigResponse CreateSectionConfig(CreateSectionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSectionConfigHeaders headers = new CreateSectionConfigHeaders();
            return CreateSectionConfigWithOptions(request, headers, runtime);
        }

        public async Task<CreateSectionConfigResponse> CreateSectionConfigAsync(CreateSectionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSectionConfigHeaders headers = new CreateSectionConfigHeaders();
            return await CreateSectionConfigWithOptionsAsync(request, headers, runtime);
        }

        public CreateSectionConfigResponse CreateSectionConfigWithOptions(CreateSectionConfigRequest request, CreateSectionConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SectionConfigs))
            {
                body["sectionConfigs"] = request.SectionConfigs;
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
            return TeaModel.ToObject<CreateSectionConfigResponse>(DoROARequest("CreateSectionConfig", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/sectionConfigs", "json", req, runtime));
        }

        public async Task<CreateSectionConfigResponse> CreateSectionConfigWithOptionsAsync(CreateSectionConfigRequest request, CreateSectionConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SectionConfigs))
            {
                body["sectionConfigs"] = request.SectionConfigs;
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
            return TeaModel.ToObject<CreateSectionConfigResponse>(await DoROARequestAsync("CreateSectionConfig", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/sectionConfigs", "json", req, runtime));
        }

        public CreateUniversityCourseGroupResponse CreateUniversityCourseGroup(CreateUniversityCourseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateUniversityCourseGroupHeaders headers = new CreateUniversityCourseGroupHeaders();
            return CreateUniversityCourseGroupWithOptions(request, headers, runtime);
        }

        public async Task<CreateUniversityCourseGroupResponse> CreateUniversityCourseGroupAsync(CreateUniversityCourseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateUniversityCourseGroupHeaders headers = new CreateUniversityCourseGroupHeaders();
            return await CreateUniversityCourseGroupWithOptionsAsync(request, headers, runtime);
        }

        public CreateUniversityCourseGroupResponse CreateUniversityCourseGroupWithOptions(CreateUniversityCourseGroupRequest request, CreateUniversityCourseGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupIntroduce))
            {
                body["courseGroupIntroduce"] = request.CourseGroupIntroduce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupName))
            {
                body["courseGroupName"] = request.CourseGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourserGroupItemModels))
            {
                body["courserGroupItemModels"] = request.CourserGroupItemModels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCourseGroupCode))
            {
                body["isvCourseGroupCode"] = request.IsvCourseGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodCode))
            {
                body["periodCode"] = request.PeriodCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchoolYear))
            {
                body["schoolYear"] = request.SchoolYear;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Semester))
            {
                body["semester"] = request.Semester;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubjectName))
            {
                body["subjectName"] = request.SubjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeacherInfos))
            {
                body["teacherInfos"] = request.TeacherInfos;
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
            return TeaModel.ToObject<CreateUniversityCourseGroupResponse>(DoROARequest("CreateUniversityCourseGroup", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courseGroups", "json", req, runtime));
        }

        public async Task<CreateUniversityCourseGroupResponse> CreateUniversityCourseGroupWithOptionsAsync(CreateUniversityCourseGroupRequest request, CreateUniversityCourseGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupIntroduce))
            {
                body["courseGroupIntroduce"] = request.CourseGroupIntroduce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupName))
            {
                body["courseGroupName"] = request.CourseGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourserGroupItemModels))
            {
                body["courserGroupItemModels"] = request.CourserGroupItemModels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCourseGroupCode))
            {
                body["isvCourseGroupCode"] = request.IsvCourseGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodCode))
            {
                body["periodCode"] = request.PeriodCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchoolYear))
            {
                body["schoolYear"] = request.SchoolYear;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Semester))
            {
                body["semester"] = request.Semester;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubjectName))
            {
                body["subjectName"] = request.SubjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeacherInfos))
            {
                body["teacherInfos"] = request.TeacherInfos;
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
            return TeaModel.ToObject<CreateUniversityCourseGroupResponse>(await DoROARequestAsync("CreateUniversityCourseGroup", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courseGroups", "json", req, runtime));
        }

        public DeleteDeptResponse DeleteDept(string deptId, DeleteDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeptHeaders headers = new DeleteDeptHeaders();
            return DeleteDeptWithOptions(deptId, request, headers, runtime);
        }

        public async Task<DeleteDeptResponse> DeleteDeptAsync(string deptId, DeleteDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeptHeaders headers = new DeleteDeptHeaders();
            return await DeleteDeptWithOptionsAsync(deptId, request, headers, runtime);
        }

        public DeleteDeptResponse DeleteDeptWithOptions(string deptId, DeleteDeptRequest request, DeleteDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            deptId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deptId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
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
            return TeaModel.ToObject<DeleteDeptResponse>(DoROARequest("DeleteDept", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/depts/" + deptId, "json", req, runtime));
        }

        public async Task<DeleteDeptResponse> DeleteDeptWithOptionsAsync(string deptId, DeleteDeptRequest request, DeleteDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            deptId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deptId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
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
            return TeaModel.ToObject<DeleteDeptResponse>(await DoROARequestAsync("DeleteDept", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/depts/" + deptId, "json", req, runtime));
        }

        public DeleteDeviceOrgResponse DeleteDeviceOrg(DeleteDeviceOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeviceOrgHeaders headers = new DeleteDeviceOrgHeaders();
            return DeleteDeviceOrgWithOptions(request, headers, runtime);
        }

        public async Task<DeleteDeviceOrgResponse> DeleteDeviceOrgAsync(DeleteDeviceOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeviceOrgHeaders headers = new DeleteDeviceOrgHeaders();
            return await DeleteDeviceOrgWithOptionsAsync(request, headers, runtime);
        }

        public DeleteDeviceOrgResponse DeleteDeviceOrgWithOptions(DeleteDeviceOrgRequest request, DeleteDeviceOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["authCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                query["deviceCode"] = request.DeviceCode;
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
            return TeaModel.ToObject<DeleteDeviceOrgResponse>(DoROARequest("DeleteDeviceOrg", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/remoteClasses/deviceOrgs", "json", req, runtime));
        }

        public async Task<DeleteDeviceOrgResponse> DeleteDeviceOrgWithOptionsAsync(DeleteDeviceOrgRequest request, DeleteDeviceOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["authCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                query["deviceCode"] = request.DeviceCode;
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
            return TeaModel.ToObject<DeleteDeviceOrgResponse>(await DoROARequestAsync("DeleteDeviceOrg", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/remoteClasses/deviceOrgs", "json", req, runtime));
        }

        public DeleteGuardianResponse DeleteGuardian(string classId, string userId, DeleteGuardianRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteGuardianHeaders headers = new DeleteGuardianHeaders();
            return DeleteGuardianWithOptions(classId, userId, request, headers, runtime);
        }

        public async Task<DeleteGuardianResponse> DeleteGuardianAsync(string classId, string userId, DeleteGuardianRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteGuardianHeaders headers = new DeleteGuardianHeaders();
            return await DeleteGuardianWithOptionsAsync(classId, userId, request, headers, runtime);
        }

        public DeleteGuardianResponse DeleteGuardianWithOptions(string classId, string userId, DeleteGuardianRequest request, DeleteGuardianHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            classId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(classId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StuId))
            {
                query["stuId"] = request.StuId;
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
            return TeaModel.ToObject<DeleteGuardianResponse>(DoROARequest("DeleteGuardian", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/classes/" + classId + "/guardians/" + userId, "json", req, runtime));
        }

        public async Task<DeleteGuardianResponse> DeleteGuardianWithOptionsAsync(string classId, string userId, DeleteGuardianRequest request, DeleteGuardianHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            classId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(classId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StuId))
            {
                query["stuId"] = request.StuId;
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
            return TeaModel.ToObject<DeleteGuardianResponse>(await DoROARequestAsync("DeleteGuardian", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/classes/" + classId + "/guardians/" + userId, "json", req, runtime));
        }

        public DeleteOrgRelationResponse DeleteOrgRelation(DeleteOrgRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteOrgRelationHeaders headers = new DeleteOrgRelationHeaders();
            return DeleteOrgRelationWithOptions(request, headers, runtime);
        }

        public async Task<DeleteOrgRelationResponse> DeleteOrgRelationAsync(DeleteOrgRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteOrgRelationHeaders headers = new DeleteOrgRelationHeaders();
            return await DeleteOrgRelationWithOptionsAsync(request, headers, runtime);
        }

        public DeleteOrgRelationResponse DeleteOrgRelationWithOptions(DeleteOrgRelationRequest request, DeleteOrgRelationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["authCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                query["targetCorpId"] = request.TargetCorpId;
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
            return TeaModel.ToObject<DeleteOrgRelationResponse>(DoROARequest("DeleteOrgRelation", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/remoteClasses/orgRelations", "json", req, runtime));
        }

        public async Task<DeleteOrgRelationResponse> DeleteOrgRelationWithOptionsAsync(DeleteOrgRelationRequest request, DeleteOrgRelationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["authCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                query["targetCorpId"] = request.TargetCorpId;
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
            return TeaModel.ToObject<DeleteOrgRelationResponse>(await DoROARequestAsync("DeleteOrgRelation", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/remoteClasses/orgRelations", "json", req, runtime));
        }

        public DeletePhysicalClassroomResponse DeletePhysicalClassroom(DeletePhysicalClassroomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeletePhysicalClassroomHeaders headers = new DeletePhysicalClassroomHeaders();
            return DeletePhysicalClassroomWithOptions(request, headers, runtime);
        }

        public async Task<DeletePhysicalClassroomResponse> DeletePhysicalClassroomAsync(DeletePhysicalClassroomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeletePhysicalClassroomHeaders headers = new DeletePhysicalClassroomHeaders();
            return await DeletePhysicalClassroomWithOptionsAsync(request, headers, runtime);
        }

        public DeletePhysicalClassroomResponse DeletePhysicalClassroomWithOptions(DeletePhysicalClassroomRequest request, DeletePhysicalClassroomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomId))
            {
                query["classroomId"] = request.ClassroomId;
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
            return TeaModel.ToObject<DeletePhysicalClassroomResponse>(DoROARequest("DeletePhysicalClassroom", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/physicalClassrooms", "json", req, runtime));
        }

        public async Task<DeletePhysicalClassroomResponse> DeletePhysicalClassroomWithOptionsAsync(DeletePhysicalClassroomRequest request, DeletePhysicalClassroomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomId))
            {
                query["classroomId"] = request.ClassroomId;
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
            return TeaModel.ToObject<DeletePhysicalClassroomResponse>(await DoROARequestAsync("DeletePhysicalClassroom", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/physicalClassrooms", "json", req, runtime));
        }

        public DeleteRemoteClassCourseResponse DeleteRemoteClassCourse(string courseCode, DeleteRemoteClassCourseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRemoteClassCourseHeaders headers = new DeleteRemoteClassCourseHeaders();
            return DeleteRemoteClassCourseWithOptions(courseCode, request, headers, runtime);
        }

        public async Task<DeleteRemoteClassCourseResponse> DeleteRemoteClassCourseAsync(string courseCode, DeleteRemoteClassCourseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRemoteClassCourseHeaders headers = new DeleteRemoteClassCourseHeaders();
            return await DeleteRemoteClassCourseWithOptionsAsync(courseCode, request, headers, runtime);
        }

        public DeleteRemoteClassCourseResponse DeleteRemoteClassCourseWithOptions(string courseCode, DeleteRemoteClassCourseRequest request, DeleteRemoteClassCourseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            courseCode = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(courseCode);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["authCode"] = request.AuthCode;
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
            return TeaModel.ToObject<DeleteRemoteClassCourseResponse>(DoROARequest("DeleteRemoteClassCourse", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/remoteClasses/courses/" + courseCode, "json", req, runtime));
        }

        public async Task<DeleteRemoteClassCourseResponse> DeleteRemoteClassCourseWithOptionsAsync(string courseCode, DeleteRemoteClassCourseRequest request, DeleteRemoteClassCourseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            courseCode = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(courseCode);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["authCode"] = request.AuthCode;
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
            return TeaModel.ToObject<DeleteRemoteClassCourseResponse>(await DoROARequestAsync("DeleteRemoteClassCourse", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/remoteClasses/courses/" + courseCode, "json", req, runtime));
        }

        public DeleteStudentResponse DeleteStudent(string classId, string userId, DeleteStudentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteStudentHeaders headers = new DeleteStudentHeaders();
            return DeleteStudentWithOptions(classId, userId, request, headers, runtime);
        }

        public async Task<DeleteStudentResponse> DeleteStudentAsync(string classId, string userId, DeleteStudentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteStudentHeaders headers = new DeleteStudentHeaders();
            return await DeleteStudentWithOptionsAsync(classId, userId, request, headers, runtime);
        }

        public DeleteStudentResponse DeleteStudentWithOptions(string classId, string userId, DeleteStudentRequest request, DeleteStudentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            classId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(classId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
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
            return TeaModel.ToObject<DeleteStudentResponse>(DoROARequest("DeleteStudent", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/classes/" + classId + "/students/" + userId, "json", req, runtime));
        }

        public async Task<DeleteStudentResponse> DeleteStudentWithOptionsAsync(string classId, string userId, DeleteStudentRequest request, DeleteStudentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            classId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(classId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
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
            return TeaModel.ToObject<DeleteStudentResponse>(await DoROARequestAsync("DeleteStudent", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/classes/" + classId + "/students/" + userId, "json", req, runtime));
        }

        public DeleteTeacherResponse DeleteTeacher(string classId, string userId, DeleteTeacherRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTeacherHeaders headers = new DeleteTeacherHeaders();
            return DeleteTeacherWithOptions(classId, userId, request, headers, runtime);
        }

        public async Task<DeleteTeacherResponse> DeleteTeacherAsync(string classId, string userId, DeleteTeacherRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTeacherHeaders headers = new DeleteTeacherHeaders();
            return await DeleteTeacherWithOptionsAsync(classId, userId, request, headers, runtime);
        }

        public DeleteTeacherResponse DeleteTeacherWithOptions(string classId, string userId, DeleteTeacherRequest request, DeleteTeacherHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            classId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(classId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Adviser))
            {
                query["adviser"] = request.Adviser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
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
            return TeaModel.ToObject<DeleteTeacherResponse>(DoROARequest("DeleteTeacher", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/classes/" + classId + "/teachers/" + userId, "json", req, runtime));
        }

        public async Task<DeleteTeacherResponse> DeleteTeacherWithOptionsAsync(string classId, string userId, DeleteTeacherRequest request, DeleteTeacherHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            classId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(classId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Adviser))
            {
                query["adviser"] = request.Adviser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
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
            return TeaModel.ToObject<DeleteTeacherResponse>(await DoROARequestAsync("DeleteTeacher", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/classes/" + classId + "/teachers/" + userId, "json", req, runtime));
        }

        public DeleteUniversityCourseGroupResponse DeleteUniversityCourseGroup(DeleteUniversityCourseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUniversityCourseGroupHeaders headers = new DeleteUniversityCourseGroupHeaders();
            return DeleteUniversityCourseGroupWithOptions(request, headers, runtime);
        }

        public async Task<DeleteUniversityCourseGroupResponse> DeleteUniversityCourseGroupAsync(DeleteUniversityCourseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUniversityCourseGroupHeaders headers = new DeleteUniversityCourseGroupHeaders();
            return await DeleteUniversityCourseGroupWithOptionsAsync(request, headers, runtime);
        }

        public DeleteUniversityCourseGroupResponse DeleteUniversityCourseGroupWithOptions(DeleteUniversityCourseGroupRequest request, DeleteUniversityCourseGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupCode))
            {
                query["courseGroupCode"] = request.CourseGroupCode;
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
            return TeaModel.ToObject<DeleteUniversityCourseGroupResponse>(DoROARequest("DeleteUniversityCourseGroup", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/universities/courseGroups", "json", req, runtime));
        }

        public async Task<DeleteUniversityCourseGroupResponse> DeleteUniversityCourseGroupWithOptionsAsync(DeleteUniversityCourseGroupRequest request, DeleteUniversityCourseGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupCode))
            {
                query["courseGroupCode"] = request.CourseGroupCode;
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
            return TeaModel.ToObject<DeleteUniversityCourseGroupResponse>(await DoROARequestAsync("DeleteUniversityCourseGroup", "edu_1.0", "HTTP", "DELETE", "AK", "/v1.0/edu/universities/courseGroups", "json", req, runtime));
        }

        public EndCourseResponse EndCourse(EndCourseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EndCourseHeaders headers = new EndCourseHeaders();
            return EndCourseWithOptions(request, headers, runtime);
        }

        public async Task<EndCourseResponse> EndCourseAsync(EndCourseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EndCourseHeaders headers = new EndCourseHeaders();
            return await EndCourseWithOptionsAsync(request, headers, runtime);
        }

        public EndCourseResponse EndCourseWithOptions(EndCourseRequest request, EndCourseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseCode))
            {
                body["courseCode"] = request.CourseCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["isvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LivePlayInfoList))
            {
                body["livePlayInfoList"] = request.LivePlayInfoList;
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
            return TeaModel.ToObject<EndCourseResponse>(DoROARequest("EndCourse", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courses/end", "json", req, runtime));
        }

        public async Task<EndCourseResponse> EndCourseWithOptionsAsync(EndCourseRequest request, EndCourseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseCode))
            {
                body["courseCode"] = request.CourseCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["isvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LivePlayInfoList))
            {
                body["livePlayInfoList"] = request.LivePlayInfoList;
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
            return TeaModel.ToObject<EndCourseResponse>(await DoROARequestAsync("EndCourse", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courses/end", "json", req, runtime));
        }

        public GetDefaultChildResponse GetDefaultChild()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDefaultChildHeaders headers = new GetDefaultChildHeaders();
            return GetDefaultChildWithOptions(headers, runtime);
        }

        public async Task<GetDefaultChildResponse> GetDefaultChildAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDefaultChildHeaders headers = new GetDefaultChildHeaders();
            return await GetDefaultChildWithOptionsAsync(headers, runtime);
        }

        public GetDefaultChildResponse GetDefaultChildWithOptions(GetDefaultChildHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<GetDefaultChildResponse>(DoROARequest("GetDefaultChild", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/defaultChildren", "json", req, runtime));
        }

        public async Task<GetDefaultChildResponse> GetDefaultChildWithOptionsAsync(GetDefaultChildHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<GetDefaultChildResponse>(await DoROARequestAsync("GetDefaultChild", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/defaultChildren", "json", req, runtime));
        }

        public GetOpenCourseDetailResponse GetOpenCourseDetail(string courseId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOpenCourseDetailHeaders headers = new GetOpenCourseDetailHeaders();
            return GetOpenCourseDetailWithOptions(courseId, headers, runtime);
        }

        public async Task<GetOpenCourseDetailResponse> GetOpenCourseDetailAsync(string courseId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOpenCourseDetailHeaders headers = new GetOpenCourseDetailHeaders();
            return await GetOpenCourseDetailWithOptionsAsync(courseId, headers, runtime);
        }

        public GetOpenCourseDetailResponse GetOpenCourseDetailWithOptions(string courseId, GetOpenCourseDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            courseId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(courseId);
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
            };
            return TeaModel.ToObject<GetOpenCourseDetailResponse>(DoROARequest("GetOpenCourseDetail", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/openCourse/" + courseId, "json", req, runtime));
        }

        public async Task<GetOpenCourseDetailResponse> GetOpenCourseDetailWithOptionsAsync(string courseId, GetOpenCourseDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            courseId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(courseId);
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
            };
            return TeaModel.ToObject<GetOpenCourseDetailResponse>(await DoROARequestAsync("GetOpenCourseDetail", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/openCourse/" + courseId, "json", req, runtime));
        }

        public GetOpenCoursesResponse GetOpenCourses(GetOpenCoursesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOpenCoursesHeaders headers = new GetOpenCoursesHeaders();
            return GetOpenCoursesWithOptions(request, headers, runtime);
        }

        public async Task<GetOpenCoursesResponse> GetOpenCoursesAsync(GetOpenCoursesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOpenCoursesHeaders headers = new GetOpenCoursesHeaders();
            return await GetOpenCoursesWithOptionsAsync(request, headers, runtime);
        }

        public GetOpenCoursesResponse GetOpenCoursesWithOptions(GetOpenCoursesRequest request, GetOpenCoursesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<GetOpenCoursesResponse>(DoROARequest("GetOpenCourses", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/openCourses", "json", req, runtime));
        }

        public async Task<GetOpenCoursesResponse> GetOpenCoursesWithOptionsAsync(GetOpenCoursesRequest request, GetOpenCoursesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<GetOpenCoursesResponse>(await DoROARequestAsync("GetOpenCourses", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/openCourses", "json", req, runtime));
        }

        public GetRemoteClassCourseResponse GetRemoteClassCourse(string courseCode, GetRemoteClassCourseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRemoteClassCourseHeaders headers = new GetRemoteClassCourseHeaders();
            return GetRemoteClassCourseWithOptions(courseCode, request, headers, runtime);
        }

        public async Task<GetRemoteClassCourseResponse> GetRemoteClassCourseAsync(string courseCode, GetRemoteClassCourseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRemoteClassCourseHeaders headers = new GetRemoteClassCourseHeaders();
            return await GetRemoteClassCourseWithOptionsAsync(courseCode, request, headers, runtime);
        }

        public GetRemoteClassCourseResponse GetRemoteClassCourseWithOptions(string courseCode, GetRemoteClassCourseRequest request, GetRemoteClassCourseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            courseCode = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(courseCode);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
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
            return TeaModel.ToObject<GetRemoteClassCourseResponse>(DoROARequest("GetRemoteClassCourse", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/remoteClasses/courses/" + courseCode, "json", req, runtime));
        }

        public async Task<GetRemoteClassCourseResponse> GetRemoteClassCourseWithOptionsAsync(string courseCode, GetRemoteClassCourseRequest request, GetRemoteClassCourseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            courseCode = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(courseCode);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
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
            return TeaModel.ToObject<GetRemoteClassCourseResponse>(await DoROARequestAsync("GetRemoteClassCourse", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/remoteClasses/courses/" + courseCode, "json", req, runtime));
        }

        public GetShareRoleMembersResponse GetShareRoleMembers(string shareRoleCode)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetShareRoleMembersHeaders headers = new GetShareRoleMembersHeaders();
            return GetShareRoleMembersWithOptions(shareRoleCode, headers, runtime);
        }

        public async Task<GetShareRoleMembersResponse> GetShareRoleMembersAsync(string shareRoleCode)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetShareRoleMembersHeaders headers = new GetShareRoleMembersHeaders();
            return await GetShareRoleMembersWithOptionsAsync(shareRoleCode, headers, runtime);
        }

        public GetShareRoleMembersResponse GetShareRoleMembersWithOptions(string shareRoleCode, GetShareRoleMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            shareRoleCode = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(shareRoleCode);
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
            };
            return TeaModel.ToObject<GetShareRoleMembersResponse>(DoROARequest("GetShareRoleMembers", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/shareRoles/" + shareRoleCode + "/members", "json", req, runtime));
        }

        public async Task<GetShareRoleMembersResponse> GetShareRoleMembersWithOptionsAsync(string shareRoleCode, GetShareRoleMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            shareRoleCode = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(shareRoleCode);
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
            };
            return TeaModel.ToObject<GetShareRoleMembersResponse>(await DoROARequestAsync("GetShareRoleMembers", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/shareRoles/" + shareRoleCode + "/members", "json", req, runtime));
        }

        public GetShareRolesResponse GetShareRoles()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetShareRolesHeaders headers = new GetShareRolesHeaders();
            return GetShareRolesWithOptions(headers, runtime);
        }

        public async Task<GetShareRolesResponse> GetShareRolesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetShareRolesHeaders headers = new GetShareRolesHeaders();
            return await GetShareRolesWithOptionsAsync(headers, runtime);
        }

        public GetShareRolesResponse GetShareRolesWithOptions(GetShareRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<GetShareRolesResponse>(DoROARequest("GetShareRoles", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/shareRoles", "json", req, runtime));
        }

        public async Task<GetShareRolesResponse> GetShareRolesWithOptionsAsync(GetShareRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<GetShareRolesResponse>(await DoROARequestAsync("GetShareRoles", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/shareRoles", "json", req, runtime));
        }

        public InitCoursesOfClassResponse InitCoursesOfClass(string classId, InitCoursesOfClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InitCoursesOfClassHeaders headers = new InitCoursesOfClassHeaders();
            return InitCoursesOfClassWithOptions(classId, request, headers, runtime);
        }

        public async Task<InitCoursesOfClassResponse> InitCoursesOfClassAsync(string classId, InitCoursesOfClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InitCoursesOfClassHeaders headers = new InitCoursesOfClassHeaders();
            return await InitCoursesOfClassWithOptionsAsync(classId, request, headers, runtime);
        }

        public InitCoursesOfClassResponse InitCoursesOfClassWithOptions(string classId, InitCoursesOfClassRequest request, InitCoursesOfClassHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            classId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(classId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Courses))
            {
                body["courses"] = request.Courses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SectionConfig.ToMap()))
            {
                body["sectionConfig"] = request.SectionConfig;
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
            return TeaModel.ToObject<InitCoursesOfClassResponse>(DoROARequest("InitCoursesOfClass", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/classes/" + classId + "/courses/init", "json", req, runtime));
        }

        public async Task<InitCoursesOfClassResponse> InitCoursesOfClassWithOptionsAsync(string classId, InitCoursesOfClassRequest request, InitCoursesOfClassHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            classId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(classId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Courses))
            {
                body["courses"] = request.Courses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SectionConfig.ToMap()))
            {
                body["sectionConfig"] = request.SectionConfig;
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
            return TeaModel.ToObject<InitCoursesOfClassResponse>(await DoROARequestAsync("InitCoursesOfClass", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/classes/" + classId + "/courses/init", "json", req, runtime));
        }

        public InsertSectionConfigResponse InsertSectionConfig(InsertSectionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertSectionConfigHeaders headers = new InsertSectionConfigHeaders();
            return InsertSectionConfigWithOptions(request, headers, runtime);
        }

        public async Task<InsertSectionConfigResponse> InsertSectionConfigAsync(InsertSectionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertSectionConfigHeaders headers = new InsertSectionConfigHeaders();
            return await InsertSectionConfigWithOptionsAsync(request, headers, runtime);
        }

        public InsertSectionConfigResponse InsertSectionConfigWithOptions(InsertSectionConfigRequest request, InsertSectionConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End.ToMap()))
            {
                body["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleName))
            {
                body["scheduleName"] = request.ScheduleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SectionModels))
            {
                body["sectionModels"] = request.SectionModels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start.ToMap()))
            {
                body["start"] = request.Start;
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
            return TeaModel.ToObject<InsertSectionConfigResponse>(DoROARequest("InsertSectionConfig", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/schedules/configs", "json", req, runtime));
        }

        public async Task<InsertSectionConfigResponse> InsertSectionConfigWithOptionsAsync(InsertSectionConfigRequest request, InsertSectionConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End.ToMap()))
            {
                body["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleName))
            {
                body["scheduleName"] = request.ScheduleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SectionModels))
            {
                body["sectionModels"] = request.SectionModels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start.ToMap()))
            {
                body["start"] = request.Start;
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
            return TeaModel.ToObject<InsertSectionConfigResponse>(await DoROARequestAsync("InsertSectionConfig", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/schedules/configs", "json", req, runtime));
        }

        public MoveStudentResponse MoveStudent(MoveStudentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveStudentHeaders headers = new MoveStudentHeaders();
            return MoveStudentWithOptions(request, headers, runtime);
        }

        public async Task<MoveStudentResponse> MoveStudentAsync(MoveStudentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MoveStudentHeaders headers = new MoveStudentHeaders();
            return await MoveStudentWithOptionsAsync(request, headers, runtime);
        }

        public MoveStudentResponse MoveStudentWithOptions(MoveStudentRequest request, MoveStudentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOauthAppId))
            {
                body["dingOauthAppId"] = request.DingOauthAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginClassId))
            {
                body["originClassId"] = request.OriginClassId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetClassId))
            {
                body["targetClassId"] = request.TargetClassId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<MoveStudentResponse>(DoROARequest("MoveStudent", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/students/move", "json", req, runtime));
        }

        public async Task<MoveStudentResponse> MoveStudentWithOptionsAsync(MoveStudentRequest request, MoveStudentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOauthAppId))
            {
                body["dingOauthAppId"] = request.DingOauthAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginClassId))
            {
                body["originClassId"] = request.OriginClassId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetClassId))
            {
                body["targetClassId"] = request.TargetClassId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<MoveStudentResponse>(await DoROARequestAsync("MoveStudent", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/students/move", "json", req, runtime));
        }

        public PollingConfirmStatusResponse PollingConfirmStatus(PollingConfirmStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PollingConfirmStatusHeaders headers = new PollingConfirmStatusHeaders();
            return PollingConfirmStatusWithOptions(request, headers, runtime);
        }

        public async Task<PollingConfirmStatusResponse> PollingConfirmStatusAsync(PollingConfirmStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PollingConfirmStatusHeaders headers = new PollingConfirmStatusHeaders();
            return await PollingConfirmStatusWithOptionsAsync(request, headers, runtime);
        }

        public PollingConfirmStatusResponse PollingConfirmStatusWithOptions(PollingConfirmStatusRequest request, PollingConfirmStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseCode))
            {
                query["courseCode"] = request.CourseCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                query["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["isvCode"] = request.IsvCode;
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
            return TeaModel.ToObject<PollingConfirmStatusResponse>(DoROARequest("PollingConfirmStatus", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/universities/courses/pollingConfirmStatus", "json", req, runtime));
        }

        public async Task<PollingConfirmStatusResponse> PollingConfirmStatusWithOptionsAsync(PollingConfirmStatusRequest request, PollingConfirmStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseCode))
            {
                query["courseCode"] = request.CourseCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                query["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["isvCode"] = request.IsvCode;
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
            return TeaModel.ToObject<PollingConfirmStatusResponse>(await DoROARequestAsync("PollingConfirmStatus", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/universities/courses/pollingConfirmStatus", "json", req, runtime));
        }

        public QueryAllSubjectsFromClassScheduleResponse QueryAllSubjectsFromClassSchedule(QueryAllSubjectsFromClassScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllSubjectsFromClassScheduleHeaders headers = new QueryAllSubjectsFromClassScheduleHeaders();
            return QueryAllSubjectsFromClassScheduleWithOptions(request, headers, runtime);
        }

        public async Task<QueryAllSubjectsFromClassScheduleResponse> QueryAllSubjectsFromClassScheduleAsync(QueryAllSubjectsFromClassScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllSubjectsFromClassScheduleHeaders headers = new QueryAllSubjectsFromClassScheduleHeaders();
            return await QueryAllSubjectsFromClassScheduleWithOptionsAsync(request, headers, runtime);
        }

        public QueryAllSubjectsFromClassScheduleResponse QueryAllSubjectsFromClassScheduleWithOptions(QueryAllSubjectsFromClassScheduleRequest tmpReq, QueryAllSubjectsFromClassScheduleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryAllSubjectsFromClassScheduleShrinkRequest request = new QueryAllSubjectsFromClassScheduleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClassIds))
            {
                request.ClassIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClassIds, "classIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassIdsShrink))
            {
                query["classIds"] = request.ClassIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodCode))
            {
                query["periodCode"] = request.PeriodCode;
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
            return TeaModel.ToObject<QueryAllSubjectsFromClassScheduleResponse>(DoROARequest("QueryAllSubjectsFromClassSchedule", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/subjects/instances", "json", req, runtime));
        }

        public async Task<QueryAllSubjectsFromClassScheduleResponse> QueryAllSubjectsFromClassScheduleWithOptionsAsync(QueryAllSubjectsFromClassScheduleRequest tmpReq, QueryAllSubjectsFromClassScheduleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryAllSubjectsFromClassScheduleShrinkRequest request = new QueryAllSubjectsFromClassScheduleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClassIds))
            {
                request.ClassIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClassIds, "classIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassIdsShrink))
            {
                query["classIds"] = request.ClassIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodCode))
            {
                query["periodCode"] = request.PeriodCode;
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
            return TeaModel.ToObject<QueryAllSubjectsFromClassScheduleResponse>(await DoROARequestAsync("QueryAllSubjectsFromClassSchedule", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/subjects/instances", "json", req, runtime));
        }

        public QueryClassScheduleResponse QueryClassSchedule(QueryClassScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryClassScheduleHeaders headers = new QueryClassScheduleHeaders();
            return QueryClassScheduleWithOptions(request, headers, runtime);
        }

        public async Task<QueryClassScheduleResponse> QueryClassScheduleAsync(QueryClassScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryClassScheduleHeaders headers = new QueryClassScheduleHeaders();
            return await QueryClassScheduleWithOptionsAsync(request, headers, runtime);
        }

        public QueryClassScheduleResponse QueryClassScheduleWithOptions(QueryClassScheduleRequest request, QueryClassScheduleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriberType))
            {
                query["subscriberType"] = request.SubscriberType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SectionIndexList))
            {
                body["sectionIndexList"] = request.SectionIndexList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriberIds))
            {
                body["subscriberIds"] = request.SubscriberIds;
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
            return TeaModel.ToObject<QueryClassScheduleResponse>(DoROARequest("QueryClassSchedule", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/classes/schedules/query", "json", req, runtime));
        }

        public async Task<QueryClassScheduleResponse> QueryClassScheduleWithOptionsAsync(QueryClassScheduleRequest request, QueryClassScheduleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriberType))
            {
                query["subscriberType"] = request.SubscriberType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SectionIndexList))
            {
                body["sectionIndexList"] = request.SectionIndexList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriberIds))
            {
                body["subscriberIds"] = request.SubscriberIds;
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
            return TeaModel.ToObject<QueryClassScheduleResponse>(await DoROARequestAsync("QueryClassSchedule", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/classes/schedules/query", "json", req, runtime));
        }

        public QueryClassScheduleByTimeSchoolResponse QueryClassScheduleByTimeSchool(QueryClassScheduleByTimeSchoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryClassScheduleByTimeSchoolHeaders headers = new QueryClassScheduleByTimeSchoolHeaders();
            return QueryClassScheduleByTimeSchoolWithOptions(request, headers, runtime);
        }

        public async Task<QueryClassScheduleByTimeSchoolResponse> QueryClassScheduleByTimeSchoolAsync(QueryClassScheduleByTimeSchoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryClassScheduleByTimeSchoolHeaders headers = new QueryClassScheduleByTimeSchoolHeaders();
            return await QueryClassScheduleByTimeSchoolWithOptionsAsync(request, headers, runtime);
        }

        public QueryClassScheduleByTimeSchoolResponse QueryClassScheduleByTimeSchoolWithOptions(QueryClassScheduleByTimeSchoolRequest request, QueryClassScheduleByTimeSchoolHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
            return TeaModel.ToObject<QueryClassScheduleByTimeSchoolResponse>(DoROARequest("QueryClassScheduleByTimeSchool", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/schools/classes/courses ", "json", req, runtime));
        }

        public async Task<QueryClassScheduleByTimeSchoolResponse> QueryClassScheduleByTimeSchoolWithOptionsAsync(QueryClassScheduleByTimeSchoolRequest request, QueryClassScheduleByTimeSchoolHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
            return TeaModel.ToObject<QueryClassScheduleByTimeSchoolResponse>(await DoROARequestAsync("QueryClassScheduleByTimeSchool", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/schools/classes/courses ", "json", req, runtime));
        }

        public QueryClassScheduleConfigResponse QueryClassScheduleConfig(QueryClassScheduleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryClassScheduleConfigHeaders headers = new QueryClassScheduleConfigHeaders();
            return QueryClassScheduleConfigWithOptions(request, headers, runtime);
        }

        public async Task<QueryClassScheduleConfigResponse> QueryClassScheduleConfigAsync(QueryClassScheduleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryClassScheduleConfigHeaders headers = new QueryClassScheduleConfigHeaders();
            return await QueryClassScheduleConfigWithOptionsAsync(request, headers, runtime);
        }

        public QueryClassScheduleConfigResponse QueryClassScheduleConfigWithOptions(QueryClassScheduleConfigRequest tmpReq, QueryClassScheduleConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryClassScheduleConfigShrinkRequest request = new QueryClassScheduleConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClassIds))
            {
                request.ClassIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClassIds, "classIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassIdsShrink))
            {
                query["classIds"] = request.ClassIdsShrink;
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
            return TeaModel.ToObject<QueryClassScheduleConfigResponse>(DoROARequest("QueryClassScheduleConfig", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/schedules/configs", "json", req, runtime));
        }

        public async Task<QueryClassScheduleConfigResponse> QueryClassScheduleConfigWithOptionsAsync(QueryClassScheduleConfigRequest tmpReq, QueryClassScheduleConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryClassScheduleConfigShrinkRequest request = new QueryClassScheduleConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClassIds))
            {
                request.ClassIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClassIds, "classIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassIdsShrink))
            {
                query["classIds"] = request.ClassIdsShrink;
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
            return TeaModel.ToObject<QueryClassScheduleConfigResponse>(await DoROARequestAsync("QueryClassScheduleConfig", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/schedules/configs", "json", req, runtime));
        }

        public QueryDeviceListByCorpIdResponse QueryDeviceListByCorpId(QueryDeviceListByCorpIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceListByCorpIdHeaders headers = new QueryDeviceListByCorpIdHeaders();
            return QueryDeviceListByCorpIdWithOptions(request, headers, runtime);
        }

        public async Task<QueryDeviceListByCorpIdResponse> QueryDeviceListByCorpIdAsync(QueryDeviceListByCorpIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceListByCorpIdHeaders headers = new QueryDeviceListByCorpIdHeaders();
            return await QueryDeviceListByCorpIdWithOptionsAsync(request, headers, runtime);
        }

        public QueryDeviceListByCorpIdResponse QueryDeviceListByCorpIdWithOptions(QueryDeviceListByCorpIdRequest request, QueryDeviceListByCorpIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<QueryDeviceListByCorpIdResponse>(DoROARequest("QueryDeviceListByCorpId", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/remoteClasses/devices", "json", req, runtime));
        }

        public async Task<QueryDeviceListByCorpIdResponse> QueryDeviceListByCorpIdWithOptionsAsync(QueryDeviceListByCorpIdRequest request, QueryDeviceListByCorpIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
            return TeaModel.ToObject<QueryDeviceListByCorpIdResponse>(await DoROARequestAsync("QueryDeviceListByCorpId", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/remoteClasses/devices", "json", req, runtime));
        }

        public QueryOrgRelationListResponse QueryOrgRelationList(QueryOrgRelationListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgRelationListHeaders headers = new QueryOrgRelationListHeaders();
            return QueryOrgRelationListWithOptions(request, headers, runtime);
        }

        public async Task<QueryOrgRelationListResponse> QueryOrgRelationListAsync(QueryOrgRelationListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgRelationListHeaders headers = new QueryOrgRelationListHeaders();
            return await QueryOrgRelationListWithOptionsAsync(request, headers, runtime);
        }

        public QueryOrgRelationListResponse QueryOrgRelationListWithOptions(QueryOrgRelationListRequest request, QueryOrgRelationListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
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
            return TeaModel.ToObject<QueryOrgRelationListResponse>(DoROARequest("QueryOrgRelationList", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/remoteClasses/orgRelations", "json", req, runtime));
        }

        public async Task<QueryOrgRelationListResponse> QueryOrgRelationListWithOptionsAsync(QueryOrgRelationListRequest request, QueryOrgRelationListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
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
            return TeaModel.ToObject<QueryOrgRelationListResponse>(await DoROARequestAsync("QueryOrgRelationList", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/remoteClasses/orgRelations", "json", req, runtime));
        }

        public QueryOrgSecretKeyResponse QueryOrgSecretKey(QueryOrgSecretKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgSecretKeyHeaders headers = new QueryOrgSecretKeyHeaders();
            return QueryOrgSecretKeyWithOptions(request, headers, runtime);
        }

        public async Task<QueryOrgSecretKeyResponse> QueryOrgSecretKeyAsync(QueryOrgSecretKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgSecretKeyHeaders headers = new QueryOrgSecretKeyHeaders();
            return await QueryOrgSecretKeyWithOptionsAsync(request, headers, runtime);
        }

        public QueryOrgSecretKeyResponse QueryOrgSecretKeyWithOptions(QueryOrgSecretKeyRequest request, QueryOrgSecretKeyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["isvCode"] = request.IsvCode;
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
            return TeaModel.ToObject<QueryOrgSecretKeyResponse>(DoROARequest("QueryOrgSecretKey", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/universities/secretKeys", "json", req, runtime));
        }

        public async Task<QueryOrgSecretKeyResponse> QueryOrgSecretKeyWithOptionsAsync(QueryOrgSecretKeyRequest request, QueryOrgSecretKeyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["isvCode"] = request.IsvCode;
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
            return TeaModel.ToObject<QueryOrgSecretKeyResponse>(await DoROARequestAsync("QueryOrgSecretKey", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/universities/secretKeys", "json", req, runtime));
        }

        public QueryOrgTypeResponse QueryOrgType()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgTypeHeaders headers = new QueryOrgTypeHeaders();
            return QueryOrgTypeWithOptions(headers, runtime);
        }

        public async Task<QueryOrgTypeResponse> QueryOrgTypeAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgTypeHeaders headers = new QueryOrgTypeHeaders();
            return await QueryOrgTypeWithOptionsAsync(headers, runtime);
        }

        public QueryOrgTypeResponse QueryOrgTypeWithOptions(QueryOrgTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<QueryOrgTypeResponse>(DoROARequest("QueryOrgType", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/orgTypes", "json", req, runtime));
        }

        public async Task<QueryOrgTypeResponse> QueryOrgTypeWithOptionsAsync(QueryOrgTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<QueryOrgTypeResponse>(await DoROARequestAsync("QueryOrgType", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/orgTypes", "json", req, runtime));
        }

        public QueryPhysicalClassroomResponse QueryPhysicalClassroom(QueryPhysicalClassroomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPhysicalClassroomHeaders headers = new QueryPhysicalClassroomHeaders();
            return QueryPhysicalClassroomWithOptions(request, headers, runtime);
        }

        public async Task<QueryPhysicalClassroomResponse> QueryPhysicalClassroomAsync(QueryPhysicalClassroomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPhysicalClassroomHeaders headers = new QueryPhysicalClassroomHeaders();
            return await QueryPhysicalClassroomWithOptionsAsync(request, headers, runtime);
        }

        public QueryPhysicalClassroomResponse QueryPhysicalClassroomWithOptions(QueryPhysicalClassroomRequest request, QueryPhysicalClassroomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomId))
            {
                query["classroomId"] = request.ClassroomId;
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
            return TeaModel.ToObject<QueryPhysicalClassroomResponse>(DoROARequest("QueryPhysicalClassroom", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/physicalClassrooms", "json", req, runtime));
        }

        public async Task<QueryPhysicalClassroomResponse> QueryPhysicalClassroomWithOptionsAsync(QueryPhysicalClassroomRequest request, QueryPhysicalClassroomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomId))
            {
                query["classroomId"] = request.ClassroomId;
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
            return TeaModel.ToObject<QueryPhysicalClassroomResponse>(await DoROARequestAsync("QueryPhysicalClassroom", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/physicalClassrooms", "json", req, runtime));
        }

        public QueryRemoteClassCourseResponse QueryRemoteClassCourse(QueryRemoteClassCourseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRemoteClassCourseHeaders headers = new QueryRemoteClassCourseHeaders();
            return QueryRemoteClassCourseWithOptions(request, headers, runtime);
        }

        public async Task<QueryRemoteClassCourseResponse> QueryRemoteClassCourseAsync(QueryRemoteClassCourseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRemoteClassCourseHeaders headers = new QueryRemoteClassCourseHeaders();
            return await QueryRemoteClassCourseWithOptionsAsync(request, headers, runtime);
        }

        public QueryRemoteClassCourseResponse QueryRemoteClassCourseWithOptions(QueryRemoteClassCourseRequest request, QueryRemoteClassCourseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
            return TeaModel.ToObject<QueryRemoteClassCourseResponse>(DoROARequest("QueryRemoteClassCourse", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/remoteClasses/courses", "json", req, runtime));
        }

        public async Task<QueryRemoteClassCourseResponse> QueryRemoteClassCourseWithOptionsAsync(QueryRemoteClassCourseRequest request, QueryRemoteClassCourseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
            return TeaModel.ToObject<QueryRemoteClassCourseResponse>(await DoROARequestAsync("QueryRemoteClassCourse", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/remoteClasses/courses", "json", req, runtime));
        }

        public QueryStatisticsDataResponse QueryStatisticsData(QueryStatisticsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryStatisticsDataHeaders headers = new QueryStatisticsDataHeaders();
            return QueryStatisticsDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryStatisticsDataResponse> QueryStatisticsDataAsync(QueryStatisticsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryStatisticsDataHeaders headers = new QueryStatisticsDataHeaders();
            return await QueryStatisticsDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryStatisticsDataResponse QueryStatisticsDataWithOptions(QueryStatisticsDataRequest request, QueryStatisticsDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SectionIndexList))
            {
                body["sectionIndexList"] = request.SectionIndexList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeacherUserIds))
            {
                body["teacherUserIds"] = request.TeacherUserIds;
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
            return TeaModel.ToObject<QueryStatisticsDataResponse>(DoROARequest("QueryStatisticsData", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/classes/schedules/statisticData/query", "json", req, runtime));
        }

        public async Task<QueryStatisticsDataResponse> QueryStatisticsDataWithOptionsAsync(QueryStatisticsDataRequest request, QueryStatisticsDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SectionIndexList))
            {
                body["sectionIndexList"] = request.SectionIndexList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeacherUserIds))
            {
                body["teacherUserIds"] = request.TeacherUserIds;
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
            return TeaModel.ToObject<QueryStatisticsDataResponse>(await DoROARequestAsync("QueryStatisticsData", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/classes/schedules/statisticData/query", "json", req, runtime));
        }

        public QuerySubjectTeachersResponse QuerySubjectTeachers(QuerySubjectTeachersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySubjectTeachersHeaders headers = new QuerySubjectTeachersHeaders();
            return QuerySubjectTeachersWithOptions(request, headers, runtime);
        }

        public async Task<QuerySubjectTeachersResponse> QuerySubjectTeachersAsync(QuerySubjectTeachersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySubjectTeachersHeaders headers = new QuerySubjectTeachersHeaders();
            return await QuerySubjectTeachersWithOptionsAsync(request, headers, runtime);
        }

        public QuerySubjectTeachersResponse QuerySubjectTeachersWithOptions(QuerySubjectTeachersRequest request, QuerySubjectTeachersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassIds))
            {
                query["classIds"] = request.ClassIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubjectCode))
            {
                query["subjectCode"] = request.SubjectCode;
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
            return TeaModel.ToObject<QuerySubjectTeachersResponse>(DoROARequest("QuerySubjectTeachers", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/subjects/teachers", "json", req, runtime));
        }

        public async Task<QuerySubjectTeachersResponse> QuerySubjectTeachersWithOptionsAsync(QuerySubjectTeachersRequest request, QuerySubjectTeachersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassIds))
            {
                query["classIds"] = request.ClassIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubjectCode))
            {
                query["subjectCode"] = request.SubjectCode;
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
            return TeaModel.ToObject<QuerySubjectTeachersResponse>(await DoROARequestAsync("QuerySubjectTeachers", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/subjects/teachers", "json", req, runtime));
        }

        public QueryTeachSubjectsResponse QueryTeachSubjects(QueryTeachSubjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTeachSubjectsHeaders headers = new QueryTeachSubjectsHeaders();
            return QueryTeachSubjectsWithOptions(request, headers, runtime);
        }

        public async Task<QueryTeachSubjectsResponse> QueryTeachSubjectsAsync(QueryTeachSubjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTeachSubjectsHeaders headers = new QueryTeachSubjectsHeaders();
            return await QueryTeachSubjectsWithOptionsAsync(request, headers, runtime);
        }

        public QueryTeachSubjectsResponse QueryTeachSubjectsWithOptions(QueryTeachSubjectsRequest request, QueryTeachSubjectsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassIds))
            {
                query["classIds"] = request.ClassIds;
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
            return TeaModel.ToObject<QueryTeachSubjectsResponse>(DoROARequest("QueryTeachSubjects", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/teachers/subjects", "json", req, runtime));
        }

        public async Task<QueryTeachSubjectsResponse> QueryTeachSubjectsWithOptionsAsync(QueryTeachSubjectsRequest request, QueryTeachSubjectsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassIds))
            {
                query["classIds"] = request.ClassIds;
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
            return TeaModel.ToObject<QueryTeachSubjectsResponse>(await DoROARequestAsync("QueryTeachSubjects", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/teachers/subjects", "json", req, runtime));
        }

        public QueryUniversityCourseGroupResponse QueryUniversityCourseGroup(QueryUniversityCourseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUniversityCourseGroupHeaders headers = new QueryUniversityCourseGroupHeaders();
            return QueryUniversityCourseGroupWithOptions(request, headers, runtime);
        }

        public async Task<QueryUniversityCourseGroupResponse> QueryUniversityCourseGroupAsync(QueryUniversityCourseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUniversityCourseGroupHeaders headers = new QueryUniversityCourseGroupHeaders();
            return await QueryUniversityCourseGroupWithOptionsAsync(request, headers, runtime);
        }

        public QueryUniversityCourseGroupResponse QueryUniversityCourseGroupWithOptions(QueryUniversityCourseGroupRequest request, QueryUniversityCourseGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupCode))
            {
                query["courseGroupCode"] = request.CourseGroupCode;
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
            return TeaModel.ToObject<QueryUniversityCourseGroupResponse>(DoROARequest("QueryUniversityCourseGroup", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/universities/courseGroups", "json", req, runtime));
        }

        public async Task<QueryUniversityCourseGroupResponse> QueryUniversityCourseGroupWithOptionsAsync(QueryUniversityCourseGroupRequest request, QueryUniversityCourseGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupCode))
            {
                query["courseGroupCode"] = request.CourseGroupCode;
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
            return TeaModel.ToObject<QueryUniversityCourseGroupResponse>(await DoROARequestAsync("QueryUniversityCourseGroup", "edu_1.0", "HTTP", "GET", "AK", "/v1.0/edu/universities/courseGroups", "json", req, runtime));
        }

        public SearchTeachersResponse SearchTeachers(SearchTeachersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchTeachersHeaders headers = new SearchTeachersHeaders();
            return SearchTeachersWithOptions(request, headers, runtime);
        }

        public async Task<SearchTeachersResponse> SearchTeachersAsync(SearchTeachersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchTeachersHeaders headers = new SearchTeachersHeaders();
            return await SearchTeachersWithOptionsAsync(request, headers, runtime);
        }

        public SearchTeachersResponse SearchTeachersWithOptions(SearchTeachersRequest request, SearchTeachersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameKeyword))
            {
                query["nameKeyword"] = request.NameKeyword;
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
            return TeaModel.ToObject<SearchTeachersResponse>(DoROARequest("SearchTeachers", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/teachers/search", "json", req, runtime));
        }

        public async Task<SearchTeachersResponse> SearchTeachersWithOptionsAsync(SearchTeachersRequest request, SearchTeachersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameKeyword))
            {
                query["nameKeyword"] = request.NameKeyword;
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
            return TeaModel.ToObject<SearchTeachersResponse>(await DoROARequestAsync("SearchTeachers", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/teachers/search", "json", req, runtime));
        }

        public StartCourseResponse StartCourse(StartCourseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartCourseWithOptions(request, headers, runtime);
        }

        public async Task<StartCourseResponse> StartCourseAsync(StartCourseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartCourseWithOptionsAsync(request, headers, runtime);
        }

        public StartCourseResponse StartCourseWithOptions(StartCourseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseCode))
            {
                body["courseCode"] = request.CourseCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["isvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LivePlayInfoList))
            {
                body["livePlayInfoList"] = request.LivePlayInfoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<StartCourseResponse>(DoROARequest("StartCourse", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courses/start", "json", req, runtime));
        }

        public async Task<StartCourseResponse> StartCourseWithOptionsAsync(StartCourseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseCode))
            {
                body["courseCode"] = request.CourseCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["isvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LivePlayInfoList))
            {
                body["livePlayInfoList"] = request.LivePlayInfoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<StartCourseResponse>(await DoROARequestAsync("StartCourse", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courses/start", "json", req, runtime));
        }

        public StartCoursePrepareResponse StartCoursePrepare(StartCoursePrepareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartCoursePrepareHeaders headers = new StartCoursePrepareHeaders();
            return StartCoursePrepareWithOptions(request, headers, runtime);
        }

        public async Task<StartCoursePrepareResponse> StartCoursePrepareAsync(StartCoursePrepareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartCoursePrepareHeaders headers = new StartCoursePrepareHeaders();
            return await StartCoursePrepareWithOptionsAsync(request, headers, runtime);
        }

        public StartCoursePrepareResponse StartCoursePrepareWithOptions(StartCoursePrepareRequest request, StartCoursePrepareHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseDate))
            {
                body["courseDate"] = request.CourseDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupCode))
            {
                body["courseGroupCode"] = request.CourseGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["isvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveCoverImage))
            {
                body["liveCoverImage"] = request.LiveCoverImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SectionIndex))
            {
                body["sectionIndex"] = request.SectionIndex;
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
            return TeaModel.ToObject<StartCoursePrepareResponse>(DoROARequest("StartCoursePrepare", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courses/prepare", "json", req, runtime));
        }

        public async Task<StartCoursePrepareResponse> StartCoursePrepareWithOptionsAsync(StartCoursePrepareRequest request, StartCoursePrepareHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseDate))
            {
                body["courseDate"] = request.CourseDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupCode))
            {
                body["courseGroupCode"] = request.CourseGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["isvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveCoverImage))
            {
                body["liveCoverImage"] = request.LiveCoverImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SectionIndex))
            {
                body["sectionIndex"] = request.SectionIndex;
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
            return TeaModel.ToObject<StartCoursePrepareResponse>(await DoROARequestAsync("StartCoursePrepare", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courses/prepare", "json", req, runtime));
        }

        public SubscribeUniversityCourseGroupResponse SubscribeUniversityCourseGroup(SubscribeUniversityCourseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubscribeUniversityCourseGroupHeaders headers = new SubscribeUniversityCourseGroupHeaders();
            return SubscribeUniversityCourseGroupWithOptions(request, headers, runtime);
        }

        public async Task<SubscribeUniversityCourseGroupResponse> SubscribeUniversityCourseGroupAsync(SubscribeUniversityCourseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubscribeUniversityCourseGroupHeaders headers = new SubscribeUniversityCourseGroupHeaders();
            return await SubscribeUniversityCourseGroupWithOptionsAsync(request, headers, runtime);
        }

        public SubscribeUniversityCourseGroupResponse SubscribeUniversityCourseGroupWithOptions(SubscribeUniversityCourseGroupRequest request, SubscribeUniversityCourseGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupCode))
            {
                body["courseGroupCode"] = request.CourseGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentUserIds))
            {
                body["studentUserIds"] = request.StudentUserIds;
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
            return TeaModel.ToObject<SubscribeUniversityCourseGroupResponse>(DoROARequest("SubscribeUniversityCourseGroup", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courseGroups/subscribe", "json", req, runtime));
        }

        public async Task<SubscribeUniversityCourseGroupResponse> SubscribeUniversityCourseGroupWithOptionsAsync(SubscribeUniversityCourseGroupRequest request, SubscribeUniversityCourseGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupCode))
            {
                body["courseGroupCode"] = request.CourseGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentUserIds))
            {
                body["studentUserIds"] = request.StudentUserIds;
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
            return TeaModel.ToObject<SubscribeUniversityCourseGroupResponse>(await DoROARequestAsync("SubscribeUniversityCourseGroup", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courseGroups/subscribe", "json", req, runtime));
        }

        public UnsubscribeUniversityCourseGroupResponse UnsubscribeUniversityCourseGroup(UnsubscribeUniversityCourseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnsubscribeUniversityCourseGroupHeaders headers = new UnsubscribeUniversityCourseGroupHeaders();
            return UnsubscribeUniversityCourseGroupWithOptions(request, headers, runtime);
        }

        public async Task<UnsubscribeUniversityCourseGroupResponse> UnsubscribeUniversityCourseGroupAsync(UnsubscribeUniversityCourseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnsubscribeUniversityCourseGroupHeaders headers = new UnsubscribeUniversityCourseGroupHeaders();
            return await UnsubscribeUniversityCourseGroupWithOptionsAsync(request, headers, runtime);
        }

        public UnsubscribeUniversityCourseGroupResponse UnsubscribeUniversityCourseGroupWithOptions(UnsubscribeUniversityCourseGroupRequest request, UnsubscribeUniversityCourseGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupCode))
            {
                body["courseGroupCode"] = request.CourseGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentUserIds))
            {
                body["studentUserIds"] = request.StudentUserIds;
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
            return TeaModel.ToObject<UnsubscribeUniversityCourseGroupResponse>(DoROARequest("UnsubscribeUniversityCourseGroup", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courseGroups/unsubscribe", "json", req, runtime));
        }

        public async Task<UnsubscribeUniversityCourseGroupResponse> UnsubscribeUniversityCourseGroupWithOptionsAsync(UnsubscribeUniversityCourseGroupRequest request, UnsubscribeUniversityCourseGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupCode))
            {
                body["courseGroupCode"] = request.CourseGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentUserIds))
            {
                body["studentUserIds"] = request.StudentUserIds;
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
            return TeaModel.ToObject<UnsubscribeUniversityCourseGroupResponse>(await DoROARequestAsync("UnsubscribeUniversityCourseGroup", "edu_1.0", "HTTP", "POST", "AK", "/v1.0/edu/universities/courseGroups/unsubscribe", "json", req, runtime));
        }

        public UpdateCoursesOfClassResponse UpdateCoursesOfClass(string classId, UpdateCoursesOfClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCoursesOfClassHeaders headers = new UpdateCoursesOfClassHeaders();
            return UpdateCoursesOfClassWithOptions(classId, request, headers, runtime);
        }

        public async Task<UpdateCoursesOfClassResponse> UpdateCoursesOfClassAsync(string classId, UpdateCoursesOfClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCoursesOfClassHeaders headers = new UpdateCoursesOfClassHeaders();
            return await UpdateCoursesOfClassWithOptionsAsync(classId, request, headers, runtime);
        }

        public UpdateCoursesOfClassResponse UpdateCoursesOfClassWithOptions(string classId, UpdateCoursesOfClassRequest request, UpdateCoursesOfClassHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            classId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(classId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Courses))
            {
                body["courses"] = request.Courses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SectionConfig.ToMap()))
            {
                body["sectionConfig"] = request.SectionConfig;
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
            return TeaModel.ToObject<UpdateCoursesOfClassResponse>(DoROARequest("UpdateCoursesOfClass", "edu_1.0", "HTTP", "PUT", "AK", "/v1.0/edu/classes/" + classId + "/courses/schedules", "json", req, runtime));
        }

        public async Task<UpdateCoursesOfClassResponse> UpdateCoursesOfClassWithOptionsAsync(string classId, UpdateCoursesOfClassRequest request, UpdateCoursesOfClassHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            classId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(classId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Courses))
            {
                body["courses"] = request.Courses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SectionConfig.ToMap()))
            {
                body["sectionConfig"] = request.SectionConfig;
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
            return TeaModel.ToObject<UpdateCoursesOfClassResponse>(await DoROARequestAsync("UpdateCoursesOfClass", "edu_1.0", "HTTP", "PUT", "AK", "/v1.0/edu/classes/" + classId + "/courses/schedules", "json", req, runtime));
        }

        public UpdatePhysicalClassroomResponse UpdatePhysicalClassroom(UpdatePhysicalClassroomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePhysicalClassroomHeaders headers = new UpdatePhysicalClassroomHeaders();
            return UpdatePhysicalClassroomWithOptions(request, headers, runtime);
        }

        public async Task<UpdatePhysicalClassroomResponse> UpdatePhysicalClassroomAsync(UpdatePhysicalClassroomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePhysicalClassroomHeaders headers = new UpdatePhysicalClassroomHeaders();
            return await UpdatePhysicalClassroomWithOptionsAsync(request, headers, runtime);
        }

        public UpdatePhysicalClassroomResponse UpdatePhysicalClassroomWithOptions(UpdatePhysicalClassroomRequest request, UpdatePhysicalClassroomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomBuilding))
            {
                body["classroomBuilding"] = request.ClassroomBuilding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomCampus))
            {
                body["classroomCampus"] = request.ClassroomCampus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomFloor))
            {
                body["classroomFloor"] = request.ClassroomFloor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomId))
            {
                body["classroomId"] = request.ClassroomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomName))
            {
                body["classroomName"] = request.ClassroomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomNumber))
            {
                body["classroomNumber"] = request.ClassroomNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectBroadcast))
            {
                body["directBroadcast"] = request.DirectBroadcast;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
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
            return TeaModel.ToObject<UpdatePhysicalClassroomResponse>(DoROARequest("UpdatePhysicalClassroom", "edu_1.0", "HTTP", "PUT", "AK", "/v1.0/edu/physicalClassrooms", "json", req, runtime));
        }

        public async Task<UpdatePhysicalClassroomResponse> UpdatePhysicalClassroomWithOptionsAsync(UpdatePhysicalClassroomRequest request, UpdatePhysicalClassroomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomBuilding))
            {
                body["classroomBuilding"] = request.ClassroomBuilding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomCampus))
            {
                body["classroomCampus"] = request.ClassroomCampus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomFloor))
            {
                body["classroomFloor"] = request.ClassroomFloor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomId))
            {
                body["classroomId"] = request.ClassroomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomName))
            {
                body["classroomName"] = request.ClassroomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassroomNumber))
            {
                body["classroomNumber"] = request.ClassroomNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectBroadcast))
            {
                body["directBroadcast"] = request.DirectBroadcast;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
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
            return TeaModel.ToObject<UpdatePhysicalClassroomResponse>(await DoROARequestAsync("UpdatePhysicalClassroom", "edu_1.0", "HTTP", "PUT", "AK", "/v1.0/edu/physicalClassrooms", "json", req, runtime));
        }

        public UpdateRemoteClassCourseResponse UpdateRemoteClassCourse(UpdateRemoteClassCourseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRemoteClassCourseHeaders headers = new UpdateRemoteClassCourseHeaders();
            return UpdateRemoteClassCourseWithOptions(request, headers, runtime);
        }

        public async Task<UpdateRemoteClassCourseResponse> UpdateRemoteClassCourseAsync(UpdateRemoteClassCourseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRemoteClassCourseHeaders headers = new UpdateRemoteClassCourseHeaders();
            return await UpdateRemoteClassCourseWithOptionsAsync(request, headers, runtime);
        }

        public UpdateRemoteClassCourseResponse UpdateRemoteClassCourseWithOptions(UpdateRemoteClassCourseRequest request, UpdateRemoteClassCourseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendParticipants))
            {
                body["attendParticipants"] = request.AttendParticipants;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                body["authCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseCode))
            {
                body["courseCode"] = request.CourseCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseName))
            {
                body["courseName"] = request.CourseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingClientId))
            {
                body["dingClientId"] = request.DingClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOauthAppId))
            {
                body["dingOauthAppId"] = request.DingOauthAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeachingParticipant.ToMap()))
            {
                body["teachingParticipant"] = request.TeachingParticipant;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateRemoteClassCourseResponse>(DoROARequest("UpdateRemoteClassCourse", "edu_1.0", "HTTP", "PUT", "AK", "/v1.0/edu/remoteClasses/courses", "json", req, runtime));
        }

        public async Task<UpdateRemoteClassCourseResponse> UpdateRemoteClassCourseWithOptionsAsync(UpdateRemoteClassCourseRequest request, UpdateRemoteClassCourseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendParticipants))
            {
                body["attendParticipants"] = request.AttendParticipants;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                body["authCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseCode))
            {
                body["courseCode"] = request.CourseCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseName))
            {
                body["courseName"] = request.CourseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingClientId))
            {
                body["dingClientId"] = request.DingClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOauthAppId))
            {
                body["dingOauthAppId"] = request.DingOauthAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeachingParticipant.ToMap()))
            {
                body["teachingParticipant"] = request.TeachingParticipant;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateRemoteClassCourseResponse>(await DoROARequestAsync("UpdateRemoteClassCourse", "edu_1.0", "HTTP", "PUT", "AK", "/v1.0/edu/remoteClasses/courses", "json", req, runtime));
        }

        public UpdateUniversityCourseGroupResponse UpdateUniversityCourseGroup(UpdateUniversityCourseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUniversityCourseGroupHeaders headers = new UpdateUniversityCourseGroupHeaders();
            return UpdateUniversityCourseGroupWithOptions(request, headers, runtime);
        }

        public async Task<UpdateUniversityCourseGroupResponse> UpdateUniversityCourseGroupAsync(UpdateUniversityCourseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUniversityCourseGroupHeaders headers = new UpdateUniversityCourseGroupHeaders();
            return await UpdateUniversityCourseGroupWithOptionsAsync(request, headers, runtime);
        }

        public UpdateUniversityCourseGroupResponse UpdateUniversityCourseGroupWithOptions(UpdateUniversityCourseGroupRequest request, UpdateUniversityCourseGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupCode))
            {
                body["courseGroupCode"] = request.CourseGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupIntroduce))
            {
                body["courseGroupIntroduce"] = request.CourseGroupIntroduce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupName))
            {
                body["courseGroupName"] = request.CourseGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourserGroupItemModels))
            {
                body["courserGroupItemModels"] = request.CourserGroupItemModels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
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
            return TeaModel.ToObject<UpdateUniversityCourseGroupResponse>(DoROARequest("UpdateUniversityCourseGroup", "edu_1.0", "HTTP", "PUT", "AK", "/v1.0/edu/universities/courseGroups", "json", req, runtime));
        }

        public async Task<UpdateUniversityCourseGroupResponse> UpdateUniversityCourseGroupWithOptionsAsync(UpdateUniversityCourseGroupRequest request, UpdateUniversityCourseGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupCode))
            {
                body["courseGroupCode"] = request.CourseGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupIntroduce))
            {
                body["courseGroupIntroduce"] = request.CourseGroupIntroduce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseGroupName))
            {
                body["courseGroupName"] = request.CourseGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourserGroupItemModels))
            {
                body["courserGroupItemModels"] = request.CourserGroupItemModels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
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
            return TeaModel.ToObject<UpdateUniversityCourseGroupResponse>(await DoROARequestAsync("UpdateUniversityCourseGroup", "edu_1.0", "HTTP", "PUT", "AK", "/v1.0/edu/universities/courseGroups", "json", req, runtime));
        }

    }
}
