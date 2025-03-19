<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models;

use AlibabaCloud\Tea\Model;

class SetPermissionInheritanceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example PASS_ON
     *
     * @var string
     */
    public $inheritance;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'inheritance' => 'inheritance',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->inheritance) {
            $res['inheritance'] = $this->inheritance;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetPermissionInheritanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['inheritance'])) {
            $model->inheritance = $map['inheritance'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
