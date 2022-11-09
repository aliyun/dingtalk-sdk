<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData;

use AlibabaCloud\Tea\Model;

class trainingExperiences extends Model
{
    /**
     * @description 详细内容描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 结束时间
     *
     * @var string
     */
    public $endDate;

    /**
     * @description 培训机构名称
     *
     * @var string
     */
    public $institutionName;

    /**
     * @description 培训地点
     *
     * @var string
     */
    public $location;

    /**
     * @description 培训名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 开始时间
     *
     * @var string
     */
    public $startDate;
    protected $_name = [
        'description'     => 'description',
        'endDate'         => 'endDate',
        'institutionName' => 'institutionName',
        'location'        => 'location',
        'name'            => 'name',
        'startDate'       => 'startDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->institutionName) {
            $res['institutionName'] = $this->institutionName;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return trainingExperiences
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['institutionName'])) {
            $model->institutionName = $map['institutionName'];
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }

        return $model;
    }
}
