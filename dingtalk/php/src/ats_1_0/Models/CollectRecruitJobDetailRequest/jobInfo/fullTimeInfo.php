<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectRecruitJobDetailRequest\jobInfo;

use AlibabaCloud\Tea\Model;

class fullTimeInfo extends Model
{
    /**
     * @description 工作经验要求最高年限
     *
     * @var string
     */
    public $maxJobExperience;

    /**
     * @description 工作经验要求最低年限
     *
     * @var string
     */
    public $minJobExperience;

    /**
     * @description 薪资发放月数
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
