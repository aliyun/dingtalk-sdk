<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryBotInstanceInGroupInfoResponseBody extends Model
{
    /**
     * @var bool
     */
    public $hasMore;

    /**
     * @var string[]
     */
    public $openConversationIds;
    protected $_name = [
        'hasMore'             => 'hasMore',
        'openConversationIds' => 'openConversationIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->openConversationIds) {
            $res['openConversationIds'] = $this->openConversationIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBotInstanceInGroupInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['openConversationIds'])) {
            if (!empty($map['openConversationIds'])) {
                $model->openConversationIds = $map['openConversationIds'];
            }
        }

        return $model;
    }
}
