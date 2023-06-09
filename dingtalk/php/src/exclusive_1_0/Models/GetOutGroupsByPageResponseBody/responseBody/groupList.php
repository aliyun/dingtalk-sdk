<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOutGroupsByPageResponseBody\responseBody;

use AlibabaCloud\Tea\Model;

class groupList extends Model
{
    /**
     * @example {   "text": {     "content": "这是一段文本"   } }
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'openConversationId' => 'openConversationId',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
