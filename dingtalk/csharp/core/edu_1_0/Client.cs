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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["sourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userid))
            {
                body["userid"] = request.Userid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsVersion))
            {
                body["jsVersion"] = request.JsVersion;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["sourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userid))
            {
                body["userid"] = request.Userid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsVersion))
            {
                body["jsVersion"] = request.JsVersion;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwMedia))
            {
                body["hwMedia"] = request.HwMedia;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwContent))
            {
                body["hwContent"] = request.HwContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwTitle))
            {
                body["hwTitle"] = request.HwTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseName))
            {
                body["courseName"] = request.CourseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwPhoto))
            {
                body["hwPhoto"] = request.HwPhoto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwVideo))
            {
                body["hwVideo"] = request.HwVideo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeacherName))
            {
                body["teacherName"] = request.TeacherName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeacherUserId))
            {
                body["teacherUserId"] = request.TeacherUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRole))
            {
                body["targetRole"] = request.TargetRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                body["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledRelease))
            {
                body["scheduledRelease"] = request.ScheduledRelease;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTime))
            {
                body["scheduledTime"] = request.ScheduledTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwDeadlineOpen))
            {
                body["hwDeadlineOpen"] = request.HwDeadlineOpen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwDeadline))
            {
                body["hwDeadline"] = request.HwDeadline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwType))
            {
                body["hwType"] = request.HwType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenSelectItemList))
            {
                body["openSelectItemList"] = request.OpenSelectItemList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwMedia))
            {
                body["hwMedia"] = request.HwMedia;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwContent))
            {
                body["hwContent"] = request.HwContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwTitle))
            {
                body["hwTitle"] = request.HwTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CourseName))
            {
                body["courseName"] = request.CourseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwPhoto))
            {
                body["hwPhoto"] = request.HwPhoto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwVideo))
            {
                body["hwVideo"] = request.HwVideo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeacherName))
            {
                body["teacherName"] = request.TeacherName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeacherUserId))
            {
                body["teacherUserId"] = request.TeacherUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRole))
            {
                body["targetRole"] = request.TargetRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                body["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledRelease))
            {
                body["scheduledRelease"] = request.ScheduledRelease;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTime))
            {
                body["scheduledTime"] = request.ScheduledTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwDeadlineOpen))
            {
                body["hwDeadlineOpen"] = request.HwDeadlineOpen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwDeadline))
            {
                body["hwDeadline"] = request.HwDeadline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HwType))
            {
                body["hwType"] = request.HwType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenSelectItemList))
            {
                body["openSelectItemList"] = request.OpenSelectItemList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
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

    }
}
