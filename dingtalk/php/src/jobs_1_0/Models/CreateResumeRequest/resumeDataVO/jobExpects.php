<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO;

use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO\jobExpects\cityList;
use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO\jobExpects\industryList;
use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO\jobExpects\jobList;
use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO\jobExpects\otherCityList;
use AlibabaCloud\Tea\Model;

class jobExpects extends Model
{
    /**
     * @var cityList[]
     */
    public $cityList;

    /**
     * @var int
     */
    public $gmtCreate;

    /**
     * @var int
     */
    public $gmtModified;

    /**
     * @var industryList[]
     */
    public $industryList;

    /**
     * @var jobList[]
     */
    public $jobList;

    /**
     * @var string
     */
    public $jobNature;

    /**
     * @var string
     */
    public $maxSalary;

    /**
     * @var string
     */
    public $minSalary;

    /**
     * @var otherCityList[]
     */
    public $otherCityList;

    /**
     * @var string
     */
    public $salaryDesc;

    /**
     * @var string
     */
    public $salarySettleType;

    /**
     * @var string
     */
    public $salaryType;

    /**
     * @var string
     */
    public $salaryYear;
    protected $_name = [
        'cityList'         => 'cityList',
        'gmtCreate'        => 'gmtCreate',
        'gmtModified'      => 'gmtModified',
        'industryList'     => 'industryList',
        'jobList'          => 'jobList',
        'jobNature'        => 'jobNature',
        'maxSalary'        => 'maxSalary',
        'minSalary'        => 'minSalary',
        'otherCityList'    => 'otherCityList',
        'salaryDesc'       => 'salaryDesc',
        'salarySettleType' => 'salarySettleType',
        'salaryType'       => 'salaryType',
        'salaryYear'       => 'salaryYear',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cityList) {
            $res['cityList'] = [];
            if (null !== $this->cityList && \is_array($this->cityList)) {
                $n = 0;
                foreach ($this->cityList as $item) {
                    $res['cityList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->industryList) {
            $res['industryList'] = [];
            if (null !== $this->industryList && \is_array($this->industryList)) {
                $n = 0;
                foreach ($this->industryList as $item) {
                    $res['industryList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->jobList) {
            $res['jobList'] = [];
            if (null !== $this->jobList && \is_array($this->jobList)) {
                $n = 0;
                foreach ($this->jobList as $item) {
                    $res['jobList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->jobNature) {
            $res['jobNature'] = $this->jobNature;
        }
        if (null !== $this->maxSalary) {
            $res['maxSalary'] = $this->maxSalary;
        }
        if (null !== $this->minSalary) {
            $res['minSalary'] = $this->minSalary;
        }
        if (null !== $this->otherCityList) {
            $res['otherCityList'] = [];
            if (null !== $this->otherCityList && \is_array($this->otherCityList)) {
                $n = 0;
                foreach ($this->otherCityList as $item) {
                    $res['otherCityList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->salaryDesc) {
            $res['salaryDesc'] = $this->salaryDesc;
        }
        if (null !== $this->salarySettleType) {
            $res['salarySettleType'] = $this->salarySettleType;
        }
        if (null !== $this->salaryType) {
            $res['salaryType'] = $this->salaryType;
        }
        if (null !== $this->salaryYear) {
            $res['salaryYear'] = $this->salaryYear;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return jobExpects
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cityList'])) {
            if (!empty($map['cityList'])) {
                $model->cityList = [];
                $n               = 0;
                foreach ($map['cityList'] as $item) {
                    $model->cityList[$n++] = null !== $item ? cityList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['industryList'])) {
            if (!empty($map['industryList'])) {
                $model->industryList = [];
                $n                   = 0;
                foreach ($map['industryList'] as $item) {
                    $model->industryList[$n++] = null !== $item ? industryList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['jobList'])) {
            if (!empty($map['jobList'])) {
                $model->jobList = [];
                $n              = 0;
                foreach ($map['jobList'] as $item) {
                    $model->jobList[$n++] = null !== $item ? jobList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['jobNature'])) {
            $model->jobNature = $map['jobNature'];
        }
        if (isset($map['maxSalary'])) {
            $model->maxSalary = $map['maxSalary'];
        }
        if (isset($map['minSalary'])) {
            $model->minSalary = $map['minSalary'];
        }
        if (isset($map['otherCityList'])) {
            if (!empty($map['otherCityList'])) {
                $model->otherCityList = [];
                $n                    = 0;
                foreach ($map['otherCityList'] as $item) {
                    $model->otherCityList[$n++] = null !== $item ? otherCityList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['salaryDesc'])) {
            $model->salaryDesc = $map['salaryDesc'];
        }
        if (isset($map['salarySettleType'])) {
            $model->salarySettleType = $map['salarySettleType'];
        }
        if (isset($map['salaryType'])) {
            $model->salaryType = $map['salaryType'];
        }
        if (isset($map['salaryYear'])) {
            $model->salaryYear = $map['salaryYear'];
        }

        return $model;
    }
}
