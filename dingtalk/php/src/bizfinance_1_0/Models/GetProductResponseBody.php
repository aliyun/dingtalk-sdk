<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetProductResponseBody extends Model
{
    /**
     * @example PROD-xxx
     *
     * @var string
     */
    public $code;

    /**
     * @example 1634786828686
     *
     * @var int
     */
    public $createTime;

    /**
     * @example 和外部合作
     *
     * @var string
     */
    public $description;

    /**
     * @example 外包商品
     *
     * @var string
     */
    public $name;

    /**
     * @example 规格型号
     *
     * @var string
     */
    public $specification;

    /**
     * @example valid
     *
     * @var string
     */
    public $status;

    /**
     * @example 个
     *
     * @var string
     */
    public $unit;

    /**
     * @var string
     */
    public $userDefineCode;
    protected $_name = [
        'code'           => 'code',
        'createTime'     => 'createTime',
        'description'    => 'description',
        'name'           => 'name',
        'specification'  => 'specification',
        'status'         => 'status',
        'unit'           => 'unit',
        'userDefineCode' => 'userDefineCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->specification) {
            $res['specification'] = $this->specification;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->userDefineCode) {
            $res['userDefineCode'] = $this->userDefineCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetProductResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['specification'])) {
            $model->specification = $map['specification'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['userDefineCode'])) {
            $model->userDefineCode = $map['userDefineCode'];
        }

        return $model;
    }
}
