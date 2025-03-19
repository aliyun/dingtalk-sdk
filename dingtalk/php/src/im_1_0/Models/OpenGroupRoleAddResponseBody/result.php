<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupRoleAddResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $openRoleId;
    protected $_name = [
        'openRoleId' => 'openRoleId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->openRoleId) {
            $res['openRoleId'] = $this->openRoleId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openRoleId'])) {
            $model->openRoleId = $map['openRoleId'];
        }

        return $model;
    }
}
