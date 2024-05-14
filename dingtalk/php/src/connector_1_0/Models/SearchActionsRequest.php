<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchActionsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example G-CONN-1015BC8093540B01B8D0000Q
     *
     * @var string
     */
    public $connectorId;

    /**
     * @description This parameter is required.
     *
     * @example ding32fff839a3e0105d
     *
     * @var string
     */
    public $connectorProviderCorpId;

    /**
     * @var string[]
     */
    public $integrationTypes;

    /**
     * @example 20
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 0
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
