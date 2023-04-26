<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectRecruitJobDetailRequest\jobInfo;

use AlibabaCloud\Tea\Model;

class fullTimeInfo extends Model
{
    /**
     * @example 20
     *
     * @var string
     */
    public $maxJobExperience;

    /**
     * @example 2
     *
     * @var string
     */
    public $minJobExperience;

    /**
     * @example 12
     *
     * @var string
     */
    public $salaryMonth;
    protected $_name = [
        'maxJobExperience' => 'maxJobExperience',
        'minJobExperience' => 'minJobExperience',
        'salaryMonth'      => 'salaryMonth',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxJobExperience) {
            $res['maxJobExperience'] = $this->maxJobExperience;
        }
        if (null !== $this->minJobExperience) {
            $res['minJobExperience'] = $this->minJobExperience;
        }
        if (null !== $this->salaryMonth) {
            $res['salaryMonth'] = $this->salaryMonth;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fullTimeInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxJobExperience'])) {
            $model->maxJobExperience = $map['maxJobExperience'];
        }
        if (isset($map['minJobExperience'])) {
            $model->minJobExperience = $map['minJobExperience'];
        }
        if (isset($map['salaryMonth'])) {
            $model->salaryMonth = $map['salaryMonth'];
        }

        return $model;
    }
}
