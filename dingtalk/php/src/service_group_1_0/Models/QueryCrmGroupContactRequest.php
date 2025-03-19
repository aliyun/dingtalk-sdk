<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCrmGroupContactRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $minResult;

    /**
     * @example 8888
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description This parameter is required.
     *
     * @example cid888
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
     *
     * @example 888
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $searchFields;
    protected $_name = [
        'minResult' => 'minResult',
        'nextToken' => 'nextToken',
        'openConversationId' => 'openConversationId',
        'openTeamId' => 'openTeamId',
        'searchFields' => 'searchFields',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->minResult) {
            $res['minResult'] = $this->minResult;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->searchFields) {
            $res['searchFields'] = $this->searchFields;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCrmGroupContactRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['minResult'])) {
            $model->minResult = $map['minResult'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['searchFields'])) {
            $model->searchFields = $map['searchFields'];
        }

        return $model;
    }
}
