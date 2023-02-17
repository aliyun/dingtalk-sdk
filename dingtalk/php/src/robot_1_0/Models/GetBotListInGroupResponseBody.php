<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\GetBotListInGroupResponseBody\chatbotInstanceVOList;
use AlibabaCloud\Tea\Model;

class GetBotListInGroupResponseBody extends Model
{
    /**
     * @var chatbotInstanceVOList[]
     */
    public $chatbotInstanceVOList;
    protected $_name = [
        'chatbotInstanceVOList' => 'chatbotInstanceVOList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->chatbotInstanceVOList) {
            $res['chatbotInstanceVOList'] = [];
            if (null !== $this->chatbotInstanceVOList && \is_array($this->chatbotInstanceVOList)) {
                $n = 0;
                foreach ($this->chatbotInstanceVOList as $item) {
                    $res['chatbotInstanceVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBotListInGroupResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chatbotInstanceVOList'])) {
            if (!empty($map['chatbotInstanceVOList'])) {
                $model->chatbotInstanceVOList = [];
                $n                            = 0;
                foreach ($map['chatbotInstanceVOList'] as $item) {
                    $model->chatbotInstanceVOList[$n++] = null !== $item ? chatbotInstanceVOList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
