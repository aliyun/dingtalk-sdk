<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryRecentConversationsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryRecentConversationsResponseBody\result\conversationList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var conversationList[]
     */
    public $conversationList;
    protected $_name = [
        'conversationList' => 'conversationList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationList) {
            $res['conversationList'] = [];
            if (null !== $this->conversationList && \is_array($this->conversationList)) {
                $n = 0;
                foreach ($this->conversationList as $item) {
                    $res['conversationList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationList'])) {
            if (!empty($map['conversationList'])) {
                $model->conversationList = [];
                $n                       = 0;
                foreach ($map['conversationList'] as $item) {
                    $model->conversationList[$n++] = null !== $item ? conversationList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
