// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0
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


        public AssignOrgHoldingToEmpHoldingBatchResponse AssignOrgHoldingToEmpHoldingBatchWithOptions(AssignOrgHoldingToEmpHoldingBatchRequest request, AssignOrgHoldingToEmpHoldingBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendOrgCultureInform))
            {
                body["sendOrgCultureInform"] = request.SendOrgCultureInform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SingleAmount))
            {
                body["singleAmount"] = request.SingleAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUsage))
            {
                body["sourceUsage"] = request.SourceUsage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUsage))
            {
                body["targetUsage"] = request.TargetUsage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserList))
            {
                body["targetUserList"] = request.TargetUserList;
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
                Action = "AssignOrgHoldingToEmpHoldingBatch",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/organizations/points/assign",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignOrgHoldingToEmpHoldingBatchResponse>(Execute(params_, req, runtime));
        }

        public async Task<AssignOrgHoldingToEmpHoldingBatchResponse> AssignOrgHoldingToEmpHoldingBatchWithOptionsAsync(AssignOrgHoldingToEmpHoldingBatchRequest request, AssignOrgHoldingToEmpHoldingBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendOrgCultureInform))
            {
                body["sendOrgCultureInform"] = request.SendOrgCultureInform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SingleAmount))
            {
                body["singleAmount"] = request.SingleAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUsage))
            {
                body["sourceUsage"] = request.SourceUsage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUsage))
            {
                body["targetUsage"] = request.TargetUsage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserList))
            {
                body["targetUserList"] = request.TargetUserList;
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
                Action = "AssignOrgHoldingToEmpHoldingBatch",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/organizations/points/assign",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignOrgHoldingToEmpHoldingBatchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AssignOrgHoldingToEmpHoldingBatchResponse AssignOrgHoldingToEmpHoldingBatch(AssignOrgHoldingToEmpHoldingBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AssignOrgHoldingToEmpHoldingBatchHeaders headers = new AssignOrgHoldingToEmpHoldingBatchHeaders();
            return AssignOrgHoldingToEmpHoldingBatchWithOptions(request, headers, runtime);
        }

        public async Task<AssignOrgHoldingToEmpHoldingBatchResponse> AssignOrgHoldingToEmpHoldingBatchAsync(AssignOrgHoldingToEmpHoldingBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AssignOrgHoldingToEmpHoldingBatchHeaders headers = new AssignOrgHoldingToEmpHoldingBatchHeaders();
            return await AssignOrgHoldingToEmpHoldingBatchWithOptionsAsync(request, headers, runtime);
        }

        public ConsumeUserPointsResponse ConsumeUserPointsWithOptions(string userId, ConsumeUserPointsRequest request, ConsumeUserPointsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                body["outId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Usage))
            {
                body["usage"] = request.Usage;
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
                Action = "ConsumeUserPoints",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/users/" + userId + "/points/deduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConsumeUserPointsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ConsumeUserPointsResponse> ConsumeUserPointsWithOptionsAsync(string userId, ConsumeUserPointsRequest request, ConsumeUserPointsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                body["outId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Usage))
            {
                body["usage"] = request.Usage;
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
                Action = "ConsumeUserPoints",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/users/" + userId + "/points/deduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConsumeUserPointsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ConsumeUserPointsResponse ConsumeUserPoints(string userId, ConsumeUserPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConsumeUserPointsHeaders headers = new ConsumeUserPointsHeaders();
            return ConsumeUserPointsWithOptions(userId, request, headers, runtime);
        }

        public async Task<ConsumeUserPointsResponse> ConsumeUserPointsAsync(string userId, ConsumeUserPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConsumeUserPointsHeaders headers = new ConsumeUserPointsHeaders();
            return await ConsumeUserPointsWithOptionsAsync(userId, request, headers, runtime);
        }

        public CreateOrgHonorResponse CreateOrgHonorWithOptions(CreateOrgHonorRequest request, CreateOrgHonorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarFrameMediaId))
            {
                body["avatarFrameMediaId"] = request.AvatarFrameMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultBgColor))
            {
                body["defaultBgColor"] = request.DefaultBgColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MedalDesc))
            {
                body["medalDesc"] = request.MedalDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MedalMediaId))
            {
                body["medalMediaId"] = request.MedalMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MedalName))
            {
                body["medalName"] = request.MedalName;
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
                Action = "CreateOrgHonor",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/honors/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrgHonorResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateOrgHonorResponse> CreateOrgHonorWithOptionsAsync(CreateOrgHonorRequest request, CreateOrgHonorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarFrameMediaId))
            {
                body["avatarFrameMediaId"] = request.AvatarFrameMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultBgColor))
            {
                body["defaultBgColor"] = request.DefaultBgColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MedalDesc))
            {
                body["medalDesc"] = request.MedalDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MedalMediaId))
            {
                body["medalMediaId"] = request.MedalMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MedalName))
            {
                body["medalName"] = request.MedalName;
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
                Action = "CreateOrgHonor",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/honors/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrgHonorResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateOrgHonorResponse CreateOrgHonor(CreateOrgHonorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOrgHonorHeaders headers = new CreateOrgHonorHeaders();
            return CreateOrgHonorWithOptions(request, headers, runtime);
        }

        public async Task<CreateOrgHonorResponse> CreateOrgHonorAsync(CreateOrgHonorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOrgHonorHeaders headers = new CreateOrgHonorHeaders();
            return await CreateOrgHonorWithOptionsAsync(request, headers, runtime);
        }

        public DeductionPointBatchResponse DeductionPointBatchWithOptions(DeductionPointBatchRequest request, DeductionPointBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductionAmount))
            {
                body["deductionAmount"] = request.DeductionAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendOrgCultureInform))
            {
                body["sendOrgCultureInform"] = request.SendOrgCultureInform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserList))
            {
                body["targetUserList"] = request.TargetUserList;
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
                Action = "DeductionPointBatch",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/users/points/deduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeductionPointBatchResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeductionPointBatchResponse> DeductionPointBatchWithOptionsAsync(DeductionPointBatchRequest request, DeductionPointBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductionAmount))
            {
                body["deductionAmount"] = request.DeductionAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendOrgCultureInform))
            {
                body["sendOrgCultureInform"] = request.SendOrgCultureInform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserList))
            {
                body["targetUserList"] = request.TargetUserList;
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
                Action = "DeductionPointBatch",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/users/points/deduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeductionPointBatchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeductionPointBatchResponse DeductionPointBatch(DeductionPointBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeductionPointBatchHeaders headers = new DeductionPointBatchHeaders();
            return DeductionPointBatchWithOptions(request, headers, runtime);
        }

        public async Task<DeductionPointBatchResponse> DeductionPointBatchAsync(DeductionPointBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeductionPointBatchHeaders headers = new DeductionPointBatchHeaders();
            return await DeductionPointBatchWithOptionsAsync(request, headers, runtime);
        }

        public ExportPointOpenResponse ExportPointOpenWithOptions(ExportPointOpenRequest request, ExportPointOpenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportDate))
            {
                body["exportDate"] = request.ExportDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportType))
            {
                body["exportType"] = request.ExportType;
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
                Action = "ExportPointOpen",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/users/points/export",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportPointOpenResponse>(Execute(params_, req, runtime));
        }

        public async Task<ExportPointOpenResponse> ExportPointOpenWithOptionsAsync(ExportPointOpenRequest request, ExportPointOpenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportDate))
            {
                body["exportDate"] = request.ExportDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportType))
            {
                body["exportType"] = request.ExportType;
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
                Action = "ExportPointOpen",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/users/points/export",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportPointOpenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ExportPointOpenResponse ExportPointOpen(ExportPointOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExportPointOpenHeaders headers = new ExportPointOpenHeaders();
            return ExportPointOpenWithOptions(request, headers, runtime);
        }

        public async Task<ExportPointOpenResponse> ExportPointOpenAsync(ExportPointOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExportPointOpenHeaders headers = new ExportPointOpenHeaders();
            return await ExportPointOpenWithOptionsAsync(request, headers, runtime);
        }

        public GrantHonorResponse GrantHonorWithOptions(string honorId, GrantHonorRequest request, GrantHonorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpirationTime))
            {
                body["expirationTime"] = request.ExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantReason))
            {
                body["grantReason"] = request.GrantReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GranterName))
            {
                body["granterName"] = request.GranterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeAnnouncer))
            {
                body["noticeAnnouncer"] = request.NoticeAnnouncer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeSingle))
            {
                body["noticeSingle"] = request.NoticeSingle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationIds))
            {
                body["openConversationIds"] = request.OpenConversationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIds))
            {
                body["receiverUserIds"] = request.ReceiverUserIds;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantHonor",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/honors/" + honorId + "/grant",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantHonorResponse>(Execute(params_, req, runtime));
        }

        public async Task<GrantHonorResponse> GrantHonorWithOptionsAsync(string honorId, GrantHonorRequest request, GrantHonorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpirationTime))
            {
                body["expirationTime"] = request.ExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantReason))
            {
                body["grantReason"] = request.GrantReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GranterName))
            {
                body["granterName"] = request.GranterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeAnnouncer))
            {
                body["noticeAnnouncer"] = request.NoticeAnnouncer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeSingle))
            {
                body["noticeSingle"] = request.NoticeSingle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationIds))
            {
                body["openConversationIds"] = request.OpenConversationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIds))
            {
                body["receiverUserIds"] = request.ReceiverUserIds;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantHonor",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/honors/" + honorId + "/grant",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantHonorResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GrantHonorResponse GrantHonor(string honorId, GrantHonorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantHonorHeaders headers = new GrantHonorHeaders();
            return GrantHonorWithOptions(honorId, request, headers, runtime);
        }

        public async Task<GrantHonorResponse> GrantHonorAsync(string honorId, GrantHonorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GrantHonorHeaders headers = new GrantHonorHeaders();
            return await GrantHonorWithOptionsAsync(honorId, request, headers, runtime);
        }

        public QueryCorpPointsResponse QueryCorpPointsWithOptions(QueryCorpPointsRequest request, QueryCorpPointsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                query["optUserId"] = request.OptUserId;
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
                Action = "QueryCorpPoints",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/organizations/points",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCorpPointsResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryCorpPointsResponse> QueryCorpPointsWithOptionsAsync(QueryCorpPointsRequest request, QueryCorpPointsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                query["optUserId"] = request.OptUserId;
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
                Action = "QueryCorpPoints",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/organizations/points",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCorpPointsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryCorpPointsResponse QueryCorpPoints(QueryCorpPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCorpPointsHeaders headers = new QueryCorpPointsHeaders();
            return QueryCorpPointsWithOptions(request, headers, runtime);
        }

        public async Task<QueryCorpPointsResponse> QueryCorpPointsAsync(QueryCorpPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCorpPointsHeaders headers = new QueryCorpPointsHeaders();
            return await QueryCorpPointsWithOptionsAsync(request, headers, runtime);
        }

        public QueryEmpPointDetailsResponse QueryEmpPointDetailsWithOptions(QueryEmpPointDetailsRequest request, QueryEmpPointDetailsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryEmpPointDetails",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/points/empDetails",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEmpPointDetailsResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryEmpPointDetailsResponse> QueryEmpPointDetailsWithOptionsAsync(QueryEmpPointDetailsRequest request, QueryEmpPointDetailsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryEmpPointDetails",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/points/empDetails",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEmpPointDetailsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryEmpPointDetailsResponse QueryEmpPointDetails(QueryEmpPointDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEmpPointDetailsHeaders headers = new QueryEmpPointDetailsHeaders();
            return QueryEmpPointDetailsWithOptions(request, headers, runtime);
        }

        public async Task<QueryEmpPointDetailsResponse> QueryEmpPointDetailsAsync(QueryEmpPointDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEmpPointDetailsHeaders headers = new QueryEmpPointDetailsHeaders();
            return await QueryEmpPointDetailsWithOptionsAsync(request, headers, runtime);
        }

        public QueryOrgHonorsResponse QueryOrgHonorsWithOptions(QueryOrgHonorsRequest request, QueryOrgHonorsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryOrgHonors",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/organizations/honors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrgHonorsResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryOrgHonorsResponse> QueryOrgHonorsWithOptionsAsync(QueryOrgHonorsRequest request, QueryOrgHonorsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryOrgHonors",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/organizations/honors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrgHonorsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryOrgHonorsResponse QueryOrgHonors(QueryOrgHonorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgHonorsHeaders headers = new QueryOrgHonorsHeaders();
            return QueryOrgHonorsWithOptions(request, headers, runtime);
        }

        public async Task<QueryOrgHonorsResponse> QueryOrgHonorsAsync(QueryOrgHonorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgHonorsHeaders headers = new QueryOrgHonorsHeaders();
            return await QueryOrgHonorsWithOptionsAsync(request, headers, runtime);
        }

        public QueryOrgPointDetailsResponse QueryOrgPointDetailsWithOptions(QueryOrgPointDetailsRequest request, QueryOrgPointDetailsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["accountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryOrgPointDetails",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/points/orgDetails",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrgPointDetailsResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryOrgPointDetailsResponse> QueryOrgPointDetailsWithOptionsAsync(QueryOrgPointDetailsRequest request, QueryOrgPointDetailsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["accountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryOrgPointDetails",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/points/orgDetails",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrgPointDetailsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryOrgPointDetailsResponse QueryOrgPointDetails(QueryOrgPointDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgPointDetailsHeaders headers = new QueryOrgPointDetailsHeaders();
            return QueryOrgPointDetailsWithOptions(request, headers, runtime);
        }

        public async Task<QueryOrgPointDetailsResponse> QueryOrgPointDetailsAsync(QueryOrgPointDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgPointDetailsHeaders headers = new QueryOrgPointDetailsHeaders();
            return await QueryOrgPointDetailsWithOptionsAsync(request, headers, runtime);
        }

        public QueryPointActionAutoAssignRuleResponse QueryPointActionAutoAssignRuleWithOptions(QueryPointActionAutoAssignRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryPointActionAutoAssignRule",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/users/points/actionRules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPointActionAutoAssignRuleResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryPointActionAutoAssignRuleResponse> QueryPointActionAutoAssignRuleWithOptionsAsync(QueryPointActionAutoAssignRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryPointActionAutoAssignRule",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/users/points/actionRules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPointActionAutoAssignRuleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryPointActionAutoAssignRuleResponse QueryPointActionAutoAssignRule()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPointActionAutoAssignRuleHeaders headers = new QueryPointActionAutoAssignRuleHeaders();
            return QueryPointActionAutoAssignRuleWithOptions(headers, runtime);
        }

        public async Task<QueryPointActionAutoAssignRuleResponse> QueryPointActionAutoAssignRuleAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPointActionAutoAssignRuleHeaders headers = new QueryPointActionAutoAssignRuleHeaders();
            return await QueryPointActionAutoAssignRuleWithOptionsAsync(headers, runtime);
        }

        public QueryPointAutoIssueSettingResponse QueryPointAutoIssueSettingWithOptions(QueryPointAutoIssueSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryPointAutoIssueSetting",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/users/points",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPointAutoIssueSettingResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryPointAutoIssueSettingResponse> QueryPointAutoIssueSettingWithOptionsAsync(QueryPointAutoIssueSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryPointAutoIssueSetting",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/users/points",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPointAutoIssueSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryPointAutoIssueSettingResponse QueryPointAutoIssueSetting()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPointAutoIssueSettingHeaders headers = new QueryPointAutoIssueSettingHeaders();
            return QueryPointAutoIssueSettingWithOptions(headers, runtime);
        }

        public async Task<QueryPointAutoIssueSettingResponse> QueryPointAutoIssueSettingAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPointAutoIssueSettingHeaders headers = new QueryPointAutoIssueSettingHeaders();
            return await QueryPointAutoIssueSettingWithOptionsAsync(headers, runtime);
        }

        public QueryUserHonorsResponse QueryUserHonorsWithOptions(string userId, QueryUserHonorsRequest request, QueryUserHonorsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserHonors",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/honors/users/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserHonorsResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryUserHonorsResponse> QueryUserHonorsWithOptionsAsync(string userId, QueryUserHonorsRequest request, QueryUserHonorsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserHonors",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/honors/users/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserHonorsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryUserHonorsResponse QueryUserHonors(string userId, QueryUserHonorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserHonorsHeaders headers = new QueryUserHonorsHeaders();
            return QueryUserHonorsWithOptions(userId, request, headers, runtime);
        }

        public async Task<QueryUserHonorsResponse> QueryUserHonorsAsync(string userId, QueryUserHonorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserHonorsHeaders headers = new QueryUserHonorsHeaders();
            return await QueryUserHonorsWithOptionsAsync(userId, request, headers, runtime);
        }

        public QueryUserPointsResponse QueryUserPointsWithOptions(string userId, QueryUserPointsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserPoints",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/users/" + userId + "/points",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserPointsResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryUserPointsResponse> QueryUserPointsWithOptionsAsync(string userId, QueryUserPointsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserPoints",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/users/" + userId + "/points",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserPointsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryUserPointsResponse QueryUserPoints(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserPointsHeaders headers = new QueryUserPointsHeaders();
            return QueryUserPointsWithOptions(userId, headers, runtime);
        }

        public async Task<QueryUserPointsResponse> QueryUserPointsAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserPointsHeaders headers = new QueryUserPointsHeaders();
            return await QueryUserPointsWithOptionsAsync(userId, headers, runtime);
        }

        public RecallHonorResponse RecallHonorWithOptions(string honorId, RecallHonorRequest request, RecallHonorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "RecallHonor",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/honors/" + honorId + "/recall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecallHonorResponse>(Execute(params_, req, runtime));
        }

        public async Task<RecallHonorResponse> RecallHonorWithOptionsAsync(string honorId, RecallHonorRequest request, RecallHonorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "RecallHonor",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/honors/" + honorId + "/recall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecallHonorResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public RecallHonorResponse RecallHonor(string honorId, RecallHonorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecallHonorHeaders headers = new RecallHonorHeaders();
            return RecallHonorWithOptions(honorId, request, headers, runtime);
        }

        public async Task<RecallHonorResponse> RecallHonorAsync(string honorId, RecallHonorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecallHonorHeaders headers = new RecallHonorHeaders();
            return await RecallHonorWithOptionsAsync(honorId, request, headers, runtime);
        }

        public UpdateAutoIssuePointResponse UpdateAutoIssuePointWithOptions(UpdateAutoIssuePointRequest request, UpdateAutoIssuePointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PointAutoNum))
            {
                body["pointAutoNum"] = request.PointAutoNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PointAutoState))
            {
                body["pointAutoState"] = request.PointAutoState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PointAutoTime))
            {
                body["pointAutoTime"] = request.PointAutoTime;
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
                Action = "UpdateAutoIssuePoint",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/users/points/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoIssuePointResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateAutoIssuePointResponse> UpdateAutoIssuePointWithOptionsAsync(UpdateAutoIssuePointRequest request, UpdateAutoIssuePointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PointAutoNum))
            {
                body["pointAutoNum"] = request.PointAutoNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PointAutoState))
            {
                body["pointAutoState"] = request.PointAutoState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PointAutoTime))
            {
                body["pointAutoTime"] = request.PointAutoTime;
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
                Action = "UpdateAutoIssuePoint",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/users/points/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoIssuePointResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateAutoIssuePointResponse UpdateAutoIssuePoint(UpdateAutoIssuePointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAutoIssuePointHeaders headers = new UpdateAutoIssuePointHeaders();
            return UpdateAutoIssuePointWithOptions(request, headers, runtime);
        }

        public async Task<UpdateAutoIssuePointResponse> UpdateAutoIssuePointAsync(UpdateAutoIssuePointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAutoIssuePointHeaders headers = new UpdateAutoIssuePointHeaders();
            return await UpdateAutoIssuePointWithOptionsAsync(request, headers, runtime);
        }

        public UpdatePointActionAutoAssignRuleResponse UpdatePointActionAutoAssignRuleWithOptions(UpdatePointActionAutoAssignRuleRequest request, UpdatePointActionAutoAssignRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdatePointRuleRequestDTOList))
            {
                body["updatePointRuleRequestDTOList"] = request.UpdatePointRuleRequestDTOList;
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
                Action = "UpdatePointActionAutoAssignRule",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/users/points/actionRules",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePointActionAutoAssignRuleResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdatePointActionAutoAssignRuleResponse> UpdatePointActionAutoAssignRuleWithOptionsAsync(UpdatePointActionAutoAssignRuleRequest request, UpdatePointActionAutoAssignRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdatePointRuleRequestDTOList))
            {
                body["updatePointRuleRequestDTOList"] = request.UpdatePointRuleRequestDTOList;
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
                Action = "UpdatePointActionAutoAssignRule",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/users/points/actionRules",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePointActionAutoAssignRuleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdatePointActionAutoAssignRuleResponse UpdatePointActionAutoAssignRule(UpdatePointActionAutoAssignRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePointActionAutoAssignRuleHeaders headers = new UpdatePointActionAutoAssignRuleHeaders();
            return UpdatePointActionAutoAssignRuleWithOptions(request, headers, runtime);
        }

        public async Task<UpdatePointActionAutoAssignRuleResponse> UpdatePointActionAutoAssignRuleAsync(UpdatePointActionAutoAssignRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePointActionAutoAssignRuleHeaders headers = new UpdatePointActionAutoAssignRuleHeaders();
            return await UpdatePointActionAutoAssignRuleWithOptionsAsync(request, headers, runtime);
        }

        public WearOrgHonorResponse WearOrgHonorWithOptions(string honorId, WearOrgHonorRequest request, WearOrgHonorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wear))
            {
                body["wear"] = request.Wear;
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
                Action = "WearOrgHonor",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/honors/" + honorId + "/wear",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WearOrgHonorResponse>(Execute(params_, req, runtime));
        }

        public async Task<WearOrgHonorResponse> WearOrgHonorWithOptionsAsync(string honorId, WearOrgHonorRequest request, WearOrgHonorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wear))
            {
                body["wear"] = request.Wear;
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
                Action = "WearOrgHonor",
                Version = "orgCulture_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/orgCulture/honors/" + honorId + "/wear",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WearOrgHonorResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public WearOrgHonorResponse WearOrgHonor(string honorId, WearOrgHonorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WearOrgHonorHeaders headers = new WearOrgHonorHeaders();
            return WearOrgHonorWithOptions(honorId, request, headers, runtime);
        }

        public async Task<WearOrgHonorResponse> WearOrgHonorAsync(string honorId, WearOrgHonorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WearOrgHonorHeaders headers = new WearOrgHonorHeaders();
            return await WearOrgHonorWithOptionsAsync(honorId, request, headers, runtime);
        }

    }
}
