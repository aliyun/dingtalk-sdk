<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenCategoryResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 操作是否成功
     *
     * @var bool
     */
    public $success;

    /**
     * @description 添加成类目ID
     *
     * @var int
     */
    public $id;

    /**
     * @description 失败时的错误消息
     *
     * @var string
     */
    public $message;
    protected $_name = [
        'success' => 'success',
        'id'      => 'id',
        'message' => 'message',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->message) {
            $res['message'] = $this->message;
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
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['message'])) {
            $model->message = $map['message'];
        }

        return $model;
    }
}
