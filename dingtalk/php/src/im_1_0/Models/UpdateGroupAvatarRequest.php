<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateGroupAvatarRequest extends Model
{
    /**
     * @description 群头像地址。
     *
     * @var string
     */
    public $groupAvatar;

    /**
     * @description 群会话id。
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'groupAvatar'        => 'groupAvatar',
        'openConversationId' => 'openConversationId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupAvatar) {
            $res['groupAvatar'] = $this->groupAvatar;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateGroupAvatarRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupAvatar'])) {
            $model->groupAvatar = $map['groupAvatar'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
