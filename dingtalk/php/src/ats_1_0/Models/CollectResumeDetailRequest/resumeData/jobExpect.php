<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData;

use AlibabaCloud\Tea\Model;

class jobExpect extends Model
{
    /**
     * @description 期望职位名称
     *
     * @var string
     */
    public $jobName;

    /**
     * @description 期望工作地
     *
     * @var string[]
     */
    public $locations;

    /**
     * @description 最高期望工资
     *
     * @var string
     */
    public $maxSalary;

    /**
     * @description 最低期望工资
     *
     * @var string
     */
    public $minSalary;

    /**
     * @description 期望入职时间
     *
     * @var string
     */
    public $onboardTime;
    protected $_name = [
        'jobName'     => 'jobName',
        'locations'   => 'locations',
        'maxSalary'   => 'maxSalary',
        'minSalary'   => 'minSalary',
        'onboardTime' => 'onboardTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->jobName) {
            $res['jobName'] = $this->jobName;
        }
        if (null !== $this->locations) {
            $res['locations'] = $this->locations;
        }
        if (null !== $this->maxSalary) {
            $res['maxSalary'] = $this->maxSalary;
        }
        if (null !== $this->minSalary) {
            $res['minSalary'] = $this->minSalary;
        }
        if (null !== $this->onboardTime) {
            $res['onboardTime'] = $this->onboardTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return jobExpect
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['jobName'])) {
            $model->jobName = $map['jobName'];
        }
        if (isset($map['locations'])) {
            if (!empty($map['locations'])) {
                $model->locations = $map['locations'];
            }
        }
        if (isset($map['maxSalary'])) {
            $model->maxSalary = $map['maxSalary'];
        }
        if (isset($map['minSalary'])) {
            $model->minSalary = $map['minSalary'];
        }
        if (isset($map['onboardTime'])) {
            $model->onboardTime = $map['onboardTime'];
        }

        return $model;
    }
}
