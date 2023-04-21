<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models;

use AlibabaCloud\Tea\Model;

class PediaWordsUpdateResponseBody extends Model
{
    /**
     * @description 返回结果
     * true,成功
     * @var bool
     */
    public $success;

    /**
     * @description 更新后待审核词条编号
     *
     * @var int
     */
    public $uuid;
    protected $_name = [
        'success' => 'success',
        'uuid'    => 'uuid',
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
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PediaWordsUpdateResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
