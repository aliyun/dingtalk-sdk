<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponseBody\content\groupAndExtList\group;

use AlibabaCloud\Tea\Model;

class leader extends Model
{
    /**
     * @description 姓名
     *
     * @var string
     */
    public $name;

    /**
     * @description 用户ID
     *
     * @var string
     */
    public $userId;

    /**
     * @description 用户工号
     *
     * @var string
     */
    public $jobNumber;
    protected $_name = [
        'name'      => 'name',
        'userId'    => 'userId',
        'jobNumber' => 'jobNumber',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->jobNumber) {
            $res['jobNumber'] = $this->jobNumber;
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['jobNumber'])) {
            $model->jobNumber = $map['jobNumber'];
        }

        return $model;
    }
}
