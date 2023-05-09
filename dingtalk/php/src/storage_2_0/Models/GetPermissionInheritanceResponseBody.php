<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetPermissionInheritanceResponseBody extends Model
{
    /**
     * @example PASS_ON
     *
     * @var string
     */
    public $inheritance;
    protected $_name = [
        'inheritance' => 'inheritance',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->inheritance) {
            $res['inheritance'] = $this->inheritance;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPermissionInheritanceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['inheritance'])) {
            $model->inheritance = $map['inheritance'];
        }

        return $model;
    }
}
