<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteFileRequest extends Model
{
    /**
     * @description 删除策略
     *
     * @var string
     */
    public $deletePolicy;
    protected $_name = [
        'deletePolicy' => 'deletePolicy',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deletePolicy) {
            $res['deletePolicy'] = $this->deletePolicy;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deletePolicy'])) {
            $model->deletePolicy = $map['deletePolicy'];
        }

        return $model;
    }
}
