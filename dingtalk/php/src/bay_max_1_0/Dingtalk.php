<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbay_max_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vbay_max_1_0\Models\QueryBaymaxSkillLogHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbay_max_1_0\Models\QueryBaymaxSkillLogRequest;
use AlibabaCloud\SDK\Dingtalk\Vbay_max_1_0\Models\QueryBaymaxSkillLogResponse;
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
     * @param QueryBaymaxSkillLogRequest $request
     * @param QueryBaymaxSkillLogHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryBaymaxSkillLogResponse
     */
    public function queryBaymaxSkillLogWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->from)) {
            $query['from'] = $request->from;
        }
        if (!Utils::isUnset($request->skillExecuteId)) {
            $query['skillExecuteId'] = $request->skillExecuteId;
        }
        if (!Utils::isUnset($request->to)) {
            $query['to'] = $request->to;
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
            'action'      => 'QueryBaymaxSkillLog',
            'version'     => 'bayMax_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bayMax/skills/logs',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryBaymaxSkillLogResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryBaymaxSkillLogRequest $request
     *
     * @return QueryBaymaxSkillLogResponse
     */
    public function queryBaymaxSkillLog($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBaymaxSkillLogHeaders([]);

        return $this->queryBaymaxSkillLogWithOptions($request, $headers, $runtime);
    }
}
