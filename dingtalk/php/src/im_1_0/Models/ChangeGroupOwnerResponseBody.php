<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class ChangeGroupOwnerResponseBody extends Model
{
    /**
     * @description 群主在业务系统内的唯一标识
     *
     * @var string
     */
    public $newGroupOwnerId;

    /**
     * @description 群主类型<2.钉内用户类型 3.钉外用户类型>
     *
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
