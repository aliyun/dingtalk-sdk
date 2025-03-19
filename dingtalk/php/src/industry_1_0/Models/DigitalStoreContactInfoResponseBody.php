<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreContactInfoResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example codexxxxx
     *
     * @var string
     */
    public $code;

    /**
     * @example 123
     *
     * @var int
     */
    public $dingDeptId;

    /**
     * @example 门店通
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 5647993312
     *
     * @var int
     */
    public $rootDeptId;
    protected $_name = [
        'code' => 'code',
        'dingDeptId' => 'dingDeptId',
        'name' => 'name',
        'rootDeptId' => 'rootDeptId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->dingDeptId) {
            $res['dingDeptId'] = $this->dingDeptId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->rootDeptId) {
            $res['rootDeptId'] = $this->rootDeptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DigitalStoreContactInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['dingDeptId'])) {
            $model->dingDeptId = $map['dingDeptId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['rootDeptId'])) {
            $model->rootDeptId = $map['rootDeptId'];
        }

        return $model;
    }
}
