<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO;

use AlibabaCloud\Tea\Model;

class projectExperiences extends Model
{
    /**
     * @var string
     */
    public $achievement;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $endDate;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $projectUrl;

    /**
     * @var string
     */
    public $responsibility;

    /**
     * @var string
     */
    public $startDate;

    /**
     * @var string
     */
    public $technology;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'achievement' => 'achievement',
        'description' => 'description',
        'endDate' => 'endDate',
        'name' => 'name',
        'projectUrl' => 'projectUrl',
        'responsibility' => 'responsibility',
        'startDate' => 'startDate',
        'technology' => 'technology',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->achievement) {
            $res['achievement'] = $this->achievement;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->projectUrl) {
            $res['projectUrl'] = $this->projectUrl;
        }
        if (null !== $this->responsibility) {
            $res['responsibility'] = $this->responsibility;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->technology) {
            $res['technology'] = $this->technology;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return projectExperiences
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['achievement'])) {
            $model->achievement = $map['achievement'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['projectUrl'])) {
            $model->projectUrl = $map['projectUrl'];
        }
        if (isset($map['responsibility'])) {
            $model->responsibility = $map['responsibility'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['technology'])) {
            $model->technology = $map['technology'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
