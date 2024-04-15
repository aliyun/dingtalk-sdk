<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vamdp_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vamdp_1_0\Models\AmdpEmployeeDataPushHeaders;
use AlibabaCloud\SDK\Dingtalk\Vamdp_1_0\Models\AmdpEmployeeDataPushRequest;
use AlibabaCloud\SDK\Dingtalk\Vamdp_1_0\Models\AmdpEmployeeDataPushResponse;
use AlibabaCloud\SDK\Dingtalk\Vamdp_1_0\Models\AmdpJobPositionDataPushHeaders;
use AlibabaCloud\SDK\Dingtalk\Vamdp_1_0\Models\AmdpJobPositionDataPushRequest;
use AlibabaCloud\SDK\Dingtalk\Vamdp_1_0\Models\AmdpJobPositionDataPushResponse;
use AlibabaCloud\SDK\Dingtalk\Vamdp_1_0\Models\AmdpOrganizationDataPushHeaders;
use AlibabaCloud\SDK\Dingtalk\Vamdp_1_0\Models\AmdpOrganizationDataPushRequest;
use AlibabaCloud\SDK\Dingtalk\Vamdp_1_0\Models\AmdpOrganizationDataPushResponse;
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
        $this->_client       = new DarabonbaGatewayDingTalkClient();
        $this->_spi          = $this->_client;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param AmdpEmployeeDataPushRequest $request
     * @param AmdpEmployeeDataPushHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return AmdpEmployeeDataPushResponse
     */
    public function amdpEmployeeDataPushWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->param)) {
            $body['param'] = $request->param;
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
            'action'      => 'AmdpEmployeeDataPush',
            'version'     => 'amdp_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/amdp/employees/datas/push',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AmdpEmployeeDataPushResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AmdpEmployeeDataPushRequest $request
     *
     * @return AmdpEmployeeDataPushResponse
     */
    public function amdpEmployeeDataPush($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AmdpEmployeeDataPushHeaders([]);

        return $this->amdpEmployeeDataPushWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AmdpJobPositionDataPushRequest $request
     * @param AmdpJobPositionDataPushHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return AmdpJobPositionDataPushResponse
     */
    public function amdpJobPositionDataPushWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->param)) {
            $body['param'] = $request->param;
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
            'action'      => 'AmdpJobPositionDataPush',
            'version'     => 'amdp_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/amdp/empJobs/datas/push',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AmdpJobPositionDataPushResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AmdpJobPositionDataPushRequest $request
     *
     * @return AmdpJobPositionDataPushResponse
     */
    public function amdpJobPositionDataPush($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AmdpJobPositionDataPushHeaders([]);

        return $this->amdpJobPositionDataPushWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AmdpOrganizationDataPushRequest $request
     * @param AmdpOrganizationDataPushHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return AmdpOrganizationDataPushResponse
     */
    public function amdpOrganizationDataPushWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->param)) {
            $body['param'] = $request->param;
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
            'action'      => 'AmdpOrganizationDataPush',
            'version'     => 'amdp_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/amdp/organizations/datas/push',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AmdpOrganizationDataPushResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AmdpOrganizationDataPushRequest $request
     *
     * @return AmdpOrganizationDataPushResponse
     */
    public function amdpOrganizationDataPush($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AmdpOrganizationDataPushHeaders([]);

        return $this->amdpOrganizationDataPushWithOptions($request, $headers, $runtime);
    }
}
