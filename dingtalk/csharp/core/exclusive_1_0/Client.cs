// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0
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


        public AddOrgResponse AddOrg(AddOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrgHeaders headers = new AddOrgHeaders();
            return AddOrgWithOptions(request, headers, runtime);
        }

        public async Task<AddOrgResponse> AddOrgAsync(AddOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrgHeaders headers = new AddOrgHeaders();
            return await AddOrgWithOptionsAsync(request, headers, runtime);
        }

        public AddOrgResponse AddOrgWithOptions(AddOrgRequest request, AddOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNum))
            {
                body["mobileNum"] = request.MobileNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
            return TeaModel.ToObject<AddOrgResponse>(DoROARequest("AddOrg", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/orgnizations", "json", req, runtime));
        }

        public async Task<AddOrgResponse> AddOrgWithOptionsAsync(AddOrgRequest request, AddOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNum))
            {
                body["mobileNum"] = request.MobileNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
            return TeaModel.ToObject<AddOrgResponse>(await DoROARequestAsync("AddOrg", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/orgnizations", "json", req, runtime));
        }

        public BanOrOpenGroupWordsResponse BanOrOpenGroupWords(BanOrOpenGroupWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BanOrOpenGroupWordsHeaders headers = new BanOrOpenGroupWordsHeaders();
            return BanOrOpenGroupWordsWithOptions(request, headers, runtime);
        }

        public async Task<BanOrOpenGroupWordsResponse> BanOrOpenGroupWordsAsync(BanOrOpenGroupWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BanOrOpenGroupWordsHeaders headers = new BanOrOpenGroupWordsHeaders();
            return await BanOrOpenGroupWordsWithOptionsAsync(request, headers, runtime);
        }

        public BanOrOpenGroupWordsResponse BanOrOpenGroupWordsWithOptions(BanOrOpenGroupWordsRequest request, BanOrOpenGroupWordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BanWordsType))
            {
                body["banWordsType"] = request.BanWordsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConverationId))
            {
                body["openConverationId"] = request.OpenConverationId;
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
            return TeaModel.ToObject<BanOrOpenGroupWordsResponse>(DoROARequest("BanOrOpenGroupWords", "exclusive_1.0", "HTTP", "PUT", "AK", "/v1.0/exclusive/enterpriseSecurities/banOrOpenGroupWords", "json", req, runtime));
        }

        public async Task<BanOrOpenGroupWordsResponse> BanOrOpenGroupWordsWithOptionsAsync(BanOrOpenGroupWordsRequest request, BanOrOpenGroupWordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BanWordsType))
            {
                body["banWordsType"] = request.BanWordsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConverationId))
            {
                body["openConverationId"] = request.OpenConverationId;
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
            return TeaModel.ToObject<BanOrOpenGroupWordsResponse>(await DoROARequestAsync("BanOrOpenGroupWords", "exclusive_1.0", "HTTP", "PUT", "AK", "/v1.0/exclusive/enterpriseSecurities/banOrOpenGroupWords", "json", req, runtime));
        }

        public CreateTrustedDeviceResponse CreateTrustedDevice(CreateTrustedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTrustedDeviceHeaders headers = new CreateTrustedDeviceHeaders();
            return CreateTrustedDeviceWithOptions(request, headers, runtime);
        }

        public async Task<CreateTrustedDeviceResponse> CreateTrustedDeviceAsync(CreateTrustedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTrustedDeviceHeaders headers = new CreateTrustedDeviceHeaders();
            return await CreateTrustedDeviceWithOptionsAsync(request, headers, runtime);
        }

        public CreateTrustedDeviceResponse CreateTrustedDeviceWithOptions(CreateTrustedDeviceRequest request, CreateTrustedDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Did))
            {
                body["did"] = request.Did;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MacAddress))
            {
                body["macAddress"] = request.MacAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
            return TeaModel.ToObject<CreateTrustedDeviceResponse>(DoROARequest("CreateTrustedDevice", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/trustedDevices", "json", req, runtime));
        }

        public async Task<CreateTrustedDeviceResponse> CreateTrustedDeviceWithOptionsAsync(CreateTrustedDeviceRequest request, CreateTrustedDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Did))
            {
                body["did"] = request.Did;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MacAddress))
            {
                body["macAddress"] = request.MacAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
            return TeaModel.ToObject<CreateTrustedDeviceResponse>(await DoROARequestAsync("CreateTrustedDevice", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/trustedDevices", "json", req, runtime));
        }

        public CreateTrustedDeviceBatchResponse CreateTrustedDeviceBatch(CreateTrustedDeviceBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTrustedDeviceBatchHeaders headers = new CreateTrustedDeviceBatchHeaders();
            return CreateTrustedDeviceBatchWithOptions(request, headers, runtime);
        }

        public async Task<CreateTrustedDeviceBatchResponse> CreateTrustedDeviceBatchAsync(CreateTrustedDeviceBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTrustedDeviceBatchHeaders headers = new CreateTrustedDeviceBatchHeaders();
            return await CreateTrustedDeviceBatchWithOptionsAsync(request, headers, runtime);
        }

        public CreateTrustedDeviceBatchResponse CreateTrustedDeviceBatchWithOptions(CreateTrustedDeviceBatchRequest request, CreateTrustedDeviceBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MacAddressList))
            {
                body["macAddressList"] = request.MacAddressList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
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
            return TeaModel.ToObject<CreateTrustedDeviceBatchResponse>(DoROARequest("CreateTrustedDeviceBatch", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/trusts/devices", "json", req, runtime));
        }

        public async Task<CreateTrustedDeviceBatchResponse> CreateTrustedDeviceBatchWithOptionsAsync(CreateTrustedDeviceBatchRequest request, CreateTrustedDeviceBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MacAddressList))
            {
                body["macAddressList"] = request.MacAddressList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
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
            return TeaModel.ToObject<CreateTrustedDeviceBatchResponse>(await DoROARequestAsync("CreateTrustedDeviceBatch", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/trusts/devices", "json", req, runtime));
        }

        public DeleteAcrossCloudStroageConfigsResponse DeleteAcrossCloudStroageConfigs(string targetCorpId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAcrossCloudStroageConfigsHeaders headers = new DeleteAcrossCloudStroageConfigsHeaders();
            return DeleteAcrossCloudStroageConfigsWithOptions(targetCorpId, headers, runtime);
        }

        public async Task<DeleteAcrossCloudStroageConfigsResponse> DeleteAcrossCloudStroageConfigsAsync(string targetCorpId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAcrossCloudStroageConfigsHeaders headers = new DeleteAcrossCloudStroageConfigsHeaders();
            return await DeleteAcrossCloudStroageConfigsWithOptionsAsync(targetCorpId, headers, runtime);
        }

        public DeleteAcrossCloudStroageConfigsResponse DeleteAcrossCloudStroageConfigsWithOptions(string targetCorpId, DeleteAcrossCloudStroageConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            targetCorpId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(targetCorpId);
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
            return TeaModel.ToObject<DeleteAcrossCloudStroageConfigsResponse>(DoROARequest("DeleteAcrossCloudStroageConfigs", "exclusive_1.0", "HTTP", "DELETE", "AK", "/v1.0/exclusive/fileStorages/acrossClouds/configurations/" + targetCorpId, "json", req, runtime));
        }

        public async Task<DeleteAcrossCloudStroageConfigsResponse> DeleteAcrossCloudStroageConfigsWithOptionsAsync(string targetCorpId, DeleteAcrossCloudStroageConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            targetCorpId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(targetCorpId);
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
            return TeaModel.ToObject<DeleteAcrossCloudStroageConfigsResponse>(await DoROARequestAsync("DeleteAcrossCloudStroageConfigs", "exclusive_1.0", "HTTP", "DELETE", "AK", "/v1.0/exclusive/fileStorages/acrossClouds/configurations/" + targetCorpId, "json", req, runtime));
        }

        public DeleteCommentResponse DeleteComment(string publisherId, string commentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCommentHeaders headers = new DeleteCommentHeaders();
            return DeleteCommentWithOptions(publisherId, commentId, headers, runtime);
        }

        public async Task<DeleteCommentResponse> DeleteCommentAsync(string publisherId, string commentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCommentHeaders headers = new DeleteCommentHeaders();
            return await DeleteCommentWithOptionsAsync(publisherId, commentId, headers, runtime);
        }

        public DeleteCommentResponse DeleteCommentWithOptions(string publisherId, string commentId, DeleteCommentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            publisherId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(publisherId);
            commentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(commentId);
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
            return TeaModel.ToObject<DeleteCommentResponse>(DoROARequest("DeleteComment", "exclusive_1.0", "HTTP", "DELETE", "AK", "/v1.0/exclusive/publishers/" + publisherId + "/comments/" + commentId, "boolean", req, runtime));
        }

        public async Task<DeleteCommentResponse> DeleteCommentWithOptionsAsync(string publisherId, string commentId, DeleteCommentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            publisherId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(publisherId);
            commentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(commentId);
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
            return TeaModel.ToObject<DeleteCommentResponse>(await DoROARequestAsync("DeleteComment", "exclusive_1.0", "HTTP", "DELETE", "AK", "/v1.0/exclusive/publishers/" + publisherId + "/comments/" + commentId, "boolean", req, runtime));
        }

        public DistributePartnerAppResponse DistributePartnerApp(DistributePartnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DistributePartnerAppHeaders headers = new DistributePartnerAppHeaders();
            return DistributePartnerAppWithOptions(request, headers, runtime);
        }

        public async Task<DistributePartnerAppResponse> DistributePartnerAppAsync(DistributePartnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DistributePartnerAppHeaders headers = new DistributePartnerAppHeaders();
            return await DistributePartnerAppWithOptionsAsync(request, headers, runtime);
        }

        public DistributePartnerAppResponse DistributePartnerAppWithOptions(DistributePartnerAppRequest request, DistributePartnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                body["subCorpId"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
            return TeaModel.ToObject<DistributePartnerAppResponse>(DoROARequest("DistributePartnerApp", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/partners/applications/distribute", "json", req, runtime));
        }

        public async Task<DistributePartnerAppResponse> DistributePartnerAppWithOptionsAsync(DistributePartnerAppRequest request, DistributePartnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                body["subCorpId"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
            return TeaModel.ToObject<DistributePartnerAppResponse>(await DoROARequestAsync("DistributePartnerApp", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/partners/applications/distribute", "json", req, runtime));
        }

        public ExclusiveCreateDingPortalResponse ExclusiveCreateDingPortal(ExclusiveCreateDingPortalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExclusiveCreateDingPortalHeaders headers = new ExclusiveCreateDingPortalHeaders();
            return ExclusiveCreateDingPortalWithOptions(request, headers, runtime);
        }

        public async Task<ExclusiveCreateDingPortalResponse> ExclusiveCreateDingPortalAsync(ExclusiveCreateDingPortalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExclusiveCreateDingPortalHeaders headers = new ExclusiveCreateDingPortalHeaders();
            return await ExclusiveCreateDingPortalWithOptionsAsync(request, headers, runtime);
        }

        public ExclusiveCreateDingPortalResponse ExclusiveCreateDingPortalWithOptions(ExclusiveCreateDingPortalRequest request, ExclusiveCreateDingPortalHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingPortalName))
            {
                body["dingPortalName"] = request.DingPortalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateAppUuid))
            {
                body["templateAppUuid"] = request.TemplateAppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCorpId))
            {
                body["templateCorpId"] = request.TemplateCorpId;
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
            return TeaModel.ToObject<ExclusiveCreateDingPortalResponse>(DoROARequest("ExclusiveCreateDingPortal", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/workbenches/templates/spread", "json", req, runtime));
        }

        public async Task<ExclusiveCreateDingPortalResponse> ExclusiveCreateDingPortalWithOptionsAsync(ExclusiveCreateDingPortalRequest request, ExclusiveCreateDingPortalHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingPortalName))
            {
                body["dingPortalName"] = request.DingPortalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateAppUuid))
            {
                body["templateAppUuid"] = request.TemplateAppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCorpId))
            {
                body["templateCorpId"] = request.TemplateCorpId;
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
            return TeaModel.ToObject<ExclusiveCreateDingPortalResponse>(await DoROARequestAsync("ExclusiveCreateDingPortal", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/workbenches/templates/spread", "json", req, runtime));
        }

        public FileStorageActiveStorageResponse FileStorageActiveStorage(FileStorageActiveStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageActiveStorageHeaders headers = new FileStorageActiveStorageHeaders();
            return FileStorageActiveStorageWithOptions(request, headers, runtime);
        }

        public async Task<FileStorageActiveStorageResponse> FileStorageActiveStorageAsync(FileStorageActiveStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageActiveStorageHeaders headers = new FileStorageActiveStorageHeaders();
            return await FileStorageActiveStorageWithOptionsAsync(request, headers, runtime);
        }

        public FileStorageActiveStorageResponse FileStorageActiveStorageWithOptions(FileStorageActiveStorageRequest request, FileStorageActiveStorageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Oss))
            {
                body["oss"] = request.Oss;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
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
            return TeaModel.ToObject<FileStorageActiveStorageResponse>(DoROARequest("FileStorageActiveStorage", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/fileStorages/active", "json", req, runtime));
        }

        public async Task<FileStorageActiveStorageResponse> FileStorageActiveStorageWithOptionsAsync(FileStorageActiveStorageRequest request, FileStorageActiveStorageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Oss))
            {
                body["oss"] = request.Oss;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
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
            return TeaModel.ToObject<FileStorageActiveStorageResponse>(await DoROARequestAsync("FileStorageActiveStorage", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/fileStorages/active", "json", req, runtime));
        }

        public FileStorageCheckConnectionResponse FileStorageCheckConnection(FileStorageCheckConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageCheckConnectionHeaders headers = new FileStorageCheckConnectionHeaders();
            return FileStorageCheckConnectionWithOptions(request, headers, runtime);
        }

        public async Task<FileStorageCheckConnectionResponse> FileStorageCheckConnectionAsync(FileStorageCheckConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageCheckConnectionHeaders headers = new FileStorageCheckConnectionHeaders();
            return await FileStorageCheckConnectionWithOptionsAsync(request, headers, runtime);
        }

        public FileStorageCheckConnectionResponse FileStorageCheckConnectionWithOptions(FileStorageCheckConnectionRequest request, FileStorageCheckConnectionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Oss))
            {
                body["oss"] = request.Oss;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
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
            return TeaModel.ToObject<FileStorageCheckConnectionResponse>(DoROARequest("FileStorageCheckConnection", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/fileStorages/connections/check", "json", req, runtime));
        }

        public async Task<FileStorageCheckConnectionResponse> FileStorageCheckConnectionWithOptionsAsync(FileStorageCheckConnectionRequest request, FileStorageCheckConnectionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Oss))
            {
                body["oss"] = request.Oss;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
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
            return TeaModel.ToObject<FileStorageCheckConnectionResponse>(await DoROARequestAsync("FileStorageCheckConnection", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/fileStorages/connections/check", "json", req, runtime));
        }

        public FileStorageGetQuotaDataResponse FileStorageGetQuotaData(FileStorageGetQuotaDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageGetQuotaDataHeaders headers = new FileStorageGetQuotaDataHeaders();
            return FileStorageGetQuotaDataWithOptions(request, headers, runtime);
        }

        public async Task<FileStorageGetQuotaDataResponse> FileStorageGetQuotaDataAsync(FileStorageGetQuotaDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageGetQuotaDataHeaders headers = new FileStorageGetQuotaDataHeaders();
            return await FileStorageGetQuotaDataWithOptionsAsync(request, headers, runtime);
        }

        public FileStorageGetQuotaDataResponse FileStorageGetQuotaDataWithOptions(FileStorageGetQuotaDataRequest request, FileStorageGetQuotaDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                query["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
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
            return TeaModel.ToObject<FileStorageGetQuotaDataResponse>(DoROARequest("FileStorageGetQuotaData", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/fileStorages/quotaDatas", "json", req, runtime));
        }

        public async Task<FileStorageGetQuotaDataResponse> FileStorageGetQuotaDataWithOptionsAsync(FileStorageGetQuotaDataRequest request, FileStorageGetQuotaDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                query["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
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
            return TeaModel.ToObject<FileStorageGetQuotaDataResponse>(await DoROARequestAsync("FileStorageGetQuotaData", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/fileStorages/quotaDatas", "json", req, runtime));
        }

        public FileStorageGetStorageStateResponse FileStorageGetStorageState(FileStorageGetStorageStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageGetStorageStateHeaders headers = new FileStorageGetStorageStateHeaders();
            return FileStorageGetStorageStateWithOptions(request, headers, runtime);
        }

        public async Task<FileStorageGetStorageStateResponse> FileStorageGetStorageStateAsync(FileStorageGetStorageStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageGetStorageStateHeaders headers = new FileStorageGetStorageStateHeaders();
            return await FileStorageGetStorageStateWithOptionsAsync(request, headers, runtime);
        }

        public FileStorageGetStorageStateResponse FileStorageGetStorageStateWithOptions(FileStorageGetStorageStateRequest request, FileStorageGetStorageStateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<FileStorageGetStorageStateResponse>(DoROARequest("FileStorageGetStorageState", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/fileStorages/states", "json", req, runtime));
        }

        public async Task<FileStorageGetStorageStateResponse> FileStorageGetStorageStateWithOptionsAsync(FileStorageGetStorageStateRequest request, FileStorageGetStorageStateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<FileStorageGetStorageStateResponse>(await DoROARequestAsync("FileStorageGetStorageState", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/fileStorages/states", "json", req, runtime));
        }

        public FileStorageUpdateStorageResponse FileStorageUpdateStorage(FileStorageUpdateStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageUpdateStorageHeaders headers = new FileStorageUpdateStorageHeaders();
            return FileStorageUpdateStorageWithOptions(request, headers, runtime);
        }

        public async Task<FileStorageUpdateStorageResponse> FileStorageUpdateStorageAsync(FileStorageUpdateStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageUpdateStorageHeaders headers = new FileStorageUpdateStorageHeaders();
            return await FileStorageUpdateStorageWithOptionsAsync(request, headers, runtime);
        }

        public FileStorageUpdateStorageResponse FileStorageUpdateStorageWithOptions(FileStorageUpdateStorageRequest request, FileStorageUpdateStorageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
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
            return TeaModel.ToObject<FileStorageUpdateStorageResponse>(DoROARequest("FileStorageUpdateStorage", "exclusive_1.0", "HTTP", "PUT", "AK", "/v1.0/exclusive/fileStorages/configurations", "json", req, runtime));
        }

        public async Task<FileStorageUpdateStorageResponse> FileStorageUpdateStorageWithOptionsAsync(FileStorageUpdateStorageRequest request, FileStorageUpdateStorageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
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
            return TeaModel.ToObject<FileStorageUpdateStorageResponse>(await DoROARequestAsync("FileStorageUpdateStorage", "exclusive_1.0", "HTTP", "PUT", "AK", "/v1.0/exclusive/fileStorages/configurations", "json", req, runtime));
        }

        public GenerateDarkWaterMarkResponse GenerateDarkWaterMark(GenerateDarkWaterMarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateDarkWaterMarkHeaders headers = new GenerateDarkWaterMarkHeaders();
            return GenerateDarkWaterMarkWithOptions(request, headers, runtime);
        }

        public async Task<GenerateDarkWaterMarkResponse> GenerateDarkWaterMarkAsync(GenerateDarkWaterMarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateDarkWaterMarkHeaders headers = new GenerateDarkWaterMarkHeaders();
            return await GenerateDarkWaterMarkWithOptionsAsync(request, headers, runtime);
        }

        public GenerateDarkWaterMarkResponse GenerateDarkWaterMarkWithOptions(GenerateDarkWaterMarkRequest request, GenerateDarkWaterMarkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
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
            return TeaModel.ToObject<GenerateDarkWaterMarkResponse>(DoROARequest("GenerateDarkWaterMark", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/enterpriseSecurities/darkWatermarks/generate", "json", req, runtime));
        }

        public async Task<GenerateDarkWaterMarkResponse> GenerateDarkWaterMarkWithOptionsAsync(GenerateDarkWaterMarkRequest request, GenerateDarkWaterMarkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
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
            return TeaModel.ToObject<GenerateDarkWaterMarkResponse>(await DoROARequestAsync("GenerateDarkWaterMark", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/enterpriseSecurities/darkWatermarks/generate", "json", req, runtime));
        }

        public GetActiveUserSummaryResponse GetActiveUserSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActiveUserSummaryHeaders headers = new GetActiveUserSummaryHeaders();
            return GetActiveUserSummaryWithOptions(dataId, headers, runtime);
        }

        public async Task<GetActiveUserSummaryResponse> GetActiveUserSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActiveUserSummaryHeaders headers = new GetActiveUserSummaryHeaders();
            return await GetActiveUserSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        public GetActiveUserSummaryResponse GetActiveUserSummaryWithOptions(string dataId, GetActiveUserSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetActiveUserSummaryResponse>(DoROARequest("GetActiveUserSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/dau/org/" + dataId, "json", req, runtime));
        }

        public async Task<GetActiveUserSummaryResponse> GetActiveUserSummaryWithOptionsAsync(string dataId, GetActiveUserSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetActiveUserSummaryResponse>(await DoROARequestAsync("GetActiveUserSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/dau/org/" + dataId, "json", req, runtime));
        }

        public GetAgentIdByRelatedAppIdResponse GetAgentIdByRelatedAppId(GetAgentIdByRelatedAppIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAgentIdByRelatedAppIdHeaders headers = new GetAgentIdByRelatedAppIdHeaders();
            return GetAgentIdByRelatedAppIdWithOptions(request, headers, runtime);
        }

        public async Task<GetAgentIdByRelatedAppIdResponse> GetAgentIdByRelatedAppIdAsync(GetAgentIdByRelatedAppIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAgentIdByRelatedAppIdHeaders headers = new GetAgentIdByRelatedAppIdHeaders();
            return await GetAgentIdByRelatedAppIdWithOptionsAsync(request, headers, runtime);
        }

        public GetAgentIdByRelatedAppIdResponse GetAgentIdByRelatedAppIdWithOptions(GetAgentIdByRelatedAppIdRequest request, GetAgentIdByRelatedAppIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetAgentIdByRelatedAppIdResponse>(DoROARequest("GetAgentIdByRelatedAppId", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/exclusiveDesigns/agentId", "json", req, runtime));
        }

        public async Task<GetAgentIdByRelatedAppIdResponse> GetAgentIdByRelatedAppIdWithOptionsAsync(GetAgentIdByRelatedAppIdRequest request, GetAgentIdByRelatedAppIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetAgentIdByRelatedAppIdResponse>(await DoROARequestAsync("GetAgentIdByRelatedAppId", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/exclusiveDesigns/agentId", "json", req, runtime));
        }

        public GetAllLabelableDeptsResponse GetAllLabelableDepts()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllLabelableDeptsHeaders headers = new GetAllLabelableDeptsHeaders();
            return GetAllLabelableDeptsWithOptions(headers, runtime);
        }

        public async Task<GetAllLabelableDeptsResponse> GetAllLabelableDeptsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllLabelableDeptsHeaders headers = new GetAllLabelableDeptsHeaders();
            return await GetAllLabelableDeptsWithOptionsAsync(headers, runtime);
        }

        public GetAllLabelableDeptsResponse GetAllLabelableDeptsWithOptions(GetAllLabelableDeptsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetAllLabelableDeptsResponse>(DoROARequest("GetAllLabelableDepts", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/partnerDepartments", "json", req, runtime));
        }

        public async Task<GetAllLabelableDeptsResponse> GetAllLabelableDeptsWithOptionsAsync(GetAllLabelableDeptsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetAllLabelableDeptsResponse>(await DoROARequestAsync("GetAllLabelableDepts", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/partnerDepartments", "json", req, runtime));
        }

        public GetAppDispatchInfoResponse GetAppDispatchInfo(GetAppDispatchInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppDispatchInfoHeaders headers = new GetAppDispatchInfoHeaders();
            return GetAppDispatchInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetAppDispatchInfoResponse> GetAppDispatchInfoAsync(GetAppDispatchInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppDispatchInfoHeaders headers = new GetAppDispatchInfoHeaders();
            return await GetAppDispatchInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetAppDispatchInfoResponse GetAppDispatchInfoWithOptions(GetAppDispatchInfoRequest request, GetAppDispatchInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetAppDispatchInfoResponse>(DoROARequest("GetAppDispatchInfo", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/apps/distributionInfos", "json", req, runtime));
        }

        public async Task<GetAppDispatchInfoResponse> GetAppDispatchInfoWithOptionsAsync(GetAppDispatchInfoRequest request, GetAppDispatchInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetAppDispatchInfoResponse>(await DoROARequestAsync("GetAppDispatchInfo", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/apps/distributionInfos", "json", req, runtime));
        }

        public GetCalenderSummaryResponse GetCalenderSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCalenderSummaryHeaders headers = new GetCalenderSummaryHeaders();
            return GetCalenderSummaryWithOptions(dataId, headers, runtime);
        }

        public async Task<GetCalenderSummaryResponse> GetCalenderSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCalenderSummaryHeaders headers = new GetCalenderSummaryHeaders();
            return await GetCalenderSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        public GetCalenderSummaryResponse GetCalenderSummaryWithOptions(string dataId, GetCalenderSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetCalenderSummaryResponse>(DoROARequest("GetCalenderSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/calendar/org/" + dataId, "json", req, runtime));
        }

        public async Task<GetCalenderSummaryResponse> GetCalenderSummaryWithOptionsAsync(string dataId, GetCalenderSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetCalenderSummaryResponse>(await DoROARequestAsync("GetCalenderSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/calendar/org/" + dataId, "json", req, runtime));
        }

        public GetCommentListResponse GetCommentList(string publisherId, GetCommentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCommentListHeaders headers = new GetCommentListHeaders();
            return GetCommentListWithOptions(publisherId, request, headers, runtime);
        }

        public async Task<GetCommentListResponse> GetCommentListAsync(string publisherId, GetCommentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCommentListHeaders headers = new GetCommentListHeaders();
            return await GetCommentListWithOptionsAsync(publisherId, request, headers, runtime);
        }

        public GetCommentListResponse GetCommentListWithOptions(string publisherId, GetCommentListRequest request, GetCommentListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            publisherId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(publisherId);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetCommentListResponse>(DoROARequest("GetCommentList", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/publishers/" + publisherId + "/comments/list", "json", req, runtime));
        }

        public async Task<GetCommentListResponse> GetCommentListWithOptionsAsync(string publisherId, GetCommentListRequest request, GetCommentListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            publisherId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(publisherId);
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetCommentListResponse>(await DoROARequestAsync("GetCommentList", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/publishers/" + publisherId + "/comments/list", "json", req, runtime));
        }

        public GetConfBaseInfoByLogicalIdResponse GetConfBaseInfoByLogicalId(GetConfBaseInfoByLogicalIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConfBaseInfoByLogicalIdHeaders headers = new GetConfBaseInfoByLogicalIdHeaders();
            return GetConfBaseInfoByLogicalIdWithOptions(request, headers, runtime);
        }

        public async Task<GetConfBaseInfoByLogicalIdResponse> GetConfBaseInfoByLogicalIdAsync(GetConfBaseInfoByLogicalIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConfBaseInfoByLogicalIdHeaders headers = new GetConfBaseInfoByLogicalIdHeaders();
            return await GetConfBaseInfoByLogicalIdWithOptionsAsync(request, headers, runtime);
        }

        public GetConfBaseInfoByLogicalIdResponse GetConfBaseInfoByLogicalIdWithOptions(GetConfBaseInfoByLogicalIdRequest request, GetConfBaseInfoByLogicalIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalConferenceId))
            {
                query["logicalConferenceId"] = request.LogicalConferenceId;
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
            return TeaModel.ToObject<GetConfBaseInfoByLogicalIdResponse>(DoROARequest("GetConfBaseInfoByLogicalId", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/conferences", "json", req, runtime));
        }

        public async Task<GetConfBaseInfoByLogicalIdResponse> GetConfBaseInfoByLogicalIdWithOptionsAsync(GetConfBaseInfoByLogicalIdRequest request, GetConfBaseInfoByLogicalIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalConferenceId))
            {
                query["logicalConferenceId"] = request.LogicalConferenceId;
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
            return TeaModel.ToObject<GetConfBaseInfoByLogicalIdResponse>(await DoROARequestAsync("GetConfBaseInfoByLogicalId", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/conferences", "json", req, runtime));
        }

        public GetConferenceDetailResponse GetConferenceDetail(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConferenceDetailHeaders headers = new GetConferenceDetailHeaders();
            return GetConferenceDetailWithOptions(conferenceId, headers, runtime);
        }

        public async Task<GetConferenceDetailResponse> GetConferenceDetailAsync(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConferenceDetailHeaders headers = new GetConferenceDetailHeaders();
            return await GetConferenceDetailWithOptionsAsync(conferenceId, headers, runtime);
        }

        public GetConferenceDetailResponse GetConferenceDetailWithOptions(string conferenceId, GetConferenceDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
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
            return TeaModel.ToObject<GetConferenceDetailResponse>(DoROARequest("GetConferenceDetail", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/conferences/" + conferenceId, "json", req, runtime));
        }

        public async Task<GetConferenceDetailResponse> GetConferenceDetailWithOptionsAsync(string conferenceId, GetConferenceDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            conferenceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(conferenceId);
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
            return TeaModel.ToObject<GetConferenceDetailResponse>(await DoROARequestAsync("GetConferenceDetail", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/conferences/" + conferenceId, "json", req, runtime));
        }

        public GetDingReportDeptSummaryResponse GetDingReportDeptSummary(string dataId, GetDingReportDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingReportDeptSummaryHeaders headers = new GetDingReportDeptSummaryHeaders();
            return GetDingReportDeptSummaryWithOptions(dataId, request, headers, runtime);
        }

        public async Task<GetDingReportDeptSummaryResponse> GetDingReportDeptSummaryAsync(string dataId, GetDingReportDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingReportDeptSummaryHeaders headers = new GetDingReportDeptSummaryHeaders();
            return await GetDingReportDeptSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        public GetDingReportDeptSummaryResponse GetDingReportDeptSummaryWithOptions(string dataId, GetDingReportDeptSummaryRequest request, GetDingReportDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetDingReportDeptSummaryResponse>(DoROARequest("GetDingReportDeptSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/report/dept/" + dataId, "json", req, runtime));
        }

        public async Task<GetDingReportDeptSummaryResponse> GetDingReportDeptSummaryWithOptionsAsync(string dataId, GetDingReportDeptSummaryRequest request, GetDingReportDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetDingReportDeptSummaryResponse>(await DoROARequestAsync("GetDingReportDeptSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/report/dept/" + dataId, "json", req, runtime));
        }

        public GetDingReportSummaryResponse GetDingReportSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingReportSummaryHeaders headers = new GetDingReportSummaryHeaders();
            return GetDingReportSummaryWithOptions(dataId, headers, runtime);
        }

        public async Task<GetDingReportSummaryResponse> GetDingReportSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingReportSummaryHeaders headers = new GetDingReportSummaryHeaders();
            return await GetDingReportSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        public GetDingReportSummaryResponse GetDingReportSummaryWithOptions(string dataId, GetDingReportSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetDingReportSummaryResponse>(DoROARequest("GetDingReportSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/datas/" + dataId + "/reports/organizations", "json", req, runtime));
        }

        public async Task<GetDingReportSummaryResponse> GetDingReportSummaryWithOptionsAsync(string dataId, GetDingReportSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetDingReportSummaryResponse>(await DoROARequestAsync("GetDingReportSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/datas/" + dataId + "/reports/organizations", "json", req, runtime));
        }

        public GetDocCreatedDeptSummaryResponse GetDocCreatedDeptSummary(string dataId, GetDocCreatedDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocCreatedDeptSummaryHeaders headers = new GetDocCreatedDeptSummaryHeaders();
            return GetDocCreatedDeptSummaryWithOptions(dataId, request, headers, runtime);
        }

        public async Task<GetDocCreatedDeptSummaryResponse> GetDocCreatedDeptSummaryAsync(string dataId, GetDocCreatedDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocCreatedDeptSummaryHeaders headers = new GetDocCreatedDeptSummaryHeaders();
            return await GetDocCreatedDeptSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        public GetDocCreatedDeptSummaryResponse GetDocCreatedDeptSummaryWithOptions(string dataId, GetDocCreatedDeptSummaryRequest request, GetDocCreatedDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetDocCreatedDeptSummaryResponse>(DoROARequest("GetDocCreatedDeptSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/doc/dept/" + dataId, "json", req, runtime));
        }

        public async Task<GetDocCreatedDeptSummaryResponse> GetDocCreatedDeptSummaryWithOptionsAsync(string dataId, GetDocCreatedDeptSummaryRequest request, GetDocCreatedDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetDocCreatedDeptSummaryResponse>(await DoROARequestAsync("GetDocCreatedDeptSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/doc/dept/" + dataId, "json", req, runtime));
        }

        public GetDocCreatedSummaryResponse GetDocCreatedSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocCreatedSummaryHeaders headers = new GetDocCreatedSummaryHeaders();
            return GetDocCreatedSummaryWithOptions(dataId, headers, runtime);
        }

        public async Task<GetDocCreatedSummaryResponse> GetDocCreatedSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocCreatedSummaryHeaders headers = new GetDocCreatedSummaryHeaders();
            return await GetDocCreatedSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        public GetDocCreatedSummaryResponse GetDocCreatedSummaryWithOptions(string dataId, GetDocCreatedSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetDocCreatedSummaryResponse>(DoROARequest("GetDocCreatedSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/doc/org/" + dataId, "json", req, runtime));
        }

        public async Task<GetDocCreatedSummaryResponse> GetDocCreatedSummaryWithOptionsAsync(string dataId, GetDocCreatedSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetDocCreatedSummaryResponse>(await DoROARequestAsync("GetDocCreatedSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/doc/org/" + dataId, "json", req, runtime));
        }

        public GetGeneralFormCreatedDeptSummaryResponse GetGeneralFormCreatedDeptSummary(string dataId, GetGeneralFormCreatedDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGeneralFormCreatedDeptSummaryHeaders headers = new GetGeneralFormCreatedDeptSummaryHeaders();
            return GetGeneralFormCreatedDeptSummaryWithOptions(dataId, request, headers, runtime);
        }

        public async Task<GetGeneralFormCreatedDeptSummaryResponse> GetGeneralFormCreatedDeptSummaryAsync(string dataId, GetGeneralFormCreatedDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGeneralFormCreatedDeptSummaryHeaders headers = new GetGeneralFormCreatedDeptSummaryHeaders();
            return await GetGeneralFormCreatedDeptSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        public GetGeneralFormCreatedDeptSummaryResponse GetGeneralFormCreatedDeptSummaryWithOptions(string dataId, GetGeneralFormCreatedDeptSummaryRequest request, GetGeneralFormCreatedDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetGeneralFormCreatedDeptSummaryResponse>(DoROARequest("GetGeneralFormCreatedDeptSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/generalForm/dept/" + dataId, "json", req, runtime));
        }

        public async Task<GetGeneralFormCreatedDeptSummaryResponse> GetGeneralFormCreatedDeptSummaryWithOptionsAsync(string dataId, GetGeneralFormCreatedDeptSummaryRequest request, GetGeneralFormCreatedDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetGeneralFormCreatedDeptSummaryResponse>(await DoROARequestAsync("GetGeneralFormCreatedDeptSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/generalForm/dept/" + dataId, "json", req, runtime));
        }

        public GetGeneralFormCreatedSummaryResponse GetGeneralFormCreatedSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGeneralFormCreatedSummaryHeaders headers = new GetGeneralFormCreatedSummaryHeaders();
            return GetGeneralFormCreatedSummaryWithOptions(dataId, headers, runtime);
        }

        public async Task<GetGeneralFormCreatedSummaryResponse> GetGeneralFormCreatedSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGeneralFormCreatedSummaryHeaders headers = new GetGeneralFormCreatedSummaryHeaders();
            return await GetGeneralFormCreatedSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        public GetGeneralFormCreatedSummaryResponse GetGeneralFormCreatedSummaryWithOptions(string dataId, GetGeneralFormCreatedSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetGeneralFormCreatedSummaryResponse>(DoROARequest("GetGeneralFormCreatedSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/generalForm/org/" + dataId, "json", req, runtime));
        }

        public async Task<GetGeneralFormCreatedSummaryResponse> GetGeneralFormCreatedSummaryWithOptionsAsync(string dataId, GetGeneralFormCreatedSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetGeneralFormCreatedSummaryResponse>(await DoROARequestAsync("GetGeneralFormCreatedSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/generalForm/org/" + dataId, "json", req, runtime));
        }

        public GetGroupActiveInfoResponse GetGroupActiveInfo(GetGroupActiveInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGroupActiveInfoHeaders headers = new GetGroupActiveInfoHeaders();
            return GetGroupActiveInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetGroupActiveInfoResponse> GetGroupActiveInfoAsync(GetGroupActiveInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGroupActiveInfoHeaders headers = new GetGroupActiveInfoHeaders();
            return await GetGroupActiveInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetGroupActiveInfoResponse GetGroupActiveInfoWithOptions(GetGroupActiveInfoRequest request, GetGroupActiveInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingGroupId))
            {
                query["dingGroupId"] = request.DingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
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
            return TeaModel.ToObject<GetGroupActiveInfoResponse>(DoROARequest("GetGroupActiveInfo", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/activeGroups", "json", req, runtime));
        }

        public async Task<GetGroupActiveInfoResponse> GetGroupActiveInfoWithOptionsAsync(GetGroupActiveInfoRequest request, GetGroupActiveInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingGroupId))
            {
                query["dingGroupId"] = request.DingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
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
            return TeaModel.ToObject<GetGroupActiveInfoResponse>(await DoROARequestAsync("GetGroupActiveInfo", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/activeGroups", "json", req, runtime));
        }

        public GetInActiveUserListResponse GetInActiveUserList(GetInActiveUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInActiveUserListHeaders headers = new GetInActiveUserListHeaders();
            return GetInActiveUserListWithOptions(request, headers, runtime);
        }

        public async Task<GetInActiveUserListResponse> GetInActiveUserListAsync(GetInActiveUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInActiveUserListHeaders headers = new GetInActiveUserListHeaders();
            return await GetInActiveUserListWithOptionsAsync(request, headers, runtime);
        }

        public GetInActiveUserListResponse GetInActiveUserListWithOptions(GetInActiveUserListRequest request, GetInActiveUserListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                body["statDate"] = request.StatDate;
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
            return TeaModel.ToObject<GetInActiveUserListResponse>(DoROARequest("GetInActiveUserList", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/inactives/users/query", "json", req, runtime));
        }

        public async Task<GetInActiveUserListResponse> GetInActiveUserListWithOptionsAsync(GetInActiveUserListRequest request, GetInActiveUserListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                body["statDate"] = request.StatDate;
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
            return TeaModel.ToObject<GetInActiveUserListResponse>(await DoROARequestAsync("GetInActiveUserList", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/inactives/users/query", "json", req, runtime));
        }

        public GetLastOrgAuthDataResponse GetLastOrgAuthData(GetLastOrgAuthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLastOrgAuthDataHeaders headers = new GetLastOrgAuthDataHeaders();
            return GetLastOrgAuthDataWithOptions(request, headers, runtime);
        }

        public async Task<GetLastOrgAuthDataResponse> GetLastOrgAuthDataAsync(GetLastOrgAuthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLastOrgAuthDataHeaders headers = new GetLastOrgAuthDataHeaders();
            return await GetLastOrgAuthDataWithOptionsAsync(request, headers, runtime);
        }

        public GetLastOrgAuthDataResponse GetLastOrgAuthDataWithOptions(GetLastOrgAuthDataRequest request, GetLastOrgAuthDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetLastOrgAuthDataResponse>(DoROARequest("GetLastOrgAuthData", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/organizations/authInfos", "json", req, runtime));
        }

        public async Task<GetLastOrgAuthDataResponse> GetLastOrgAuthDataWithOptionsAsync(GetLastOrgAuthDataRequest request, GetLastOrgAuthDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetLastOrgAuthDataResponse>(await DoROARequestAsync("GetLastOrgAuthData", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/organizations/authInfos", "json", req, runtime));
        }

        public GetOaOperatorLogListResponse GetOaOperatorLogList(GetOaOperatorLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOaOperatorLogListHeaders headers = new GetOaOperatorLogListHeaders();
            return GetOaOperatorLogListWithOptions(request, headers, runtime);
        }

        public async Task<GetOaOperatorLogListResponse> GetOaOperatorLogListAsync(GetOaOperatorLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOaOperatorLogListHeaders headers = new GetOaOperatorLogListHeaders();
            return await GetOaOperatorLogListWithOptionsAsync(request, headers, runtime);
        }

        public GetOaOperatorLogListResponse GetOaOperatorLogListWithOptions(GetOaOperatorLogListRequest request, GetOaOperatorLogListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryList))
            {
                body["categoryList"] = request.CategoryList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
            return TeaModel.ToObject<GetOaOperatorLogListResponse>(DoROARequest("GetOaOperatorLogList", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/oaOperatorLogs/query", "json", req, runtime));
        }

        public async Task<GetOaOperatorLogListResponse> GetOaOperatorLogListWithOptionsAsync(GetOaOperatorLogListRequest request, GetOaOperatorLogListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryList))
            {
                body["categoryList"] = request.CategoryList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
            return TeaModel.ToObject<GetOaOperatorLogListResponse>(await DoROARequestAsync("GetOaOperatorLogList", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/oaOperatorLogs/query", "json", req, runtime));
        }

        public GetPartnerTypeByParentIdResponse GetPartnerTypeByParentId(string parentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPartnerTypeByParentIdHeaders headers = new GetPartnerTypeByParentIdHeaders();
            return GetPartnerTypeByParentIdWithOptions(parentId, headers, runtime);
        }

        public async Task<GetPartnerTypeByParentIdResponse> GetPartnerTypeByParentIdAsync(string parentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPartnerTypeByParentIdHeaders headers = new GetPartnerTypeByParentIdHeaders();
            return await GetPartnerTypeByParentIdWithOptionsAsync(parentId, headers, runtime);
        }

        public GetPartnerTypeByParentIdResponse GetPartnerTypeByParentIdWithOptions(string parentId, GetPartnerTypeByParentIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            parentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(parentId);
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
            return TeaModel.ToObject<GetPartnerTypeByParentIdResponse>(DoROARequest("GetPartnerTypeByParentId", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/partnerLabels/" + parentId, "json", req, runtime));
        }

        public async Task<GetPartnerTypeByParentIdResponse> GetPartnerTypeByParentIdWithOptionsAsync(string parentId, GetPartnerTypeByParentIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            parentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(parentId);
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
            return TeaModel.ToObject<GetPartnerTypeByParentIdResponse>(await DoROARequestAsync("GetPartnerTypeByParentId", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/partnerLabels/" + parentId, "json", req, runtime));
        }

        public GetPublisherSummaryResponse GetPublisherSummary(string dataId, GetPublisherSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPublisherSummaryHeaders headers = new GetPublisherSummaryHeaders();
            return GetPublisherSummaryWithOptions(dataId, request, headers, runtime);
        }

        public async Task<GetPublisherSummaryResponse> GetPublisherSummaryAsync(string dataId, GetPublisherSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPublisherSummaryHeaders headers = new GetPublisherSummaryHeaders();
            return await GetPublisherSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        public GetPublisherSummaryResponse GetPublisherSummaryWithOptions(string dataId, GetPublisherSummaryRequest request, GetPublisherSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetPublisherSummaryResponse>(DoROARequest("GetPublisherSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/publisher/" + dataId, "json", req, runtime));
        }

        public async Task<GetPublisherSummaryResponse> GetPublisherSummaryWithOptionsAsync(string dataId, GetPublisherSummaryRequest request, GetPublisherSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetPublisherSummaryResponse>(await DoROARequestAsync("GetPublisherSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/publisher/" + dataId, "json", req, runtime));
        }

        public GetSignedDetailByPageResponse GetSignedDetailByPage(GetSignedDetailByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignedDetailByPageHeaders headers = new GetSignedDetailByPageHeaders();
            return GetSignedDetailByPageWithOptions(request, headers, runtime);
        }

        public async Task<GetSignedDetailByPageResponse> GetSignedDetailByPageAsync(GetSignedDetailByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignedDetailByPageHeaders headers = new GetSignedDetailByPageHeaders();
            return await GetSignedDetailByPageWithOptionsAsync(request, headers, runtime);
        }

        public GetSignedDetailByPageResponse GetSignedDetailByPageWithOptions(GetSignedDetailByPageRequest request, GetSignedDetailByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignStatus))
            {
                query["signStatus"] = request.SignStatus;
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
            return TeaModel.ToObject<GetSignedDetailByPageResponse>(DoROARequest("GetSignedDetailByPage", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/audits/users", "json", req, runtime));
        }

        public async Task<GetSignedDetailByPageResponse> GetSignedDetailByPageWithOptionsAsync(GetSignedDetailByPageRequest request, GetSignedDetailByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignStatus))
            {
                query["signStatus"] = request.SignStatus;
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
            return TeaModel.ToObject<GetSignedDetailByPageResponse>(await DoROARequestAsync("GetSignedDetailByPage", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/audits/users", "json", req, runtime));
        }

        public GetTrustDeviceListResponse GetTrustDeviceList(GetTrustDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTrustDeviceListHeaders headers = new GetTrustDeviceListHeaders();
            return GetTrustDeviceListWithOptions(request, headers, runtime);
        }

        public async Task<GetTrustDeviceListResponse> GetTrustDeviceListAsync(GetTrustDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTrustDeviceListHeaders headers = new GetTrustDeviceListHeaders();
            return await GetTrustDeviceListWithOptionsAsync(request, headers, runtime);
        }

        public GetTrustDeviceListResponse GetTrustDeviceListWithOptions(GetTrustDeviceListRequest request, GetTrustDeviceListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
            return TeaModel.ToObject<GetTrustDeviceListResponse>(DoROARequest("GetTrustDeviceList", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/trustedDevices/query", "json", req, runtime));
        }

        public async Task<GetTrustDeviceListResponse> GetTrustDeviceListWithOptionsAsync(GetTrustDeviceListRequest request, GetTrustDeviceListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
            return TeaModel.ToObject<GetTrustDeviceListResponse>(await DoROARequestAsync("GetTrustDeviceList", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/trustedDevices/query", "json", req, runtime));
        }

        public GetUserAppVersionSummaryResponse GetUserAppVersionSummary(string dataId, GetUserAppVersionSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserAppVersionSummaryHeaders headers = new GetUserAppVersionSummaryHeaders();
            return GetUserAppVersionSummaryWithOptions(dataId, request, headers, runtime);
        }

        public async Task<GetUserAppVersionSummaryResponse> GetUserAppVersionSummaryAsync(string dataId, GetUserAppVersionSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserAppVersionSummaryHeaders headers = new GetUserAppVersionSummaryHeaders();
            return await GetUserAppVersionSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        public GetUserAppVersionSummaryResponse GetUserAppVersionSummaryWithOptions(string dataId, GetUserAppVersionSummaryRequest request, GetUserAppVersionSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetUserAppVersionSummaryResponse>(DoROARequest("GetUserAppVersionSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/appVersion/org/" + dataId, "json", req, runtime));
        }

        public async Task<GetUserAppVersionSummaryResponse> GetUserAppVersionSummaryWithOptionsAsync(string dataId, GetUserAppVersionSummaryRequest request, GetUserAppVersionSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            dataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataId);
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
            return TeaModel.ToObject<GetUserAppVersionSummaryResponse>(await DoROARequestAsync("GetUserAppVersionSummary", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/appVersion/org/" + dataId, "json", req, runtime));
        }

        public GetUserStayLengthResponse GetUserStayLength(GetUserStayLengthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserStayLengthHeaders headers = new GetUserStayLengthHeaders();
            return GetUserStayLengthWithOptions(request, headers, runtime);
        }

        public async Task<GetUserStayLengthResponse> GetUserStayLengthAsync(GetUserStayLengthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserStayLengthHeaders headers = new GetUserStayLengthHeaders();
            return await GetUserStayLengthWithOptionsAsync(request, headers, runtime);
        }

        public GetUserStayLengthResponse GetUserStayLengthWithOptions(GetUserStayLengthRequest request, GetUserStayLengthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
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
            return TeaModel.ToObject<GetUserStayLengthResponse>(DoROARequest("GetUserStayLength", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/users/stayTimes", "json", req, runtime));
        }

        public async Task<GetUserStayLengthResponse> GetUserStayLengthWithOptionsAsync(GetUserStayLengthRequest request, GetUserStayLengthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
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
            return TeaModel.ToObject<GetUserStayLengthResponse>(await DoROARequestAsync("GetUserStayLength", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/users/stayTimes", "json", req, runtime));
        }

        public ListAuditLogResponse ListAuditLog(ListAuditLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAuditLogHeaders headers = new ListAuditLogHeaders();
            return ListAuditLogWithOptions(request, headers, runtime);
        }

        public async Task<ListAuditLogResponse> ListAuditLogAsync(ListAuditLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAuditLogHeaders headers = new ListAuditLogHeaders();
            return await ListAuditLogWithOptionsAsync(request, headers, runtime);
        }

        public ListAuditLogResponse ListAuditLogWithOptions(ListAuditLogRequest request, ListAuditLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextBizId))
            {
                query["nextBizId"] = request.NextBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextGmtCreate))
            {
                query["nextGmtCreate"] = request.NextGmtCreate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["startDate"] = request.StartDate;
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
            return TeaModel.ToObject<ListAuditLogResponse>(DoROARequest("ListAuditLog", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/fileAuditLogs", "json", req, runtime));
        }

        public async Task<ListAuditLogResponse> ListAuditLogWithOptionsAsync(ListAuditLogRequest request, ListAuditLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextBizId))
            {
                query["nextBizId"] = request.NextBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextGmtCreate))
            {
                query["nextGmtCreate"] = request.NextGmtCreate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["startDate"] = request.StartDate;
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
            return TeaModel.ToObject<ListAuditLogResponse>(await DoROARequestAsync("ListAuditLog", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/fileAuditLogs", "json", req, runtime));
        }

        public ListJoinOrgInfoResponse ListJoinOrgInfo(ListJoinOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListJoinOrgInfoHeaders headers = new ListJoinOrgInfoHeaders();
            return ListJoinOrgInfoWithOptions(request, headers, runtime);
        }

        public async Task<ListJoinOrgInfoResponse> ListJoinOrgInfoAsync(ListJoinOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListJoinOrgInfoHeaders headers = new ListJoinOrgInfoHeaders();
            return await ListJoinOrgInfoWithOptionsAsync(request, headers, runtime);
        }

        public ListJoinOrgInfoResponse ListJoinOrgInfoWithOptions(ListJoinOrgInfoRequest request, ListJoinOrgInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
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
            return TeaModel.ToObject<ListJoinOrgInfoResponse>(DoROARequest("ListJoinOrgInfo", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/exclusiveAccounts/organizations/infos", "json", req, runtime));
        }

        public async Task<ListJoinOrgInfoResponse> ListJoinOrgInfoWithOptionsAsync(ListJoinOrgInfoRequest request, ListJoinOrgInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
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
            return TeaModel.ToObject<ListJoinOrgInfoResponse>(await DoROARequestAsync("ListJoinOrgInfo", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/exclusiveAccounts/organizations/infos", "json", req, runtime));
        }

        public ListMiniAppAvailableVersionResponse ListMiniAppAvailableVersion(ListMiniAppAvailableVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMiniAppAvailableVersionHeaders headers = new ListMiniAppAvailableVersionHeaders();
            return ListMiniAppAvailableVersionWithOptions(request, headers, runtime);
        }

        public async Task<ListMiniAppAvailableVersionResponse> ListMiniAppAvailableVersionAsync(ListMiniAppAvailableVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMiniAppAvailableVersionHeaders headers = new ListMiniAppAvailableVersionHeaders();
            return await ListMiniAppAvailableVersionWithOptionsAsync(request, headers, runtime);
        }

        public ListMiniAppAvailableVersionResponse ListMiniAppAvailableVersionWithOptions(ListMiniAppAvailableVersionRequest request, ListMiniAppAvailableVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionTypeSet))
            {
                body["versionTypeSet"] = request.VersionTypeSet;
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
            return TeaModel.ToObject<ListMiniAppAvailableVersionResponse>(DoROARequest("ListMiniAppAvailableVersion", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/miniApps/versions/availableLists", "json", req, runtime));
        }

        public async Task<ListMiniAppAvailableVersionResponse> ListMiniAppAvailableVersionWithOptionsAsync(ListMiniAppAvailableVersionRequest request, ListMiniAppAvailableVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionTypeSet))
            {
                body["versionTypeSet"] = request.VersionTypeSet;
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
            return TeaModel.ToObject<ListMiniAppAvailableVersionResponse>(await DoROARequestAsync("ListMiniAppAvailableVersion", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/miniApps/versions/availableLists", "json", req, runtime));
        }

        public ListMiniAppHistoryVersionResponse ListMiniAppHistoryVersion(ListMiniAppHistoryVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMiniAppHistoryVersionHeaders headers = new ListMiniAppHistoryVersionHeaders();
            return ListMiniAppHistoryVersionWithOptions(request, headers, runtime);
        }

        public async Task<ListMiniAppHistoryVersionResponse> ListMiniAppHistoryVersionAsync(ListMiniAppHistoryVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMiniAppHistoryVersionHeaders headers = new ListMiniAppHistoryVersionHeaders();
            return await ListMiniAppHistoryVersionWithOptionsAsync(request, headers, runtime);
        }

        public ListMiniAppHistoryVersionResponse ListMiniAppHistoryVersionWithOptions(ListMiniAppHistoryVersionRequest request, ListMiniAppHistoryVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListMiniAppHistoryVersionResponse>(DoROARequest("ListMiniAppHistoryVersion", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/miniApps/versions/historyLists", "json", req, runtime));
        }

        public async Task<ListMiniAppHistoryVersionResponse> ListMiniAppHistoryVersionWithOptionsAsync(ListMiniAppHistoryVersionRequest request, ListMiniAppHistoryVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListMiniAppHistoryVersionResponse>(await DoROARequestAsync("ListMiniAppHistoryVersion", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/miniApps/versions/historyLists", "json", req, runtime));
        }

        public ListPartnerRolesResponse ListPartnerRoles(string parentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPartnerRolesHeaders headers = new ListPartnerRolesHeaders();
            return ListPartnerRolesWithOptions(parentId, headers, runtime);
        }

        public async Task<ListPartnerRolesResponse> ListPartnerRolesAsync(string parentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPartnerRolesHeaders headers = new ListPartnerRolesHeaders();
            return await ListPartnerRolesWithOptionsAsync(parentId, headers, runtime);
        }

        public ListPartnerRolesResponse ListPartnerRolesWithOptions(string parentId, ListPartnerRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            parentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(parentId);
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
            return TeaModel.ToObject<ListPartnerRolesResponse>(DoROARequest("ListPartnerRoles", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/partners/roles/" + parentId, "json", req, runtime));
        }

        public async Task<ListPartnerRolesResponse> ListPartnerRolesWithOptionsAsync(string parentId, ListPartnerRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            parentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(parentId);
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
            return TeaModel.ToObject<ListPartnerRolesResponse>(await DoROARequestAsync("ListPartnerRoles", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/partners/roles/" + parentId, "json", req, runtime));
        }

        public ListPunchScheduleByConditionWithPagingResponse ListPunchScheduleByConditionWithPaging(ListPunchScheduleByConditionWithPagingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPunchScheduleByConditionWithPagingHeaders headers = new ListPunchScheduleByConditionWithPagingHeaders();
            return ListPunchScheduleByConditionWithPagingWithOptions(request, headers, runtime);
        }

        public async Task<ListPunchScheduleByConditionWithPagingResponse> ListPunchScheduleByConditionWithPagingAsync(ListPunchScheduleByConditionWithPagingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPunchScheduleByConditionWithPagingHeaders headers = new ListPunchScheduleByConditionWithPagingHeaders();
            return await ListPunchScheduleByConditionWithPagingWithOptionsAsync(request, headers, runtime);
        }

        public ListPunchScheduleByConditionWithPagingResponse ListPunchScheduleByConditionWithPagingWithOptions(ListPunchScheduleByConditionWithPagingRequest request, ListPunchScheduleByConditionWithPagingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizInstanceId))
            {
                body["bizInstanceId"] = request.BizInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleDateEnd))
            {
                body["scheduleDateEnd"] = request.ScheduleDateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleDateStart))
            {
                body["scheduleDateStart"] = request.ScheduleDateStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
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
            return TeaModel.ToObject<ListPunchScheduleByConditionWithPagingResponse>(DoROARequest("ListPunchScheduleByConditionWithPaging", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/punchSchedules/query", "json", req, runtime));
        }

        public async Task<ListPunchScheduleByConditionWithPagingResponse> ListPunchScheduleByConditionWithPagingWithOptionsAsync(ListPunchScheduleByConditionWithPagingRequest request, ListPunchScheduleByConditionWithPagingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizInstanceId))
            {
                body["bizInstanceId"] = request.BizInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleDateEnd))
            {
                body["scheduleDateEnd"] = request.ScheduleDateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleDateStart))
            {
                body["scheduleDateStart"] = request.ScheduleDateStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
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
            return TeaModel.ToObject<ListPunchScheduleByConditionWithPagingResponse>(await DoROARequestAsync("ListPunchScheduleByConditionWithPaging", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/punchSchedules/query", "json", req, runtime));
        }

        public PublishFileChangeNoticeResponse PublishFileChangeNotice(PublishFileChangeNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishFileChangeNoticeHeaders headers = new PublishFileChangeNoticeHeaders();
            return PublishFileChangeNoticeWithOptions(request, headers, runtime);
        }

        public async Task<PublishFileChangeNoticeResponse> PublishFileChangeNoticeAsync(PublishFileChangeNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishFileChangeNoticeHeaders headers = new PublishFileChangeNoticeHeaders();
            return await PublishFileChangeNoticeWithOptionsAsync(request, headers, runtime);
        }

        public PublishFileChangeNoticeResponse PublishFileChangeNoticeWithOptions(PublishFileChangeNoticeRequest request, PublishFileChangeNoticeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["operateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["spaceId"] = request.SpaceId;
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
            return TeaModel.ToObject<PublishFileChangeNoticeResponse>(DoROARequest("PublishFileChangeNotice", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/comments/send", "none", req, runtime));
        }

        public async Task<PublishFileChangeNoticeResponse> PublishFileChangeNoticeWithOptionsAsync(PublishFileChangeNoticeRequest request, PublishFileChangeNoticeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["operateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["spaceId"] = request.SpaceId;
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
            return TeaModel.ToObject<PublishFileChangeNoticeResponse>(await DoROARequestAsync("PublishFileChangeNotice", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/comments/send", "none", req, runtime));
        }

        public PushBadgeResponse PushBadge(PushBadgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushBadgeHeaders headers = new PushBadgeHeaders();
            return PushBadgeWithOptions(request, headers, runtime);
        }

        public async Task<PushBadgeResponse> PushBadgeAsync(PushBadgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushBadgeHeaders headers = new PushBadgeHeaders();
            return await PushBadgeWithOptionsAsync(request, headers, runtime);
        }

        public PushBadgeResponse PushBadgeWithOptions(PushBadgeRequest request, PushBadgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BadgeItems))
            {
                body["badgeItems"] = request.BadgeItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                body["pushType"] = request.PushType;
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
            return TeaModel.ToObject<PushBadgeResponse>(DoROARequest("PushBadge", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/exclusiveDesigns/redPoints/push", "json", req, runtime));
        }

        public async Task<PushBadgeResponse> PushBadgeWithOptionsAsync(PushBadgeRequest request, PushBadgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BadgeItems))
            {
                body["badgeItems"] = request.BadgeItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                body["pushType"] = request.PushType;
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
            return TeaModel.ToObject<PushBadgeResponse>(await DoROARequestAsync("PushBadge", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/exclusiveDesigns/redPoints/push", "json", req, runtime));
        }

        public QueryAcrossCloudStroageConfigsResponse QueryAcrossCloudStroageConfigs(QueryAcrossCloudStroageConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAcrossCloudStroageConfigsHeaders headers = new QueryAcrossCloudStroageConfigsHeaders();
            return QueryAcrossCloudStroageConfigsWithOptions(request, headers, runtime);
        }

        public async Task<QueryAcrossCloudStroageConfigsResponse> QueryAcrossCloudStroageConfigsAsync(QueryAcrossCloudStroageConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAcrossCloudStroageConfigsHeaders headers = new QueryAcrossCloudStroageConfigsHeaders();
            return await QueryAcrossCloudStroageConfigsWithOptionsAsync(request, headers, runtime);
        }

        public QueryAcrossCloudStroageConfigsResponse QueryAcrossCloudStroageConfigsWithOptions(QueryAcrossCloudStroageConfigsRequest request, QueryAcrossCloudStroageConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCloudType))
            {
                query["targetCloudType"] = request.TargetCloudType;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryAcrossCloudStroageConfigsResponse>(DoROARequest("QueryAcrossCloudStroageConfigs", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/fileStorages/acrossClouds/configurations", "json", req, runtime));
        }

        public async Task<QueryAcrossCloudStroageConfigsResponse> QueryAcrossCloudStroageConfigsWithOptionsAsync(QueryAcrossCloudStroageConfigsRequest request, QueryAcrossCloudStroageConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCloudType))
            {
                query["targetCloudType"] = request.TargetCloudType;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryAcrossCloudStroageConfigsResponse>(await DoROARequestAsync("QueryAcrossCloudStroageConfigs", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/fileStorages/acrossClouds/configurations", "json", req, runtime));
        }

        public QueryPartnerInfoResponse QueryPartnerInfo(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPartnerInfoHeaders headers = new QueryPartnerInfoHeaders();
            return QueryPartnerInfoWithOptions(userId, headers, runtime);
        }

        public async Task<QueryPartnerInfoResponse> QueryPartnerInfoAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPartnerInfoHeaders headers = new QueryPartnerInfoHeaders();
            return await QueryPartnerInfoWithOptionsAsync(userId, headers, runtime);
        }

        public QueryPartnerInfoResponse QueryPartnerInfoWithOptions(string userId, QueryPartnerInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
            return TeaModel.ToObject<QueryPartnerInfoResponse>(DoROARequest("QueryPartnerInfo", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/partners/users/" + userId, "json", req, runtime));
        }

        public async Task<QueryPartnerInfoResponse> QueryPartnerInfoWithOptionsAsync(string userId, QueryPartnerInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
            return TeaModel.ToObject<QueryPartnerInfoResponse>(await DoROARequestAsync("QueryPartnerInfo", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/partners/users/" + userId, "json", req, runtime));
        }

        public RollbackMiniAppVersionResponse RollbackMiniAppVersion(RollbackMiniAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RollbackMiniAppVersionHeaders headers = new RollbackMiniAppVersionHeaders();
            return RollbackMiniAppVersionWithOptions(request, headers, runtime);
        }

        public async Task<RollbackMiniAppVersionResponse> RollbackMiniAppVersionAsync(RollbackMiniAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RollbackMiniAppVersionHeaders headers = new RollbackMiniAppVersionHeaders();
            return await RollbackMiniAppVersionWithOptionsAsync(request, headers, runtime);
        }

        public RollbackMiniAppVersionResponse RollbackMiniAppVersionWithOptions(RollbackMiniAppVersionRequest request, RollbackMiniAppVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RollbackVersion))
            {
                body["rollbackVersion"] = request.RollbackVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersion))
            {
                body["targetVersion"] = request.TargetVersion;
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
            return TeaModel.ToObject<RollbackMiniAppVersionResponse>(DoROARequest("RollbackMiniAppVersion", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/miniApps/versions/rollback", "json", req, runtime));
        }

        public async Task<RollbackMiniAppVersionResponse> RollbackMiniAppVersionWithOptionsAsync(RollbackMiniAppVersionRequest request, RollbackMiniAppVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RollbackVersion))
            {
                body["rollbackVersion"] = request.RollbackVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersion))
            {
                body["targetVersion"] = request.TargetVersion;
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
            return TeaModel.ToObject<RollbackMiniAppVersionResponse>(await DoROARequestAsync("RollbackMiniAppVersion", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/miniApps/versions/rollback", "json", req, runtime));
        }

        public SaveAcrossCloudStroageConfigsResponse SaveAcrossCloudStroageConfigs(SaveAcrossCloudStroageConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveAcrossCloudStroageConfigsHeaders headers = new SaveAcrossCloudStroageConfigsHeaders();
            return SaveAcrossCloudStroageConfigsWithOptions(request, headers, runtime);
        }

        public async Task<SaveAcrossCloudStroageConfigsResponse> SaveAcrossCloudStroageConfigsAsync(SaveAcrossCloudStroageConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveAcrossCloudStroageConfigsHeaders headers = new SaveAcrossCloudStroageConfigsHeaders();
            return await SaveAcrossCloudStroageConfigsWithOptionsAsync(request, headers, runtime);
        }

        public SaveAcrossCloudStroageConfigsResponse SaveAcrossCloudStroageConfigsWithOptions(SaveAcrossCloudStroageConfigsRequest request, SaveAcrossCloudStroageConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                body["bucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudType))
            {
                body["cloudType"] = request.CloudType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                body["endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
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
            return TeaModel.ToObject<SaveAcrossCloudStroageConfigsResponse>(DoROARequest("SaveAcrossCloudStroageConfigs", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/fileStorages/acrossClouds/configurations", "json", req, runtime));
        }

        public async Task<SaveAcrossCloudStroageConfigsResponse> SaveAcrossCloudStroageConfigsWithOptionsAsync(SaveAcrossCloudStroageConfigsRequest request, SaveAcrossCloudStroageConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                body["bucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudType))
            {
                body["cloudType"] = request.CloudType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                body["endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
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
            return TeaModel.ToObject<SaveAcrossCloudStroageConfigsResponse>(await DoROARequestAsync("SaveAcrossCloudStroageConfigs", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/fileStorages/acrossClouds/configurations", "json", req, runtime));
        }

        public SaveAndSubmitAuthInfoResponse SaveAndSubmitAuthInfo(SaveAndSubmitAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveAndSubmitAuthInfoHeaders headers = new SaveAndSubmitAuthInfoHeaders();
            return SaveAndSubmitAuthInfoWithOptions(request, headers, runtime);
        }

        public async Task<SaveAndSubmitAuthInfoResponse> SaveAndSubmitAuthInfoAsync(SaveAndSubmitAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveAndSubmitAuthInfoHeaders headers = new SaveAndSubmitAuthInfoHeaders();
            return await SaveAndSubmitAuthInfoWithOptionsAsync(request, headers, runtime);
        }

        public SaveAndSubmitAuthInfoResponse SaveAndSubmitAuthInfoWithOptions(SaveAndSubmitAuthInfoRequest request, SaveAndSubmitAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRemark))
            {
                body["applyRemark"] = request.ApplyRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeMediaId))
            {
                body["authorizeMediaId"] = request.AuthorizeMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                body["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPerson))
            {
                body["legalPerson"] = request.LegalPerson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIdCard))
            {
                body["legalPersonIdCard"] = request.LegalPersonIdCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseMediaId))
            {
                body["licenseMediaId"] = request.LicenseMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocCity))
            {
                body["locCity"] = request.LocCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocCityName))
            {
                body["locCityName"] = request.LocCityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocProvince))
            {
                body["locProvince"] = request.LocProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocProvinceName))
            {
                body["locProvinceName"] = request.LocProvinceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNum))
            {
                body["mobileNum"] = request.MobileNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["orgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationCode))
            {
                body["organizationCode"] = request.OrganizationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationCodeMediaId))
            {
                body["organizationCodeMediaId"] = request.OrganizationCodeMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistLocation))
            {
                body["registLocation"] = request.RegistLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistNum))
            {
                body["registNum"] = request.RegistNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnifiedSocialCredit))
            {
                body["unifiedSocialCredit"] = request.UnifiedSocialCredit;
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
            return TeaModel.ToObject<SaveAndSubmitAuthInfoResponse>(DoROARequest("SaveAndSubmitAuthInfo", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/ognizations/authInfos/saveAndSubmit", "json", req, runtime));
        }

        public async Task<SaveAndSubmitAuthInfoResponse> SaveAndSubmitAuthInfoWithOptionsAsync(SaveAndSubmitAuthInfoRequest request, SaveAndSubmitAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRemark))
            {
                body["applyRemark"] = request.ApplyRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeMediaId))
            {
                body["authorizeMediaId"] = request.AuthorizeMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                body["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPerson))
            {
                body["legalPerson"] = request.LegalPerson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIdCard))
            {
                body["legalPersonIdCard"] = request.LegalPersonIdCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseMediaId))
            {
                body["licenseMediaId"] = request.LicenseMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocCity))
            {
                body["locCity"] = request.LocCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocCityName))
            {
                body["locCityName"] = request.LocCityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocProvince))
            {
                body["locProvince"] = request.LocProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocProvinceName))
            {
                body["locProvinceName"] = request.LocProvinceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNum))
            {
                body["mobileNum"] = request.MobileNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["orgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationCode))
            {
                body["organizationCode"] = request.OrganizationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationCodeMediaId))
            {
                body["organizationCodeMediaId"] = request.OrganizationCodeMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistLocation))
            {
                body["registLocation"] = request.RegistLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistNum))
            {
                body["registNum"] = request.RegistNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnifiedSocialCredit))
            {
                body["unifiedSocialCredit"] = request.UnifiedSocialCredit;
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
            return TeaModel.ToObject<SaveAndSubmitAuthInfoResponse>(await DoROARequestAsync("SaveAndSubmitAuthInfo", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/ognizations/authInfos/saveAndSubmit", "json", req, runtime));
        }

        public SearchOrgInnerGroupInfoResponse SearchOrgInnerGroupInfo(SearchOrgInnerGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchOrgInnerGroupInfoHeaders headers = new SearchOrgInnerGroupInfoHeaders();
            return SearchOrgInnerGroupInfoWithOptions(request, headers, runtime);
        }

        public async Task<SearchOrgInnerGroupInfoResponse> SearchOrgInnerGroupInfoAsync(SearchOrgInnerGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchOrgInnerGroupInfoHeaders headers = new SearchOrgInnerGroupInfoHeaders();
            return await SearchOrgInnerGroupInfoWithOptionsAsync(request, headers, runtime);
        }

        public SearchOrgInnerGroupInfoResponse SearchOrgInnerGroupInfoWithOptions(SearchOrgInnerGroupInfoRequest request, SearchOrgInnerGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                query["createTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["createTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMembersCountEnd))
            {
                query["groupMembersCountEnd"] = request.GroupMembersCountEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMembersCountStart))
            {
                query["groupMembersCountStart"] = request.GroupMembersCountStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwner))
            {
                query["groupOwner"] = request.GroupOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastActiveTimeEnd))
            {
                query["lastActiveTimeEnd"] = request.LastActiveTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastActiveTimeStart))
            {
                query["lastActiveTimeStart"] = request.LastActiveTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                query["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncToDingpan))
            {
                query["syncToDingpan"] = request.SyncToDingpan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
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
            return TeaModel.ToObject<SearchOrgInnerGroupInfoResponse>(DoROARequest("SearchOrgInnerGroupInfo", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/securities/orgGroupInfos", "json", req, runtime));
        }

        public async Task<SearchOrgInnerGroupInfoResponse> SearchOrgInnerGroupInfoWithOptionsAsync(SearchOrgInnerGroupInfoRequest request, SearchOrgInnerGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                query["createTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["createTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMembersCountEnd))
            {
                query["groupMembersCountEnd"] = request.GroupMembersCountEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMembersCountStart))
            {
                query["groupMembersCountStart"] = request.GroupMembersCountStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwner))
            {
                query["groupOwner"] = request.GroupOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastActiveTimeEnd))
            {
                query["lastActiveTimeEnd"] = request.LastActiveTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastActiveTimeStart))
            {
                query["lastActiveTimeStart"] = request.LastActiveTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                query["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncToDingpan))
            {
                query["syncToDingpan"] = request.SyncToDingpan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
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
            return TeaModel.ToObject<SearchOrgInnerGroupInfoResponse>(await DoROARequestAsync("SearchOrgInnerGroupInfo", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/securities/orgGroupInfos", "json", req, runtime));
        }

        public SendAppDingResponse SendAppDing(SendAppDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendAppDingHeaders headers = new SendAppDingHeaders();
            return SendAppDingWithOptions(request, headers, runtime);
        }

        public async Task<SendAppDingResponse> SendAppDingAsync(SendAppDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendAppDingHeaders headers = new SendAppDingHeaders();
            return await SendAppDingWithOptionsAsync(request, headers, runtime);
        }

        public SendAppDingResponse SendAppDingWithOptions(SendAppDingRequest request, SendAppDingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userids))
            {
                body["userids"] = request.Userids;
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
            return TeaModel.ToObject<SendAppDingResponse>(DoROARequest("SendAppDing", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/appDings/send", "none", req, runtime));
        }

        public async Task<SendAppDingResponse> SendAppDingWithOptionsAsync(SendAppDingRequest request, SendAppDingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userids))
            {
                body["userids"] = request.Userids;
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
            return TeaModel.ToObject<SendAppDingResponse>(await DoROARequestAsync("SendAppDing", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/appDings/send", "none", req, runtime));
        }

        public SendInvitationResponse SendInvitation(SendInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInvitationHeaders headers = new SendInvitationHeaders();
            return SendInvitationWithOptions(request, headers, runtime);
        }

        public async Task<SendInvitationResponse> SendInvitationAsync(SendInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInvitationHeaders headers = new SendInvitationHeaders();
            return await SendInvitationWithOptionsAsync(request, headers, runtime);
        }

        public SendInvitationResponse SendInvitationWithOptions(SendInvitationRequest request, SendInvitationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgAlias))
            {
                body["orgAlias"] = request.OrgAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerLabelId))
            {
                body["partnerLabelId"] = request.PartnerLabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerNum))
            {
                body["partnerNum"] = request.PartnerNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
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
            return TeaModel.ToObject<SendInvitationResponse>(DoROARequest("SendInvitation", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/partnerDepartments/invitations/send", "none", req, runtime));
        }

        public async Task<SendInvitationResponse> SendInvitationWithOptionsAsync(SendInvitationRequest request, SendInvitationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgAlias))
            {
                body["orgAlias"] = request.OrgAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerLabelId))
            {
                body["partnerLabelId"] = request.PartnerLabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerNum))
            {
                body["partnerNum"] = request.PartnerNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
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
            return TeaModel.ToObject<SendInvitationResponse>(await DoROARequestAsync("SendInvitation", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/partnerDepartments/invitations/send", "none", req, runtime));
        }

        public SendPhoneDingResponse SendPhoneDing(SendPhoneDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendPhoneDingHeaders headers = new SendPhoneDingHeaders();
            return SendPhoneDingWithOptions(request, headers, runtime);
        }

        public async Task<SendPhoneDingResponse> SendPhoneDingAsync(SendPhoneDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendPhoneDingHeaders headers = new SendPhoneDingHeaders();
            return await SendPhoneDingWithOptionsAsync(request, headers, runtime);
        }

        public SendPhoneDingResponse SendPhoneDingWithOptions(SendPhoneDingRequest request, SendPhoneDingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userids))
            {
                body["userids"] = request.Userids;
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
            return TeaModel.ToObject<SendPhoneDingResponse>(DoROARequest("SendPhoneDing", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/phoneDings/send", "json", req, runtime));
        }

        public async Task<SendPhoneDingResponse> SendPhoneDingWithOptionsAsync(SendPhoneDingRequest request, SendPhoneDingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userids))
            {
                body["userids"] = request.Userids;
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
            return TeaModel.ToObject<SendPhoneDingResponse>(await DoROARequestAsync("SendPhoneDing", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/phoneDings/send", "json", req, runtime));
        }

        public SetDeptPartnerTypeAndNumResponse SetDeptPartnerTypeAndNum(SetDeptPartnerTypeAndNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDeptPartnerTypeAndNumHeaders headers = new SetDeptPartnerTypeAndNumHeaders();
            return SetDeptPartnerTypeAndNumWithOptions(request, headers, runtime);
        }

        public async Task<SetDeptPartnerTypeAndNumResponse> SetDeptPartnerTypeAndNumAsync(SetDeptPartnerTypeAndNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDeptPartnerTypeAndNumHeaders headers = new SetDeptPartnerTypeAndNumHeaders();
            return await SetDeptPartnerTypeAndNumWithOptionsAsync(request, headers, runtime);
        }

        public SetDeptPartnerTypeAndNumResponse SetDeptPartnerTypeAndNumWithOptions(SetDeptPartnerTypeAndNumRequest request, SetDeptPartnerTypeAndNumHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelIds))
            {
                body["labelIds"] = request.LabelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerNum))
            {
                body["partnerNum"] = request.PartnerNum;
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
            return TeaModel.ToObject<SetDeptPartnerTypeAndNumResponse>(DoROARequest("SetDeptPartnerTypeAndNum", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/partnerDepartments", "none", req, runtime));
        }

        public async Task<SetDeptPartnerTypeAndNumResponse> SetDeptPartnerTypeAndNumWithOptionsAsync(SetDeptPartnerTypeAndNumRequest request, SetDeptPartnerTypeAndNumHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelIds))
            {
                body["labelIds"] = request.LabelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerNum))
            {
                body["partnerNum"] = request.PartnerNum;
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
            return TeaModel.ToObject<SetDeptPartnerTypeAndNumResponse>(await DoROARequestAsync("SetDeptPartnerTypeAndNum", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/partnerDepartments", "none", req, runtime));
        }

        public UpdateFileStatusResponse UpdateFileStatus(UpdateFileStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFileStatusHeaders headers = new UpdateFileStatusHeaders();
            return UpdateFileStatusWithOptions(request, headers, runtime);
        }

        public async Task<UpdateFileStatusResponse> UpdateFileStatusAsync(UpdateFileStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFileStatusHeaders headers = new UpdateFileStatusHeaders();
            return await UpdateFileStatusWithOptionsAsync(request, headers, runtime);
        }

        public UpdateFileStatusResponse UpdateFileStatusWithOptions(UpdateFileStatusRequest request, UpdateFileStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestIds))
            {
                body["requestIds"] = request.RequestIds;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateFileStatusResponse>(DoROARequest("UpdateFileStatus", "exclusive_1.0", "HTTP", "PUT", "AK", "/v1.0/exclusive/sending/files/status", "json", req, runtime));
        }

        public async Task<UpdateFileStatusResponse> UpdateFileStatusWithOptionsAsync(UpdateFileStatusRequest request, UpdateFileStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestIds))
            {
                body["requestIds"] = request.RequestIds;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateFileStatusResponse>(await DoROARequestAsync("UpdateFileStatus", "exclusive_1.0", "HTTP", "PUT", "AK", "/v1.0/exclusive/sending/files/status", "json", req, runtime));
        }

        public UpdateMiniAppVersionStatusResponse UpdateMiniAppVersionStatus(UpdateMiniAppVersionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMiniAppVersionStatusHeaders headers = new UpdateMiniAppVersionStatusHeaders();
            return UpdateMiniAppVersionStatusWithOptions(request, headers, runtime);
        }

        public async Task<UpdateMiniAppVersionStatusResponse> UpdateMiniAppVersionStatusAsync(UpdateMiniAppVersionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMiniAppVersionStatusHeaders headers = new UpdateMiniAppVersionStatusHeaders();
            return await UpdateMiniAppVersionStatusWithOptionsAsync(request, headers, runtime);
        }

        public UpdateMiniAppVersionStatusResponse UpdateMiniAppVersionStatusWithOptions(UpdateMiniAppVersionStatusRequest request, UpdateMiniAppVersionStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionType))
            {
                body["versionType"] = request.VersionType;
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
            return TeaModel.ToObject<UpdateMiniAppVersionStatusResponse>(DoROARequest("UpdateMiniAppVersionStatus", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/miniApps/versions/versionStatus", "json", req, runtime));
        }

        public async Task<UpdateMiniAppVersionStatusResponse> UpdateMiniAppVersionStatusWithOptionsAsync(UpdateMiniAppVersionStatusRequest request, UpdateMiniAppVersionStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionType))
            {
                body["versionType"] = request.VersionType;
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
            return TeaModel.ToObject<UpdateMiniAppVersionStatusResponse>(await DoROARequestAsync("UpdateMiniAppVersionStatus", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/miniApps/versions/versionStatus", "json", req, runtime));
        }

        public UpdatePartnerVisibilityResponse UpdatePartnerVisibility(UpdatePartnerVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePartnerVisibilityHeaders headers = new UpdatePartnerVisibilityHeaders();
            return UpdatePartnerVisibilityWithOptions(request, headers, runtime);
        }

        public async Task<UpdatePartnerVisibilityResponse> UpdatePartnerVisibilityAsync(UpdatePartnerVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePartnerVisibilityHeaders headers = new UpdatePartnerVisibilityHeaders();
            return await UpdatePartnerVisibilityWithOptionsAsync(request, headers, runtime);
        }

        public UpdatePartnerVisibilityResponse UpdatePartnerVisibilityWithOptions(UpdatePartnerVisibilityRequest request, UpdatePartnerVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["labelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
            return TeaModel.ToObject<UpdatePartnerVisibilityResponse>(DoROARequest("UpdatePartnerVisibility", "exclusive_1.0", "HTTP", "PUT", "AK", "/v1.0/exclusive/partnerDepartments/visibilityPartners", "boolean", req, runtime));
        }

        public async Task<UpdatePartnerVisibilityResponse> UpdatePartnerVisibilityWithOptionsAsync(UpdatePartnerVisibilityRequest request, UpdatePartnerVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["labelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
            return TeaModel.ToObject<UpdatePartnerVisibilityResponse>(await DoROARequestAsync("UpdatePartnerVisibility", "exclusive_1.0", "HTTP", "PUT", "AK", "/v1.0/exclusive/partnerDepartments/visibilityPartners", "boolean", req, runtime));
        }

        public UpdateRoleVisibilityResponse UpdateRoleVisibility(UpdateRoleVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRoleVisibilityHeaders headers = new UpdateRoleVisibilityHeaders();
            return UpdateRoleVisibilityWithOptions(request, headers, runtime);
        }

        public async Task<UpdateRoleVisibilityResponse> UpdateRoleVisibilityAsync(UpdateRoleVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRoleVisibilityHeaders headers = new UpdateRoleVisibilityHeaders();
            return await UpdateRoleVisibilityWithOptionsAsync(request, headers, runtime);
        }

        public UpdateRoleVisibilityResponse UpdateRoleVisibilityWithOptions(UpdateRoleVisibilityRequest request, UpdateRoleVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["labelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
            return TeaModel.ToObject<UpdateRoleVisibilityResponse>(DoROARequest("UpdateRoleVisibility", "exclusive_1.0", "HTTP", "PUT", "AK", "/v1.0/exclusive/partnerDepartments/visibilityRoles", "boolean", req, runtime));
        }

        public async Task<UpdateRoleVisibilityResponse> UpdateRoleVisibilityWithOptionsAsync(UpdateRoleVisibilityRequest request, UpdateRoleVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["labelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
            return TeaModel.ToObject<UpdateRoleVisibilityResponse>(await DoROARequestAsync("UpdateRoleVisibility", "exclusive_1.0", "HTTP", "PUT", "AK", "/v1.0/exclusive/partnerDepartments/visibilityRoles", "boolean", req, runtime));
        }

        public UpdateStorageModeResponse UpdateStorageMode(UpdateStorageModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateStorageModeHeaders headers = new UpdateStorageModeHeaders();
            return UpdateStorageModeWithOptions(request, headers, runtime);
        }

        public async Task<UpdateStorageModeResponse> UpdateStorageModeAsync(UpdateStorageModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateStorageModeHeaders headers = new UpdateStorageModeHeaders();
            return await UpdateStorageModeWithOptionsAsync(request, headers, runtime);
        }

        public UpdateStorageModeResponse UpdateStorageModeWithOptions(UpdateStorageModeRequest request, UpdateStorageModeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileStorageMode))
            {
                body["fileStorageMode"] = request.FileStorageMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
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
            return TeaModel.ToObject<UpdateStorageModeResponse>(DoROARequest("UpdateStorageMode", "exclusive_1.0", "HTTP", "PUT", "AK", "/v1.0/exclusive/fileStorages/acrossClouds/storageModes", "json", req, runtime));
        }

        public async Task<UpdateStorageModeResponse> UpdateStorageModeWithOptionsAsync(UpdateStorageModeRequest request, UpdateStorageModeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileStorageMode))
            {
                body["fileStorageMode"] = request.FileStorageMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
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
            return TeaModel.ToObject<UpdateStorageModeResponse>(await DoROARequestAsync("UpdateStorageMode", "exclusive_1.0", "HTTP", "PUT", "AK", "/v1.0/exclusive/fileStorages/acrossClouds/storageModes", "json", req, runtime));
        }

    }
}
