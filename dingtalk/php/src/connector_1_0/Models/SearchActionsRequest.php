<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchActionsRequest extends Model
{
    /**
     * @description 连接器的ID
     *
     * @var string
     */
    public $connectorId;

    /**
     * @description 连接器提供组织ID
     *
     * @var string
     */
    public $connectorProviderCorpId;

    /**
     * @description 集成类型，默认只有basic-基础类型
     *
     * @var string[]
     */
    public $integrationTypes;

    /**
     * @description 最大返回记录数
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 查询位置，为空表示从头开始
     *
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'connectorId'             => 'connectorId',
        'connectorProviderCorpId' => 'connectorProviderCorpId',
        'integrationTypes'        => 'integrationTypes',
        'maxResults'              => 'maxResults',
        'nextToken'               => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->connectorId) {
            $res['connectorId'] = $this->connectorId;
        }
        if (null !== $this->connectorProviderCorpId) {
            $res['connectorProviderCorpId'] = $this->connectorProviderCorpId;
        }
        if (null !== $this->integrationTypes) {
            $res['integrationTypes'] = $this->integrationTypes;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchActionsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['connectorId'])) {
            $model->connectorId = $map['connectorId'];
        }
        if (isset($map['connectorProviderCorpId'])) {
            $model->connectorProviderCorpId = $map['connectorProviderCorpId'];
        }
        if (isset($map['integrationTypes'])) {
            if (!empty($map['integrationTypes'])) {
                $model->integrationTypes = $map['integrationTypes'];
            }
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
