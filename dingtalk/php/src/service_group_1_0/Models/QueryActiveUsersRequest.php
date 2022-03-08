<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryActiveUsersRequest extends Model
{
    /**
     * @description 开放群ID
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
     * @description 查询topN的数据
     *
     * @var int
     */
    public $topN;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'openTeamId'         => 'openTeamId',
        'topN'               => 'topN',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->topN) {
            $res['topN'] = $this->topN;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryActiveUsersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['topN'])) {
            $model->topN = $map['topN'];
        }

        return $model;
    }
}
