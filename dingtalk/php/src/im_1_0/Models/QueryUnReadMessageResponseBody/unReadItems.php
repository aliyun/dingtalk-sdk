<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUnReadMessageResponseBody;

use AlibabaCloud\Tea\Model;

class unReadItems extends Model
{
    /**
     * @example 14da****2760
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example 10
     *
     * @var int
     */
    public $unReadCount;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'unReadCount' => 'unReadCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->unReadCount) {
            $res['unReadCount'] = $this->unReadCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return unReadItems
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['unReadCount'])) {
            $model->unReadCount = $map['unReadCount'];
        }

        return $model;
    }
}
