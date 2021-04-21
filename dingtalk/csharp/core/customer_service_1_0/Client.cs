// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkcustomer_service_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkcustomer_service_1_0
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


        public CreateTicketResponse CreateTicket(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTicketHeaders headers = new CreateTicketHeaders();
            return CreateTicketWithOptions(request, headers, runtime);
        }

        public async Task<CreateTicketResponse> CreateTicketAsync(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTicketHeaders headers = new CreateTicketHeaders();
            return await CreateTicketWithOptionsAsync(request, headers, runtime);
        }

        public CreateTicketResponse CreateTicketWithOptions(CreateTicketRequest request, CreateTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignId))
            {
                body["foreignId"] = request.ForeignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignName))
            {
                body["foreignName"] = request.ForeignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenInstanceId))
            {
                body["openInstanceId"] = request.OpenInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionType))
            {
                body["productionType"] = request.ProductionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
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
            return TeaModel.ToObject<CreateTicketResponse>(DoROARequest("CreateTicket", "customerService_1.0", "HTTP", "POST", "AK", "/v1.0/customerService/tickets", "json", req, runtime));
        }

        public async Task<CreateTicketResponse> CreateTicketWithOptionsAsync(CreateTicketRequest request, CreateTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignId))
            {
                body["foreignId"] = request.ForeignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignName))
            {
                body["foreignName"] = request.ForeignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenInstanceId))
            {
                body["openInstanceId"] = request.OpenInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionType))
            {
                body["productionType"] = request.ProductionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
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
            return TeaModel.ToObject<CreateTicketResponse>(await DoROARequestAsync("CreateTicket", "customerService_1.0", "HTTP", "POST", "AK", "/v1.0/customerService/tickets", "json", req, runtime));
        }

    }
}
