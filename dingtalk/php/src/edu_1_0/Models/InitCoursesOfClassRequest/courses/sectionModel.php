<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitCoursesOfClassRequest\courses;

use AlibabaCloud\Tea\Model;

class sectionModel extends Model
{
    /**
     * @description 节次序列号。
     *
     * @var int
     */
    public $sectionIndex;

    /**
     * @description 节次名称。
     *
     * @var string
     */
    public $sectionName;
    protected $_name = [
        'sectionIndex' => 'sectionIndex',
        'sectionName'  => 'sectionName',
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

        return $model;
    }
}
