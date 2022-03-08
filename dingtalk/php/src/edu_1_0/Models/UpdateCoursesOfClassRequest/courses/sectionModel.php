<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassRequest\courses;

use AlibabaCloud\Tea\Model;

class sectionModel extends Model
{
    /**
     * @description 节次index
     *
     * @var int
     */
    public $sectionIndex;

    /**
     * @description 节次名称
     *
     * @var string
     */
    public $sectionName;

    /**
     * @description sectionType
     *
     * @var string
     */
    public $sectionType;
    protected $_name = [
        'sectionIndex' => 'sectionIndex',
        'sectionName'  => 'sectionName',
        'sectionType'  => 'sectionType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sectionIndex) {
            $res['sectionIndex'] = $this->sectionIndex;
        }
        if (null !== $this->sectionName) {
            $res['sectionName'] = $this->sectionName;
        }
        if (null !== $this->sectionType) {
            $res['sectionType'] = $this->sectionType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sectionModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sectionIndex'])) {
            $model->sectionIndex = $map['sectionIndex'];
        }
        if (isset($map['sectionName'])) {
            $model->sectionName = $map['sectionName'];
        }
        if (isset($map['sectionType'])) {
            $model->sectionType = $map['sectionType'];
        }

        return $model;
    }
}
