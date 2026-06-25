<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmcp_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\ActivateMcpHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\ActivateMcpRequest;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\ActivateMcpResponse;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\DeleteMcpHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\DeleteMcpRequest;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\DeleteMcpResponse;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\GetMcpDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\GetMcpDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\GetSkillDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\GetSkillDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\ListMarketMcpsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\ListMarketMcpsRequest;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\ListMarketMcpsResponse;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\ListSkillsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\ListSkillsRequest;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\ListSkillsResponse;
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
        $gatewayClient = new Client();
        $this->_spi = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 激活MCP
     *  *
     * @param ActivateMcpRequest $request ActivateMcpRequest
     * @param ActivateMcpHeaders $headers ActivateMcpHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return ActivateMcpResponse ActivateMcpResponse
     */
    public function activateMcpWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->mcpId)) {
            $body['mcpId'] = $request->mcpId;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ActivateMcp',
            'version' => 'mcp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mcp/activate',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ActivateMcpResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 激活MCP
     *  *
     * @param ActivateMcpRequest $request ActivateMcpRequest
     *
     * @return ActivateMcpResponse ActivateMcpResponse
     */
    public function activateMcp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ActivateMcpHeaders([]);

        return $this->activateMcpWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除MCP实例
     *  *
     * @param DeleteMcpRequest $request DeleteMcpRequest
     * @param DeleteMcpHeaders $headers DeleteMcpHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteMcpResponse DeleteMcpResponse
     */
    public function deleteMcpWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->instanceId)) {
            $body['instanceId'] = $request->instanceId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'DeleteMcp',
            'version' => 'mcp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mcp/delete',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteMcpResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除MCP实例
     *  *
     * @param DeleteMcpRequest $request DeleteMcpRequest
     *
     * @return DeleteMcpResponse DeleteMcpResponse
     */
    public function deleteMcp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteMcpHeaders([]);

        return $this->deleteMcpWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据mcpId获取MCP详情
     *  *
     * @param string              $mcpId
     * @param GetMcpDetailHeaders $headers GetMcpDetailHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetMcpDetailResponse GetMcpDetailResponse
     */
    public function getMcpDetailWithOptions($mcpId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action' => 'GetMcpDetail',
            'version' => 'mcp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mcp/mcps/' . $mcpId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetMcpDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据mcpId获取MCP详情
     *  *
     * @param string $mcpId
     *
     * @return GetMcpDetailResponse GetMcpDetailResponse
     */
    public function getMcpDetail($mcpId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMcpDetailHeaders([]);

        return $this->getMcpDetailWithOptions($mcpId, $headers, $runtime);
    }

    /**
     * @summary 根据skillId查询Skill详情及安装包下载链接
     *  *
     * @param string                $skillId
     * @param GetSkillDetailHeaders $headers GetSkillDetailHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSkillDetailResponse GetSkillDetailResponse
     */
    public function getSkillDetailWithOptions($skillId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action' => 'GetSkillDetail',
            'version' => 'mcp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mcp/skills/' . $skillId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSkillDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据skillId查询Skill详情及安装包下载链接
     *  *
     * @param string $skillId
     *
     * @return GetSkillDetailResponse GetSkillDetailResponse
     */
    public function getSkillDetail($skillId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSkillDetailHeaders([]);

        return $this->getSkillDetailWithOptions($skillId, $headers, $runtime);
    }

    /**
     * @summary 查询MCP广场精选MCP列表
     *  *
     * @param ListMarketMcpsRequest $request ListMarketMcpsRequest
     * @param ListMarketMcpsHeaders $headers ListMarketMcpsHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return ListMarketMcpsResponse ListMarketMcpsResponse
     */
    public function listMarketMcpsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->page)) {
            $query['page'] = $request->page;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ListMarketMcps',
            'version' => 'mcp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mcp/mcps',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListMarketMcpsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询MCP广场精选MCP列表
     *  *
     * @param ListMarketMcpsRequest $request ListMarketMcpsRequest
     *
     * @return ListMarketMcpsResponse ListMarketMcpsResponse
     */
    public function listMarketMcps($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListMarketMcpsHeaders([]);

        return $this->listMarketMcpsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页查询Skill广场精选列表
     *  *
     * @param ListSkillsRequest $request ListSkillsRequest
     * @param ListSkillsHeaders $headers ListSkillsHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return ListSkillsResponse ListSkillsResponse
     */
    public function listSkillsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->page)) {
            $query['page'] = $request->page;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ListSkills',
            'version' => 'mcp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mcp/skills',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListSkillsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页查询Skill广场精选列表
     *  *
     * @param ListSkillsRequest $request ListSkillsRequest
     *
     * @return ListSkillsResponse ListSkillsResponse
     */
    public function listSkills($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSkillsHeaders([]);

        return $this->listSkillsWithOptions($request, $headers, $runtime);
    }
}
