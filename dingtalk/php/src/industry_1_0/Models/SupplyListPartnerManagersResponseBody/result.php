<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListPartnerManagersResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 56789123
     *
     * @var string
     */
    public $deptId;

    /**
     * @example 对接部门名称
     *
     * @var string
     */
    public $deptName;

    /**
     * @example user
     *
     * @var string
     */
    public $interfaceType;

    /**
     * @example 121234567
     *
     * @var string
     */
    public $userId;

    /**
     * @example 名称
     *
     * @var string
     */
    public $userName;
    protected $_name = [
        'deptId'        => 'deptId',
        'deptName'      => 'deptName',
        'interfaceType' => 'interfaceType',
        'userId'        => 'userId',
        'userName'      => 'userName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->interfaceType) {
            $res['interfaceType'] = $this->interfaceType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['interfaceType'])) {
            $model->interfaceType = $map['interfaceType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
