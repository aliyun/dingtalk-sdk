<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteInstanceResponseBody extends Model
{
    /**
     * @description Id of the request
     *
     * @var string
     */
    public $openDataInstanceId;
    protected $_name = [
        'openDataInstanceId' => 'openDataInstanceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openDataInstanceId) {
            $res['openDataInstanceId'] = $this->openDataInstanceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteInstanceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openDataInstanceId'])) {
            $model->openDataInstanceId = $map['openDataInstanceId'];
        }

        return $model;
    }
}
