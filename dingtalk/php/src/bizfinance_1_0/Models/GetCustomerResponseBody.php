<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCustomerResponseBody extends Model
{
    /**
     * @description 客户Code
     *
     * @var string
     */
    public $code;

    /**
     * @description 客户名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 客户描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 创建时间(单位MS)
     *
     * @var int
     */
    public $createTime;

    /**
     * @description 状态：启用(valid), 停用(invalid), 删除(deleted)
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'code'        => 'code',
        'name'        => 'name',
        'description' => 'description',
        'createTime'  => 'createTime',
        'status'      => 'status',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCustomerResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
