<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetSimpleGroupsResponseBody\result\groups;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetSimpleGroupsResponseBody\result\groups\selectedClass\sections;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetSimpleGroupsResponseBody\result\groups\selectedClass\setting;
use AlibabaCloud\Tea\Model;

class selectedClass extends Model
{
    /**
     * @example 20008010
     *
     * @var int
     */
    public $classId;

    /**
     * @example 早班
     *
     * @var string
     */
    public $className;

    /**
     * @var sections[]
     */
    public $sections;

    /**
     * @var setting
     */
    public $setting;
    protected $_name = [
        'classId'   => 'classId',
        'className' => 'className',
        'sections'  => 'sections',
        'setting'   => 'setting',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->className) {
            $res['className'] = $this->className;
        }
        if (null !== $this->sections) {
            $res['sections'] = [];
            if (null !== $this->sections && \is_array($this->sections)) {
                $n = 0;
                foreach ($this->sections as $item) {
                    $res['sections'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->setting) {
            $res['setting'] = null !== $this->setting ? $this->setting->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return selectedClass
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['className'])) {
            $model->className = $map['className'];
        }
        if (isset($map['sections'])) {
            if (!empty($map['sections'])) {
                $model->sections = [];
                $n               = 0;
                foreach ($map['sections'] as $item) {
                    $model->sections[$n++] = null !== $item ? sections::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['setting'])) {
            $model->setting = setting::fromMap($map['setting']);
        }

        return $model;
    }
}
