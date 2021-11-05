<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPrintAppInfoRequest extends Model
{
    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 搜索关键字
     *
     * @var string
     */
    public $nameLike;
    protected $_name = [
        'userId'   => 'userId',
        'nameLike' => 'nameLike',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->nameLike) {
            $res['nameLike'] = $this->nameLike;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPrintAppInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['nameLike'])) {
            $model->nameLike = $map['nameLike'];
        }

        return $model;
    }
}
