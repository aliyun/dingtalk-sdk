<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class ChangeGroupOwnerRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 14da****2760
     *
     * @var string
     */
    public $groupOwnerId;

    /**
     * @description This parameter is required.
     *
     * @example 3
     *
     * @var int
     */
    public $groupOwnerType;

    /**
     * @description This parameter is required.
     *
     * @example 14da****2760
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
