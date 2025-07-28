<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest;

use AlibabaCloud\Tea\Model;

class jobContentVO extends Model
{
    /**
     * @var string
     */
    public $commitment;

    /**
     * @var int
     */
    public $hireCount;

    /**
     * @var string
     */
    public $jobContent;

    /**
     * @var string
     */
    public $jobName;

    /**
     * @var int
     */
    public $maxSalary;

    /**
     * @var int
     */
    public $minSalary;
    protected $_name = [
        'commitment' => 'commitment',
        'hireCount' => 'hireCount',
        'jobContent' => 'jobContent',
        'jobName' => 'jobName',
        'maxSalary' => 'maxSalary',
        'minSalary' => 'minSalary',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->commitment) {
            $res['commitment'] = $this->commitment;
        }
        if (null !== $this->hireCount) {
            $res['hireCount'] = $this->hireCount;
        }
        if (null !== $this->jobContent) {
            $res['jobContent'] = $this->jobContent;
        }
        if (null !== $this->jobName) {
            $res['jobName'] = $this->jobName;
        }
        if (null !== $this->maxSalary) {
            $res['maxSalary'] = $this->maxSalary;
        }
        if (null !== $this->minSalary) {
            $res['minSalary'] = $this->minSalary;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return jobContentVO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['commitment'])) {
            $model->commitment = $map['commitment'];
        }
        if (isset($map['hireCount'])) {
            $model->hireCount = $map['hireCount'];
        }
        if (isset($map['jobContent'])) {
            $model->jobContent = $map['jobContent'];
        }
        if (isset($map['jobName'])) {
            $model->jobName = $map['jobName'];
        }
        if (isset($map['maxSalary'])) {
            $model->maxSalary = $map['maxSalary'];
        }
        if (isset($map['minSalary'])) {
            $model->minSalary = $map['minSalary'];
        }

        return $model;
    }
}
