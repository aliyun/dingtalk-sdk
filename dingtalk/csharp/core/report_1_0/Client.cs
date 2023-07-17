// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkreport_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkreport_1_0
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


        public CreateTemplatesResponse CreateTemplatesWithOptions(CreateTemplatesRequest request, CreateTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowAddReceivers))
            {
                body["allowAddReceivers"] = request.AllowAddReceivers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowEdit))
            {
                body["allowEdit"] = request.AllowEdit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowGetLocation))
            {
                body["allowGetLocation"] = request.AllowGetLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthDeptIds))
            {
                body["authDeptIds"] = request.AuthDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthUserIds))
            {
                body["authUserIds"] = request.AuthUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                body["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultReceivedCids))
            {
                body["defaultReceivedCids"] = request.DefaultReceivedCids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultReceivedMasterLevels))
            {
                body["defaultReceivedMasterLevels"] = request.DefaultReceivedMasterLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultReceivers))
            {
                body["defaultReceivers"] = request.DefaultReceivers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logo))
            {
                body["logo"] = request.Logo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxWordCount))
            {
                body["maxWordCount"] = request.MaxWordCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinWordCount))
            {
                body["minWordCount"] = request.MinWordCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateManagers))
            {
                body["templateManagers"] = request.TemplateManagers;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateTemplates",
                Version = "report_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/report/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplatesResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateTemplatesResponse> CreateTemplatesWithOptionsAsync(CreateTemplatesRequest request, CreateTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowAddReceivers))
            {
                body["allowAddReceivers"] = request.AllowAddReceivers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowEdit))
            {
                body["allowEdit"] = request.AllowEdit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowGetLocation))
            {
                body["allowGetLocation"] = request.AllowGetLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthDeptIds))
            {
                body["authDeptIds"] = request.AuthDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthUserIds))
            {
                body["authUserIds"] = request.AuthUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                body["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultReceivedCids))
            {
                body["defaultReceivedCids"] = request.DefaultReceivedCids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultReceivedMasterLevels))
            {
                body["defaultReceivedMasterLevels"] = request.DefaultReceivedMasterLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultReceivers))
            {
                body["defaultReceivers"] = request.DefaultReceivers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logo))
            {
                body["logo"] = request.Logo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxWordCount))
            {
                body["maxWordCount"] = request.MaxWordCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinWordCount))
            {
                body["minWordCount"] = request.MinWordCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateManagers))
            {
                body["templateManagers"] = request.TemplateManagers;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateTemplates",
                Version = "report_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/report/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplatesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateTemplatesResponse CreateTemplates(CreateTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTemplatesHeaders headers = new CreateTemplatesHeaders();
            return CreateTemplatesWithOptions(request, headers, runtime);
        }

        public async Task<CreateTemplatesResponse> CreateTemplatesAsync(CreateTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTemplatesHeaders headers = new CreateTemplatesHeaders();
            return await CreateTemplatesWithOptionsAsync(request, headers, runtime);
        }

    }
}
