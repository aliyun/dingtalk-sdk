<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigRequest;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigRequest\sectionConfigs\sectionEndDate;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigRequest\sectionConfigs\sectionModels;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigRequest\sectionConfigs\sectionStartDate;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigRequest\sectionConfigs\semesterEndDate;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigRequest\sectionConfigs\semesterStartDate;
use AlibabaCloud\Tea\Model;

class sectionConfigs extends Model
{
    /**
     * @description 课表名称
     *
     * @var string
     */
    public $scheduleName;

    /**
     * @description 学年
     *
     * @var string
     */
    public $schoolYear;

    /**
     * @description 结束时间
     *
     * @var sectionEndDate
     */
    public $sectionEndDate;

    /**
     * @description 节次模型
     *
     * @var sectionModels[]
     */
    public $sectionModels;

    /**
     * @description 开始时间（精确到日）
     *
     * @var sectionStartDate
     */
    public $sectionStartDate;

    /**
     * @description 学期
     *
     * @var int
     */
    public $semester;

    /**
     * @description 学期结束时间
     *
     * @var semesterEndDate
     */
    public $semesterEndDate;

    /**
     * @description 学期开始时间
     *
     * @var semesterStartDate
     */
    public $semesterStartDate;
    protected $_name = [
        'scheduleName'      => 'scheduleName',
        'schoolYear'        => 'schoolYear',
        'sectionEndDate'    => 'sectionEndDate',
        'sectionModels'     => 'sectionModels',
        'sectionStartDate'  => 'sectionStartDate',
        'semester'          => 'semester',
        'semesterEndDate'   => 'semesterEndDate',
        'semesterStartDate' => 'semesterStartDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->scheduleName) {
            $res['scheduleName'] = $this->scheduleName;
        }
        if (null !== $this->schoolYear) {
            $res['schoolYear'] = $this->schoolYear;
        }
        if (null !== $this->sectionEndDate) {
            $res['sectionEndDate'] = null !== $this->sectionEndDate ? $this->sectionEndDate->toMap() : null;
        }
        if (null !== $this->sectionModels) {
            $res['sectionModels'] = [];
            if (null !== $this->sectionModels && \is_array($this->sectionModels)) {
                $n = 0;
                foreach ($this->sectionModels as $item) {
                    $res['sectionModels'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->sectionStartDate) {
            $res['sectionStartDate'] = null !== $this->sectionStartDate ? $this->sectionStartDate->toMap() : null;
        }
        if (null !== $this->semester) {
            $res['semester'] = $this->semester;
        }
        if (null !== $this->semesterEndDate) {
            $res['semesterEndDate'] = null !== $this->semesterEndDate ? $this->semesterEndDate->toMap() : null;
        }
        if (null !== $this->semesterStartDate) {
            $res['semesterStartDate'] = null !== $this->semesterStartDate ? $this->semesterStartDate->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sectionConfigs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['scheduleName'])) {
            $model->scheduleName = $map['scheduleName'];
        }
        if (isset($map['schoolYear'])) {
            $model->schoolYear = $map['schoolYear'];
        }
        if (isset($map['sectionEndDate'])) {
            $model->sectionEndDate = sectionEndDate::fromMap($map['sectionEndDate']);
        }
        if (isset($map['sectionModels'])) {
            if (!empty($map['sectionModels'])) {
                $model->sectionModels = [];
                $n                    = 0;
                foreach ($map['sectionModels'] as $item) {
                    $model->sectionModels[$n++] = null !== $item ? sectionModels::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['sectionStartDate'])) {
            $model->sectionStartDate = sectionStartDate::fromMap($map['sectionStartDate']);
        }
        if (isset($map['semester'])) {
            $model->semester = $map['semester'];
        }
        if (isset($map['semesterEndDate'])) {
            $model->semesterEndDate = semesterEndDate::fromMap($map['semesterEndDate']);
        }
        if (isset($map['semesterStartDate'])) {
            $model->semesterStartDate = semesterStartDate::fromMap($map['semesterStartDate']);
        }

        return $model;
    }
}
