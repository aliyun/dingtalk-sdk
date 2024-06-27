<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voccupationauth_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Voccupationauth_1_0\Models\CheckUserTasksStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Voccupationauth_1_0\Models\CheckUserTasksStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Voccupationauth_1_0\Models\CheckUserTasksStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Voccupationauth_1_0\Models\CheckUserTaskStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Voccupationauth_1_0\Models\CheckUserTaskStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Voccupationauth_1_0\Models\CheckUserTaskStatusResponse;
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
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 检查用户任务状态
     *  *
     * @param CheckUserTaskStatusRequest $request CheckUserTaskStatusRequest
     * @param CheckUserTaskStatusHeaders $headers CheckUserTaskStatusHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return CheckUserTaskStatusResponse CheckUserTaskStatusResponse
     */
    public function checkUserTaskStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->provinceCode)) {
            $body['provinceCode'] = $request->provinceCode;
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
            'action'      => 'CheckUserTaskStatus',
            'version'     => 'occupationauth_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/occupationauth/auths/userTasks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CheckUserTaskStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 检查用户任务状态
     *  *
     * @param CheckUserTaskStatusRequest $request CheckUserTaskStatusRequest
     *
     * @return CheckUserTaskStatusResponse CheckUserTaskStatusResponse
     */
    public function checkUserTaskStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckUserTaskStatusHeaders([]);

        return $this->checkUserTaskStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 检查用户任务状态
     *  *
     * @param CheckUserTasksStatusRequest $request CheckUserTasksStatusRequest
     * @param CheckUserTasksStatusHeaders $headers CheckUserTasksStatusHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return CheckUserTasksStatusResponse CheckUserTasksStatusResponse
     */
    public function checkUserTasksStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->provinceCode)) {
            $query['provinceCode'] = $request->provinceCode;
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
            'action'      => 'CheckUserTasksStatus',
            'version'     => 'occupationauth_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/occupationauth/userTasks/check',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CheckUserTasksStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 检查用户任务状态
     *  *
     * @param CheckUserTasksStatusRequest $request CheckUserTasksStatusRequest
     *
     * @return CheckUserTasksStatusResponse CheckUserTasksStatusResponse
     */
    public function checkUserTasksStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckUserTasksStatusHeaders([]);

        return $this->checkUserTasksStatusWithOptions($request, $headers, $runtime);
    }
}
