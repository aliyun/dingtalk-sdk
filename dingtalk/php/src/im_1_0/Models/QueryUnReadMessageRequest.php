<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUnReadMessageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1107****2120
     *
     * @var string
     */
    public $appUserId;

    /**
     * @example 1745****8777
     *
     * @var string[]
     */
    public $openConversationIds;
    protected $_name = [
        'appUserId'           => 'appUserId',
        'openConversationIds' => 'openConversationIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUserId) {
            $res['appUserId'] = $this->appUserId;
        }
        if (null !== $this->openConversationIds) {
            $res['openConversationIds'] = $this->openConversationIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUnReadMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUserId'])) {
            $model->appUserId = $map['appUserId'];
        }
        if (isset($map['openConversationIds'])) {
            if (!empty($map['openConversationIds'])) {
                $model->openConversationIds = $map['openConversationIds'];
            }
        }

        return $model;
    }
}
