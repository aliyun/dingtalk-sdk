<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryCustomerByPageResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example CUS_XXX
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
     * @example 重要客户
     *
     * @var string
     */
    public $description;

    /**
     * @example XX有限公司
     *
     * @var string
     */
    public $name;

    /**
     * @example valid
     *
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $userDefineCode;
    protected $_name = [
        'code'           => 'code',
        'createTime'     => 'createTime',
        'description'    => 'description',
        'name'           => 'name',
        'status'         => 'status',
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
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->userDefineCode) {
            $res['userDefineCode'] = $this->userDefineCode;
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
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['userDefineCode'])) {
            $model->userDefineCode = $map['userDefineCode'];
        }

        return $model;
    }
}
