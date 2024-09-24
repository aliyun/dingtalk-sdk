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
use Darabonba\GatewayDingTalk\Client;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $this->_productId    = 'dingtalk';
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 获取用户的减碳明细
     *  *
     * @param GetPersonalCarbonInfoRequest $request GetPersonalCarbonInfoRequest
     * @param GetPersonalCarbonInfoHeaders $headers GetPersonalCarbonInfoHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPersonalCarbonInfoResponse GetPersonalCarbonInfoResponse
     */
    public function getPersonalCarbonInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->actionType)) {
            $query['actionType'] = $request->actionType;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetPersonalCarbonInfo',
            'version'     => 'carbon_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/carbon/personals/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetPersonalCarbonInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用户的减碳明细
     *  *
     * @param GetPersonalCarbonInfoRequest $request GetPersonalCarbonInfoRequest
     *
     * @return GetPersonalCarbonInfoResponse GetPersonalCarbonInfoResponse
     */
    public function getPersonalCarbonInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPersonalCarbonInfoHeaders([]);

        return $this->getPersonalCarbonInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 写入阿里巴巴每日组织明细碳能量数据
     *  *
     * @param WriteAlibabaOrgCarbonRequest $request WriteAlibabaOrgCarbonRequest
     * @param WriteAlibabaOrgCarbonHeaders $headers WriteAlibabaOrgCarbonHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return WriteAlibabaOrgCarbonResponse WriteAlibabaOrgCarbonResponse
     */
    public function writeAlibabaOrgCarbonWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->orgDetailsList)) {
            $body['orgDetailsList'] = $request->orgDetailsList;
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
            'action'      => 'WriteAlibabaOrgCarbon',
            'version'     => 'carbon_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/carbon/alibabaOrgDetails/write',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return WriteAlibabaOrgCarbonResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 写入阿里巴巴每日组织明细碳能量数据
     *  *
     * @param WriteAlibabaOrgCarbonRequest $request WriteAlibabaOrgCarbonRequest
     *
     * @return WriteAlibabaOrgCarbonResponse WriteAlibabaOrgCarbonResponse
     */
    public function writeAlibabaOrgCarbon($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WriteAlibabaOrgCarbonHeaders([]);

        return $this->writeAlibabaOrgCarbonWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 写入阿里巴巴每日用户碳能量数据
     *  *
     * @param WriteAlibabaUserCarbonRequest $request WriteAlibabaUserCarbonRequest
     * @param WriteAlibabaUserCarbonHeaders $headers WriteAlibabaUserCarbonHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return WriteAlibabaUserCarbonResponse WriteAlibabaUserCarbonResponse
     */
    public function writeAlibabaUserCarbonWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userDetailsList)) {
            $body['userDetailsList'] = $request->userDetailsList;
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
            'action'      => 'WriteAlibabaUserCarbon',
            'version'     => 'carbon_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/carbon/alibabaUserDetails/write',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return WriteAlibabaUserCarbonResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 写入阿里巴巴每日用户碳能量数据
     *  *
     * @param WriteAlibabaUserCarbonRequest $request WriteAlibabaUserCarbonRequest
     *
     * @return WriteAlibabaUserCarbonResponse WriteAlibabaUserCarbonResponse
     */
    public function writeAlibabaUserCarbon($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WriteAlibabaUserCarbonHeaders([]);

        return $this->writeAlibabaUserCarbonWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary ISV记录数据传输当前状态
     *  *
     * @param WriteIsvStateRequest $request WriteIsvStateRequest
     * @param WriteIsvStateHeaders $headers WriteIsvStateHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return WriteIsvStateResponse WriteIsvStateResponse
     */
    public function writeIsvStateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->isvName)) {
            $query['isvName'] = $request->isvName;
        }
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'WriteIsvState',
            'version'     => 'carbon_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/carbon/datas/states/write',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return WriteIsvStateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary ISV记录数据传输当前状态
     *  *
     * @param WriteIsvStateRequest $request WriteIsvStateRequest
     *
     * @return WriteIsvStateResponse WriteIsvStateResponse
     */
    public function writeIsvState($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WriteIsvStateHeaders([]);

        return $this->writeIsvStateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 写入isv每日组织明细碳能量数据
     *  *
     * @param WriteOrgCarbonRequest $request WriteOrgCarbonRequest
     * @param WriteOrgCarbonHeaders $headers WriteOrgCarbonHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return WriteOrgCarbonResponse WriteOrgCarbonResponse
     */
    public function writeOrgCarbonWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->orgDetailsList)) {
            $body['orgDetailsList'] = $request->orgDetailsList;
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
            'action'      => 'WriteOrgCarbon',
            'version'     => 'carbon_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/carbon/orgDetails/write',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return WriteOrgCarbonResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 写入isv每日组织明细碳能量数据
     *  *
     * @param WriteOrgCarbonRequest $request WriteOrgCarbonRequest
     *
     * @return WriteOrgCarbonResponse WriteOrgCarbonResponse
     */
    public function writeOrgCarbon($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WriteOrgCarbonHeaders([]);

        return $this->writeOrgCarbonWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 写入isv每日用户明细碳能量数据
     *  *
     * @param WriteUserCarbonRequest $request WriteUserCarbonRequest
     * @param WriteUserCarbonHeaders $headers WriteUserCarbonHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return WriteUserCarbonResponse WriteUserCarbonResponse
     */
    public function writeUserCarbonWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userDetailsList)) {
            $body['userDetailsList'] = $request->userDetailsList;
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
            'action'      => 'WriteUserCarbon',
            'version'     => 'carbon_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/carbon/userDetails/write',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return WriteUserCarbonResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 写入isv每日用户明细碳能量数据
     *  *
     * @param WriteUserCarbonRequest $request WriteUserCarbonRequest
     *
     * @return WriteUserCarbonResponse WriteUserCarbonResponse
     */
    public function writeUserCarbon($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WriteUserCarbonHeaders([]);

        return $this->writeUserCarbonWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 写入isv能耗每日用户明细碳能量数据
     *  *
     * @param WriteUserCarbonEnergyRequest $request WriteUserCarbonEnergyRequest
     * @param WriteUserCarbonEnergyHeaders $headers WriteUserCarbonEnergyHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return WriteUserCarbonEnergyResponse WriteUserCarbonEnergyResponse
     */
    public function writeUserCarbonEnergyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userDetailsList)) {
            $body['userDetailsList'] = $request->userDetailsList;
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
            'action'      => 'WriteUserCarbonEnergy',
            'version'     => 'carbon_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/carbon/userDetails/energies/write',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return WriteUserCarbonEnergyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 写入isv能耗每日用户明细碳能量数据
     *  *
     * @param WriteUserCarbonEnergyRequest $request WriteUserCarbonEnergyRequest
     *
     * @return WriteUserCarbonEnergyResponse WriteUserCarbonEnergyResponse
     */
    public function writeUserCarbonEnergy($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WriteUserCarbonEnergyHeaders([]);

        return $this->writeUserCarbonEnergyWithOptions($request, $headers, $runtime);
    }
}
