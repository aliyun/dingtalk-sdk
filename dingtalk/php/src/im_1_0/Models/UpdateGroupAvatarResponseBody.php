<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateGroupAvatarResponseBody extends Model
{
    /**
     * @var string
     */
    public $newGroupAvatar;
    protected $_name = [
        'newGroupAvatar' => 'newGroupAvatar',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->newGroupAvatar) {
            $res['newGroupAvatar'] = $this->newGroupAvatar;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateGroupAvatarResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['newGroupAvatar'])) {
            $model->newGroupAvatar = $map['newGroupAvatar'];
        }

        return $model;
    }
}
