<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QuerySingleGroupResponseBody\openConversations;
use AlibabaCloud\Tea\Model;

class QuerySingleGroupResponseBody extends Model
{
    /**
     * @description 群会话列表。
     *
     * @var openConversations[]
     */
    public $openConversations;
    protected $_name = [
        'openConversations' => 'openConversations',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversations) {
            $res['openConversations'] = [];
            if (null !== $this->openConversations && \is_array($this->openConversations)) {
                $n = 0;
                foreach ($this->openConversations as $item) {
                    $res['openConversations'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySingleGroupResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversations'])) {
            if (!empty($map['openConversations'])) {
                $model->openConversations = [];
                $n                        = 0;
                foreach ($map['openConversations'] as $item) {
                    $model->openConversations[$n++] = null !== $item ? openConversations::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
