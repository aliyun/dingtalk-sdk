<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchBindingGroupBizIdsRequest;

use AlibabaCloud\Tea\Model;

class bindingGroupBizIds extends Model
{
    /**
     * @description 业务ID
     *
     * @var string
     */
    public $bizId;

    /**
     * @description 群会话ID
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'bizId'              => 'bizId',
        'openConversationId' => 'openConversationId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return bindingGroupBizIds
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
