<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryProcessesInstanceResponseBody\data;

use AlibabaCloud\Tea\Model;

class originator extends Model
{
    /**
     * @example 18f923a7-5a5e-426d-94ae-a55ad1a4b240
     *
     * @var string
     */
    public $departmentId;

    /**
     * @example 研发中心
     *
     * @var string
     */
    public $departmentName;

    /**
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @example aea4d7a7-d162-4c77-9c44-7bd9cb8316a5
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'departmentId' => 'departmentId',
        'departmentName' => 'departmentName',
        'name' => 'name',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }
        if (null !== $this->departmentName) {
            $res['departmentName'] = $this->departmentName;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['departmentName'])) {
            $model->departmentName = $map['departmentName'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
