// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkhrm_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 新增法人公司
         *
         * @param request AddHrmLegalEntityRequest
         * @param headers AddHrmLegalEntityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddHrmLegalEntityResponse
         */
        public AddHrmLegalEntityResponse AddHrmLegalEntityWithOptions(AddHrmLegalEntityRequest request, AddHrmLegalEntityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTenantId))
            {
                query["dingTenantId"] = request.DingTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                body["createUserId"] = request.CreateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalEntityName))
            {
                body["legalEntityName"] = request.LegalEntityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalEntityShortName))
            {
                body["legalEntityShortName"] = request.LegalEntityShortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalEntityStatus))
            {
                body["legalEntityStatus"] = request.LegalEntityStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonName))
            {
                body["legalPersonName"] = request.LegalPersonName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddHrmLegalEntity",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/legalEntities/companies",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddHrmLegalEntityResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 新增法人公司
         *
         * @param request AddHrmLegalEntityRequest
         * @param headers AddHrmLegalEntityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddHrmLegalEntityResponse
         */
        public async Task<AddHrmLegalEntityResponse> AddHrmLegalEntityWithOptionsAsync(AddHrmLegalEntityRequest request, AddHrmLegalEntityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTenantId))
            {
                query["dingTenantId"] = request.DingTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                body["createUserId"] = request.CreateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalEntityName))
            {
                body["legalEntityName"] = request.LegalEntityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalEntityShortName))
            {
                body["legalEntityShortName"] = request.LegalEntityShortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalEntityStatus))
            {
                body["legalEntityStatus"] = request.LegalEntityStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonName))
            {
                body["legalPersonName"] = request.LegalPersonName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddHrmLegalEntity",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/legalEntities/companies",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddHrmLegalEntityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 新增法人公司
         *
         * @param request AddHrmLegalEntityRequest
         * @return AddHrmLegalEntityResponse
         */
        public AddHrmLegalEntityResponse AddHrmLegalEntity(AddHrmLegalEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddHrmLegalEntityHeaders headers = new AddHrmLegalEntityHeaders();
            return AddHrmLegalEntityWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新增法人公司
         *
         * @param request AddHrmLegalEntityRequest
         * @return AddHrmLegalEntityResponse
         */
        public async Task<AddHrmLegalEntityResponse> AddHrmLegalEntityAsync(AddHrmLegalEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddHrmLegalEntityHeaders headers = new AddHrmLegalEntityHeaders();
            return await AddHrmLegalEntityWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事添加待入职员工信息(支持花名册数据和分组明细更新)
         *
         * @param request AddHrmPreentryRequest
         * @param headers AddHrmPreentryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddHrmPreentryResponse
         */
        public AddHrmPreentryResponse AddHrmPreentryWithOptions(AddHrmPreentryRequest request, AddHrmPreentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Groups))
            {
                body["groups"] = request.Groups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSendPreEntryMsg))
            {
                body["needSendPreEntryMsg"] = request.NeedSendPreEntryMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreEntryTime))
            {
                body["preEntryTime"] = request.PreEntryTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddHrmPreentry",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/preentries",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddHrmPreentryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事添加待入职员工信息(支持花名册数据和分组明细更新)
         *
         * @param request AddHrmPreentryRequest
         * @param headers AddHrmPreentryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddHrmPreentryResponse
         */
        public async Task<AddHrmPreentryResponse> AddHrmPreentryWithOptionsAsync(AddHrmPreentryRequest request, AddHrmPreentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Groups))
            {
                body["groups"] = request.Groups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSendPreEntryMsg))
            {
                body["needSendPreEntryMsg"] = request.NeedSendPreEntryMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreEntryTime))
            {
                body["preEntryTime"] = request.PreEntryTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddHrmPreentry",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/preentries",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddHrmPreentryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事添加待入职员工信息(支持花名册数据和分组明细更新)
         *
         * @param request AddHrmPreentryRequest
         * @return AddHrmPreentryResponse
         */
        public AddHrmPreentryResponse AddHrmPreentry(AddHrmPreentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddHrmPreentryHeaders headers = new AddHrmPreentryHeaders();
            return AddHrmPreentryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事添加待入职员工信息(支持花名册数据和分组明细更新)
         *
         * @param request AddHrmPreentryRequest
         * @return AddHrmPreentryResponse
         */
        public async Task<AddHrmPreentryResponse> AddHrmPreentryAsync(AddHrmPreentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddHrmPreentryHeaders headers = new AddHrmPreentryHeaders();
            return await AddHrmPreentryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建电子签签署记录
         *
         * @param request CreateRecordRequest
         * @param headers CreateRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRecordResponse
         */
        public CreateRecordResponse CreateRecordWithOptions(CreateRecordRequest request, CreateRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachmentList))
            {
                body["attachmentList"] = request.AttachmentList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldList))
            {
                body["fieldList"] = request.FieldList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupList))
            {
                body["groupList"] = request.GroupList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignLastLegalEntityName))
            {
                body["signLastLegalEntityName"] = request.SignLastLegalEntityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignLegalEntityName))
            {
                body["signLegalEntityName"] = request.SignLegalEntityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignSource))
            {
                body["signSource"] = request.SignSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignStartUserId))
            {
                body["signStartUserId"] = request.SignStartUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignUserId))
            {
                body["signUserId"] = request.SignUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateRecord",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/signCenters/records",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRecordResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建电子签签署记录
         *
         * @param request CreateRecordRequest
         * @param headers CreateRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRecordResponse
         */
        public async Task<CreateRecordResponse> CreateRecordWithOptionsAsync(CreateRecordRequest request, CreateRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachmentList))
            {
                body["attachmentList"] = request.AttachmentList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldList))
            {
                body["fieldList"] = request.FieldList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupList))
            {
                body["groupList"] = request.GroupList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignLastLegalEntityName))
            {
                body["signLastLegalEntityName"] = request.SignLastLegalEntityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignLegalEntityName))
            {
                body["signLegalEntityName"] = request.SignLegalEntityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignSource))
            {
                body["signSource"] = request.SignSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignStartUserId))
            {
                body["signStartUserId"] = request.SignStartUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignUserId))
            {
                body["signUserId"] = request.SignUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateRecord",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/signCenters/records",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRecordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建电子签签署记录
         *
         * @param request CreateRecordRequest
         * @return CreateRecordResponse
         */
        public CreateRecordResponse CreateRecord(CreateRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRecordHeaders headers = new CreateRecordHeaders();
            return CreateRecordWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建电子签签署记录
         *
         * @param request CreateRecordRequest
         * @return CreateRecordResponse
         */
        public async Task<CreateRecordResponse> CreateRecordAsync(CreateRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRecordHeaders headers = new CreateRecordHeaders();
            return await CreateRecordWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事设备市场管理
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeviceMarketManagerResponse
         */
        public DeviceMarketManagerResponse DeviceMarketManagerWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeviceMarketManager",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/device/market/manager",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceMarketManagerResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事设备市场管理
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeviceMarketManagerResponse
         */
        public async Task<DeviceMarketManagerResponse> DeviceMarketManagerWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeviceMarketManager",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/device/market/manager",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceMarketManagerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事设备市场管理
         *
         * @return DeviceMarketManagerResponse
         */
        public DeviceMarketManagerResponse DeviceMarketManager()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeviceMarketManagerWithOptions(headers, runtime);
        }

        /**
         * @summary 智能人事设备市场管理
         *
         * @return DeviceMarketManagerResponse
         */
        public async Task<DeviceMarketManagerResponse> DeviceMarketManagerAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeviceMarketManagerWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 智能人事设备定向管理接口
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeviceMarketOrderManagerResponse
         */
        public DeviceMarketOrderManagerResponse DeviceMarketOrderManagerWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeviceMarketOrderManager",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/device/market/order/manager",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceMarketOrderManagerResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事设备定向管理接口
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeviceMarketOrderManagerResponse
         */
        public async Task<DeviceMarketOrderManagerResponse> DeviceMarketOrderManagerWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeviceMarketOrderManager",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/device/market/order/manager",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceMarketOrderManagerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事设备定向管理接口
         *
         * @return DeviceMarketOrderManagerResponse
         */
        public DeviceMarketOrderManagerResponse DeviceMarketOrderManager()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeviceMarketOrderManagerWithOptions(headers, runtime);
        }

        /**
         * @summary 智能人事设备定向管理接口
         *
         * @return DeviceMarketOrderManagerResponse
         */
        public async Task<DeviceMarketOrderManagerResponse> DeviceMarketOrderManagerAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeviceMarketOrderManagerWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary e签宝专有查询证件接口
         *
         * @param request ECertQueryRequest
         * @param headers ECertQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ECertQueryResponse
         */
        public ECertQueryResponse ECertQueryWithOptions(ECertQueryRequest request, ECertQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ECertQuery",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/eCerts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ECertQueryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary e签宝专有查询证件接口
         *
         * @param request ECertQueryRequest
         * @param headers ECertQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ECertQueryResponse
         */
        public async Task<ECertQueryResponse> ECertQueryWithOptionsAsync(ECertQueryRequest request, ECertQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ECertQuery",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/eCerts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ECertQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary e签宝专有查询证件接口
         *
         * @param request ECertQueryRequest
         * @return ECertQueryResponse
         */
        public ECertQueryResponse ECertQuery(ECertQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ECertQueryHeaders headers = new ECertQueryHeaders();
            return ECertQueryWithOptions(request, headers, runtime);
        }

        /**
         * @summary e签宝专有查询证件接口
         *
         * @param request ECertQueryRequest
         * @return ECertQueryResponse
         */
        public async Task<ECertQueryResponse> ECertQueryAsync(ECertQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ECertQueryHeaders headers = new ECertQueryHeaders();
            return await ECertQueryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事员工档案附件更新
         *
         * @param request EmployeeAttachmentUpdateRequest
         * @param headers EmployeeAttachmentUpdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return EmployeeAttachmentUpdateResponse
         */
        public EmployeeAttachmentUpdateResponse EmployeeAttachmentUpdateWithOptions(EmployeeAttachmentUpdateRequest request, EmployeeAttachmentUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppAgentId))
            {
                query["appAgentId"] = request.AppAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldCode))
            {
                body["fieldCode"] = request.FieldCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSuffix))
            {
                body["fileSuffix"] = request.FileSuffix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EmployeeAttachmentUpdate",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/employees/attachments",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EmployeeAttachmentUpdateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事员工档案附件更新
         *
         * @param request EmployeeAttachmentUpdateRequest
         * @param headers EmployeeAttachmentUpdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return EmployeeAttachmentUpdateResponse
         */
        public async Task<EmployeeAttachmentUpdateResponse> EmployeeAttachmentUpdateWithOptionsAsync(EmployeeAttachmentUpdateRequest request, EmployeeAttachmentUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppAgentId))
            {
                query["appAgentId"] = request.AppAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldCode))
            {
                body["fieldCode"] = request.FieldCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSuffix))
            {
                body["fileSuffix"] = request.FileSuffix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EmployeeAttachmentUpdate",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/employees/attachments",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EmployeeAttachmentUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事员工档案附件更新
         *
         * @param request EmployeeAttachmentUpdateRequest
         * @return EmployeeAttachmentUpdateResponse
         */
        public EmployeeAttachmentUpdateResponse EmployeeAttachmentUpdate(EmployeeAttachmentUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EmployeeAttachmentUpdateHeaders headers = new EmployeeAttachmentUpdateHeaders();
            return EmployeeAttachmentUpdateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事员工档案附件更新
         *
         * @param request EmployeeAttachmentUpdateRequest
         * @return EmployeeAttachmentUpdateResponse
         */
        public async Task<EmployeeAttachmentUpdateResponse> EmployeeAttachmentUpdateAsync(EmployeeAttachmentUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EmployeeAttachmentUpdateHeaders headers = new EmployeeAttachmentUpdateHeaders();
            return await EmployeeAttachmentUpdateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 人事高级合同管理回退
         *
         * @param request EsignRollbackRequest
         * @param headers EsignRollbackHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return EsignRollbackResponse
         */
        public EsignRollbackResponse EsignRollbackWithOptions(EsignRollbackRequest request, EsignRollbackHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "EsignRollback",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/contracts/esign/rollback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignRollbackResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 人事高级合同管理回退
         *
         * @param request EsignRollbackRequest
         * @param headers EsignRollbackHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return EsignRollbackResponse
         */
        public async Task<EsignRollbackResponse> EsignRollbackWithOptionsAsync(EsignRollbackRequest request, EsignRollbackHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "EsignRollback",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/contracts/esign/rollback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignRollbackResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 人事高级合同管理回退
         *
         * @param request EsignRollbackRequest
         * @return EsignRollbackResponse
         */
        public EsignRollbackResponse EsignRollback(EsignRollbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignRollbackHeaders headers = new EsignRollbackHeaders();
            return EsignRollbackWithOptions(request, headers, runtime);
        }

        /**
         * @summary 人事高级合同管理回退
         *
         * @param request EsignRollbackRequest
         * @return EsignRollbackResponse
         */
        public async Task<EsignRollbackResponse> EsignRollbackAsync(EsignRollbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignRollbackHeaders headers = new EsignRollbackHeaders();
            return await EsignRollbackWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取员工花名册指定字段的信息，支持明细分组字段
         *
         * @param request GetEmployeeRosterByFieldRequest
         * @param headers GetEmployeeRosterByFieldHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEmployeeRosterByFieldResponse
         */
        public GetEmployeeRosterByFieldResponse GetEmployeeRosterByFieldWithOptions(GetEmployeeRosterByFieldRequest request, GetEmployeeRosterByFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppAgentId))
            {
                body["appAgentId"] = request.AppAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldFilterList))
            {
                body["fieldFilterList"] = request.FieldFilterList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text2SelectConvert))
            {
                body["text2SelectConvert"] = request.Text2SelectConvert;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmployeeRosterByField",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/rosters/lists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmployeeRosterByFieldResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取员工花名册指定字段的信息，支持明细分组字段
         *
         * @param request GetEmployeeRosterByFieldRequest
         * @param headers GetEmployeeRosterByFieldHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEmployeeRosterByFieldResponse
         */
        public async Task<GetEmployeeRosterByFieldResponse> GetEmployeeRosterByFieldWithOptionsAsync(GetEmployeeRosterByFieldRequest request, GetEmployeeRosterByFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppAgentId))
            {
                body["appAgentId"] = request.AppAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldFilterList))
            {
                body["fieldFilterList"] = request.FieldFilterList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text2SelectConvert))
            {
                body["text2SelectConvert"] = request.Text2SelectConvert;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmployeeRosterByField",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/rosters/lists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmployeeRosterByFieldResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取员工花名册指定字段的信息，支持明细分组字段
         *
         * @param request GetEmployeeRosterByFieldRequest
         * @return GetEmployeeRosterByFieldResponse
         */
        public GetEmployeeRosterByFieldResponse GetEmployeeRosterByField(GetEmployeeRosterByFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmployeeRosterByFieldHeaders headers = new GetEmployeeRosterByFieldHeaders();
            return GetEmployeeRosterByFieldWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取员工花名册指定字段的信息，支持明细分组字段
         *
         * @param request GetEmployeeRosterByFieldRequest
         * @return GetEmployeeRosterByFieldResponse
         */
        public async Task<GetEmployeeRosterByFieldResponse> GetEmployeeRosterByFieldAsync(GetEmployeeRosterByFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmployeeRosterByFieldHeaders headers = new GetEmployeeRosterByFieldHeaders();
            return await GetEmployeeRosterByFieldWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询文件模板列表及文件模板内花名册字段
         *
         * @param request GetFileTemplateListRequest
         * @param headers GetFileTemplateListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileTemplateListResponse
         */
        public GetFileTemplateListResponse GetFileTemplateListWithOptions(GetFileTemplateListRequest request, GetFileTemplateListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignSource))
            {
                body["signSource"] = request.SignSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateStatus))
            {
                body["templateStatus"] = request.TemplateStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateTypeList))
            {
                body["templateTypeList"] = request.TemplateTypeList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetFileTemplateList",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/fileTemplates/lists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileTemplateListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询文件模板列表及文件模板内花名册字段
         *
         * @param request GetFileTemplateListRequest
         * @param headers GetFileTemplateListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileTemplateListResponse
         */
        public async Task<GetFileTemplateListResponse> GetFileTemplateListWithOptionsAsync(GetFileTemplateListRequest request, GetFileTemplateListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignSource))
            {
                body["signSource"] = request.SignSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateStatus))
            {
                body["templateStatus"] = request.TemplateStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateTypeList))
            {
                body["templateTypeList"] = request.TemplateTypeList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetFileTemplateList",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/fileTemplates/lists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileTemplateListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询文件模板列表及文件模板内花名册字段
         *
         * @param request GetFileTemplateListRequest
         * @return GetFileTemplateListResponse
         */
        public GetFileTemplateListResponse GetFileTemplateList(GetFileTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileTemplateListHeaders headers = new GetFileTemplateListHeaders();
            return GetFileTemplateListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询文件模板列表及文件模板内花名册字段
         *
         * @param request GetFileTemplateListRequest
         * @return GetFileTemplateListResponse
         */
        public async Task<GetFileTemplateListResponse> GetFileTemplateListAsync(GetFileTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileTemplateListHeaders headers = new GetFileTemplateListHeaders();
            return await GetFileTemplateListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通过签署记录id查询指定的电子签署记录
         *
         * @param request GetSignRecordByIdRequest
         * @param headers GetSignRecordByIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSignRecordByIdResponse
         */
        public GetSignRecordByIdResponse GetSignRecordByIdWithOptions(GetSignRecordByIdRequest request, GetSignRecordByIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSignRecordById",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/signCenters/records/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignRecordByIdResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通过签署记录id查询指定的电子签署记录
         *
         * @param request GetSignRecordByIdRequest
         * @param headers GetSignRecordByIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSignRecordByIdResponse
         */
        public async Task<GetSignRecordByIdResponse> GetSignRecordByIdWithOptionsAsync(GetSignRecordByIdRequest request, GetSignRecordByIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSignRecordById",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/signCenters/records/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignRecordByIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通过签署记录id查询指定的电子签署记录
         *
         * @param request GetSignRecordByIdRequest
         * @return GetSignRecordByIdResponse
         */
        public GetSignRecordByIdResponse GetSignRecordById(GetSignRecordByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignRecordByIdHeaders headers = new GetSignRecordByIdHeaders();
            return GetSignRecordByIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通过签署记录id查询指定的电子签署记录
         *
         * @param request GetSignRecordByIdRequest
         * @return GetSignRecordByIdResponse
         */
        public async Task<GetSignRecordByIdResponse> GetSignRecordByIdAsync(GetSignRecordByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignRecordByIdHeaders headers = new GetSignRecordByIdHeaders();
            return await GetSignRecordByIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询指定用户的电子签署记录，并返回签署记录的基本数据及已签署完成的文件预览地址
         *
         * @param request GetSignRecordByUserIdRequest
         * @param headers GetSignRecordByUserIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSignRecordByUserIdResponse
         */
        public GetSignRecordByUserIdResponse GetSignRecordByUserIdWithOptions(GetSignRecordByUserIdRequest request, GetSignRecordByUserIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignStatus))
            {
                body["signStatus"] = request.SignStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignUserId))
            {
                body["signUserId"] = request.SignUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetSignRecordByUserId",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/signCenters/users/records/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignRecordByUserIdResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询指定用户的电子签署记录，并返回签署记录的基本数据及已签署完成的文件预览地址
         *
         * @param request GetSignRecordByUserIdRequest
         * @param headers GetSignRecordByUserIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSignRecordByUserIdResponse
         */
        public async Task<GetSignRecordByUserIdResponse> GetSignRecordByUserIdWithOptionsAsync(GetSignRecordByUserIdRequest request, GetSignRecordByUserIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignStatus))
            {
                body["signStatus"] = request.SignStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignUserId))
            {
                body["signUserId"] = request.SignUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetSignRecordByUserId",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/signCenters/users/records/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignRecordByUserIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询指定用户的电子签署记录，并返回签署记录的基本数据及已签署完成的文件预览地址
         *
         * @param request GetSignRecordByUserIdRequest
         * @return GetSignRecordByUserIdResponse
         */
        public GetSignRecordByUserIdResponse GetSignRecordByUserId(GetSignRecordByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignRecordByUserIdHeaders headers = new GetSignRecordByUserIdHeaders();
            return GetSignRecordByUserIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询指定用户的电子签署记录，并返回签署记录的基本数据及已签署完成的文件预览地址
         *
         * @param request GetSignRecordByUserIdRequest
         * @return GetSignRecordByUserIdResponse
         */
        public async Task<GetSignRecordByUserIdResponse> GetSignRecordByUserIdAsync(GetSignRecordByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignRecordByUserIdHeaders headers = new GetSignRecordByUserIdHeaders();
            return await GetSignRecordByUserIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事权限查询
         *
         * @param request HrmAuthResourcesQueryRequest
         * @param headers HrmAuthResourcesQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmAuthResourcesQueryResponse
         */
        public HrmAuthResourcesQueryResponse HrmAuthResourcesQueryWithOptions(HrmAuthResourcesQueryRequest request, HrmAuthResourcesQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthResourceIds))
            {
                body["authResourceIds"] = request.AuthResourceIds;
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
                Action = "HrmAuthResourcesQuery",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/authResources/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmAuthResourcesQueryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事权限查询
         *
         * @param request HrmAuthResourcesQueryRequest
         * @param headers HrmAuthResourcesQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmAuthResourcesQueryResponse
         */
        public async Task<HrmAuthResourcesQueryResponse> HrmAuthResourcesQueryWithOptionsAsync(HrmAuthResourcesQueryRequest request, HrmAuthResourcesQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthResourceIds))
            {
                body["authResourceIds"] = request.AuthResourceIds;
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
                Action = "HrmAuthResourcesQuery",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/authResources/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmAuthResourcesQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事权限查询
         *
         * @param request HrmAuthResourcesQueryRequest
         * @return HrmAuthResourcesQueryResponse
         */
        public HrmAuthResourcesQueryResponse HrmAuthResourcesQuery(HrmAuthResourcesQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmAuthResourcesQueryHeaders headers = new HrmAuthResourcesQueryHeaders();
            return HrmAuthResourcesQueryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事权限查询
         *
         * @param request HrmAuthResourcesQueryRequest
         * @return HrmAuthResourcesQueryResponse
         */
        public async Task<HrmAuthResourcesQueryResponse> HrmAuthResourcesQueryAsync(HrmAuthResourcesQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmAuthResourcesQueryHeaders headers = new HrmAuthResourcesQueryHeaders();
            return await HrmAuthResourcesQueryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事权益查询
         *
         * @param request HrmBenefitQueryRequest
         * @param headers HrmBenefitQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmBenefitQueryResponse
         */
        public HrmBenefitQueryResponse HrmBenefitQueryWithOptions(HrmBenefitQueryRequest request, HrmBenefitQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCodes))
            {
                body["benefitCodes"] = request.BenefitCodes;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "HrmBenefitQuery",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/benefits/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmBenefitQueryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事权益查询
         *
         * @param request HrmBenefitQueryRequest
         * @param headers HrmBenefitQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmBenefitQueryResponse
         */
        public async Task<HrmBenefitQueryResponse> HrmBenefitQueryWithOptionsAsync(HrmBenefitQueryRequest request, HrmBenefitQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCodes))
            {
                body["benefitCodes"] = request.BenefitCodes;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "HrmBenefitQuery",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/benefits/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmBenefitQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事权益查询
         *
         * @param request HrmBenefitQueryRequest
         * @return HrmBenefitQueryResponse
         */
        public HrmBenefitQueryResponse HrmBenefitQuery(HrmBenefitQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmBenefitQueryHeaders headers = new HrmBenefitQueryHeaders();
            return HrmBenefitQueryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事权益查询
         *
         * @param request HrmBenefitQueryRequest
         * @return HrmBenefitQueryResponse
         */
        public async Task<HrmBenefitQueryResponse> HrmBenefitQueryAsync(HrmBenefitQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmBenefitQueryHeaders headers = new HrmBenefitQueryHeaders();
            return await HrmBenefitQueryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询企业配置信息
         *
         * @param request HrmCorpConfigQueryRequest
         * @param headers HrmCorpConfigQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmCorpConfigQueryResponse
         */
        public HrmCorpConfigQueryResponse HrmCorpConfigQueryWithOptions(HrmCorpConfigQueryRequest request, HrmCorpConfigQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubType))
            {
                body["subType"] = request.SubType;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrmCorpConfigQuery",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/corp/configs/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmCorpConfigQueryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询企业配置信息
         *
         * @param request HrmCorpConfigQueryRequest
         * @param headers HrmCorpConfigQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmCorpConfigQueryResponse
         */
        public async Task<HrmCorpConfigQueryResponse> HrmCorpConfigQueryWithOptionsAsync(HrmCorpConfigQueryRequest request, HrmCorpConfigQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubType))
            {
                body["subType"] = request.SubType;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrmCorpConfigQuery",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/corp/configs/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmCorpConfigQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询企业配置信息
         *
         * @param request HrmCorpConfigQueryRequest
         * @return HrmCorpConfigQueryResponse
         */
        public HrmCorpConfigQueryResponse HrmCorpConfigQuery(HrmCorpConfigQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmCorpConfigQueryHeaders headers = new HrmCorpConfigQueryHeaders();
            return HrmCorpConfigQueryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询企业配置信息
         *
         * @param request HrmCorpConfigQueryRequest
         * @return HrmCorpConfigQueryResponse
         */
        public async Task<HrmCorpConfigQueryResponse> HrmCorpConfigQueryAsync(HrmCorpConfigQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmCorpConfigQueryHeaders headers = new HrmCorpConfigQueryHeaders();
            return await HrmCorpConfigQueryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事邮件发送
         *
         * @param request HrmMailSendRequest
         * @param headers HrmMailSendHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmMailSendResponse
         */
        public HrmMailSendResponse HrmMailSendWithOptions(HrmMailSendRequest request, HrmMailSendHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mail))
            {
                body["mail"] = request.Mail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "HrmMailSend",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/mails/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmMailSendResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事邮件发送
         *
         * @param request HrmMailSendRequest
         * @param headers HrmMailSendHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmMailSendResponse
         */
        public async Task<HrmMailSendResponse> HrmMailSendWithOptionsAsync(HrmMailSendRequest request, HrmMailSendHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mail))
            {
                body["mail"] = request.Mail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "HrmMailSend",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/mails/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmMailSendResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事邮件发送
         *
         * @param request HrmMailSendRequest
         * @return HrmMailSendResponse
         */
        public HrmMailSendResponse HrmMailSend(HrmMailSendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmMailSendHeaders headers = new HrmMailSendHeaders();
            return HrmMailSendWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事邮件发送
         *
         * @param request HrmMailSendRequest
         * @return HrmMailSendResponse
         */
        public async Task<HrmMailSendResponse> HrmMailSendAsync(HrmMailSendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmMailSendHeaders headers = new HrmMailSendHeaders();
            return await HrmMailSendWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 人事2.0支持Moka事件转发
         *
         * @param request HrmMokaEventRequest
         * @param headers HrmMokaEventHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmMokaEventResponse
         */
        public HrmMokaEventResponse HrmMokaEventWithOptions(HrmMokaEventRequest request, HrmMokaEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "HrmMokaEvent",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/moka/events/forward",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmMokaEventResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 人事2.0支持Moka事件转发
         *
         * @param request HrmMokaEventRequest
         * @param headers HrmMokaEventHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmMokaEventResponse
         */
        public async Task<HrmMokaEventResponse> HrmMokaEventWithOptionsAsync(HrmMokaEventRequest request, HrmMokaEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "HrmMokaEvent",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/moka/events/forward",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmMokaEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 人事2.0支持Moka事件转发
         *
         * @param request HrmMokaEventRequest
         * @return HrmMokaEventResponse
         */
        public HrmMokaEventResponse HrmMokaEvent(HrmMokaEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmMokaEventHeaders headers = new HrmMokaEventHeaders();
            return HrmMokaEventWithOptions(request, headers, runtime);
        }

        /**
         * @summary 人事2.0支持Moka事件转发
         *
         * @param request HrmMokaEventRequest
         * @return HrmMokaEventResponse
         */
        public async Task<HrmMokaEventResponse> HrmMokaEventAsync(HrmMokaEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmMokaEventHeaders headers = new HrmMokaEventHeaders();
            return await HrmMokaEventWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 人事2.0支持Moka接口转发
         *
         * @param request HrmMokaOapiRequest
         * @param headers HrmMokaOapiHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmMokaOapiResponse
         */
        public HrmMokaOapiResponse HrmMokaOapiWithOptions(HrmMokaOapiRequest request, HrmMokaOapiHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiCode))
            {
                body["apiCode"] = request.ApiCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "HrmMokaOapi",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/moka/forward",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmMokaOapiResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 人事2.0支持Moka接口转发
         *
         * @param request HrmMokaOapiRequest
         * @param headers HrmMokaOapiHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmMokaOapiResponse
         */
        public async Task<HrmMokaOapiResponse> HrmMokaOapiWithOptionsAsync(HrmMokaOapiRequest request, HrmMokaOapiHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiCode))
            {
                body["apiCode"] = request.ApiCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "HrmMokaOapi",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/moka/forward",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmMokaOapiResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 人事2.0支持Moka接口转发
         *
         * @param request HrmMokaOapiRequest
         * @return HrmMokaOapiResponse
         */
        public HrmMokaOapiResponse HrmMokaOapi(HrmMokaOapiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmMokaOapiHeaders headers = new HrmMokaOapiHeaders();
            return HrmMokaOapiWithOptions(request, headers, runtime);
        }

        /**
         * @summary 人事2.0支持Moka接口转发
         *
         * @param request HrmMokaOapiRequest
         * @return HrmMokaOapiResponse
         */
        public async Task<HrmMokaOapiResponse> HrmMokaOapiAsync(HrmMokaOapiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmMokaOapiHeaders headers = new HrmMokaOapiHeaders();
            return await HrmMokaOapiWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事转正接口
         *
         * @param request HrmProcessRegularRequest
         * @param headers HrmProcessRegularHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmProcessRegularResponse
         */
        public HrmProcessRegularResponse HrmProcessRegularWithOptions(HrmProcessRegularRequest request, HrmProcessRegularHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationId))
            {
                body["operationId"] = request.OperationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegularDate))
            {
                body["regularDate"] = request.RegularDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
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
                Action = "HrmProcessRegular",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/processes/regulars/become",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmProcessRegularResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事转正接口
         *
         * @param request HrmProcessRegularRequest
         * @param headers HrmProcessRegularHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmProcessRegularResponse
         */
        public async Task<HrmProcessRegularResponse> HrmProcessRegularWithOptionsAsync(HrmProcessRegularRequest request, HrmProcessRegularHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationId))
            {
                body["operationId"] = request.OperationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegularDate))
            {
                body["regularDate"] = request.RegularDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
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
                Action = "HrmProcessRegular",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/processes/regulars/become",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmProcessRegularResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事转正接口
         *
         * @param request HrmProcessRegularRequest
         * @return HrmProcessRegularResponse
         */
        public HrmProcessRegularResponse HrmProcessRegular(HrmProcessRegularRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmProcessRegularHeaders headers = new HrmProcessRegularHeaders();
            return HrmProcessRegularWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事转正接口
         *
         * @param request HrmProcessRegularRequest
         * @return HrmProcessRegularResponse
         */
        public async Task<HrmProcessRegularResponse> HrmProcessRegularAsync(HrmProcessRegularRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmProcessRegularHeaders headers = new HrmProcessRegularHeaders();
            return await HrmProcessRegularWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事离职和交接接口
         *
         * @param request HrmProcessTerminationAndHandoverRequest
         * @param headers HrmProcessTerminationAndHandoverHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmProcessTerminationAndHandoverResponse
         */
        public HrmProcessTerminationAndHandoverResponse HrmProcessTerminationAndHandoverWithOptions(HrmProcessTerminationAndHandoverRequest request, HrmProcessTerminationAndHandoverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AflowHandOverUserId))
            {
                body["aflowHandOverUserId"] = request.AflowHandOverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingPanHandoverUserId))
            {
                body["dingPanHandoverUserId"] = request.DingPanHandoverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectSubordinatesHandoverUserId))
            {
                body["directSubordinatesHandoverUserId"] = request.DirectSubordinatesHandoverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DismissionMemo))
            {
                body["dismissionMemo"] = request.DismissionMemo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DismissionReason))
            {
                body["dismissionReason"] = request.DismissionReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocNoteHandoverUserId))
            {
                body["docNoteHandoverUserId"] = request.DocNoteHandoverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastWorkDate))
            {
                body["lastWorkDate"] = request.LastWorkDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionHandoverUserId))
            {
                body["permissionHandoverUserId"] = request.PermissionHandoverUserId;
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
                Action = "HrmProcessTerminationAndHandover",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/processes/terminateAndHandOver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmProcessTerminationAndHandoverResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事离职和交接接口
         *
         * @param request HrmProcessTerminationAndHandoverRequest
         * @param headers HrmProcessTerminationAndHandoverHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmProcessTerminationAndHandoverResponse
         */
        public async Task<HrmProcessTerminationAndHandoverResponse> HrmProcessTerminationAndHandoverWithOptionsAsync(HrmProcessTerminationAndHandoverRequest request, HrmProcessTerminationAndHandoverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AflowHandOverUserId))
            {
                body["aflowHandOverUserId"] = request.AflowHandOverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingPanHandoverUserId))
            {
                body["dingPanHandoverUserId"] = request.DingPanHandoverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectSubordinatesHandoverUserId))
            {
                body["directSubordinatesHandoverUserId"] = request.DirectSubordinatesHandoverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DismissionMemo))
            {
                body["dismissionMemo"] = request.DismissionMemo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DismissionReason))
            {
                body["dismissionReason"] = request.DismissionReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocNoteHandoverUserId))
            {
                body["docNoteHandoverUserId"] = request.DocNoteHandoverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastWorkDate))
            {
                body["lastWorkDate"] = request.LastWorkDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionHandoverUserId))
            {
                body["permissionHandoverUserId"] = request.PermissionHandoverUserId;
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
                Action = "HrmProcessTerminationAndHandover",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/processes/terminateAndHandOver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmProcessTerminationAndHandoverResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事离职和交接接口
         *
         * @param request HrmProcessTerminationAndHandoverRequest
         * @return HrmProcessTerminationAndHandoverResponse
         */
        public HrmProcessTerminationAndHandoverResponse HrmProcessTerminationAndHandover(HrmProcessTerminationAndHandoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmProcessTerminationAndHandoverHeaders headers = new HrmProcessTerminationAndHandoverHeaders();
            return HrmProcessTerminationAndHandoverWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事离职和交接接口
         *
         * @param request HrmProcessTerminationAndHandoverRequest
         * @return HrmProcessTerminationAndHandoverResponse
         */
        public async Task<HrmProcessTerminationAndHandoverResponse> HrmProcessTerminationAndHandoverAsync(HrmProcessTerminationAndHandoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmProcessTerminationAndHandoverHeaders headers = new HrmProcessTerminationAndHandoverHeaders();
            return await HrmProcessTerminationAndHandoverWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事调岗接口
         *
         * @param request HrmProcessTransferRequest
         * @param headers HrmProcessTransferHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmProcessTransferResponse
         */
        public HrmProcessTransferResponse HrmProcessTransferWithOptions(HrmProcessTransferRequest request, HrmProcessTransferHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIdsAfterTransfer))
            {
                body["deptIdsAfterTransfer"] = request.DeptIdsAfterTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdAfterTransfer))
            {
                body["jobIdAfterTransfer"] = request.JobIdAfterTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainDeptIdAfterTransfer))
            {
                body["mainDeptIdAfterTransfer"] = request.MainDeptIdAfterTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                body["operateUserId"] = request.OperateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PositionIdAfterTransfer))
            {
                body["positionIdAfterTransfer"] = request.PositionIdAfterTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PositionLevelAfterTransfer))
            {
                body["positionLevelAfterTransfer"] = request.PositionLevelAfterTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PositionNameAfterTransfer))
            {
                body["positionNameAfterTransfer"] = request.PositionNameAfterTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankIdAfterTransfer))
            {
                body["rankIdAfterTransfer"] = request.RankIdAfterTransfer;
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
                Action = "HrmProcessTransfer",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/processes/transfer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmProcessTransferResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事调岗接口
         *
         * @param request HrmProcessTransferRequest
         * @param headers HrmProcessTransferHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmProcessTransferResponse
         */
        public async Task<HrmProcessTransferResponse> HrmProcessTransferWithOptionsAsync(HrmProcessTransferRequest request, HrmProcessTransferHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIdsAfterTransfer))
            {
                body["deptIdsAfterTransfer"] = request.DeptIdsAfterTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdAfterTransfer))
            {
                body["jobIdAfterTransfer"] = request.JobIdAfterTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainDeptIdAfterTransfer))
            {
                body["mainDeptIdAfterTransfer"] = request.MainDeptIdAfterTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                body["operateUserId"] = request.OperateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PositionIdAfterTransfer))
            {
                body["positionIdAfterTransfer"] = request.PositionIdAfterTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PositionLevelAfterTransfer))
            {
                body["positionLevelAfterTransfer"] = request.PositionLevelAfterTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PositionNameAfterTransfer))
            {
                body["positionNameAfterTransfer"] = request.PositionNameAfterTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankIdAfterTransfer))
            {
                body["rankIdAfterTransfer"] = request.RankIdAfterTransfer;
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
                Action = "HrmProcessTransfer",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/processes/transfer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmProcessTransferResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事调岗接口
         *
         * @param request HrmProcessTransferRequest
         * @return HrmProcessTransferResponse
         */
        public HrmProcessTransferResponse HrmProcessTransfer(HrmProcessTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmProcessTransferHeaders headers = new HrmProcessTransferHeaders();
            return HrmProcessTransferWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事调岗接口
         *
         * @param request HrmProcessTransferRequest
         * @return HrmProcessTransferResponse
         */
        public async Task<HrmProcessTransferResponse> HrmProcessTransferAsync(HrmProcessTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmProcessTransferHeaders headers = new HrmProcessTransferHeaders();
            return await HrmProcessTransferWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 修改员工最后一次离职信息
         *
         * @param request HrmProcessUpdateTerminationInfoRequest
         * @param headers HrmProcessUpdateTerminationInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmProcessUpdateTerminationInfoResponse
         */
        public HrmProcessUpdateTerminationInfoResponse HrmProcessUpdateTerminationInfoWithOptions(HrmProcessUpdateTerminationInfoRequest request, HrmProcessUpdateTerminationInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DismissionMemo))
            {
                body["dismissionMemo"] = request.DismissionMemo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastWorkDate))
            {
                body["lastWorkDate"] = request.LastWorkDate;
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
                Action = "HrmProcessUpdateTerminationInfo",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/processes/employees/terminations",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmProcessUpdateTerminationInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 修改员工最后一次离职信息
         *
         * @param request HrmProcessUpdateTerminationInfoRequest
         * @param headers HrmProcessUpdateTerminationInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmProcessUpdateTerminationInfoResponse
         */
        public async Task<HrmProcessUpdateTerminationInfoResponse> HrmProcessUpdateTerminationInfoWithOptionsAsync(HrmProcessUpdateTerminationInfoRequest request, HrmProcessUpdateTerminationInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DismissionMemo))
            {
                body["dismissionMemo"] = request.DismissionMemo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastWorkDate))
            {
                body["lastWorkDate"] = request.LastWorkDate;
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
                Action = "HrmProcessUpdateTerminationInfo",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/processes/employees/terminations",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmProcessUpdateTerminationInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 修改员工最后一次离职信息
         *
         * @param request HrmProcessUpdateTerminationInfoRequest
         * @return HrmProcessUpdateTerminationInfoResponse
         */
        public HrmProcessUpdateTerminationInfoResponse HrmProcessUpdateTerminationInfo(HrmProcessUpdateTerminationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmProcessUpdateTerminationInfoHeaders headers = new HrmProcessUpdateTerminationInfoHeaders();
            return HrmProcessUpdateTerminationInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 修改员工最后一次离职信息
         *
         * @param request HrmProcessUpdateTerminationInfoRequest
         * @return HrmProcessUpdateTerminationInfoResponse
         */
        public async Task<HrmProcessUpdateTerminationInfoResponse> HrmProcessUpdateTerminationInfoAsync(HrmProcessUpdateTerminationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmProcessUpdateTerminationInfoHeaders headers = new HrmProcessUpdateTerminationInfoHeaders();
            return await HrmProcessUpdateTerminationInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事pts能力调用
         *
         * @param request HrmPtsServiceRequest
         * @param headers HrmPtsServiceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmPtsServiceResponse
         */
        public HrmPtsServiceResponse HrmPtsServiceWithOptions(HrmPtsServiceRequest request, HrmPtsServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                body["env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                body["outerId"] = request.OuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["path"] = request.Path;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "HrmPtsService",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/pts/request",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmPtsServiceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事pts能力调用
         *
         * @param request HrmPtsServiceRequest
         * @param headers HrmPtsServiceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HrmPtsServiceResponse
         */
        public async Task<HrmPtsServiceResponse> HrmPtsServiceWithOptionsAsync(HrmPtsServiceRequest request, HrmPtsServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                body["env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                body["outerId"] = request.OuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["path"] = request.Path;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "HrmPtsService",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/pts/request",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrmPtsServiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事pts能力调用
         *
         * @param request HrmPtsServiceRequest
         * @return HrmPtsServiceResponse
         */
        public HrmPtsServiceResponse HrmPtsService(HrmPtsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmPtsServiceHeaders headers = new HrmPtsServiceHeaders();
            return HrmPtsServiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事pts能力调用
         *
         * @param request HrmPtsServiceRequest
         * @return HrmPtsServiceResponse
         */
        public async Task<HrmPtsServiceResponse> HrmPtsServiceAsync(HrmPtsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrmPtsServiceHeaders headers = new HrmPtsServiceHeaders();
            return await HrmPtsServiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 作废签署记录
         *
         * @param request InvalidSignRecordsRequest
         * @param headers InvalidSignRecordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InvalidSignRecordsResponse
         */
        public InvalidSignRecordsResponse InvalidSignRecordsWithOptions(InvalidSignRecordsRequest request, InvalidSignRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvalidUserId))
            {
                body["invalidUserId"] = request.InvalidUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignRecordIds))
            {
                body["signRecordIds"] = request.SignRecordIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusRemark))
            {
                body["statusRemark"] = request.StatusRemark;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "InvalidSignRecords",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/signCenters/records/invalid",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvalidSignRecordsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 作废签署记录
         *
         * @param request InvalidSignRecordsRequest
         * @param headers InvalidSignRecordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InvalidSignRecordsResponse
         */
        public async Task<InvalidSignRecordsResponse> InvalidSignRecordsWithOptionsAsync(InvalidSignRecordsRequest request, InvalidSignRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvalidUserId))
            {
                body["invalidUserId"] = request.InvalidUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignRecordIds))
            {
                body["signRecordIds"] = request.SignRecordIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusRemark))
            {
                body["statusRemark"] = request.StatusRemark;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "InvalidSignRecords",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/signCenters/records/invalid",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvalidSignRecordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 作废签署记录
         *
         * @param request InvalidSignRecordsRequest
         * @return InvalidSignRecordsResponse
         */
        public InvalidSignRecordsResponse InvalidSignRecords(InvalidSignRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvalidSignRecordsHeaders headers = new InvalidSignRecordsHeaders();
            return InvalidSignRecordsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 作废签署记录
         *
         * @param request InvalidSignRecordsRequest
         * @return InvalidSignRecordsResponse
         */
        public async Task<InvalidSignRecordsResponse> InvalidSignRecordsAsync(InvalidSignRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvalidSignRecordsHeaders headers = new InvalidSignRecordsHeaders();
            return await InvalidSignRecordsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事主数据删除服务
         *
         * @param request MasterDataDeleteRequest
         * @param headers MasterDataDeleteHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MasterDataDeleteResponse
         */
        public MasterDataDeleteResponse MasterDataDeleteWithOptions(MasterDataDeleteRequest request, MasterDataDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MasterDataDelete",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/datas/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MasterDataDeleteResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事主数据删除服务
         *
         * @param request MasterDataDeleteRequest
         * @param headers MasterDataDeleteHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MasterDataDeleteResponse
         */
        public async Task<MasterDataDeleteResponse> MasterDataDeleteWithOptionsAsync(MasterDataDeleteRequest request, MasterDataDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MasterDataDelete",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/datas/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MasterDataDeleteResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事主数据删除服务
         *
         * @param request MasterDataDeleteRequest
         * @return MasterDataDeleteResponse
         */
        public MasterDataDeleteResponse MasterDataDelete(MasterDataDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MasterDataDeleteHeaders headers = new MasterDataDeleteHeaders();
            return MasterDataDeleteWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事主数据删除服务
         *
         * @param request MasterDataDeleteRequest
         * @return MasterDataDeleteResponse
         */
        public async Task<MasterDataDeleteResponse> MasterDataDeleteAsync(MasterDataDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MasterDataDeleteHeaders headers = new MasterDataDeleteHeaders();
            return await MasterDataDeleteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事主数据查询服务
         *
         * @param request MasterDataQueryRequest
         * @param headers MasterDataQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MasterDataQueryResponse
         */
        public MasterDataQueryResponse MasterDataQueryWithOptions(MasterDataQueryRequest request, MasterDataQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUK))
            {
                body["bizUK"] = request.BizUK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryParams))
            {
                body["queryParams"] = request.QueryParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationIds))
            {
                body["relationIds"] = request.RelationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeCode))
            {
                body["scopeCode"] = request.ScopeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewEntityCode))
            {
                body["viewEntityCode"] = request.ViewEntityCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "MasterDataQuery",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/datas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MasterDataQueryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事主数据查询服务
         *
         * @param request MasterDataQueryRequest
         * @param headers MasterDataQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MasterDataQueryResponse
         */
        public async Task<MasterDataQueryResponse> MasterDataQueryWithOptionsAsync(MasterDataQueryRequest request, MasterDataQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUK))
            {
                body["bizUK"] = request.BizUK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryParams))
            {
                body["queryParams"] = request.QueryParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationIds))
            {
                body["relationIds"] = request.RelationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeCode))
            {
                body["scopeCode"] = request.ScopeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewEntityCode))
            {
                body["viewEntityCode"] = request.ViewEntityCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "MasterDataQuery",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/datas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MasterDataQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事主数据查询服务
         *
         * @param request MasterDataQueryRequest
         * @return MasterDataQueryResponse
         */
        public MasterDataQueryResponse MasterDataQuery(MasterDataQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MasterDataQueryHeaders headers = new MasterDataQueryHeaders();
            return MasterDataQueryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事主数据查询服务
         *
         * @param request MasterDataQueryRequest
         * @return MasterDataQueryResponse
         */
        public async Task<MasterDataQueryResponse> MasterDataQueryAsync(MasterDataQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MasterDataQueryHeaders headers = new MasterDataQueryHeaders();
            return await MasterDataQueryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事主数据保存服务
         *
         * @param request MasterDataSaveRequest
         * @param headers MasterDataSaveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MasterDataSaveResponse
         */
        public MasterDataSaveResponse MasterDataSaveWithOptions(MasterDataSaveRequest request, MasterDataSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MasterDataSave",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/datas/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MasterDataSaveResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事主数据保存服务
         *
         * @param request MasterDataSaveRequest
         * @param headers MasterDataSaveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MasterDataSaveResponse
         */
        public async Task<MasterDataSaveResponse> MasterDataSaveWithOptionsAsync(MasterDataSaveRequest request, MasterDataSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MasterDataSave",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/datas/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MasterDataSaveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事主数据保存服务
         *
         * @param request MasterDataSaveRequest
         * @return MasterDataSaveResponse
         */
        public MasterDataSaveResponse MasterDataSave(MasterDataSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MasterDataSaveHeaders headers = new MasterDataSaveHeaders();
            return MasterDataSaveWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事主数据保存服务
         *
         * @param request MasterDataSaveRequest
         * @return MasterDataSaveResponse
         */
        public async Task<MasterDataSaveResponse> MasterDataSaveAsync(MasterDataSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MasterDataSaveHeaders headers = new MasterDataSaveHeaders();
            return await MasterDataSaveWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 主数据中拥有某个领域数据的租户信息查询
         *
         * @param request MasterDataTenantQueyRequest
         * @param headers MasterDataTenantQueyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MasterDataTenantQueyResponse
         */
        public MasterDataTenantQueyResponse MasterDataTenantQueyWithOptions(MasterDataTenantQueyRequest request, MasterDataTenantQueyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityCode))
            {
                query["entityCode"] = request.EntityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeCode))
            {
                query["scopeCode"] = request.ScopeCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "MasterDataTenantQuey",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/tenants",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MasterDataTenantQueyResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 主数据中拥有某个领域数据的租户信息查询
         *
         * @param request MasterDataTenantQueyRequest
         * @param headers MasterDataTenantQueyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MasterDataTenantQueyResponse
         */
        public async Task<MasterDataTenantQueyResponse> MasterDataTenantQueyWithOptionsAsync(MasterDataTenantQueyRequest request, MasterDataTenantQueyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityCode))
            {
                query["entityCode"] = request.EntityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeCode))
            {
                query["scopeCode"] = request.ScopeCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "MasterDataTenantQuey",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/tenants",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MasterDataTenantQueyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 主数据中拥有某个领域数据的租户信息查询
         *
         * @param request MasterDataTenantQueyRequest
         * @return MasterDataTenantQueyResponse
         */
        public MasterDataTenantQueyResponse MasterDataTenantQuey(MasterDataTenantQueyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MasterDataTenantQueyHeaders headers = new MasterDataTenantQueyHeaders();
            return MasterDataTenantQueyWithOptions(request, headers, runtime);
        }

        /**
         * @summary 主数据中拥有某个领域数据的租户信息查询
         *
         * @param request MasterDataTenantQueyRequest
         * @return MasterDataTenantQueyResponse
         */
        public async Task<MasterDataTenantQueyResponse> MasterDataTenantQueyAsync(MasterDataTenantQueyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MasterDataTenantQueyHeaders headers = new MasterDataTenantQueyHeaders();
            return await MasterDataTenantQueyWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事主数据根据ID获取
         *
         * @param request MasterDatasGetRequest
         * @param headers MasterDatasGetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MasterDatasGetResponse
         */
        public MasterDatasGetResponse MasterDatasGetWithOptions(MasterDatasGetRequest request, MasterDatasGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjId))
            {
                body["objId"] = request.ObjId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeCode))
            {
                body["scopeCode"] = request.ScopeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewEntityCode))
            {
                body["viewEntityCode"] = request.ViewEntityCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "MasterDatasGet",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masterDatas/objects/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MasterDatasGetResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事主数据根据ID获取
         *
         * @param request MasterDatasGetRequest
         * @param headers MasterDatasGetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MasterDatasGetResponse
         */
        public async Task<MasterDatasGetResponse> MasterDatasGetWithOptionsAsync(MasterDatasGetRequest request, MasterDatasGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjId))
            {
                body["objId"] = request.ObjId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeCode))
            {
                body["scopeCode"] = request.ScopeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewEntityCode))
            {
                body["viewEntityCode"] = request.ViewEntityCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "MasterDatasGet",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masterDatas/objects/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MasterDatasGetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事主数据根据ID获取
         *
         * @param request MasterDatasGetRequest
         * @return MasterDatasGetResponse
         */
        public MasterDatasGetResponse MasterDatasGet(MasterDatasGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MasterDatasGetHeaders headers = new MasterDatasGetHeaders();
            return MasterDatasGetWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事主数据根据ID获取
         *
         * @param request MasterDatasGetRequest
         * @return MasterDatasGetResponse
         */
        public async Task<MasterDatasGetResponse> MasterDatasGetAsync(MasterDatasGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MasterDatasGetHeaders headers = new MasterDatasGetHeaders();
            return await MasterDatasGetWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事主数据查询服务
         *
         * @param request MasterDatasQueryRequest
         * @param headers MasterDatasQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MasterDatasQueryResponse
         */
        public MasterDatasQueryResponse MasterDatasQueryWithOptions(MasterDatasQueryRequest request, MasterDatasQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUK))
            {
                body["bizUK"] = request.BizUK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryParams))
            {
                body["queryParams"] = request.QueryParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationIds))
            {
                body["relationIds"] = request.RelationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeCode))
            {
                body["scopeCode"] = request.ScopeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewEntityCode))
            {
                body["viewEntityCode"] = request.ViewEntityCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "MasterDatasQuery",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masterDatas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MasterDatasQueryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事主数据查询服务
         *
         * @param request MasterDatasQueryRequest
         * @param headers MasterDatasQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MasterDatasQueryResponse
         */
        public async Task<MasterDatasQueryResponse> MasterDatasQueryWithOptionsAsync(MasterDatasQueryRequest request, MasterDatasQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUK))
            {
                body["bizUK"] = request.BizUK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryParams))
            {
                body["queryParams"] = request.QueryParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationIds))
            {
                body["relationIds"] = request.RelationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeCode))
            {
                body["scopeCode"] = request.ScopeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewEntityCode))
            {
                body["viewEntityCode"] = request.ViewEntityCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "MasterDatasQuery",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masterDatas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MasterDatasQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事主数据查询服务
         *
         * @param request MasterDatasQueryRequest
         * @return MasterDatasQueryResponse
         */
        public MasterDatasQueryResponse MasterDatasQuery(MasterDatasQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MasterDatasQueryHeaders headers = new MasterDatasQueryHeaders();
            return MasterDatasQueryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事主数据查询服务
         *
         * @param request MasterDatasQueryRequest
         * @return MasterDatasQueryResponse
         */
        public async Task<MasterDatasQueryResponse> MasterDatasQueryAsync(MasterDatasQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MasterDatasQueryHeaders headers = new MasterDatasQueryHeaders();
            return await MasterDatasQueryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary oem 老用户数据迁移时，开通oem 应用
         *
         * @param request OpenOemMicroAppRequest
         * @param headers OpenOemMicroAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenOemMicroAppResponse
         */
        public OpenOemMicroAppResponse OpenOemMicroAppWithOptions(OpenOemMicroAppRequest request, OpenOemMicroAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "OpenOemMicroApp",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/oem/microApps/open",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenOemMicroAppResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary oem 老用户数据迁移时，开通oem 应用
         *
         * @param request OpenOemMicroAppRequest
         * @param headers OpenOemMicroAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenOemMicroAppResponse
         */
        public async Task<OpenOemMicroAppResponse> OpenOemMicroAppWithOptionsAsync(OpenOemMicroAppRequest request, OpenOemMicroAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "OpenOemMicroApp",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/oem/microApps/open",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenOemMicroAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary oem 老用户数据迁移时，开通oem 应用
         *
         * @param request OpenOemMicroAppRequest
         * @return OpenOemMicroAppResponse
         */
        public OpenOemMicroAppResponse OpenOemMicroApp(OpenOemMicroAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenOemMicroAppHeaders headers = new OpenOemMicroAppHeaders();
            return OpenOemMicroAppWithOptions(request, headers, runtime);
        }

        /**
         * @summary oem 老用户数据迁移时，开通oem 应用
         *
         * @param request OpenOemMicroAppRequest
         * @return OpenOemMicroAppResponse
         */
        public async Task<OpenOemMicroAppResponse> OpenOemMicroAppAsync(OpenOemMicroAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenOemMicroAppHeaders headers = new OpenOemMicroAppHeaders();
            return await OpenOemMicroAppWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 自定义入职流程数据查询
         *
         * @param request QueryCustomEntryProcessesRequest
         * @param headers QueryCustomEntryProcessesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCustomEntryProcessesResponse
         */
        public QueryCustomEntryProcessesResponse QueryCustomEntryProcessesWithOptions(QueryCustomEntryProcessesRequest request, QueryCustomEntryProcessesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                query["operateUserId"] = request.OperateUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryCustomEntryProcesses",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/customEntryProcesses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomEntryProcessesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 自定义入职流程数据查询
         *
         * @param request QueryCustomEntryProcessesRequest
         * @param headers QueryCustomEntryProcessesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCustomEntryProcessesResponse
         */
        public async Task<QueryCustomEntryProcessesResponse> QueryCustomEntryProcessesWithOptionsAsync(QueryCustomEntryProcessesRequest request, QueryCustomEntryProcessesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                query["operateUserId"] = request.OperateUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryCustomEntryProcesses",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/customEntryProcesses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomEntryProcessesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 自定义入职流程数据查询
         *
         * @param request QueryCustomEntryProcessesRequest
         * @return QueryCustomEntryProcessesResponse
         */
        public QueryCustomEntryProcessesResponse QueryCustomEntryProcesses(QueryCustomEntryProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomEntryProcessesHeaders headers = new QueryCustomEntryProcessesHeaders();
            return QueryCustomEntryProcessesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 自定义入职流程数据查询
         *
         * @param request QueryCustomEntryProcessesRequest
         * @return QueryCustomEntryProcessesResponse
         */
        public async Task<QueryCustomEntryProcessesResponse> QueryCustomEntryProcessesAsync(QueryCustomEntryProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomEntryProcessesHeaders headers = new QueryCustomEntryProcessesHeaders();
            return await QueryCustomEntryProcessesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询企业已离职员工列表
         *
         * @param request QueryDismissionStaffIdListRequest
         * @param headers QueryDismissionStaffIdListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDismissionStaffIdListResponse
         */
        public QueryDismissionStaffIdListResponse QueryDismissionStaffIdListWithOptions(QueryDismissionStaffIdListRequest request, QueryDismissionStaffIdListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryDismissionStaffIdList",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/employees/dismissions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDismissionStaffIdListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询企业已离职员工列表
         *
         * @param request QueryDismissionStaffIdListRequest
         * @param headers QueryDismissionStaffIdListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDismissionStaffIdListResponse
         */
        public async Task<QueryDismissionStaffIdListResponse> QueryDismissionStaffIdListWithOptionsAsync(QueryDismissionStaffIdListRequest request, QueryDismissionStaffIdListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryDismissionStaffIdList",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/employees/dismissions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDismissionStaffIdListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询企业已离职员工列表
         *
         * @param request QueryDismissionStaffIdListRequest
         * @return QueryDismissionStaffIdListResponse
         */
        public QueryDismissionStaffIdListResponse QueryDismissionStaffIdList(QueryDismissionStaffIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDismissionStaffIdListHeaders headers = new QueryDismissionStaffIdListHeaders();
            return QueryDismissionStaffIdListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询企业已离职员工列表
         *
         * @param request QueryDismissionStaffIdListRequest
         * @return QueryDismissionStaffIdListResponse
         */
        public async Task<QueryDismissionStaffIdListResponse> QueryDismissionStaffIdListAsync(QueryDismissionStaffIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDismissionStaffIdListHeaders headers = new QueryDismissionStaffIdListHeaders();
            return await QueryDismissionStaffIdListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据传入的staffId列表，批量查询员工的离职信息
         *
         * @param tmpReq QueryHrmEmployeeDismissionInfoRequest
         * @param headers QueryHrmEmployeeDismissionInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryHrmEmployeeDismissionInfoResponse
         */
        public QueryHrmEmployeeDismissionInfoResponse QueryHrmEmployeeDismissionInfoWithOptions(QueryHrmEmployeeDismissionInfoRequest tmpReq, QueryHrmEmployeeDismissionInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryHrmEmployeeDismissionInfoShrinkRequest request = new QueryHrmEmployeeDismissionInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserIdList))
            {
                request.UserIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserIdList, "userIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdListShrink))
            {
                query["userIdList"] = request.UserIdListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryHrmEmployeeDismissionInfo",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/employees/dimissionInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHrmEmployeeDismissionInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据传入的staffId列表，批量查询员工的离职信息
         *
         * @param tmpReq QueryHrmEmployeeDismissionInfoRequest
         * @param headers QueryHrmEmployeeDismissionInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryHrmEmployeeDismissionInfoResponse
         */
        public async Task<QueryHrmEmployeeDismissionInfoResponse> QueryHrmEmployeeDismissionInfoWithOptionsAsync(QueryHrmEmployeeDismissionInfoRequest tmpReq, QueryHrmEmployeeDismissionInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryHrmEmployeeDismissionInfoShrinkRequest request = new QueryHrmEmployeeDismissionInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserIdList))
            {
                request.UserIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserIdList, "userIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdListShrink))
            {
                query["userIdList"] = request.UserIdListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryHrmEmployeeDismissionInfo",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/employees/dimissionInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHrmEmployeeDismissionInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据传入的staffId列表，批量查询员工的离职信息
         *
         * @param request QueryHrmEmployeeDismissionInfoRequest
         * @return QueryHrmEmployeeDismissionInfoResponse
         */
        public QueryHrmEmployeeDismissionInfoResponse QueryHrmEmployeeDismissionInfo(QueryHrmEmployeeDismissionInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHrmEmployeeDismissionInfoHeaders headers = new QueryHrmEmployeeDismissionInfoHeaders();
            return QueryHrmEmployeeDismissionInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据传入的staffId列表，批量查询员工的离职信息
         *
         * @param request QueryHrmEmployeeDismissionInfoRequest
         * @return QueryHrmEmployeeDismissionInfoResponse
         */
        public async Task<QueryHrmEmployeeDismissionInfoResponse> QueryHrmEmployeeDismissionInfoAsync(QueryHrmEmployeeDismissionInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHrmEmployeeDismissionInfoHeaders headers = new QueryHrmEmployeeDismissionInfoHeaders();
            return await QueryHrmEmployeeDismissionInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分页查询企业的职级信息
         *
         * @param request QueryJobRanksRequest
         * @param headers QueryJobRanksHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryJobRanksResponse
         */
        public QueryJobRanksResponse QueryJobRanksWithOptions(QueryJobRanksRequest request, QueryJobRanksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankCategoryId))
            {
                query["rankCategoryId"] = request.RankCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankCode))
            {
                query["rankCode"] = request.RankCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankName))
            {
                query["rankName"] = request.RankName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryJobRanks",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/jobRanks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryJobRanksResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 分页查询企业的职级信息
         *
         * @param request QueryJobRanksRequest
         * @param headers QueryJobRanksHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryJobRanksResponse
         */
        public async Task<QueryJobRanksResponse> QueryJobRanksWithOptionsAsync(QueryJobRanksRequest request, QueryJobRanksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankCategoryId))
            {
                query["rankCategoryId"] = request.RankCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankCode))
            {
                query["rankCode"] = request.RankCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankName))
            {
                query["rankName"] = request.RankName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryJobRanks",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/jobRanks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryJobRanksResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 分页查询企业的职级信息
         *
         * @param request QueryJobRanksRequest
         * @return QueryJobRanksResponse
         */
        public QueryJobRanksResponse QueryJobRanks(QueryJobRanksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobRanksHeaders headers = new QueryJobRanksHeaders();
            return QueryJobRanksWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分页查询企业的职级信息
         *
         * @param request QueryJobRanksRequest
         * @return QueryJobRanksResponse
         */
        public async Task<QueryJobRanksResponse> QueryJobRanksAsync(QueryJobRanksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobRanksHeaders headers = new QueryJobRanksHeaders();
            return await QueryJobRanksWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分页查询企业职务信息
         *
         * @param request QueryJobsRequest
         * @param headers QueryJobsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryJobsResponse
         */
        public QueryJobsResponse QueryJobsWithOptions(QueryJobsRequest request, QueryJobsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["jobName"] = request.JobName;
            }
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
                Action = "QueryJobs",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryJobsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 分页查询企业职务信息
         *
         * @param request QueryJobsRequest
         * @param headers QueryJobsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryJobsResponse
         */
        public async Task<QueryJobsResponse> QueryJobsWithOptionsAsync(QueryJobsRequest request, QueryJobsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["jobName"] = request.JobName;
            }
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
                Action = "QueryJobs",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryJobsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 分页查询企业职务信息
         *
         * @param request QueryJobsRequest
         * @return QueryJobsResponse
         */
        public QueryJobsResponse QueryJobs(QueryJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobsHeaders headers = new QueryJobsHeaders();
            return QueryJobsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分页查询企业职务信息
         *
         * @param request QueryJobsRequest
         * @return QueryJobsResponse
         */
        public async Task<QueryJobsResponse> QueryJobsAsync(QueryJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobsHeaders headers = new QueryJobsHeaders();
            return await QueryJobsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事查询微应用状态
         *
         * @param request QueryMicroAppStatusRequest
         * @param headers QueryMicroAppStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMicroAppStatusResponse
         */
        public QueryMicroAppStatusResponse QueryMicroAppStatusWithOptions(QueryMicroAppStatusRequest request, QueryMicroAppStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantIdList))
            {
                body["tenantIdList"] = request.TenantIdList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryMicroAppStatus",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/microApps/statuses/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMicroAppStatusResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事查询微应用状态
         *
         * @param request QueryMicroAppStatusRequest
         * @param headers QueryMicroAppStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMicroAppStatusResponse
         */
        public async Task<QueryMicroAppStatusResponse> QueryMicroAppStatusWithOptionsAsync(QueryMicroAppStatusRequest request, QueryMicroAppStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantIdList))
            {
                body["tenantIdList"] = request.TenantIdList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryMicroAppStatus",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/microApps/statuses/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMicroAppStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事查询微应用状态
         *
         * @param request QueryMicroAppStatusRequest
         * @return QueryMicroAppStatusResponse
         */
        public QueryMicroAppStatusResponse QueryMicroAppStatus(QueryMicroAppStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMicroAppStatusHeaders headers = new QueryMicroAppStatusHeaders();
            return QueryMicroAppStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事查询微应用状态
         *
         * @param request QueryMicroAppStatusRequest
         * @return QueryMicroAppStatusResponse
         */
        public async Task<QueryMicroAppStatusResponse> QueryMicroAppStatusAsync(QueryMicroAppStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMicroAppStatusHeaders headers = new QueryMicroAppStatusHeaders();
            return await QueryMicroAppStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事查询微应用可见性
         *
         * @param request QueryMicroAppViewRequest
         * @param headers QueryMicroAppViewHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMicroAppViewResponse
         */
        public QueryMicroAppViewResponse QueryMicroAppViewWithOptions(QueryMicroAppViewRequest request, QueryMicroAppViewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantIdList))
            {
                body["tenantIdList"] = request.TenantIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewUserId))
            {
                body["viewUserId"] = request.ViewUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryMicroAppView",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/microApps/visibilities/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMicroAppViewResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事查询微应用可见性
         *
         * @param request QueryMicroAppViewRequest
         * @param headers QueryMicroAppViewHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMicroAppViewResponse
         */
        public async Task<QueryMicroAppViewResponse> QueryMicroAppViewWithOptionsAsync(QueryMicroAppViewRequest request, QueryMicroAppViewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantIdList))
            {
                body["tenantIdList"] = request.TenantIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewUserId))
            {
                body["viewUserId"] = request.ViewUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryMicroAppView",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/microApps/visibilities/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMicroAppViewResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事查询微应用可见性
         *
         * @param request QueryMicroAppViewRequest
         * @return QueryMicroAppViewResponse
         */
        public QueryMicroAppViewResponse QueryMicroAppView(QueryMicroAppViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMicroAppViewHeaders headers = new QueryMicroAppViewHeaders();
            return QueryMicroAppViewWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事查询微应用可见性
         *
         * @param request QueryMicroAppViewRequest
         * @return QueryMicroAppViewResponse
         */
        public async Task<QueryMicroAppViewResponse> QueryMicroAppViewAsync(QueryMicroAppViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMicroAppViewHeaders headers = new QueryMicroAppViewHeaders();
            return await QueryMicroAppViewWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分页查询企业职位信息
         *
         * @param request QueryPositionsRequest
         * @param headers QueryPositionsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPositionsResponse
         */
        public QueryPositionsResponse QueryPositionsWithOptions(QueryPositionsRequest request, QueryPositionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InCategoryIds))
            {
                body["inCategoryIds"] = request.InCategoryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InPositionIds))
            {
                body["inPositionIds"] = request.InPositionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PositionName))
            {
                body["positionName"] = request.PositionName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryPositions",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/positions/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPositionsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 分页查询企业职位信息
         *
         * @param request QueryPositionsRequest
         * @param headers QueryPositionsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPositionsResponse
         */
        public async Task<QueryPositionsResponse> QueryPositionsWithOptionsAsync(QueryPositionsRequest request, QueryPositionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InCategoryIds))
            {
                body["inCategoryIds"] = request.InCategoryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InPositionIds))
            {
                body["inPositionIds"] = request.InPositionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PositionName))
            {
                body["positionName"] = request.PositionName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryPositions",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/positions/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPositionsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 分页查询企业职位信息
         *
         * @param request QueryPositionsRequest
         * @return QueryPositionsResponse
         */
        public QueryPositionsResponse QueryPositions(QueryPositionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPositionsHeaders headers = new QueryPositionsHeaders();
            return QueryPositionsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分页查询企业职位信息
         *
         * @param request QueryPositionsRequest
         * @return QueryPositionsResponse
         */
        public async Task<QueryPositionsResponse> QueryPositionsAsync(QueryPositionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPositionsHeaders headers = new QueryPositionsHeaders();
            return await QueryPositionsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 撤回电子签署中的签署记录
         *
         * @param request RevokeSignRecordsRequest
         * @param headers RevokeSignRecordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeSignRecordsResponse
         */
        public RevokeSignRecordsResponse RevokeSignRecordsWithOptions(RevokeSignRecordsRequest request, RevokeSignRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevokeUserId))
            {
                body["revokeUserId"] = request.RevokeUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignRecordIds))
            {
                body["signRecordIds"] = request.SignRecordIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusRemark))
            {
                body["statusRemark"] = request.StatusRemark;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RevokeSignRecords",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/signCenters/records/revoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeSignRecordsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 撤回电子签署中的签署记录
         *
         * @param request RevokeSignRecordsRequest
         * @param headers RevokeSignRecordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeSignRecordsResponse
         */
        public async Task<RevokeSignRecordsResponse> RevokeSignRecordsWithOptionsAsync(RevokeSignRecordsRequest request, RevokeSignRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevokeUserId))
            {
                body["revokeUserId"] = request.RevokeUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignRecordIds))
            {
                body["signRecordIds"] = request.SignRecordIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusRemark))
            {
                body["statusRemark"] = request.StatusRemark;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RevokeSignRecords",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/signCenters/records/revoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeSignRecordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 撤回电子签署中的签署记录
         *
         * @param request RevokeSignRecordsRequest
         * @return RevokeSignRecordsResponse
         */
        public RevokeSignRecordsResponse RevokeSignRecords(RevokeSignRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RevokeSignRecordsHeaders headers = new RevokeSignRecordsHeaders();
            return RevokeSignRecordsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 撤回电子签署中的签署记录
         *
         * @param request RevokeSignRecordsRequest
         * @return RevokeSignRecordsResponse
         */
        public async Task<RevokeSignRecordsResponse> RevokeSignRecordsAsync(RevokeSignRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RevokeSignRecordsHeaders headers = new RevokeSignRecordsHeaders();
            return await RevokeSignRecordsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询花名册中有权限的字段列表
         *
         * @param request RosterMetaAvailableFieldListRequest
         * @param headers RosterMetaAvailableFieldListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RosterMetaAvailableFieldListResponse
         */
        public RosterMetaAvailableFieldListResponse RosterMetaAvailableFieldListWithOptions(RosterMetaAvailableFieldListRequest request, RosterMetaAvailableFieldListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppAgentId))
            {
                query["appAgentId"] = request.AppAgentId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RosterMetaAvailableFieldList",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/rosters/meta/authorities/fields",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RosterMetaAvailableFieldListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询花名册中有权限的字段列表
         *
         * @param request RosterMetaAvailableFieldListRequest
         * @param headers RosterMetaAvailableFieldListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RosterMetaAvailableFieldListResponse
         */
        public async Task<RosterMetaAvailableFieldListResponse> RosterMetaAvailableFieldListWithOptionsAsync(RosterMetaAvailableFieldListRequest request, RosterMetaAvailableFieldListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppAgentId))
            {
                query["appAgentId"] = request.AppAgentId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RosterMetaAvailableFieldList",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/rosters/meta/authorities/fields",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RosterMetaAvailableFieldListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询花名册中有权限的字段列表
         *
         * @param request RosterMetaAvailableFieldListRequest
         * @return RosterMetaAvailableFieldListResponse
         */
        public RosterMetaAvailableFieldListResponse RosterMetaAvailableFieldList(RosterMetaAvailableFieldListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RosterMetaAvailableFieldListHeaders headers = new RosterMetaAvailableFieldListHeaders();
            return RosterMetaAvailableFieldListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询花名册中有权限的字段列表
         *
         * @param request RosterMetaAvailableFieldListRequest
         * @return RosterMetaAvailableFieldListResponse
         */
        public async Task<RosterMetaAvailableFieldListResponse> RosterMetaAvailableFieldListAsync(RosterMetaAvailableFieldListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RosterMetaAvailableFieldListHeaders headers = new RosterMetaAvailableFieldListHeaders();
            return await RosterMetaAvailableFieldListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事花名册字段选项修改
         *
         * @param request RosterMetaFieldOptionsUpdateRequest
         * @param headers RosterMetaFieldOptionsUpdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RosterMetaFieldOptionsUpdateResponse
         */
        public RosterMetaFieldOptionsUpdateResponse RosterMetaFieldOptionsUpdateWithOptions(RosterMetaFieldOptionsUpdateRequest request, RosterMetaFieldOptionsUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppAgentId))
            {
                query["appAgentId"] = request.AppAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldCode))
            {
                body["fieldCode"] = request.FieldCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                body["modifyType"] = request.ModifyType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RosterMetaFieldOptionsUpdate",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/rosters/meta/fields/options",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RosterMetaFieldOptionsUpdateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事花名册字段选项修改
         *
         * @param request RosterMetaFieldOptionsUpdateRequest
         * @param headers RosterMetaFieldOptionsUpdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RosterMetaFieldOptionsUpdateResponse
         */
        public async Task<RosterMetaFieldOptionsUpdateResponse> RosterMetaFieldOptionsUpdateWithOptionsAsync(RosterMetaFieldOptionsUpdateRequest request, RosterMetaFieldOptionsUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppAgentId))
            {
                query["appAgentId"] = request.AppAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldCode))
            {
                body["fieldCode"] = request.FieldCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                body["modifyType"] = request.ModifyType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RosterMetaFieldOptionsUpdate",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/rosters/meta/fields/options",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RosterMetaFieldOptionsUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事花名册字段选项修改
         *
         * @param request RosterMetaFieldOptionsUpdateRequest
         * @return RosterMetaFieldOptionsUpdateResponse
         */
        public RosterMetaFieldOptionsUpdateResponse RosterMetaFieldOptionsUpdate(RosterMetaFieldOptionsUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RosterMetaFieldOptionsUpdateHeaders headers = new RosterMetaFieldOptionsUpdateHeaders();
            return RosterMetaFieldOptionsUpdateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事花名册字段选项修改
         *
         * @param request RosterMetaFieldOptionsUpdateRequest
         * @return RosterMetaFieldOptionsUpdateResponse
         */
        public async Task<RosterMetaFieldOptionsUpdateResponse> RosterMetaFieldOptionsUpdateAsync(RosterMetaFieldOptionsUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RosterMetaFieldOptionsUpdateHeaders headers = new RosterMetaFieldOptionsUpdateHeaders();
            return await RosterMetaFieldOptionsUpdateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary ISV发送卡片消息
         *
         * @param request SendIsvCardMessageRequest
         * @param headers SendIsvCardMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendIsvCardMessageResponse
         */
        public SendIsvCardMessageResponse SendIsvCardMessageWithOptions(SendIsvCardMessageRequest request, SendIsvCardMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["messageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIds))
            {
                body["receiverUserIds"] = request.ReceiverUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                body["sceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUserId))
            {
                body["senderUserId"] = request.SenderUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueMap))
            {
                body["valueMap"] = request.ValueMap;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendIsvCardMessage",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/cardMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendIsvCardMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary ISV发送卡片消息
         *
         * @param request SendIsvCardMessageRequest
         * @param headers SendIsvCardMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendIsvCardMessageResponse
         */
        public async Task<SendIsvCardMessageResponse> SendIsvCardMessageWithOptionsAsync(SendIsvCardMessageRequest request, SendIsvCardMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["messageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIds))
            {
                body["receiverUserIds"] = request.ReceiverUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                body["sceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUserId))
            {
                body["senderUserId"] = request.SenderUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueMap))
            {
                body["valueMap"] = request.ValueMap;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendIsvCardMessage",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/cardMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendIsvCardMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary ISV发送卡片消息
         *
         * @param request SendIsvCardMessageRequest
         * @return SendIsvCardMessageResponse
         */
        public SendIsvCardMessageResponse SendIsvCardMessage(SendIsvCardMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendIsvCardMessageHeaders headers = new SendIsvCardMessageHeaders();
            return SendIsvCardMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary ISV发送卡片消息
         *
         * @param request SendIsvCardMessageRequest
         * @return SendIsvCardMessageResponse
         */
        public async Task<SendIsvCardMessageResponse> SendIsvCardMessageAsync(SendIsvCardMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendIsvCardMessageHeaders headers = new SendIsvCardMessageHeaders();
            return await SendIsvCardMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 初始化解决方案任务
         *
         * @param request SolutionTaskInitRequest
         * @param headers SolutionTaskInitHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SolutionTaskInitResponse
         */
        public SolutionTaskInitResponse SolutionTaskInitWithOptions(SolutionTaskInitRequest request, SolutionTaskInitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionType))
            {
                query["solutionType"] = request.SolutionType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClaimTime))
            {
                body["claimTime"] = request.ClaimTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishTime))
            {
                body["finishTime"] = request.FinishTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                body["outerId"] = request.OuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SolutionTaskInit",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/solutions/tasks/init",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SolutionTaskInitResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 初始化解决方案任务
         *
         * @param request SolutionTaskInitRequest
         * @param headers SolutionTaskInitHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SolutionTaskInitResponse
         */
        public async Task<SolutionTaskInitResponse> SolutionTaskInitWithOptionsAsync(SolutionTaskInitRequest request, SolutionTaskInitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionType))
            {
                query["solutionType"] = request.SolutionType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClaimTime))
            {
                body["claimTime"] = request.ClaimTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishTime))
            {
                body["finishTime"] = request.FinishTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                body["outerId"] = request.OuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SolutionTaskInit",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/solutions/tasks/init",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SolutionTaskInitResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 初始化解决方案任务
         *
         * @param request SolutionTaskInitRequest
         * @return SolutionTaskInitResponse
         */
        public SolutionTaskInitResponse SolutionTaskInit(SolutionTaskInitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SolutionTaskInitHeaders headers = new SolutionTaskInitHeaders();
            return SolutionTaskInitWithOptions(request, headers, runtime);
        }

        /**
         * @summary 初始化解决方案任务
         *
         * @param request SolutionTaskInitRequest
         * @return SolutionTaskInitResponse
         */
        public async Task<SolutionTaskInitResponse> SolutionTaskInitAsync(SolutionTaskInitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SolutionTaskInitHeaders headers = new SolutionTaskInitHeaders();
            return await SolutionTaskInitWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 保存解决方案任务
         *
         * @param request SolutionTaskSaveRequest
         * @param headers SolutionTaskSaveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SolutionTaskSaveResponse
         */
        public SolutionTaskSaveResponse SolutionTaskSaveWithOptions(SolutionTaskSaveRequest request, SolutionTaskSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionType))
            {
                query["solutionType"] = request.SolutionType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClaimTime))
            {
                body["claimTime"] = request.ClaimTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishTime))
            {
                body["finishTime"] = request.FinishTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                body["outerId"] = request.OuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionInstanceId))
            {
                body["solutionInstanceId"] = request.SolutionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateOuterId))
            {
                body["templateOuterId"] = request.TemplateOuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SolutionTaskSave",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/solutions/tasks/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SolutionTaskSaveResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 保存解决方案任务
         *
         * @param request SolutionTaskSaveRequest
         * @param headers SolutionTaskSaveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SolutionTaskSaveResponse
         */
        public async Task<SolutionTaskSaveResponse> SolutionTaskSaveWithOptionsAsync(SolutionTaskSaveRequest request, SolutionTaskSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionType))
            {
                query["solutionType"] = request.SolutionType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClaimTime))
            {
                body["claimTime"] = request.ClaimTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishTime))
            {
                body["finishTime"] = request.FinishTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                body["outerId"] = request.OuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionInstanceId))
            {
                body["solutionInstanceId"] = request.SolutionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateOuterId))
            {
                body["templateOuterId"] = request.TemplateOuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SolutionTaskSave",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/solutions/tasks/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SolutionTaskSaveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 保存解决方案任务
         *
         * @param request SolutionTaskSaveRequest
         * @return SolutionTaskSaveResponse
         */
        public SolutionTaskSaveResponse SolutionTaskSave(SolutionTaskSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SolutionTaskSaveHeaders headers = new SolutionTaskSaveHeaders();
            return SolutionTaskSaveWithOptions(request, headers, runtime);
        }

        /**
         * @summary 保存解决方案任务
         *
         * @param request SolutionTaskSaveRequest
         * @return SolutionTaskSaveResponse
         */
        public async Task<SolutionTaskSaveResponse> SolutionTaskSaveAsync(SolutionTaskSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SolutionTaskSaveHeaders headers = new SolutionTaskSaveHeaders();
            return await SolutionTaskSaveWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 同步解决方案状态
         *
         * @param request SyncSolutionStatusRequest
         * @param headers SyncSolutionStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncSolutionStatusResponse
         */
        public SyncSolutionStatusResponse SyncSolutionStatusWithOptions(SyncSolutionStatusRequest request, SyncSolutionStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionStatus))
            {
                body["solutionStatus"] = request.SolutionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionType))
            {
                body["solutionType"] = request.SolutionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncSolutionStatus",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/solutions/statuses/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncSolutionStatusResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 同步解决方案状态
         *
         * @param request SyncSolutionStatusRequest
         * @param headers SyncSolutionStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncSolutionStatusResponse
         */
        public async Task<SyncSolutionStatusResponse> SyncSolutionStatusWithOptionsAsync(SyncSolutionStatusRequest request, SyncSolutionStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionStatus))
            {
                body["solutionStatus"] = request.SolutionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionType))
            {
                body["solutionType"] = request.SolutionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncSolutionStatus",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/solutions/statuses/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncSolutionStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 同步解决方案状态
         *
         * @param request SyncSolutionStatusRequest
         * @return SyncSolutionStatusResponse
         */
        public SyncSolutionStatusResponse SyncSolutionStatus(SyncSolutionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncSolutionStatusHeaders headers = new SyncSolutionStatusHeaders();
            return SyncSolutionStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 同步解决方案状态
         *
         * @param request SyncSolutionStatusRequest
         * @return SyncSolutionStatusResponse
         */
        public async Task<SyncSolutionStatusResponse> SyncSolutionStatusAsync(SyncSolutionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncSolutionStatusHeaders headers = new SyncSolutionStatusHeaders();
            return await SyncSolutionStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 同步解决方案任务模版
         *
         * @param request SyncTaskTemplateRequest
         * @param headers SyncTaskTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncTaskTemplateResponse
         */
        public SyncTaskTemplateResponse SyncTaskTemplateWithOptions(SyncTaskTemplateRequest request, SyncTaskTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionType))
            {
                query["solutionType"] = request.SolutionType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delete))
            {
                body["delete"] = request.Delete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Des))
            {
                body["des"] = request.Des;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                body["outerId"] = request.OuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskScopeVO))
            {
                body["taskScopeVO"] = request.TaskScopeVO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SyncTaskTemplate",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/solutions/tasks/templates/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncTaskTemplateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 同步解决方案任务模版
         *
         * @param request SyncTaskTemplateRequest
         * @param headers SyncTaskTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncTaskTemplateResponse
         */
        public async Task<SyncTaskTemplateResponse> SyncTaskTemplateWithOptionsAsync(SyncTaskTemplateRequest request, SyncTaskTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionType))
            {
                query["solutionType"] = request.SolutionType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delete))
            {
                body["delete"] = request.Delete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Des))
            {
                body["des"] = request.Des;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                body["outerId"] = request.OuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskScopeVO))
            {
                body["taskScopeVO"] = request.TaskScopeVO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SyncTaskTemplate",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/solutions/tasks/templates/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncTaskTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 同步解决方案任务模版
         *
         * @param request SyncTaskTemplateRequest
         * @return SyncTaskTemplateResponse
         */
        public SyncTaskTemplateResponse SyncTaskTemplate(SyncTaskTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncTaskTemplateHeaders headers = new SyncTaskTemplateHeaders();
            return SyncTaskTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 同步解决方案任务模版
         *
         * @param request SyncTaskTemplateRequest
         * @return SyncTaskTemplateResponse
         */
        public async Task<SyncTaskTemplateResponse> SyncTaskTemplateAsync(SyncTaskTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncTaskTemplateHeaders headers = new SyncTaskTemplateHeaders();
            return await SyncTaskTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新法人公司名称
         *
         * @param request UpdateHrmLegalEntityNameRequest
         * @param headers UpdateHrmLegalEntityNameHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateHrmLegalEntityNameResponse
         */
        public UpdateHrmLegalEntityNameResponse UpdateHrmLegalEntityNameWithOptions(UpdateHrmLegalEntityNameRequest request, UpdateHrmLegalEntityNameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTenantId))
            {
                query["dingTenantId"] = request.DingTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalEntityName))
            {
                query["legalEntityName"] = request.LegalEntityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLegalEntityName))
            {
                query["originLegalEntityName"] = request.OriginLegalEntityName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateHrmLegalEntityName",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/legalEntities/companyNames",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHrmLegalEntityNameResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新法人公司名称
         *
         * @param request UpdateHrmLegalEntityNameRequest
         * @param headers UpdateHrmLegalEntityNameHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateHrmLegalEntityNameResponse
         */
        public async Task<UpdateHrmLegalEntityNameResponse> UpdateHrmLegalEntityNameWithOptionsAsync(UpdateHrmLegalEntityNameRequest request, UpdateHrmLegalEntityNameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTenantId))
            {
                query["dingTenantId"] = request.DingTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalEntityName))
            {
                query["legalEntityName"] = request.LegalEntityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLegalEntityName))
            {
                query["originLegalEntityName"] = request.OriginLegalEntityName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateHrmLegalEntityName",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/legalEntities/companyNames",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHrmLegalEntityNameResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新法人公司名称
         *
         * @param request UpdateHrmLegalEntityNameRequest
         * @return UpdateHrmLegalEntityNameResponse
         */
        public UpdateHrmLegalEntityNameResponse UpdateHrmLegalEntityName(UpdateHrmLegalEntityNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHrmLegalEntityNameHeaders headers = new UpdateHrmLegalEntityNameHeaders();
            return UpdateHrmLegalEntityNameWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新法人公司名称
         *
         * @param request UpdateHrmLegalEntityNameRequest
         * @return UpdateHrmLegalEntityNameResponse
         */
        public async Task<UpdateHrmLegalEntityNameResponse> UpdateHrmLegalEntityNameAsync(UpdateHrmLegalEntityNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHrmLegalEntityNameHeaders headers = new UpdateHrmLegalEntityNameHeaders();
            return await UpdateHrmLegalEntityNameWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新法人公司
         *
         * @param request UpdateHrmLegalEntityWithoutNameRequest
         * @param headers UpdateHrmLegalEntityWithoutNameHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateHrmLegalEntityWithoutNameResponse
         */
        public UpdateHrmLegalEntityWithoutNameResponse UpdateHrmLegalEntityWithoutNameWithOptions(UpdateHrmLegalEntityWithoutNameRequest request, UpdateHrmLegalEntityWithoutNameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTenantId))
            {
                query["dingTenantId"] = request.DingTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                body["createUserId"] = request.CreateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalEntityName))
            {
                body["legalEntityName"] = request.LegalEntityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalEntityShortName))
            {
                body["legalEntityShortName"] = request.LegalEntityShortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalEntityStatus))
            {
                body["legalEntityStatus"] = request.LegalEntityStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonName))
            {
                body["legalPersonName"] = request.LegalPersonName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateHrmLegalEntityWithoutName",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/legalEntities/companies",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHrmLegalEntityWithoutNameResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新法人公司
         *
         * @param request UpdateHrmLegalEntityWithoutNameRequest
         * @param headers UpdateHrmLegalEntityWithoutNameHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateHrmLegalEntityWithoutNameResponse
         */
        public async Task<UpdateHrmLegalEntityWithoutNameResponse> UpdateHrmLegalEntityWithoutNameWithOptionsAsync(UpdateHrmLegalEntityWithoutNameRequest request, UpdateHrmLegalEntityWithoutNameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTenantId))
            {
                query["dingTenantId"] = request.DingTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                body["createUserId"] = request.CreateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalEntityName))
            {
                body["legalEntityName"] = request.LegalEntityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalEntityShortName))
            {
                body["legalEntityShortName"] = request.LegalEntityShortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalEntityStatus))
            {
                body["legalEntityStatus"] = request.LegalEntityStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonName))
            {
                body["legalPersonName"] = request.LegalPersonName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateHrmLegalEntityWithoutName",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/masters/legalEntities/companies",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHrmLegalEntityWithoutNameResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新法人公司
         *
         * @param request UpdateHrmLegalEntityWithoutNameRequest
         * @return UpdateHrmLegalEntityWithoutNameResponse
         */
        public UpdateHrmLegalEntityWithoutNameResponse UpdateHrmLegalEntityWithoutName(UpdateHrmLegalEntityWithoutNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHrmLegalEntityWithoutNameHeaders headers = new UpdateHrmLegalEntityWithoutNameHeaders();
            return UpdateHrmLegalEntityWithoutNameWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新法人公司
         *
         * @param request UpdateHrmLegalEntityWithoutNameRequest
         * @return UpdateHrmLegalEntityWithoutNameResponse
         */
        public async Task<UpdateHrmLegalEntityWithoutNameResponse> UpdateHrmLegalEntityWithoutNameAsync(UpdateHrmLegalEntityWithoutNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHrmLegalEntityWithoutNameHeaders headers = new UpdateHrmLegalEntityWithoutNameHeaders();
            return await UpdateHrmLegalEntityWithoutNameWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 智能人事更新版本回退按钮状态
         *
         * @param request UpdateHrmVersionRollBackStatusRequest
         * @param headers UpdateHrmVersionRollBackStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateHrmVersionRollBackStatusResponse
         */
        public UpdateHrmVersionRollBackStatusResponse UpdateHrmVersionRollBackStatusWithOptions(UpdateHrmVersionRollBackStatusRequest request, UpdateHrmVersionRollBackStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigValue))
            {
                body["configValue"] = request.ConfigValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateHrmVersionRollBackStatus",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/versions/rollbackButtons/statuses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHrmVersionRollBackStatusResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 智能人事更新版本回退按钮状态
         *
         * @param request UpdateHrmVersionRollBackStatusRequest
         * @param headers UpdateHrmVersionRollBackStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateHrmVersionRollBackStatusResponse
         */
        public async Task<UpdateHrmVersionRollBackStatusResponse> UpdateHrmVersionRollBackStatusWithOptionsAsync(UpdateHrmVersionRollBackStatusRequest request, UpdateHrmVersionRollBackStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigValue))
            {
                body["configValue"] = request.ConfigValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateHrmVersionRollBackStatus",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/versions/rollbackButtons/statuses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHrmVersionRollBackStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 智能人事更新版本回退按钮状态
         *
         * @param request UpdateHrmVersionRollBackStatusRequest
         * @return UpdateHrmVersionRollBackStatusResponse
         */
        public UpdateHrmVersionRollBackStatusResponse UpdateHrmVersionRollBackStatus(UpdateHrmVersionRollBackStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHrmVersionRollBackStatusHeaders headers = new UpdateHrmVersionRollBackStatusHeaders();
            return UpdateHrmVersionRollBackStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 智能人事更新版本回退按钮状态
         *
         * @param request UpdateHrmVersionRollBackStatusRequest
         * @return UpdateHrmVersionRollBackStatusResponse
         */
        public async Task<UpdateHrmVersionRollBackStatusResponse> UpdateHrmVersionRollBackStatusAsync(UpdateHrmVersionRollBackStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHrmVersionRollBackStatusHeaders headers = new UpdateHrmVersionRollBackStatusHeaders();
            return await UpdateHrmVersionRollBackStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary ISV更新卡片消息
         *
         * @param request UpdateIsvCardMessageRequest
         * @param headers UpdateIsvCardMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIsvCardMessageResponse
         */
        public UpdateIsvCardMessageResponse UpdateIsvCardMessageWithOptions(UpdateIsvCardMessageRequest request, UpdateIsvCardMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["messageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                body["sceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueMap))
            {
                body["valueMap"] = request.ValueMap;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateIsvCardMessage",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/cardMessages",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIsvCardMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary ISV更新卡片消息
         *
         * @param request UpdateIsvCardMessageRequest
         * @param headers UpdateIsvCardMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIsvCardMessageResponse
         */
        public async Task<UpdateIsvCardMessageResponse> UpdateIsvCardMessageWithOptionsAsync(UpdateIsvCardMessageRequest request, UpdateIsvCardMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["messageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                body["sceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueMap))
            {
                body["valueMap"] = request.ValueMap;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateIsvCardMessage",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/cardMessages",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIsvCardMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary ISV更新卡片消息
         *
         * @param request UpdateIsvCardMessageRequest
         * @return UpdateIsvCardMessageResponse
         */
        public UpdateIsvCardMessageResponse UpdateIsvCardMessage(UpdateIsvCardMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateIsvCardMessageHeaders headers = new UpdateIsvCardMessageHeaders();
            return UpdateIsvCardMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary ISV更新卡片消息
         *
         * @param request UpdateIsvCardMessageRequest
         * @return UpdateIsvCardMessageResponse
         */
        public async Task<UpdateIsvCardMessageResponse> UpdateIsvCardMessageAsync(UpdateIsvCardMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateIsvCardMessageHeaders headers = new UpdateIsvCardMessageHeaders();
            return await UpdateIsvCardMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 上传附件材料
         *
         * @param request UploadAttachmentRequest
         * @param headers UploadAttachmentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadAttachmentResponse
         */
        public UploadAttachmentResponse UploadAttachmentWithOptions(UploadAttachmentRequest request, UploadAttachmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
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
                Action = "UploadAttachment",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/attachments/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadAttachmentResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 上传附件材料
         *
         * @param request UploadAttachmentRequest
         * @param headers UploadAttachmentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadAttachmentResponse
         */
        public async Task<UploadAttachmentResponse> UploadAttachmentWithOptionsAsync(UploadAttachmentRequest request, UploadAttachmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
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
                Action = "UploadAttachment",
                Version = "hrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrm/attachments/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadAttachmentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 上传附件材料
         *
         * @param request UploadAttachmentRequest
         * @return UploadAttachmentResponse
         */
        public UploadAttachmentResponse UploadAttachment(UploadAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadAttachmentHeaders headers = new UploadAttachmentHeaders();
            return UploadAttachmentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 上传附件材料
         *
         * @param request UploadAttachmentRequest
         * @return UploadAttachmentResponse
         */
        public async Task<UploadAttachmentResponse> UploadAttachmentAsync(UploadAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadAttachmentHeaders headers = new UploadAttachmentHeaders();
            return await UploadAttachmentWithOptionsAsync(request, headers, runtime);
        }

    }
}
