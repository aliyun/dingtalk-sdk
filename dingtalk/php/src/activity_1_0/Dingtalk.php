<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vactivity_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vactivity_1_0\Models\CreateActivityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vactivity_1_0\Models\CreateActivityRequest;
use AlibabaCloud\SDK\Dingtalk\Vactivity_1_0\Models\CreateActivityResponse;
use AlibabaCloud\SDK\Dingtalk\Vactivity_1_0\Models\ListActivityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vactivity_1_0\Models\ListActivityRequest;
use AlibabaCloud\SDK\Dingtalk\Vactivity_1_0\Models\ListActivityResponse;
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
     * @param CreateActivityRequest $request
     * @param CreateActivityHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CreateActivityResponse
     */
    public function createActivityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->detail)) {
            $body['detail'] = $request->detail;
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
            'action'      => 'CreateActivity',
            'version'     => 'activity_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/activity/meta',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateActivityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateActivityRequest $request
     *
     * @return CreateActivityResponse
     */
    public function createActivity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateActivityHeaders([]);

        return $this->createActivityWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListActivityRequest $request
     * @param ListActivityHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return ListActivityResponse
     */
    public function listActivityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
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
            'action'      => 'ListActivity',
            'version'     => 'activity_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/activity/metaLists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListActivityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListActivityRequest $request
     *
     * @return ListActivityResponse
     */
    public function listActivity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListActivityHeaders([]);

        return $this->listActivityWithOptions($request, $headers, $runtime);
    }
}
