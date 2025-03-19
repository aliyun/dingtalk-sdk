<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateMemberGroupNickRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $groupNick;

    /**
     * @description This parameter is required.
     *
     * @example cidXXXXXXX
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'groupNick' => 'groupNick',
        'openConversationId' => 'openConversationId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupNick) {
            $res['groupNick'] = $this->groupNick;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateMemberGroupNickRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupNick'])) {
            $model->groupNick = $map['groupNick'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
