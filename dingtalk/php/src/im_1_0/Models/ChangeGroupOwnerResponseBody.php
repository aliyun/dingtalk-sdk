<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class ChangeGroupOwnerResponseBody extends Model
{
    /**
     * @var string
     */
    public $newGroupOwnerId;

    /**
     * @var int
     */
    public $newGroupOwnerType;
    protected $_name = [
        'newGroupOwnerId'   => 'newGroupOwnerId',
        'newGroupOwnerType' => 'newGroupOwnerType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->newGroupOwnerId) {
            $res['newGroupOwnerId'] = $this->newGroupOwnerId;
        }
        if (null !== $this->newGroupOwnerType) {
            $res['newGroupOwnerType'] = $this->newGroupOwnerType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChangeGroupOwnerResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['newGroupOwnerId'])) {
            $model->newGroupOwnerId = $map['newGroupOwnerId'];
        }
        if (isset($map['newGroupOwnerType'])) {
            $model->newGroupOwnerType = $map['newGroupOwnerType'];
        }

        return $model;
    }
}
