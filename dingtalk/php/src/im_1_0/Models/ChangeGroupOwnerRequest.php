<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class ChangeGroupOwnerRequest extends Model
{
    /**
     * @description 群主id
     *
     * @var string
     */
    public $groupOwnerId;

    /**
     * @description 群主类型<2.钉钉 3.C端>
     *
     * @var int
     */
    public $groupOwnerType;

    /**
     * @description 群id(客联系业务系统内的群id)
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
