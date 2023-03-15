<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\GetFileUploadInfoRequest\option;

use AlibabaCloud\Tea\Model;

class preCheckParam extends Model
{
    /**
     * @description 文件名称, 文件名称合法性和文件名称冲突校验
     * 1. 头尾不能包含空格，否则会自动去除
     * 2. 不能包含特殊字符，包括：制表符、*、"、<、>、|
     * 3. 不能以"."结尾
     * @var string
     */
    public $name;

    /**
     * @description 文件大小, 做容量相关校验。不传则不做校验。
     *
     * @var int
     */
    public $size;
    protected $_name = [
        'name' => 'name',
        'size' => 'size',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return preCheckParam
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }

        return $model;
    }
}
