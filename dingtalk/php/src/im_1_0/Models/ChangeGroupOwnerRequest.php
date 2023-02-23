<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class ChangeGroupOwnerRequest extends Model
{
    /**
     * @description 群主在业务系统内的唯一标识
     *
     * @var string
     */
    public $groupOwnerId;

    /**
     * @description 群主类型<2.钉内用户类型 3.钉外用户类型>
     *
     * @var int
     */
    public $groupOwnerType;

    /**
     * @description 群会话Id。
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'groupOwnerId'       => 'groupOwnerId',
        'groupOwnerType'     => 'groupOwnerType',
        'openConversationId' => 'openConversationId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupOwnerId) {
            $res['groupOwnerId'] = $this->groupOwnerId;
        }
        if (null !== $this->groupOwnerType) {
            $res['groupOwnerType'] = $this->groupOwnerType;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChangeGroupOwnerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupOwnerId'])) {
            $model->groupOwnerId = $map['groupOwnerId'];
        }
        if (isset($map['groupOwnerType'])) {
            $model->groupOwnerType = $map['groupOwnerType'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
