// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkmanufacturing_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkmanufacturing_1_0
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


        public IndustrializeManufactureJobBookResponse IndustrializeManufactureJobBook(string userId, IndustrializeManufactureJobBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return IndustrializeManufactureJobBookWithOptions(userId, request, headers, runtime);
        }

        public async Task<IndustrializeManufactureJobBookResponse> IndustrializeManufactureJobBookAsync(string userId, IndustrializeManufactureJobBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await IndustrializeManufactureJobBookWithOptionsAsync(userId, request, headers, runtime);
        }

        public IndustrializeManufactureJobBookResponse IndustrializeManufactureJobBookWithOptions(string userId, IndustrializeManufactureJobBookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstNo))
            {
                body["instNo"] = request.InstNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBatchJob))
            {
                body["isBatchJob"] = request.IsBatchJob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManufactureDate))
            {
                body["manufactureDate"] = request.ManufactureDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MesAppKey))
            {
                body["mesAppKey"] = request.MesAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessEnName))
            {
                body["processEnName"] = request.ProcessEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                body["processName"] = request.ProcessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductEnName))
            {
                body["productEnName"] = request.ProductEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualifiedQuantity))
            {
                body["qualifiedQuantity"] = request.QualifiedQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReworkableQuantity))
            {
                body["reworkableQuantity"] = request.ReworkableQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScrappedQuantity))
            {
                body["scrappedQuantity"] = request.ScrappedQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitPrice))
            {
                body["unitPrice"] = request.UnitPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNameList))
            {
                body["userNameList"] = request.UserNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<IndustrializeManufactureJobBookResponse>(DoROARequest("IndustrializeManufactureJobBook", "manufacturing_1.0", "HTTP", "POST", "AK", "/v1.0/manufacturing/users/" + userId + "/jobs", "json", req, runtime));
        }

        public async Task<IndustrializeManufactureJobBookResponse> IndustrializeManufactureJobBookWithOptionsAsync(string userId, IndustrializeManufactureJobBookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstNo))
            {
                body["instNo"] = request.InstNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBatchJob))
            {
                body["isBatchJob"] = request.IsBatchJob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManufactureDate))
            {
                body["manufactureDate"] = request.ManufactureDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MesAppKey))
            {
                body["mesAppKey"] = request.MesAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessEnName))
            {
                body["processEnName"] = request.ProcessEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                body["processName"] = request.ProcessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductEnName))
            {
                body["productEnName"] = request.ProductEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualifiedQuantity))
            {
                body["qualifiedQuantity"] = request.QualifiedQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReworkableQuantity))
            {
                body["reworkableQuantity"] = request.ReworkableQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScrappedQuantity))
            {
                body["scrappedQuantity"] = request.ScrappedQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitPrice))
            {
                body["unitPrice"] = request.UnitPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNameList))
            {
                body["userNameList"] = request.UserNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<IndustrializeManufactureJobBookResponse>(await DoROARequestAsync("IndustrializeManufactureJobBook", "manufacturing_1.0", "HTTP", "POST", "AK", "/v1.0/manufacturing/users/" + userId + "/jobs", "json", req, runtime));
        }

        public IndustrializeManufactureQueryJobsResponse IndustrializeManufactureQueryJobs(IndustrializeManufactureQueryJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustrializeManufactureQueryJobsHeaders headers = new IndustrializeManufactureQueryJobsHeaders();
            return IndustrializeManufactureQueryJobsWithOptions(request, headers, runtime);
        }

        public async Task<IndustrializeManufactureQueryJobsResponse> IndustrializeManufactureQueryJobsAsync(IndustrializeManufactureQueryJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustrializeManufactureQueryJobsHeaders headers = new IndustrializeManufactureQueryJobsHeaders();
            return await IndustrializeManufactureQueryJobsWithOptionsAsync(request, headers, runtime);
        }

        public IndustrializeManufactureQueryJobsResponse IndustrializeManufactureQueryJobsWithOptions(IndustrializeManufactureQueryJobsRequest request, IndustrializeManufactureQueryJobsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["currentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstNo))
            {
                body["instNo"] = request.InstNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManufactureDay))
            {
                body["manufactureDay"] = request.ManufactureDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MesAppKey))
            {
                body["mesAppKey"] = request.MesAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                body["processName"] = request.ProcessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualifiedQuantity))
            {
                body["qualifiedQuantity"] = request.QualifiedQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitPrice))
            {
                body["unitPrice"] = request.UnitPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
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
            return TeaModel.ToObject<IndustrializeManufactureQueryJobsResponse>(DoROARequest("IndustrializeManufactureQueryJobs", "manufacturing_1.0", "HTTP", "POST", "AK", "/v1.0/manufacturing/users/jobs/query", "json", req, runtime));
        }

        public async Task<IndustrializeManufactureQueryJobsResponse> IndustrializeManufactureQueryJobsWithOptionsAsync(IndustrializeManufactureQueryJobsRequest request, IndustrializeManufactureQueryJobsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["currentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstNo))
            {
                body["instNo"] = request.InstNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManufactureDay))
            {
                body["manufactureDay"] = request.ManufactureDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MesAppKey))
            {
                body["mesAppKey"] = request.MesAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                body["processName"] = request.ProcessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualifiedQuantity))
            {
                body["qualifiedQuantity"] = request.QualifiedQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitPrice))
            {
                body["unitPrice"] = request.UnitPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
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
            return TeaModel.ToObject<IndustrializeManufactureQueryJobsResponse>(await DoROARequestAsync("IndustrializeManufactureQueryJobs", "manufacturing_1.0", "HTTP", "POST", "AK", "/v1.0/manufacturing/users/jobs/query", "json", req, runtime));
        }

    }
}
