<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDepartmentInfoResponseBody\content;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDepartmentInfoResponseBody\content\residentLeader\job;
use AlibabaCloud\Tea\Model;

class residentLeader extends Model
{
    /**
     * @description 工作标签
     *
     * @var job
     */
    public $job;

    /**
     * @description 工号
     *
     * @var string
     */
    public $jobNumber;

    /**
     * @description 姓名
     *
     * @var string
     */
    public $name;

    /**
     * @description 人员Id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'job'       => 'job',
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
        if (null !== $this->job) {
            $res['job'] = null !== $this->job ? $this->job->toMap() : null;
        }
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
     * @return residentLeader
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['job'])) {
            $model->job = job::fromMap($map['job']);
        }
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
