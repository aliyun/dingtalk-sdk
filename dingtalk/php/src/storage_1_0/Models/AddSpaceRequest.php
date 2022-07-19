<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddSpaceRequest\option;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddSpaceRequest\param;
use AlibabaCloud\Tea\Model;

class AddSpaceRequest extends Model
{
    /**
     * @description 可选参数
     *
     * @var option
     */
    public $option;

    /**
     * @description 必选参数
     *
     * @var param
     */
    public $param;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'option'  => 'option',
        'param'   => 'param',
        'unionId' => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->option) {
            $res['option'] = null !== $this->option ? $this->option->toMap() : null;
        }
        if (null !== $this->param) {
            $res['param'] = null !== $this->param ? $this->param->toMap() : null;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddSpaceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['option'])) {
            $model->option = option::fromMap($map['option']);
        }
        if (isset($map['param'])) {
            $model->param = param::fromMap($map['param']);
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
