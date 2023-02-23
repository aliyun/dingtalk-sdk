<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateGroupNameResponseBody extends Model
{
    /**
     * @description 新群名称
     *
     * @var string
     */
    public $newGroupName;
    protected $_name = [
        'newGroupName' => 'newGroupName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->newGroupName) {
            $res['newGroupName'] = $this->newGroupName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateGroupNameResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['newGroupName'])) {
            $model->newGroupName = $map['newGroupName'];
        }

        return $model;
    }
}
