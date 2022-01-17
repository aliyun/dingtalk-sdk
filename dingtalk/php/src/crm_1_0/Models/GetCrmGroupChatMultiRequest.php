<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCrmGroupChatMultiRequest extends Model
{
    /**
     * @description 群openConversationId列表。
     *
     * @var string[]
     */
    public $openConversationIds;
    protected $_name = [
        'openConversationIds' => 'openConversationIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationIds) {
            $res['openConversationIds'] = $this->openConversationIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCrmGroupChatMultiRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationIds'])) {
            if (!empty($map['openConversationIds'])) {
                $model->openConversationIds = $map['openConversationIds'];
            }
        }

        return $model;
    }
}
