<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDepartmentInfoResponseBody\content;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDepartmentInfoResponseBody\content\leader\job;
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
     * @description 人员Id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 工号
     *
     * @var string
     */
    public $jobNumber;

    /**
     * @description 工作标签
     *
     * @var job
     */
    public $job;
    protected $_name = [
        'name'      => 'name',
        'userId'    => 'userId',
        'jobNumber' => 'jobNumber',
        'job'       => 'job',
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
        if (null !== $this->job) {
            $res['job'] = null !== $this->job ? $this->job->toMap() : null;
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
        if (isset($map['job'])) {
            $model->job = job::fromMap($map['job']);
        }

        return $model;
    }
}
