<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0;

use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\QueryComponentScopesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\QueryComponentScopesResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\QueryShortcutScopesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\QueryShortcutScopesResponse;
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
     * @param string $shortcutKey
     *
     * @return QueryShortcutScopesResponse
     */
    public function queryShortcutScopes($shortcutKey)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryShortcutScopesHeaders([]);

        return $this->queryShortcutScopesWithOptions($shortcutKey, $headers, $runtime);
    }

    /**
     * @param string                     $shortcutKey
     * @param QueryShortcutScopesHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryShortcutScopesResponse
     */
    public function queryShortcutScopesWithOptions($shortcutKey, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryShortcutScopesResponse::fromMap($this->doROARequest('QueryShortcutScopes', 'workbench_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workbench/shortcuts/' . $shortcutKey . '/scopes', 'json', $req, $runtime));
    }

    /**
     * @param string $componentId
     *
     * @return QueryComponentScopesResponse
     */
    public function queryComponentScopes($componentId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryComponentScopesHeaders([]);

        return $this->queryComponentScopesWithOptions($componentId, $headers, $runtime);
    }

    /**
     * @param string                      $componentId
     * @param QueryComponentScopesHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryComponentScopesResponse
     */
    public function queryComponentScopesWithOptions($componentId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryComponentScopesResponse::fromMap($this->doROARequest('QueryComponentScopes', 'workbench_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workbench/components/' . $componentId . '/scopes', 'json', $req, $runtime));
    }
}
