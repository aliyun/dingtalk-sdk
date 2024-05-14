<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryCategoryByPageResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example INCOME_XXX
     *
     * @var string
     */
    public $code;

    /**
     * @description This parameter is required.
     *
     * @example false
     *
     * @var bool
     */
    public $isDir;

    /**
     * @description This parameter is required.
     *
     * @example 汽车
     *
     * @var string
     */
    public $name;

    /**
     * @example INCOM_XXX
     *
     * @var string
     */
    public $parentCode;

    /**
     * @description This parameter is required.
     *
     * @example valid
     *
     * @var string
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @example income
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'code'       => 'code',
        'isDir'      => 'isDir',
        'name'       => 'name',
        'parentCode' => 'parentCode',
        'status'     => 'status',
        'type'       => 'type',
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
        if (null !== $this->isDir) {
            $res['isDir'] = $this->isDir;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->parentCode) {
            $res['parentCode'] = $this->parentCode;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['isDir'])) {
            $model->isDir = $map['isDir'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['parentCode'])) {
            $model->parentCode = $map['parentCode'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
