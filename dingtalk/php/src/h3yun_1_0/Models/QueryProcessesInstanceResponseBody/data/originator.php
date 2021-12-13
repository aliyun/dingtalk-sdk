<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryProcessesInstanceResponseBody\data;

use AlibabaCloud\Tea\Model;

class originator extends Model
{
    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 用户名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 所属组织id
     *
     * @var string
     */
    public $departmentId;

    /**
     * @description 所属组织名称
     *
     * @var string
     */
    public $departmentName;
    protected $_name = [
        'userId'         => 'userId',
        'name'           => 'name',
        'departmentId'   => 'departmentId',
        'departmentName' => 'departmentName',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }
        if (null !== $this->departmentName) {
            $res['departmentName'] = $this->departmentName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return originator
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['departmentName'])) {
            $model->departmentName = $map['departmentName'];
        }

        return $model;
    }
}
