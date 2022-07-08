<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models\RemovePermissionResponseBody\data;
use AlibabaCloud\Tea\Model;

class RemovePermissionResponseBody extends Model
{
    /**
     * @description 当执行出错的时候，移除权限失败的用户昵称列表
     *
     * @var data
     */
    public $data;

    /**
     * @description 服务端返回的错误代码
     *
     * @var int
     */
    public $statusCode;

    /**
     * @description 描述本次调用的业务层面是否成功
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'data'       => 'data',
        'statusCode' => 'statusCode',
        'success'    => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->data) {
            $res['data'] = null !== $this->data ? $this->data->toMap() : null;
        }
        if (null !== $this->statusCode) {
            $res['statusCode'] = $this->statusCode;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RemovePermissionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data'])) {
            $model->data = data::fromMap($map['data']);
        }
        if (isset($map['statusCode'])) {
            $model->statusCode = $map['statusCode'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
