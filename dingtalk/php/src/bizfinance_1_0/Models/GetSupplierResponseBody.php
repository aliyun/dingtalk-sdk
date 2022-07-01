<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSupplierResponseBody extends Model
{
    /**
     * @description 供应商Code
     *
     * @var string
     */
    public $code;

    /**
     * @description 创建时间(单位MS)
     *
     * @var int
     */
    public $createTime;

    /**
     * @description 供应商描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 供应商名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 状态：启用(valid), 停用(invalid), 删除(deleted)
     *
     * @var string
     */
    public $status;

    /**
     * @description 用户自定义code
     *
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
     * @return GetSupplierResponseBody
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
