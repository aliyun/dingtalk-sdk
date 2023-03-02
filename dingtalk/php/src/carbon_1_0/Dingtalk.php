<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\GetPersonalCarbonInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\GetPersonalCarbonInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\GetPersonalCarbonInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteAlibabaOrgCarbonHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteAlibabaOrgCarbonRequest;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteAlibabaOrgCarbonResponse;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteAlibabaUserCarbonHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteAlibabaUserCarbonRequest;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteAlibabaUserCarbonResponse;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteIsvStateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteIsvStateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteIsvStateResponse;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteOrgCarbonHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteOrgCarbonRequest;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteOrgCarbonResponse;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteUserCarbonEnergyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteUserCarbonEnergyRequest;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteUserCarbonEnergyResponse;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteUserCarbonHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteUserCarbonRequest;
use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteUserCarbonResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param GetPersonalCarbonInfoRequest $request
     *
     * @return GetPersonalCarbonInfoResponse
     */
    public function getPersonalCarbonInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPersonalCarbonInfoHeaders([]);

        return $this->getPersonalCarbonInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetPersonalCarbonInfoRequest $request
     * @param GetPersonalCarbonInfoHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return GetPersonalCarbonInfoResponse
     */
    public function getPersonalCarbonInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->actionType)) {
            @$query['actionType'] = $request->actionType;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetPersonalCarbonInfoResponse::fromMap($this->doROARequest('GetPersonalCarbonInfo', 'carbon_1.0', 'HTTP', 'GET', 'AK', '/v1.0/carbon/personals/infos', 'json', $req, $runtime));
    }

    /**
     * @param WriteAlibabaOrgCarbonRequest $request
     *
     * @return WriteAlibabaOrgCarbonResponse
     */
    public function writeAlibabaOrgCarbon($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WriteAlibabaOrgCarbonHeaders([]);

        return $this->writeAlibabaOrgCarbonWithOptions($request, $headers, $runtime);
    }

    /**
     * @param WriteAlibabaOrgCarbonRequest $request
     * @param WriteAlibabaOrgCarbonHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return WriteAlibabaOrgCarbonResponse
     */
    public function writeAlibabaOrgCarbonWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->orgDetailsList)) {
            @$body['orgDetailsList'] = $request->orgDetailsList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return WriteAlibabaOrgCarbonResponse::fromMap($this->doROARequest('WriteAlibabaOrgCarbon', 'carbon_1.0', 'HTTP', 'POST', 'AK', '/v1.0/carbon/alibabaOrgDetails/write', 'json', $req, $runtime));
    }

    /**
     * @param WriteAlibabaUserCarbonRequest $request
     *
     * @return WriteAlibabaUserCarbonResponse
     */
    public function writeAlibabaUserCarbon($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WriteAlibabaUserCarbonHeaders([]);

        return $this->writeAlibabaUserCarbonWithOptions($request, $headers, $runtime);
    }

    /**
     * @param WriteAlibabaUserCarbonRequest $request
     * @param WriteAlibabaUserCarbonHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return WriteAlibabaUserCarbonResponse
     */
    public function writeAlibabaUserCarbonWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userDetailsList)) {
            @$body['userDetailsList'] = $request->userDetailsList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return WriteAlibabaUserCarbonResponse::fromMap($this->doROARequest('WriteAlibabaUserCarbon', 'carbon_1.0', 'HTTP', 'POST', 'AK', '/v1.0/carbon/alibabaUserDetails/write', 'json', $req, $runtime));
    }

    /**
     * @param WriteIsvStateRequest $request
     *
     * @return WriteIsvStateResponse
     */
    public function writeIsvState($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WriteIsvStateHeaders([]);

        return $this->writeIsvStateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param WriteIsvStateRequest $request
     * @param WriteIsvStateHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return WriteIsvStateResponse
     */
    public function writeIsvStateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->isvName)) {
            @$query['isvName'] = $request->isvName;
        }
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return WriteIsvStateResponse::fromMap($this->doROARequest('WriteIsvState', 'carbon_1.0', 'HTTP', 'POST', 'AK', '/v1.0/carbon/datas/states/write', 'json', $req, $runtime));
    }

    /**
     * @param WriteOrgCarbonRequest $request
     *
     * @return WriteOrgCarbonResponse
     */
    public function writeOrgCarbon($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WriteOrgCarbonHeaders([]);

        return $this->writeOrgCarbonWithOptions($request, $headers, $runtime);
    }

    /**
     * @param WriteOrgCarbonRequest $request
     * @param WriteOrgCarbonHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return WriteOrgCarbonResponse
     */
    public function writeOrgCarbonWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->orgDetailsList)) {
            @$body['orgDetailsList'] = $request->orgDetailsList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return WriteOrgCarbonResponse::fromMap($this->doROARequest('WriteOrgCarbon', 'carbon_1.0', 'HTTP', 'POST', 'AK', '/v1.0/carbon/orgDetails/write', 'json', $req, $runtime));
    }

    /**
     * @param WriteUserCarbonRequest $request
     *
     * @return WriteUserCarbonResponse
     */
    public function writeUserCarbon($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WriteUserCarbonHeaders([]);

        return $this->writeUserCarbonWithOptions($request, $headers, $runtime);
    }

    /**
     * @param WriteUserCarbonRequest $request
     * @param WriteUserCarbonHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return WriteUserCarbonResponse
     */
    public function writeUserCarbonWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userDetailsList)) {
            @$body['userDetailsList'] = $request->userDetailsList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return WriteUserCarbonResponse::fromMap($this->doROARequest('WriteUserCarbon', 'carbon_1.0', 'HTTP', 'POST', 'AK', '/v1.0/carbon/userDetails/write', 'json', $req, $runtime));
    }

    /**
     * @param WriteUserCarbonEnergyRequest $request
     *
     * @return WriteUserCarbonEnergyResponse
     */
    public function writeUserCarbonEnergy($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WriteUserCarbonEnergyHeaders([]);

        return $this->writeUserCarbonEnergyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param WriteUserCarbonEnergyRequest $request
     * @param WriteUserCarbonEnergyHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return WriteUserCarbonEnergyResponse
     */
    public function writeUserCarbonEnergyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userDetailsList)) {
            @$body['userDetailsList'] = $request->userDetailsList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return WriteUserCarbonEnergyResponse::fromMap($this->doROARequest('WriteUserCarbonEnergy', 'carbon_1.0', 'HTTP', 'POST', 'AK', '/v1.0/carbon/userDetails/energies/write', 'json', $req, $runtime));
    }
}
