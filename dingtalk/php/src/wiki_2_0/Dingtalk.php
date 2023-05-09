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
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListNodesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListNodesRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListNodesResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListTeamsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListTeamsRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListTeamsResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListWorkspacesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListWorkspacesRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListWorkspacesResponse;
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
     * @param AddTeamRequest $request
     * @param AddTeamHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return AddTeamResponse
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
     * @param AddTeamRequest $request
     *
     * @return AddTeamResponse
     */
    public function addTeam($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddTeamHeaders([]);

        return $this->addTeamWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddWorkspaceRequest $request
     * @param AddWorkspaceHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return AddWorkspaceResponse
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
     * @param AddWorkspaceRequest $request
     *
     * @return AddWorkspaceResponse
     */
    public function addWorkspace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddWorkspaceHeaders([]);

        return $this->addWorkspaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string            $teamId
     * @param DeleteTeamRequest $request
     * @param DeleteTeamHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return DeleteTeamResponse
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
     * @param string            $teamId
     * @param DeleteTeamRequest $request
     *
     * @return DeleteTeamResponse
     */
    public function deleteTeam($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteTeamHeaders([]);

        return $this->deleteTeamWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @param GetMineWorkspaceRequest $request
     * @param GetMineWorkspaceHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetMineWorkspaceResponse
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
     * @param GetMineWorkspaceRequest $request
     *
     * @return GetMineWorkspaceResponse
     */
    public function getMineWorkspace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMineWorkspaceHeaders([]);

        return $this->getMineWorkspaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string         $nodeId
     * @param GetNodeRequest $request
     * @param GetNodeHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return GetNodeResponse
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
     * @param string         $nodeId
     * @param GetNodeRequest $request
     *
     * @return GetNodeResponse
     */
    public function getNode($nodeId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetNodeHeaders([]);

        return $this->getNodeWithOptions($nodeId, $request, $headers, $runtime);
    }

    /**
     * @param GetNodeByUrlRequest $request
     * @param GetNodeByUrlHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return GetNodeByUrlResponse
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
     * @param GetNodeByUrlRequest $request
     *
     * @return GetNodeByUrlResponse
     */
    public function getNodeByUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetNodeByUrlHeaders([]);

        return $this->getNodeByUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetNodesRequest $request
     * @param GetNodesHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return GetNodesResponse
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
     * @param GetNodesRequest $request
     *
     * @return GetNodesResponse
     */
    public function getNodes($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetNodesHeaders([]);

        return $this->getNodesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string         $teamId
     * @param GetTeamRequest $request
     * @param GetTeamHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return GetTeamResponse
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
     * @param string         $teamId
     * @param GetTeamRequest $request
     *
     * @return GetTeamResponse
     */
    public function getTeam($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTeamHeaders([]);

        return $this->getTeamWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @param string              $workspaceId
     * @param GetWorkspaceRequest $request
     * @param GetWorkspaceHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return GetWorkspaceResponse
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
     * @param string              $workspaceId
     * @param GetWorkspaceRequest $request
     *
     * @return GetWorkspaceResponse
     */
    public function getWorkspace($workspaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetWorkspaceHeaders([]);

        return $this->getWorkspaceWithOptions($workspaceId, $request, $headers, $runtime);
    }

    /**
     * @param GetWorkspacesRequest $request
     * @param GetWorkspacesHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetWorkspacesResponse
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
     * @param GetWorkspacesRequest $request
     *
     * @return GetWorkspacesResponse
     */
    public function getWorkspaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetWorkspacesHeaders([]);

        return $this->getWorkspacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListNodesRequest $request
     * @param ListNodesHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return ListNodesResponse
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
     * @param ListNodesRequest $request
     *
     * @return ListNodesResponse
     */
    public function listNodes($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListNodesHeaders([]);

        return $this->listNodesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListTeamsRequest $request
     * @param ListTeamsHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return ListTeamsResponse
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
     * @param ListTeamsRequest $request
     *
     * @return ListTeamsResponse
     */
    public function listTeams($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListTeamsHeaders([]);

        return $this->listTeamsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListWorkspacesRequest $request
     * @param ListWorkspacesHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return ListWorkspacesResponse
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
     * @param ListWorkspacesRequest $request
     *
     * @return ListWorkspacesResponse
     */
    public function listWorkspaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListWorkspacesHeaders([]);

        return $this->listWorkspacesWithOptions($request, $headers, $runtime);
    }
}
