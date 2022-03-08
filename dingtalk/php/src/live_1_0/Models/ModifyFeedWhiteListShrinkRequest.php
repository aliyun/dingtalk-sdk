<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ModifyFeedWhiteListShrinkRequest extends Model
{
    /**
     * @description 操作类型（1 添加白名单 / 2 删除白名单）
     *
     * @var int
     */
    public $action;

    /**
     * @description 操作的白名单列表
     *
     * @var string
     */
    public $modifyUserListShrink;

    /**
     * @description 用户id（操作者的组织内id）
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'action'               => 'action',
        'modifyUserListShrink' => 'modifyUserList',
        'userId'               => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->modifyUserListShrink) {
            $res['modifyUserList'] = $this->modifyUserListShrink;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ModifyFeedWhiteListShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['modifyUserList'])) {
            $model->modifyUserListShrink = $map['modifyUserList'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
