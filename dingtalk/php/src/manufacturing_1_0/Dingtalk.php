<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0\Models\IndustrializeManufactureJobBookRequest;
use AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0\Models\IndustrializeManufactureJobBookResponse;
use AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0\Models\IndustrializeManufactureQueryJobsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0\Models\IndustrializeManufactureQueryJobsRequest;
use AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0\Models\IndustrializeManufactureQueryJobsResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client as DarabonbaGatewayDingTalkClient;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    protected $_client;

    public function __construct($config)
    {
        parent::__construct($config);
        $this->_client             = new DarabonbaGatewayDingTalkClient();
        $this->_spi                = $this->_client;
        $this->_signatureAlgorithm = 'v2';
        $this->_endpointRule       = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param string                                 $userId
     * @param IndustrializeManufactureJobBookRequest $request
     * @param string[]                               $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return IndustrializeManufactureJobBookResponse
     */
    public function industrializeManufactureJobBookWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extend)) {
            $body['extend'] = $request->extend;
        }
        if (!Utils::isUnset($request->instNo)) {
            $body['instNo'] = $request->instNo;
        }
        if (!Utils::isUnset($request->isBatchJob)) {
            $body['isBatchJob'] = $request->isBatchJob;
        }
        if (!Utils::isUnset($request->manufactureDate)) {
            $body['manufactureDate'] = $request->manufactureDate;
        }
        if (!Utils::isUnset($request->mesAppKey)) {
            $body['mesAppKey'] = $request->mesAppKey;
        }
        if (!Utils::isUnset($request->processEnName)) {
            $body['processEnName'] = $request->processEnName;
        }
        if (!Utils::isUnset($request->processName)) {
            $body['processName'] = $request->processName;
        }
        if (!Utils::isUnset($request->productCode)) {
            $body['productCode'] = $request->productCode;
        }
        if (!Utils::isUnset($request->productEnName)) {
            $body['productEnName'] = $request->productEnName;
        }
        if (!Utils::isUnset($request->productName)) {
            $body['productName'] = $request->productName;
        }
        if (!Utils::isUnset($request->productSpecification)) {
            $body['productSpecification'] = $request->productSpecification;
        }
        if (!Utils::isUnset($request->qualifiedQuantity)) {
            $body['qualifiedQuantity'] = $request->qualifiedQuantity;
        }
        if (!Utils::isUnset($request->reworkableQuantity)) {
            $body['reworkableQuantity'] = $request->reworkableQuantity;
        }
        if (!Utils::isUnset($request->scrappedQuantity)) {
            $body['scrappedQuantity'] = $request->scrappedQuantity;
        }
        if (!Utils::isUnset($request->unitPrice)) {
            $body['unitPrice'] = $request->unitPrice;
        }
        if (!Utils::isUnset($request->userIdList)) {
            $body['userIdList'] = $request->userIdList;
        }
        if (!Utils::isUnset($request->userName)) {
            $body['userName'] = $request->userName;
        }
        if (!Utils::isUnset($request->userNameList)) {
            $body['userNameList'] = $request->userNameList;
        }
        if (!Utils::isUnset($request->uuid)) {
            $body['uuid'] = $request->uuid;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'IndustrializeManufactureJobBook',
            'version'     => 'manufacturing_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/manufacturing/users/' . $userId . '/jobs',
            'method'      => 'POST',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IndustrializeManufactureJobBookResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                                 $userId
     * @param IndustrializeManufactureJobBookRequest $request
     *
     * @return IndustrializeManufactureJobBookResponse
     */
    public function industrializeManufactureJobBook($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->industrializeManufactureJobBookWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param IndustrializeManufactureQueryJobsRequest $request
     * @param IndustrializeManufactureQueryJobsHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return IndustrializeManufactureQueryJobsResponse
     */
    public function industrializeManufactureQueryJobsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->currentPage)) {
            $body['currentPage'] = $request->currentPage;
        }
        if (!Utils::isUnset($request->instNo)) {
            $body['instNo'] = $request->instNo;
        }
        if (!Utils::isUnset($request->manufactureDay)) {
            $body['manufactureDay'] = $request->manufactureDay;
        }
        if (!Utils::isUnset($request->mesAppKey)) {
            $body['mesAppKey'] = $request->mesAppKey;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->processName)) {
            $body['processName'] = $request->processName;
        }
        if (!Utils::isUnset($request->productCode)) {
            $body['productCode'] = $request->productCode;
        }
        if (!Utils::isUnset($request->productName)) {
            $body['productName'] = $request->productName;
        }
        if (!Utils::isUnset($request->productSpecification)) {
            $body['productSpecification'] = $request->productSpecification;
        }
        if (!Utils::isUnset($request->qualifiedQuantity)) {
            $body['qualifiedQuantity'] = $request->qualifiedQuantity;
        }
        if (!Utils::isUnset($request->unitPrice)) {
            $body['unitPrice'] = $request->unitPrice;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->userIdList)) {
            $body['userIdList'] = $request->userIdList;
        }
        if (!Utils::isUnset($request->userName)) {
            $body['userName'] = $request->userName;
        }
        if (!Utils::isUnset($request->uuid)) {
            $body['uuid'] = $request->uuid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'IndustrializeManufactureQueryJobs',
            'version'     => 'manufacturing_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/manufacturing/users/jobs/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IndustrializeManufactureQueryJobsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param IndustrializeManufactureQueryJobsRequest $request
     *
     * @return IndustrializeManufactureQueryJobsResponse
     */
    public function industrializeManufactureQueryJobs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustrializeManufactureQueryJobsHeaders([]);

        return $this->industrializeManufactureQueryJobsWithOptions($request, $headers, $runtime);
    }
}
