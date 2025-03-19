<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenGroupUserRoleQueryRequest extends Model
{
    /**
     * @description This parameter is required.
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

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $viewedUserId;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'userId' => 'userId',
        'viewedUserId' => 'viewedUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->viewedUserId) {
            $res['viewedUserId'] = $this->viewedUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenGroupUserRoleQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['viewedUserId'])) {
            $model->viewedUserId = $map['viewedUserId'];
        }

        return $model;
    }
}
