<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponseBody\content\groupAndExtList\group;

use AlibabaCloud\Tea\Model;

class leader extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 888asd
     *
     * @var string
     */
    public $jobNumber;

    /**
     * @description This parameter is required.
     *
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 666abc
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'jobNumber' => 'jobNumber',
        'name'      => 'name',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->jobNumber) {
            $res['jobNumber'] = $this->jobNumber;
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
     * @return leader
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['jobNumber'])) {
            $model->jobNumber = $map['jobNumber'];
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
