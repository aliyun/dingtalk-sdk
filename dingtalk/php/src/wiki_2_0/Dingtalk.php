<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\AddTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\AddTeamRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\AddTeamResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\AddWorkspaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\AddWorkspaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\AddWorkspaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\DeleteTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\DeleteTeamRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\DeleteTeamResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetDefaultHandOverUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetDefaultHandOverUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetDefaultHandOverUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetMineWorkspaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetMineWorkspaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetMineWorkspaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetNodeByUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetNodeByUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetNodeByUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetNodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetNodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetNodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetNodesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetNodesRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetNodesResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetTeamRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetTeamResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetWorkspaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetWorkspaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetWorkspaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetWorkspacesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetWorkspacesRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetWorkspacesResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\HandOverWorkspaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\HandOverWorkspaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\HandOverWorkspaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListNodesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListNodesRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListNodesResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListTeamsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListTeamsRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListTeamsResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListWorkspacesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListWorkspacesRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListWorkspacesResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\SetDefaultHandOverUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\SetDefaultHandOverUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\SetDefaultHandOverUserResponse;
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
     * @summary 新建知识小组
     *  *
     * @param AddTeamRequest $request AddTeamRequest
     * @param AddTeamHeaders $headers AddTeamHeaders
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return AddTeamResponse AddTeamResponse
     */
    public function addTeamWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AddTeam',
            'version'     => 'wiki_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/wiki/teams',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddTeamResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新建知识小组
     *  *
     * @param AddTeamRequest $request AddTeamRequest
     *
     * @return AddTeamResponse AddTeamResponse
     */
    public function addTeam($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddTeamHeaders([]);

        return $this->addTeamWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 新建知识库
     *  *
     * @param AddWorkspaceRequest $request AddWorkspaceRequest
     * @param AddWorkspaceHeaders $headers AddWorkspaceHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return AddWorkspaceResponse AddWorkspaceResponse
     */
    public function addWorkspaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AddWorkspace',
            'version'     => 'wiki_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/wiki/workspaces',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddWorkspaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新建知识库
     *  *
     * @param AddWorkspaceRequest $request AddWorkspaceRequest
     *
     * @return AddWorkspaceResponse AddWorkspaceResponse
     */
    public function addWorkspace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddWorkspaceHeaders([]);

        return $this->addWorkspaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除知识小组
     *  *
     * @param string            $teamId
     * @param DeleteTeamRequest $request DeleteTeamRequest
     * @param DeleteTeamHeaders $headers DeleteTeamHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteTeamResponse DeleteTeamResponse
     */
    public function deleteTeamWithOptions($teamId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'DeleteTeam',
            'version'     => 'wiki_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/wiki/teams/' . $teamId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteTeamResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除知识小组
     *  *
     * @param string            $teamId
     * @param DeleteTeamRequest $request DeleteTeamRequest
     *
     * @return DeleteTeamResponse DeleteTeamResponse
     */
    public function deleteTeam($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteTeamHeaders([]);

        return $this->deleteTeamWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询员工离职时知识库默认转交人
     *  *
     * @param GetDefaultHandOverUserRequest $request GetDefaultHandOverUserRequest
     * @param GetDefaultHandOverUserHeaders $headers GetDefaultHandOverUserHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDefaultHandOverUserResponse GetDefaultHandOverUserResponse
     */
    public function getDefaultHandOverUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'GetDefaultHandOverUser',
            'version'     => 'wiki_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/wiki/managementSettings/defaultHandOverUsers',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDefaultHandOverUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询员工离职时知识库默认转交人
     *  *
     * @param GetDefaultHandOverUserRequest $request GetDefaultHandOverUserRequest
     *
     * @return GetDefaultHandOverUserResponse GetDefaultHandOverUserResponse
     */
    public function getDefaultHandOverUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDefaultHandOverUserHeaders([]);

        return $this->getDefaultHandOverUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取我的文档
     *  *
     * @param GetMineWorkspaceRequest $request GetMineWorkspaceRequest
     * @param GetMineWorkspaceHeaders $headers GetMineWorkspaceHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetMineWorkspaceResponse GetMineWorkspaceResponse
     */
    public function getMineWorkspaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'GetMineWorkspace',
            'version'     => 'wiki_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/wiki/mineWorkspaces',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetMineWorkspaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取我的文档
     *  *
     * @param GetMineWorkspaceRequest $request GetMineWorkspaceRequest
     *
     * @return GetMineWorkspaceResponse GetMineWorkspaceResponse
     */
    public function getMineWorkspace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMineWorkspaceHeaders([]);

        return $this->getMineWorkspaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取节点
     *  *
     * @param string         $nodeId
     * @param GetNodeRequest $request GetNodeRequest
     * @param GetNodeHeaders $headers GetNodeHeaders
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return GetNodeResponse GetNodeResponse
     */
    public function getNodeWithOptions($nodeId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->withPermissionRole)) {
            $query['withPermissionRole'] = $request->withPermissionRole;
        }
        if (!Utils::isUnset($request->withStatisticalInfo)) {
            $query['withStatisticalInfo'] = $request->withStatisticalInfo;
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
            'action'      => 'GetNode',
            'version'     => 'wiki_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/wiki/nodes/' . $nodeId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetNodeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取节点
     *  *
     * @param string         $nodeId
     * @param GetNodeRequest $request GetNodeRequest
     *
     * @return GetNodeResponse GetNodeResponse
     */
    public function getNode($nodeId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetNodeHeaders([]);

        return $this->getNodeWithOptions($nodeId, $request, $headers, $runtime);
    }

    /**
     * @summary 通过链接获取节点
     *  *
     * @param GetNodeByUrlRequest $request GetNodeByUrlRequest
     * @param GetNodeByUrlHeaders $headers GetNodeByUrlHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetNodeByUrlResponse GetNodeByUrlResponse
     */
    public function getNodeByUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->url)) {
            $body['url'] = $request->url;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetNodeByUrl',
            'version'     => 'wiki_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/wiki/nodes/queryByUrl',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetNodeByUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过链接获取节点
     *  *
     * @param GetNodeByUrlRequest $request GetNodeByUrlRequest
     *
     * @return GetNodeByUrlResponse GetNodeByUrlResponse
     */
    public function getNodeByUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetNodeByUrlHeaders([]);

        return $this->getNodeByUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量获取节点
     *  *
     * @param GetNodesRequest $request GetNodesRequest
     * @param GetNodesHeaders $headers GetNodesHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetNodesResponse GetNodesResponse
     */
    public function getNodesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->nodeIds)) {
            $body['nodeIds'] = $request->nodeIds;
        }
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetNodes',
            'version'     => 'wiki_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/wiki/nodes/batchQuery',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetNodesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量获取节点
     *  *
     * @param GetNodesRequest $request GetNodesRequest
     *
     * @return GetNodesResponse GetNodesResponse
     */
    public function getNodes($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetNodesHeaders([]);

        return $this->getNodesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取知识小组
     *  *
     * @param string         $teamId
     * @param GetTeamRequest $request GetTeamRequest
     * @param GetTeamHeaders $headers GetTeamHeaders
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTeamResponse GetTeamResponse
     */
    public function getTeamWithOptions($teamId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'GetTeam',
            'version'     => 'wiki_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/wiki/teams/' . $teamId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTeamResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取知识小组
     *  *
     * @param string         $teamId
     * @param GetTeamRequest $request GetTeamRequest
     *
     * @return GetTeamResponse GetTeamResponse
     */
    public function getTeam($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTeamHeaders([]);

        return $this->getTeamWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取知识库
     *  *
     * @param string              $workspaceId
     * @param GetWorkspaceRequest $request     GetWorkspaceRequest
     * @param GetWorkspaceHeaders $headers     GetWorkspaceHeaders
     * @param RuntimeOptions      $runtime     runtime options for this request RuntimeOptions
     *
     * @return GetWorkspaceResponse GetWorkspaceResponse
     */
    public function getWorkspaceWithOptions($workspaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->withPermissionRole)) {
            $query['withPermissionRole'] = $request->withPermissionRole;
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
            'action'      => 'GetWorkspace',
            'version'     => 'wiki_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/wiki/workspaces/' . $workspaceId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetWorkspaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取知识库
     *  *
     * @param string              $workspaceId
     * @param GetWorkspaceRequest $request     GetWorkspaceRequest
     *
     * @return GetWorkspaceResponse GetWorkspaceResponse
     */
    public function getWorkspace($workspaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetWorkspaceHeaders([]);

        return $this->getWorkspaceWithOptions($workspaceId, $request, $headers, $runtime);
    }

    /**
     * @summary 批量获取知识库
     *  *
     * @param GetWorkspacesRequest $request GetWorkspacesRequest
     * @param GetWorkspacesHeaders $headers GetWorkspacesHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetWorkspacesResponse GetWorkspacesResponse
     */
    public function getWorkspacesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->workspaceIds)) {
            $body['workspaceIds'] = $request->workspaceIds;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetWorkspaces',
            'version'     => 'wiki_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/wiki/workspaces/batchQuery',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetWorkspacesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量获取知识库
     *  *
     * @param GetWorkspacesRequest $request GetWorkspacesRequest
     *
     * @return GetWorkspacesResponse GetWorkspacesResponse
     */
    public function getWorkspaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetWorkspacesHeaders([]);

        return $this->getWorkspacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 转交知识库
     *  *
     * @param HandOverWorkspaceRequest $request HandOverWorkspaceRequest
     * @param HandOverWorkspaceHeaders $headers HandOverWorkspaceHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return HandOverWorkspaceResponse HandOverWorkspaceResponse
     */
    public function handOverWorkspaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->sourceOwnerId)) {
            $body['sourceOwnerId'] = $request->sourceOwnerId;
        }
        if (!Utils::isUnset($request->targetOwnerId)) {
            $body['targetOwnerId'] = $request->targetOwnerId;
        }
        if (!Utils::isUnset($request->workspaceId)) {
            $body['workspaceId'] = $request->workspaceId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'HandOverWorkspace',
            'version'     => 'wiki_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/wiki/managementOperations/workspaces/handOver',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HandOverWorkspaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 转交知识库
     *  *
     * @param HandOverWorkspaceRequest $request HandOverWorkspaceRequest
     *
     * @return HandOverWorkspaceResponse HandOverWorkspaceResponse
     */
    public function handOverWorkspace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HandOverWorkspaceHeaders([]);

        return $this->handOverWorkspaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取节点列表
     *  *
     * @param ListNodesRequest $request ListNodesRequest
     * @param ListNodesHeaders $headers ListNodesHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return ListNodesResponse ListNodesResponse
     */
    public function listNodesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->parentNodeId)) {
            $query['parentNodeId'] = $request->parentNodeId;
        }
        if (!Utils::isUnset($request->withPermissionRole)) {
            $query['withPermissionRole'] = $request->withPermissionRole;
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
            'action'      => 'ListNodes',
            'version'     => 'wiki_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/wiki/nodes',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListNodesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取节点列表
     *  *
     * @param ListNodesRequest $request ListNodesRequest
     *
     * @return ListNodesResponse ListNodesResponse
     */
    public function listNodes($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListNodesHeaders([]);

        return $this->listNodesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取知识小组列表
     *  *
     * @param ListTeamsRequest $request ListTeamsRequest
     * @param ListTeamsHeaders $headers ListTeamsHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return ListTeamsResponse ListTeamsResponse
     */
    public function listTeamsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'ListTeams',
            'version'     => 'wiki_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/wiki/teams',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListTeamsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取知识小组列表
     *  *
     * @param ListTeamsRequest $request ListTeamsRequest
     *
     * @return ListTeamsResponse ListTeamsResponse
     */
    public function listTeams($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListTeamsHeaders([]);

        return $this->listTeamsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取知识库列表
     *  *
     * @param ListWorkspacesRequest $request ListWorkspacesRequest
     * @param ListWorkspacesHeaders $headers ListWorkspacesHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return ListWorkspacesResponse ListWorkspacesResponse
     */
    public function listWorkspacesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->orderBy)) {
            $query['orderBy'] = $request->orderBy;
        }
        if (!Utils::isUnset($request->teamId)) {
            $query['teamId'] = $request->teamId;
        }
        if (!Utils::isUnset($request->withPermissionRole)) {
            $query['withPermissionRole'] = $request->withPermissionRole;
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
            'action'      => 'ListWorkspaces',
            'version'     => 'wiki_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/wiki/workspaces',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListWorkspacesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取知识库列表
     *  *
     * @param ListWorkspacesRequest $request ListWorkspacesRequest
     *
     * @return ListWorkspacesResponse ListWorkspacesResponse
     */
    public function listWorkspaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListWorkspacesHeaders([]);

        return $this->listWorkspacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设置员工离职时知识库默认转交人
     *  *
     * @param SetDefaultHandOverUserRequest $request SetDefaultHandOverUserRequest
     * @param SetDefaultHandOverUserHeaders $headers SetDefaultHandOverUserHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return SetDefaultHandOverUserResponse SetDefaultHandOverUserResponse
     */
    public function setDefaultHandOverUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->defaultHandoverUserId)) {
            $body['defaultHandoverUserId'] = $request->defaultHandoverUserId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SetDefaultHandOverUser',
            'version'     => 'wiki_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/wiki/managementSettings/defaultHandOverUsers/set',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SetDefaultHandOverUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置员工离职时知识库默认转交人
     *  *
     * @param SetDefaultHandOverUserRequest $request SetDefaultHandOverUserRequest
     *
     * @return SetDefaultHandOverUserResponse SetDefaultHandOverUserResponse
     */
    public function setDefaultHandOverUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetDefaultHandOverUserHeaders([]);

        return $this->setDefaultHandOverUserWithOptions($request, $headers, $runtime);
    }
}
