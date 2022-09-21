<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCrmGroupContactRequest extends Model
{
    /**
     * @description 条数
     *
     * @var int
     */
    public $minResult;

    /**
     * @description 游标
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 群ID
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 检索条件
     *
     * @var string
     */
    public $searchFields;
    protected $_name = [
        'minResult'          => 'minResult',
        'nextToken'          => 'nextToken',
        'openConversationId' => 'openConversationId',
        'openTeamId'         => 'openTeamId',
        'searchFields'       => 'searchFields',
    ];

    public function validate()
    {
    }

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
